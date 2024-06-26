﻿using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.PovRay.SDL.Values;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.PovRay.SDL.Transforms;

public sealed class SdlTranslateTransform : SdlTransform
{
    public ISdlVectorValue Direction { get; private set; }


    internal SdlTranslateTransform(ISdlVectorValue direction)
    {
        Direction = direction;
    }
}