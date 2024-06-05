﻿using GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Rendering.PovRay.SDL.Values;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Rendering.PovRay.SDL.Objects.FSP;

public class SdlSuperquadricEllipsoid : SdlObject, ISdlFspObject
{
    public ISdlScalarValue EastWestExponent { get; set; }

    public ISdlScalarValue NorthSouthExponent { get; set; }
}