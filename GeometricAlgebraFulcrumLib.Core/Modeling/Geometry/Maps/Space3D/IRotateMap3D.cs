﻿namespace GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.Maps.Space3D;

public interface IRotateMap3D :
    IAffineMap3D
{
    IRotateMap3D InverseRotateMap();
}