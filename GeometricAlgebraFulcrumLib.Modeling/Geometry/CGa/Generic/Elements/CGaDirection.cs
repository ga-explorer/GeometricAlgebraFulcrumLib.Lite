﻿using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using GeometricAlgebraFulcrumLib.Algebra.Scalars.Generic;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.CGa.Generic.Blades;

namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.CGa.Generic.Elements;

public class CGaDirection<T> :
    CGaElement<T>
{
    public override CGaBlade<T> Position
        => GeometricSpace.ZeroVectorBlade;

    public override Scalar<T> RadiusSquared
    {
        get => Position.GeometricSpace.ScalarZero;
        set => throw new ReadOnlyException();
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal CGaDirection(CGaGeometricSpace<T> cgaGeometricSpace, IScalar<T> weight, CGaBlade<T> direction)
        : base(
            cgaGeometricSpace,
            CGaElementKind.Direction,
            weight,
            direction
        )
    {
        Debug.Assert(IsValid());
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sealed override bool IsValid()
    {
        return Weight.IsValid() &&
               Weight >= 0 &&
               Direction.IsVGaBlade() &&
               Direction.Norm().IsNearOne() &&
               Position.IsZero();
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool IsSameElement(CGaElement<T> element2, bool ignoreWeight = false)
    {
        if (element2 is not CGaDirection<T> direction2)
            return false;

        if (!ignoreWeight && !Weight.IsNearEqualTo(element2.Weight))
            return false;

        if (!Direction.IsNearEqual(direction2.Direction))
            return false;

        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override CGaBlade<T> EncodeOpnsBlade()
    {
        return Weight * Direction.Op(GeometricSpace.Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override CGaBlade<T> EncodeIpnsBlade()
    {
        return -Weight * Direction.VGaDual().Op(GeometricSpace.Ei);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        if (Weight.IsNearZero())
            return "Zero Conformal Direction";

        return new StringBuilder()
            .AppendLine("Conformal Direction:")
            .AppendLine($"   Weight: ${BasisSpecs.ToLaTeX(Weight)}$")
            .AppendLine($"   Unit Direction Grade: ${Direction.Grade}$")
            .AppendLine($"   Unit Direction: ${Direction.ToLaTeX()}$")
            .AppendLine($"   Unit Direction Normal: ${NormalDirection.ToLaTeX()}$")
            .AppendLine($"   OPNS Blade: ${EncodeOpnsBlade().ToLaTeX()}$")
            .AppendLine($"   IPNS Blade: ${EncodeIpnsBlade().ToLaTeX()}$")
            .ToString();
    }
}