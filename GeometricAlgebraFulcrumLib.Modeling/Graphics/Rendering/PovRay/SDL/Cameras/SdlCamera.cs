﻿using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.PovRay.SDL.Transforms;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.PovRay.SDL.Cameras;

public abstract class SdlCamera : ISdlCamera
{
    public List<ISdlTransform> Transforms { get; }



    protected SdlCamera()
    {
        Transforms = new List<ISdlTransform>();
    }
}