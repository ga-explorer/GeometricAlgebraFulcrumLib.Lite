﻿using Size = SixLabors.ImageSharp.Size;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ImageSharp.Processing.AutoCrop.Extensions;

internal static class SizeExtensions
{
    public static SixLabors.ImageSharp.Point ToPoint(this Size size)
    {
        return new SixLabors.ImageSharp.Point(size.Width, size.Height);
    }
}