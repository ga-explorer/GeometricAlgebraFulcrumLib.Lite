﻿using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.PovRay.SDL.Values;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.PovRay.SDL.Directives;

public sealed class SdlWhileDirective : SdlDirective
{
    public ISdlBooleanValue LoopCondition { get; set; }

    public List<ISdlStatement> Statements { get; private set; }


    public SdlWhileDirective()
    {
        Statements = new List<ISdlStatement>();
    }
}