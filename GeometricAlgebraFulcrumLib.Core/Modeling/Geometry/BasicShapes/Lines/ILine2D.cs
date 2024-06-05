﻿using GeometricAlgebraFulcrumLib.Core.Algebra;
using GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.BasicShapes.Lines.Immutable;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.BasicShapes.Lines;

public interface ILine2D : IAlgebraicElement
{
    double OriginX { get; }

    double OriginY { get; }


    double DirectionX { get; }

    double DirectionY { get; }


    Line2D ToLine();
}