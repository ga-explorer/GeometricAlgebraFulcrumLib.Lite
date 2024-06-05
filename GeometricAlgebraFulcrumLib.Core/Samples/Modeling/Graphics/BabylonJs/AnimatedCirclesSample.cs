﻿using GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.Parametric.Space1D.Scalars.Harmonic;
using GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.Visualizer;
using GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Rendering.Visuals.Space3D.Animations;
using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using SixLabors.ImageSharp;
using GeometricAlgebraFulcrumLib.Utilities.Web.Colors;

namespace GeometricAlgebraFulcrumLib.Core.Samples.Modeling.Graphics.BabylonJs;

public static class AnimatedCirclesSample
{
    public static void CircleCurveExample()
    {
        var animationSpecs =
            GrVisualAnimationSpecs.Create(10, 5);

        var center =
            LinFloat64Vector3D.Zero;

        var normal =
            LinFloat64Vector3D.E2;

        var radius = CosWaveParametricScalar.Create(
            animationSpecs.FrameTimeRange,
            1,
            5,
            1
        );

        var visualizer = new GeometryVisualizer();

        visualizer
            .SetWorkingFolder(@"D:\Projects\Study\Web\Babylon.js")
            .SetAnimationSpecs(animationSpecs)
            .BeginDrawing3D("Animated Circle Curve")
            .SetCurveStyleTube(0.05)
            .DrawCircleCurve(Color.BlueViolet, center, normal, radius)
            .SaveHtmlFile();
    }

    public static void CircleSurfaceExample()
    {
        var animationSpecs =
            GrVisualAnimationSpecs.Create(10, 5);

        var center =
            LinFloat64Vector3D.Zero;

        var normal =
            LinFloat64Vector3D.E2;

        var radius = CosWaveParametricScalar.Create(
            animationSpecs.FrameTimeRange,
            1,
            5,
            1
        );

        var visualizer = new GeometryVisualizer();

        visualizer
            .SetWorkingFolder(@"D:\Projects\Study\Web\Babylon.js")
            .SetAnimationSpecs(animationSpecs)
            .BeginDrawing3D("Animated Circle Surface")
            .SetSurfaceStyleThick(0.025)
            .DrawCircleSurface(Color.BlueViolet.SetAlpha(0.5), center, normal, radius)
            .SaveHtmlFile();
    }
}