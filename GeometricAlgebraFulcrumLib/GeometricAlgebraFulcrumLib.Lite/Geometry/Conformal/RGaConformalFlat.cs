using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public class RGaConformalFlat :
    RGaConformalElementWithPosition
{
    public double OriginToHyperPlaneDistance
    {
        get
        {
            Debug.Assert(Direction.Grade == VSpaceDimensions - 3);

            return Position.Lcp(NormalDirectionVector);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal RGaConformalFlat(RGaConformalSpace conformalSpace, double weight, RGaFloat64Vector position, RGaFloat64KVector direction)
        : base(conformalSpace, weight, position, direction)
    {
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsPoint()
    {
        return IsDirection0D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLine()
    {
        return IsDirection1D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsPlane()
    {
        return IsDirection2D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsVolume()
    {
        return IsDirection3D();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsHyperVolume(int grade)
    {
        return IsDirectionOfGrade(grade);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeOpns()
    {
        return Weight * ConformalSpace.Translate(
            Eo.Op(Direction.Op(Ei)),
            Position
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeIpns()
    {
        return Weight * ConformalSpace.Translate(
            ConformalSpace.EGaDual(Direction).GradeInvolution(),
            Position
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EncodePGa()
    {
        return ConformalSpace.IpnsToPGa(EncodeIpns());
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64Vector> GetEGaPoints()
    {
        var pointList = new List<RGaFloat64Vector>(Direction.Grade + 1)
        {
            Position
        };

        pointList.AddRange(
            GetDirectionVectors()
                .Select(v => 
                    Position + v
                )
        );

        return pointList;
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
        return IsDirectionParallelTo(egaPoint - Position);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool NearContainsEGaPoint(RGaFloat64Vector egaPoint, double epsilon = 1e-12)
    {
        return IsDirectionNearParallelTo(egaPoint - Position, epsilon);
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine("Conformal Flat:")
            .AppendLine($"   Weight: ${ConformalSpace.ToLaTeX(Weight)}$")
            .AppendLine($"   Unit Direction: ${ConformalSpace.ToLaTeX(Direction)}$")
            .AppendLine($"   Position: ${ConformalSpace.ToLaTeX(Position)}$")
            .AppendLine($"   OPNS Blade: ${ConformalSpace.ToLaTeX(EncodeOpns())}$")
            .AppendLine($"   IPNS Blade: ${ConformalSpace.ToLaTeX(EncodeIpns())}$")
            .AppendLine($"    PGA Blade: ${ConformalSpace.ToLaTeX(EncodePGa())}$")
            .ToString();
    }
}