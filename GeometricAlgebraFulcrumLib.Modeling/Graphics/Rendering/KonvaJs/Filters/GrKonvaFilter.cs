﻿using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.KonvaJs.Styles;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.KonvaJs.Filters;

public abstract class GrKonvaFilter :
    GrKonvaShapeSubStyle
{
    public abstract string FilterName { get; }

    
    protected GrKonvaFilter(GrKonvaShapeStyle parentStyle) 
        : base(parentStyle)
    {
    }
}