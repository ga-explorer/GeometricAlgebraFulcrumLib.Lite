﻿using GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Rendering.PovRay.SDL.Values;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Rendering.PovRay.SDL.Finishes;

public sealed class SdlBrillianceFinishItem : ISdlFinishItem
{
    public ISdlScalarValue Amount { get; set; }
}