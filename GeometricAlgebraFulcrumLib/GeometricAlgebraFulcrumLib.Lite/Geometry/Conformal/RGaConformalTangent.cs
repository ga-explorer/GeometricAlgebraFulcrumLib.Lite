using System.Runtime.CompilerServices;
using System.Text;
using DataStructuresLib.BitManipulation;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public class RGaConformalTangent :
    RGaConformalElementWithPosition
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal RGaConformalTangent(RGaConformalSpace conformalSpace, double weight, RGaFloat64Vector position, RGaFloat64KVector direction)
        : base(conformalSpace, weight, position, direction)
    {
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeOpns()
    {
        return Weight * ConformalSpace.Translate(
            Eo.Op(Direction),
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
            Eo.Op(direction),
            Position
        ).GetFirstKVectorPart();
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine("Conformal Tangent:")
            .AppendLine($"   Weight: ${ConformalSpace.ToLaTeX(Weight)}$")
            .AppendLine($"   Unit Direction: ${ConformalSpace.ToLaTeX(Direction)}$")
            .AppendLine($"   Position: ${ConformalSpace.ToLaTeX(Position)}$")
            .AppendLine($"   OPNS Blade: ${ConformalSpace.ToLaTeX(EncodeOpns())}$")
            .AppendLine($"   IPNS Blade: ${ConformalSpace.ToLaTeX(EncodeIpns())}$")
            .ToString();
    }
}