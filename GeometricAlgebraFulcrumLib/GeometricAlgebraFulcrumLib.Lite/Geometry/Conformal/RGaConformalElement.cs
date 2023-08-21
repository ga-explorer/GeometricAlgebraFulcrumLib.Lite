using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space4D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public abstract class RGaConformalElement
{
    public RGaConformalSpace ConformalSpace { get; }

    public int VSpaceDimensions
        => ConformalSpace.VSpaceDimensions;

    public double Weight { get; }

    public RGaFloat64KVector Direction { get; }
    
    public RGaFloat64Vector DirectionVector 
        => Direction.GetVectorPart();

    public Float64Vector2D DirectionVector2D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 4);

            return Float64Vector2D.Create(
                DirectionVector[2], 
                DirectionVector[3]
            );
        }
    }

    public Float64Vector3D DirectionVector3D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 5);

            return Float64Vector3D.Create(
                DirectionVector[2], 
                DirectionVector[3], 
                DirectionVector[4]
            );
        }
    }
    
    public Float64Vector4D DirectionVector4D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 6);

            return Float64Vector4D.Create(
                DirectionVector[2], 
                DirectionVector[3], 
                DirectionVector[4], 
                DirectionVector[5]
            );
        }
    }
    
    public RGaFloat64Bivector DirectionBivector 
        => Direction.GetBivectorPart();

    public Float64Bivector2D DirectionBivector2D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 4);

            return Float64Bivector2D.Create(
                DirectionBivector[2, 3]
            );
        }
    }

    public Float64Bivector3D DirectionBivector3D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 5);

            return Float64Bivector3D.Create(
                DirectionBivector[2, 3], 
                DirectionBivector[2, 4], 
                DirectionBivector[3, 4]
            );
        }
    }
    
    //public Float64Bivector4D DirectionBivector4D
    //{
    //    get
    //    {
    //        Debug.Assert(VSpaceDimensions == 6);

    //        return Float64Bivector4D.Create(
    //            DirectionBivector[2], 
    //            DirectionBivector[3], 
    //            DirectionBivector[4], 
    //            DirectionBivector[5]
    //        );
    //    }
    //}

    public RGaFloat64KVector NormalDirection
        => ConformalSpace.EGaDual(Direction);
    
    public RGaFloat64Vector NormalDirectionVector 
        => NormalDirection.GetVectorPart();

    public Float64Vector2D NormalDirectionVector2D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 4);

            var normal = NormalDirectionVector;

            return Float64Vector2D.Create(
                normal[2], 
                normal[3]
            );
        }
    }

    public Float64Vector3D NormalDirectionVector3D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 5);

            var normal = NormalDirectionVector;

            return Float64Vector3D.Create(
                normal[2], 
                normal[3], 
                normal[4]
            );
        }
    }
    
    public Float64Vector4D NormalDirectionVector4D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 6);

            var normal = NormalDirectionVector;

            return Float64Vector4D.Create(
                normal[2], 
                normal[3], 
                normal[4], 
                normal[5]
            );
        }
    }
    
    public RGaFloat64Bivector NormalDirectionBivector 
        => NormalDirection.GetBivectorPart();

    public Float64Bivector2D NormalDirectionBivector2D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 4);

            var normal = NormalDirectionBivector;

            return Float64Bivector2D.Create(
                normal[2, 3]
            );
        }
    }

    public Float64Bivector3D NormalDirectionBivector3D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 5);

            var normal = NormalDirectionBivector;

            return Float64Bivector3D.Create(
                normal[2, 3], 
                normal[2, 4], 
                normal[3, 4]
            );
        }
    }
    
    //public Float64Bivector4D DirectionBivector4D
    //{
    //    get
    //    {
    //        Debug.Assert(VSpaceDimensions == 6);

    //        var normal = NormalDirectionBivector;

    //        return Float64Bivector4D.Create(
    //            normal[2], 
    //            normal[3], 
    //            normal[4], 
    //            normal[5]
    //        );
    //    }
    //}

    public RGaFloat64Vector Eo
        => ConformalSpace.Eo;

    public RGaFloat64Vector Ei
        => ConformalSpace.Ei;


    protected RGaConformalElement(RGaConformalSpace conformalSpace, double weight, RGaFloat64KVector direction)
    {
        Debug.Assert(
            weight.IsValid() && weight > 0 &&
            conformalSpace.IsValidEGaElement(direction)
        );

        ConformalSpace = conformalSpace;
        Weight = weight;
        Direction = direction.DivideByNorm();
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirection0D()
    {
        return Direction.Grade == 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirection1D()
    {
        return Direction.Grade == 1;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirection2D()
    {
        return Direction.Grade == 2;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirection3D()
    {
        return Direction.Grade == 3;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirectionOfGrade(int grade)
    {
        return Direction.Grade == grade;
    }


    public abstract RGaFloat64KVector EncodeOpns();

    public abstract RGaFloat64KVector EncodeIpns();


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirectionParallelTo(RGaFloat64Vector egaVector)
    {
        Debug.Assert(ConformalSpace.IsValidEGaElement(egaVector));

        return egaVector.Op(Direction).IsZero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirectionNearParallelTo(RGaFloat64Vector egaVector, double epsilon = 1e-12)
    {
        Debug.Assert(ConformalSpace.IsValidEGaElement(egaVector));

        return egaVector.Op(Direction).IsNearZero(epsilon);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirectionOrthogonalTo(RGaFloat64Vector egaVector)
    {
        Debug.Assert(ConformalSpace.IsValidEGaElement(egaVector));

        return egaVector.Lcp(Direction).IsZero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDirectionNearOrthogonalTo(RGaFloat64Vector egaVector, double epsilon = 1e-12)
    {
        Debug.Assert(ConformalSpace.IsValidEGaElement(egaVector));

        return egaVector.Lcp(Direction).IsNearZero(epsilon);
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalDirection ToDirection()
    {
        if (this is RGaConformalDirection direction)
            return direction;

        return new RGaConformalDirection(
            ConformalSpace,
            Weight,
            Direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat ToFlat(RGaFloat64Vector egaPosition)
    {
        return new RGaConformalFlat(
            ConformalSpace, 
            Weight, 
            egaPosition, 
            Direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent ToTangent(RGaFloat64Vector egaPosition)
    {
        return new RGaConformalTangent(
            ConformalSpace, 
            Weight, 
            egaPosition, 
            Direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound ToRound(RGaFloat64Vector egaPosition, double radiusSquared)
    {
        return new RGaConformalRound(
            ConformalSpace, 
            Weight, 
            radiusSquared,
            egaPosition, 
            Direction
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64Vector> GetDirectionVectors()
    {
        return Direction.BladeToVectors();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64Vector> GetDirectionVectors(IEnumerable<int> probeBasisVectorIndices)
    {
        return Direction.BladeToVectors(
            probeBasisVectorIndices
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IReadOnlyList<RGaFloat64Vector> GetDirectionVectors(IEnumerable<RGaFloat64Vector> probeVectors)
    {
        return Direction.BladeToVectors(
            probeVectors.ToImmutableArray()
        );
    }
}