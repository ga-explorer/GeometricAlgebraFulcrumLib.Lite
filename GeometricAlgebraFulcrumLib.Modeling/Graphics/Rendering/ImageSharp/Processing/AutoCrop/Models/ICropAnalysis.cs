﻿using SixLabors.ImageSharp;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ImageSharp.Processing.AutoCrop.Models;

public interface ICropAnalysis
{
    Rectangle BoundingBox { get; }
    Color Background { get; }
    bool Success { get; }
}