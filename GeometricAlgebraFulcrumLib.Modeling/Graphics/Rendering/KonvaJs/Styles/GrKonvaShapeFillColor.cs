﻿using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.KonvaJs.Values;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.KonvaJs.Styles;

public sealed class GrKonvaShapeFillColor : 
    GrKonvaShapeFill
{
    public GrKonvaJsColorValue? Color
    {
        get => ParentStyle.GetAttributeValueOrNull<GrKonvaJsColorValue>("Fill");
        set => ParentStyle.SetAttributeValue("Fill", value);
    }

    public override GrKonvaShapeFillKind Kind 
        => GrKonvaShapeFillKind.Color;


    internal GrKonvaShapeFillColor(GrKonvaShapeStyle parentStyle) 
        : base(parentStyle)
    {
    }

    
}