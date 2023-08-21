using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using System.Runtime.CompilerServices;
using System.Text;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public class RGaConformalDirection :
    RGaConformalElement
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal RGaConformalDirection(RGaConformalSpace conformalSpace, double weight, RGaFloat64KVector direction)
        : base(conformalSpace, weight, direction)
    {
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeOpns()
    {
        return Weight * Direction.Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override RGaFloat64KVector EncodeIpns()
    {
        return -Weight * ConformalSpace.EGaDual(Direction).Op(Ei);
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine("Conformal Direction:")
            .AppendLine($"   Weight: ${ConformalSpace.ToLaTeX(Weight)}$")
            .AppendLine($"   Unit Direction: ${ConformalSpace.ToLaTeX(Direction)}$")
            .AppendLine($"   OPNS Blade: ${ConformalSpace.ToLaTeX(EncodeOpns())}$")
            .AppendLine($"   IPNS Blade: ${ConformalSpace.ToLaTeX(EncodeIpns())}$")
            .ToString();
    }
}