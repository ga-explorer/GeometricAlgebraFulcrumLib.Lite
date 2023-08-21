using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space4D;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public abstract class RGaConformalElementWithPosition :
    RGaConformalElement
{
    public RGaFloat64Vector Position { get; }

    public Float64Vector2D Position2D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 4);

            return Float64Vector2D.Create(
                Position[2], 
                Position[3]
            );
        }
    }

    public Float64Vector3D Position3D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 5);

            return Float64Vector3D.Create(
                Position[2], 
                Position[3], 
                Position[4]
            );
        }
    }
    
    public Float64Vector4D Position4D
    {
        get
        {
            Debug.Assert(VSpaceDimensions == 6);

            return Float64Vector4D.Create(
                Position[2], 
                Position[3], 
                Position[4], 
                Position[5]
            );
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaConformalElementWithPosition(RGaConformalSpace conformalSpace, double weight, RGaFloat64Vector position, RGaFloat64KVector direction)
        : base(conformalSpace, weight, direction)
    {
        Debug.Assert(
            conformalSpace.IsValidEGaElement(position)
        );

        Position = position;
    }
    
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat ToFlat()
    {
        if (this is RGaConformalFlat flat)
            return flat;

        return new RGaConformalFlat(
            ConformalSpace, 
            Weight, 
            Position, 
            Direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent ToTangent()
    {
        if (this is RGaConformalTangent tangent)
            return tangent;

        return new RGaConformalTangent(
            ConformalSpace, 
            Weight, 
            Position, 
            Direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound ToRound(double radiusSquared)
    {
        if (this is RGaConformalRound round && round.RadiusSquared == radiusSquared)
            return round;

        return new RGaConformalRound(
            ConformalSpace, 
            Weight, 
            radiusSquared,
            Position, 
            Direction
        );
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EncodePGaPosition()
    {
        return ConformalSpace.PGaEncodePoint(Position);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EncodeOpnsFlatPosition()
    {
        return ConformalSpace.OpnsEncodeFlatPoint(Position);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeIpnsPosition()
    {
        return ConformalSpace.IpnsEncodePoint(Position);
    }
}