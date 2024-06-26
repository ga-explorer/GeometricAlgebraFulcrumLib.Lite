﻿namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.BasicShapes;

public interface IIntersectable
{
    /// <summary>
    /// Enable or disable intersections test for this geometric object
    /// </summary>
    bool IntersectionTestsEnabled { get; }
}