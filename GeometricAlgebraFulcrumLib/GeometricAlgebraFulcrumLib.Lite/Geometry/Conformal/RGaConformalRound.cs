using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using DataStructuresLib.BitManipulation;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space4D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public class RGaConformalRound :
    RGaConformalElementWithPosition
{
    public RGaFloat64Vector Center 
        => Position;

    public Float64Vector2D Center2D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 4);

            return Float64Vector2D.Create(
                Center[2], 
                Center[3]
            );
        }
    }

    public Float64Vector3D Center3D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 5);

            return Float64Vector3D.Create(
                Center[2], 
                Center[3], 
                Center[4]
            );
        }
    }
    
    public Float64Vector4D Center4D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 6);

            return Float64Vector4D.Create(
                Center[2], 
                Center[3], 
                Center[4], 
                Center[5]
            );
        }
    }

    public double RadiusSquared { get; }
    
    public double RealRadius 
        => RadiusSquared.SqrtOfAbs();

    public double RealRadiusSquared 
        => RadiusSquared.Abs();

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal RGaConformalRound(RGaConformalSpace conformalSpace, double weight, double radiusSquared, RGaFloat64Vector position, RGaFloat64KVector direction)
        : base(conformalSpace, weight, position, direction)
    {
        Debug.Assert(
            radiusSquared.IsValid()
        );

        RadiusSquared = radiusSquared;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsPoint()
    {
        return RadiusSquared.IsZero();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsPointPair()
    {
        return IsDirection1D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsCircle()
    {
        return IsDirection2D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsSphere()
    {
        return IsDirection3D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsHyperSphere(int grade)
    {
        return IsDirectionOfGrade(grade);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsRealPointPair()
    {
        return IsDirection1D() && RadiusSquared > 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsRealCircle()
    {
        return IsDirection2D() && RadiusSquared > 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsRealSphere()
    {
        return IsDirection3D() && RadiusSquared > 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsRealHyperSphere(int grade)
    {
        return IsDirectionOfGrade(grade) && RadiusSquared > 0;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsImaginaryPointPair()
    {
        return IsDirection1D() && RadiusSquared < 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsImaginaryCircle()
    {
        return IsDirection2D() && RadiusSquared < 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsImaginarySphere()
    {
        return IsDirection3D() && RadiusSquared < 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsImaginaryHyperSphere(int grade)
    {
        return IsDirectionOfGrade(grade) && RadiusSquared < 0;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeOpns()
    {
        return Weight * ConformalSpace.Translate(
            (Eo + 0.5 * RadiusSquared * Ei).Op(Direction),
            Position
        ).GetFirstKVectorPart();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeIpns()
    {
        var direction = ConformalSpace.EGaDual(
            (VSpaceDimensions - 2).IsEven() ? Direction : -Direction
        );

        return Weight * ConformalSpace.Translate(
            (Eo - 0.5 * RadiusSquared * Ei).Op(direction),
            Position
        ).GetFirstKVectorPart();
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64Vector> GetEGaPoints()
    {
        var directionVectors = 
            GetDirectionVectors().ToList();

        directionVectors.Add(
            -directionVectors.Aggregate(
                ConformalSpace.ZeroVector,
                (a, b) => a + b
            ).DivideByNorm()
        );

        return directionVectors
            .Select(v => Position + v * RealRadius)
            .ToImmutableArray();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64KVector> GetPGaPoints()
    {
        return GetEGaPoints()
            .Select(ConformalSpace.PGaEncodePoint)
            .ToImmutableArray();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64Vector> GetIpnsPoints()
    {
        return GetEGaPoints()
            .Select(ConformalSpace.IpnsEncodePoint)
            .ToImmutableArray();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64KVector> GetOpnsFlatPoints()
    {
        return GetEGaPoints()
            .Select(ConformalSpace.OpnsEncodeFlatPoint)
            .ToImmutableArray();
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool ContainsEGaPoint(RGaFloat64Vector egaPoint)
    {
        var v = egaPoint - Position;

        return IsDirectionParallelTo(v) && 
               v.NormSquared() == RealRadiusSquared;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool NearContainsEGaPoint(RGaFloat64Vector egaPoint, double epsilon = 1e-12)
    {
        var v = egaPoint - Position;

        return IsDirectionNearParallelTo(v, epsilon) && 
               (v.Norm() - RealRadius).IsNearZero(epsilon);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine("Conformal Flat:")
            .AppendLine($"   Weight: ${ConformalSpace.ToLaTeX(Weight)}$")
            .AppendLine($"   Unit Direction: ${ConformalSpace.ToLaTeX(Direction)}$")
            .AppendLine($"   Position: ${ConformalSpace.ToLaTeX(Position)}$")
            .AppendLine($"   Squared Radius: ${ConformalSpace.ToLaTeX(RadiusSquared)}$")
            .AppendLine($"   OPNS Blade: ${ConformalSpace.ToLaTeX(EncodeOpns())}$")
            .AppendLine($"   IPNS Blade: ${ConformalSpace.ToLaTeX(EncodeIpns())}$")
            .ToString();
    }
}