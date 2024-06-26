﻿using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Float64.Angles;
using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Float64.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Algebra.Scalars.Float64;
using GeometricAlgebraFulcrumLib.Utilities.Structures.Dictionary;
using GeometricAlgebraFulcrumLib.Utilities.Structures.Files;
using GeometricAlgebraFulcrumLib.Utilities.Structures.Sequences;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.BabylonJs;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.Visuals.Space3D.Animations;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.Visuals.Space3D.Basic;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.Visuals.Space3D.Curves;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.Visuals.Space3D.Images;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.Visuals.Space3D.Surfaces;
using Humanizer;
using SixLabors.ImageSharp;
using GeometricAlgebraFulcrumLib.Utilities.Web.Html.Media;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space1D.Angles;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space1D.Scalars;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space2D.Curves;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space3D.Curves;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space3D.Curves.Adaptive;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Borders.Space2D.Immutable;

namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.Visualizer;

public class GeometryVisualizer
{
    private string _workingFolder = @"D:\Projects\Study\Web\Babylon.js";

    protected ComputedSequenceCollection<string> SceneObjectNameSequences { get; }
        = new ComputedSequenceCollection<string>(
            (key, index) => $"{key}{index}"
        );


    public int FrameRate { get; }

    public double MaxTime { get; }

    public GrVisualAnimationSpecs AnimationSpecs { get; protected set; }

    public string WorkingFolder
    {
        get => _workingFolder;
        set => _workingFolder = Directory.Exists(value)
                ? value
                : throw new DirectoryNotFoundException(value);
    }

    public string Title { get; protected set; }

    public int CanvasWidth { get; set; }
        = 1024;

    public int CanvasHeight { get; set; }
        = 728;

    public int GridUnitCount { get; set; }
        = 24;

    public double GridUnitSize { get; set; }
        = 1d;

    public double GridOpacity { get; set; }
        = 0.25d;

    public double CameraDistance { get; set; }
        = 15;

    public LinFloat64Vector3D AxesOrigin { get; set; }
        = LinFloat64Vector3D.Zero;

    public GrBabylonJsHtmlComposer3D HtmlComposer { get; private set; }

    public GrBabylonJsSceneComposer3D MainSceneComposer
        => HtmlComposer.FirstSceneComposer;

    public GrBabylonJsScene MainScene
        => HtmlComposer.FirstScene;

    public WclHtmlImageDataUrlCache ImageCache
        => HtmlComposer.ImageCache;

    public IReadOnlyDictionary<string, string> LaTeXDictionary { get; private set; }

    public GeometryVisualizerPointStyle PointStyle { get; }

    public GeometryVisualizerVectorStyle VectorStyle { get; }

    public GeometryVisualizerCurveStyle CurveStyle { get; }

    public GeometryVisualizerSurfaceStyle SurfaceStyle { get; }


    public GeometryVisualizer()
    {
        LaTeXDictionary = new Dictionary<string, string>();
        MaxTime = 0;
        FrameRate = 0;
        AnimationSpecs = GrVisualAnimationSpecs.Static;

        PointStyle = new GeometryVisualizerPointStyle(this, 0.08);
        VectorStyle = new GeometryVisualizerVectorStyle(this, 0.08);
        CurveStyle = new GeometryVisualizerCurveStyle(this);
        SurfaceStyle = new GeometryVisualizerSurfaceStyle(this);
    }


    protected string GetNewSceneObjectName(string key)
    {
        return SceneObjectNameSequences.GetNextItem(key);
    }

    protected virtual void InitializeSceneComposers(int index)
    {
        var mainSceneComposer = new GrBabylonJsSceneComposer3D(
            "mainScene",
            new GrBabylonJsSnapshotSpecs
            {
                Enabled = false,
                Width = CanvasWidth,
                Height = CanvasHeight,
                Precision = 1,
                UsePrecision = true,
                Delay = index == 0 ? 2000 : 1000,
                FileName = $"Frame-{index:D6}.png"
            }
        )
        {
            BackgroundColor = Color.AliceBlue,
            ShowDebugLayer = false,
        };

        HtmlComposer = new GrBabylonJsHtmlComposer3D(mainSceneComposer)
        {
            CanvasWidth = CanvasWidth,
            CanvasHeight = CanvasHeight,
            CanvasFullScreen = false,
            HtmlPageTitle = Title
        };
    }

    protected virtual void InitializeImageCache()
    {
        var workingPath = Path.Combine(WorkingFolder, "images");

        Console.Write("Generating images cache .. ");

        ImageCache.MarginSize = 0;
        ImageCache.BackgroundColor = Color.FromRgba(255, 255, 255, 0);

        ImageCache.AddPngFromFile(
            "copyright",
            workingPath.GetFilePath("Copyright.png")
        );

        ImageCache.MarginSize = 0;
        ImageCache.BackgroundColor = Color.FromRgba(255, 255, 255, 0);

        foreach (var (name, latexText) in LaTeXDictionary)
            ImageCache.AddLaTeXCode(name, latexText);

        //var latexImageComposer = new GrLaTeXImageComposer
        //{
        //    LaTeXBinFolder = @"D:\texlive\2021\bin\win32\",
        //    Resolution = 200
        //};

        //ImageCache.GeneratePngBase64Strings(latexImageComposer);

        ImageCache.GeneratePngDataUrlStrings(WorkingFolder);
        //ImageCache.GenerateSvgDataUrlStrings(WorkingPath);

        //var maxWidth = 0;
        //var maxHeight = 0;
        //for (var i = 0; i < Signal.TimeValues.Count; i++)
        //{
        //    var imageData = ImageCache[$"signalText-{i:D6}"];

        //    if (maxWidth < imageData.Width) maxWidth = imageData.Width;
        //    if (maxHeight < imageData.Height) maxHeight = imageData.Height;
        //}

        //SignalTextImageMaxWidth = maxWidth;
        //SignalTextImageMaxHeight = maxHeight;

        Console.WriteLine("done.");
        Console.WriteLine();
    }


    public GeometryVisualizer SetWorkingFolder(string workingFolder)
    {
        WorkingFolder = workingFolder;

        return this;
    }

    public GeometryVisualizer SetAnimationSpecs(GrVisualAnimationSpecs animationSpecs)
    {
        AnimationSpecs = animationSpecs;

        return this;
    }

    public GeometryVisualizer SetGrid(int unitCount, double unitSize = 1d, double opacity = 0.25d)
    {
        GridUnitCount = unitCount;
        GridUnitSize = unitSize;
        GridOpacity = opacity;

        return this;
    }

    public GeometryVisualizer BeginDrawing2D(string title)
    {
        return BeginDrawing2D(title, new EmptyDictionary<string, string>());
    }

    public virtual GeometryVisualizer BeginDrawing2D(string title, IReadOnlyDictionary<string, string> laTeXDictionary)
    {
        Title = title;

        SceneObjectNameSequences.Reset();

        PointStyle.SetStyle(0.08);
        VectorStyle.SetStyle(0.08);
        CurveStyle.SetTubeStyle(0.08);

        LaTeXDictionary = laTeXDictionary;

        InitializeSceneComposers(0);

        if (LaTeXDictionary.Count > 0)
            InitializeImageCache();

        MainSceneComposer
            .AddDefaultGridXyz(GridUnitCount, GridUnitSize, GridOpacity)
            .AddDefaultAxes(AxesOrigin)
            .AddDefaultEnvironment(GridUnitCount)
            .AddDefaultOrthographicCamera(
                CameraDistance,
                "Math.PI / 2",
                "Math.PI / 2",
                BoundingBox2D.CreateAround(
                    0,
                    0,
                    0.5 * GridUnitCount * GridUnitSize,
                    0.5 * GridUnitCount * GridUnitSize * CanvasHeight / CanvasWidth
                )
            );

        return this;
    }

    public GeometryVisualizer BeginDrawing3D(string title)
    {
        return BeginDrawing3D(title, new EmptyDictionary<string, string>());
    }

    public virtual GeometryVisualizer BeginDrawing3D(string title, IReadOnlyDictionary<string, string> laTeXDictionary)
    {
        Title = title;

        SceneObjectNameSequences.Reset();

        PointStyle.SetStyle(0.08);
        VectorStyle.SetStyle(0.08);
        CurveStyle.SetTubeStyle(0.08);

        LaTeXDictionary = laTeXDictionary;

        InitializeSceneComposers(0);

        if (LaTeXDictionary.Count > 0)
            InitializeImageCache();

        MainSceneComposer
            .AddDefaultGridXyz(GridUnitCount, 1, 0.25)
            .AddDefaultAxes(AxesOrigin)
            .AddDefaultEnvironment(GridUnitCount)
            .AddDefaultPerspectiveCamera(
                CameraDistance,
                "2 * Math.PI / 20",
                "2 * Math.PI / 5"
            );

        return this;
    }


    public GeometryVisualizer SetPointStyle(double thickness)
    {
        PointStyle.SetStyle(thickness);

        return this;
    }

    public GeometryVisualizer SetVectorStyle(double thickness)
    {
        VectorStyle.SetStyle(thickness);

        return this;
    }

    public GeometryVisualizer SetCurveStyleTube(double thickness)
    {
        CurveStyle.SetTubeStyle(thickness);

        return this;
    }

    public GeometryVisualizer SetCurveStyleSolid()
    {
        CurveStyle.SetSolidStyle();

        return this;
    }

    public GeometryVisualizer SetCurveStyleDashed(int dashOn, int dashOff, int dashPerLine)
    {
        CurveStyle.SetDashedStyle(
            dashOn,
            dashOff,
            dashPerLine
        );

        return this;
    }

    public GeometryVisualizer SetSurfaceStyleThick(double thickness)
    {
        SurfaceStyle.SetThickStyle(thickness);

        return this;
    }

    public GeometryVisualizer SetSurfaceStyleThin()
    {
        SurfaceStyle.SetThinStyle();

        return this;
    }


    public GeometryVisualizer DrawLaTeX(string key, LinFloat64Vector2D origin)
    {
        return DrawLaTeX(key, origin.ToXyLinVector3D());
    }

    public GeometryVisualizer DrawLaTeX(string key, LinFloat64Vector3D origin)
    {
        var name = GetNewSceneObjectName("laTeX");

        MainSceneComposer.AddLaTeXText(
            GrVisualLaTeXText3D.CreateStatic(
                name,
                ImageCache,
                key,
                origin,
                HtmlComposer.LaTeXScalingFactor
            )
        );

        return this;
    }

    public GeometryVisualizer DrawLaTeX(string key, IFloat64ParametricCurve2D originCurve)
    {
        return DrawLaTeX(key, originCurve.ToXyParametricCurve3D());
    }

    public GeometryVisualizer DrawLaTeX(string key, IParametricCurve3D originCurve)
    {
        MainSceneComposer.AddLaTeXText(
            GrVisualLaTeXText3D.CreateAnimated(
                GetNewSceneObjectName("laTeX"),
                ImageCache,
                key,
                AnimationSpecs.CreateAnimatedVector3D(originCurve),
                HtmlComposer.LaTeXScalingFactor
            )
        );

        return this;
    }


    public GeometryVisualizer DrawPoint(Color color, LinFloat64Vector2D position)
    {
        return DrawPoint(color, position.ToXyLinVector3D());
    }

    public GeometryVisualizer DrawPoint(Color color, LinFloat64Vector3D position)
    {
        MainSceneComposer.AddPoint(
            GrVisualPoint3D.CreateStatic(
                GetNewSceneObjectName("point"),
                PointStyle.GetVisualStyle(color),
                position
            )
        );

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, params LinFloat64Vector2D[] mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, params LinFloat64Vector3D[] mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv);

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, IEnumerable<LinFloat64Vector2D> mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, IEnumerable<LinFloat64Vector3D> mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv);

        return this;
    }

    public GeometryVisualizer DrawPointCoordinateLines(Color color, LinFloat64Vector2D point, bool drawCoordinatePoints = true)
    {
        return DrawPointCoordinateLines(color, point.ToXyLinVector3D(), drawCoordinatePoints);
    }

    public GeometryVisualizer DrawPointCoordinateLines(Color color, LinFloat64Vector3D point, bool drawCoordinatePoints = true)
    {
        var pointXy = point.ProjectOnXyPlane();
        var pointXz = point.ProjectOnXzPlane();
        var pointYz = point.ProjectOnYzPlane();

        var pointX = point.ProjectOnXAxis();
        var pointY = point.ProjectOnYAxis();
        var pointZ = point.ProjectOnZAxis();

        DrawLineCurvesTo(
            color,
            pointXy,
            pointX,
            pointY
        );

        DrawLineCurvesTo(
            color,
            pointXz,
            pointX,
            pointZ
        );

        DrawLineCurvesTo(
            color,
            pointYz,
            pointY,
            pointZ
        );

        DrawLineCurvesTo(
            color,
            point,
            pointXy,
            pointXz,
            pointYz
        );

        DrawLineCurvesTo(
            color,
            LinFloat64Vector3D.Zero,
            pointX,
            pointY,
            pointZ
        );

        if (drawCoordinatePoints)
            DrawPoints(
                color,
                pointX,
                pointY,
                pointZ,
                pointXy,
                pointXz,
                pointYz
            );

        return this;
    }


    public GeometryVisualizer DrawPoint(Color color, IFloat64ParametricCurve2D pointCurve)
    {
        return DrawPoint(color, pointCurve.ToXyParametricCurve3D());
    }

    public GeometryVisualizer DrawPoint(Color color, IParametricCurve3D pointCurve)
    {
        if (AnimationSpecs.IsStatic)
            throw new InvalidOperationException();

        MainSceneComposer.AddPoint(
            GrVisualPoint3D.CreateAnimated(
                GetNewSceneObjectName("point"),
                PointStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(pointCurve)
            )
        );

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, params IFloat64ParametricCurve2D[] mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv.ToXyParametricCurve3D());

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, params IParametricCurve3D[] mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv);

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, IEnumerable<IFloat64ParametricCurve2D> mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv.ToXyParametricCurve3D());

        return this;
    }

    public GeometryVisualizer DrawPoints(Color color, IEnumerable<IParametricCurve3D> mvList)
    {
        foreach (var mv in mvList)
            DrawPoint(color, mv);

        return this;
    }


    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector2D vector)
    {
        return DrawVector(color, LinFloat64Vector3D.Zero, vector.ToXyLinVector3D());
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector3D vector)
    {
        return DrawVector(color, LinFloat64Vector3D.Zero, vector);
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector2D origin, LinFloat64Vector2D vector)
    {
        return DrawVector(color, origin.ToXyLinVector3D(), vector.ToXyLinVector3D());
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector3D origin, LinFloat64Vector3D vector)
    {
        MainSceneComposer.AddVector(
            GrVisualVector3D.CreateStatic(
                GetNewSceneObjectName("vector"),
                VectorStyle.GetVisualStyle(color),
                origin,
                vector
            )
        );

        return this;
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector2D origin, LinFloat64Vector2D vector1, LinFloat64Vector2D vector2)
    {
        DrawVector(color, origin.ToXyLinVector3D(), vector1.ToXyLinVector3D());
        DrawVector(color, origin.ToXyLinVector3D(), vector2.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector3D origin, LinFloat64Vector3D vector1, LinFloat64Vector3D vector2)
    {
        DrawVector(color, origin, vector1);
        DrawVector(color, origin, vector2);

        return this;
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector2D origin, LinFloat64Vector2D vector1, LinFloat64Vector2D vector2, LinFloat64Vector2D vector3)
    {
        DrawVector(color, origin.ToXyLinVector3D(), vector1.ToXyLinVector3D());
        DrawVector(color, origin.ToXyLinVector3D(), vector2.ToXyLinVector3D());
        DrawVector(color, origin.ToXyLinVector3D(), vector3.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector3D origin, LinFloat64Vector3D vector1, LinFloat64Vector3D vector2, LinFloat64Vector3D vector3)
    {
        DrawVector(color, origin, vector1);
        DrawVector(color, origin, vector2);
        DrawVector(color, origin, vector3);

        return this;
    }

    public GeometryVisualizer DrawVectors(Color color, LinFloat64Vector2D origin, params LinFloat64Vector2D[] vectorList)
    {
        foreach (var vector in vectorList)
            DrawVector(color, origin.ToXyLinVector3D(), vector.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawVectors(Color color, LinFloat64Vector3D origin, params LinFloat64Vector3D[] vectorList)
    {
        foreach (var vector in vectorList)
            DrawVector(color, origin, vector);

        return this;
    }

    public GeometryVisualizer DrawVectors(Color color, LinFloat64Vector2D origin, IEnumerable<LinFloat64Vector2D> vectorList)
    {
        foreach (var vector in vectorList)
            DrawVector(color, origin.ToXyLinVector3D(), vector.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawVectors(Color color, LinFloat64Vector3D origin, IEnumerable<LinFloat64Vector3D> vectorList)
    {
        foreach (var vector in vectorList)
            DrawVector(color, origin, vector);

        return this;
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector2D origin, IFloat64ParametricCurve2D vectorCurve)
    {
        return DrawVector(color, origin.ToXyLinVector3D(), vectorCurve.ToXyParametricCurve3D());
    }

    public GeometryVisualizer DrawVector(Color color, LinFloat64Vector3D origin, IParametricCurve3D vectorCurve)
    {
        var name = GetNewSceneObjectName("vector");

        var visualVector = GrVisualVector3D.CreateAnimated(
            name,
            VectorStyle.GetVisualStyle(color),
            origin,
            AnimationSpecs.CreateAnimatedVector3D(vectorCurve)
        );

        MainSceneComposer.AddVector(visualVector);

        return this;
    }

    public GeometryVisualizer DrawVector(Color color, IFloat64ParametricCurve2D originCurve, IFloat64ParametricCurve2D vectorCurve)
    {
        return DrawVector(color, originCurve.ToXyParametricCurve3D(), vectorCurve.ToXyParametricCurve3D());
    }

    public GeometryVisualizer DrawVector(Color color, IParametricCurve3D originCurve, IParametricCurve3D vectorCurve)
    {
        var name = GetNewSceneObjectName("vector");

        var visualVector = GrVisualVector3D.CreateAnimated(
            name,
            VectorStyle.GetVisualStyle(color),
            AnimationSpecs.CreateAnimatedVector3D(originCurve),
            AnimationSpecs.CreateAnimatedVector3D(vectorCurve)
        );

        MainSceneComposer.AddVector(visualVector);

        return this;
    }


    public GeometryVisualizer DrawLineCurve(Color color, LinFloat64Vector2D point1, LinFloat64Vector2D point2)
    {
        return DrawLineCurve(color, point1.ToXyLinVector3D(), point2.ToXyLinVector3D());
    }

    public GeometryVisualizer DrawLineCurve(Color color, LinFloat64Vector3D point1, LinFloat64Vector3D point2)
    {
        var name = GetNewSceneObjectName("curve");

        MainSceneComposer.AddLineSegment(
            GrVisualLineSegment3D.CreateStatic(
                name,
                CurveStyle.GetVisualStyle(color),
                point1,
                point2
            )
        );

        return this;
    }

    public GeometryVisualizer DrawLineCurve(Color color, LinFloat64Vector2D point1, IFloat64ParametricCurve2D point2)
    {
        return DrawLineCurve(color, point1.ToXyLinVector3D(), point2.ToXyParametricCurve3D());
    }

    public GeometryVisualizer DrawLineCurve(Color color, LinFloat64Vector3D point1, IParametricCurve3D point2)
    {
        MainSceneComposer.AddLineSegment(
            GrVisualLineSegment3D.CreateAnimated(
                GetNewSceneObjectName("curve"),
                CurveStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(point1),
                AnimationSpecs.CreateAnimatedVector3D(point2)
            )
        );

        return this;
    }

    public GeometryVisualizer DrawLineCurve(Color color, IParametricCurve3D point1, LinFloat64Vector3D point2)
    {
        MainSceneComposer.AddLineSegment(
            GrVisualLineSegment3D.CreateAnimated(
                GetNewSceneObjectName("curve"),
                CurveStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(point1),
                AnimationSpecs.CreateAnimatedVector3D(point2)
            )
        );

        return this;
    }

    public GeometryVisualizer DrawLineCurve(Color color, IFloat64ParametricCurve2D point1, IFloat64ParametricCurve2D point2)
    {
        return DrawLineCurve(color, point1.ToXyParametricCurve3D(), point2.ToXyParametricCurve3D());
    }

    public GeometryVisualizer DrawLineCurve(Color color, IParametricCurve3D point1, IParametricCurve3D point2)
    {
        MainSceneComposer.AddLineSegment(
            GrVisualLineSegment3D.CreateAnimated(
                GetNewSceneObjectName("curve"),
                CurveStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(point1),
                AnimationSpecs.CreateAnimatedVector3D(point2)
            )
        );

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector2D point, LinFloat64Vector2D point1, LinFloat64Vector2D point2)
    {
        DrawLineCurve(color, point.ToXyLinVector3D(), point1.ToXyLinVector3D());
        DrawLineCurve(color, point.ToXyLinVector3D(), point2.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector3D point, LinFloat64Vector3D point1, LinFloat64Vector3D point2)
    {
        DrawLineCurve(color, point, point1);
        DrawLineCurve(color, point, point2);

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector2D point, LinFloat64Vector2D point1, LinFloat64Vector2D point2, LinFloat64Vector2D point3)
    {
        DrawLineCurve(color, point.ToXyLinVector3D(), point1.ToXyLinVector3D());
        DrawLineCurve(color, point.ToXyLinVector3D(), point2.ToXyLinVector3D());
        DrawLineCurve(color, point.ToXyLinVector3D(), point3.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector3D point, LinFloat64Vector3D point1, LinFloat64Vector3D point2, LinFloat64Vector3D point3)
    {
        DrawLineCurve(color, point, point1);
        DrawLineCurve(color, point, point2);
        DrawLineCurve(color, point, point3);

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector2D point1, IEnumerable<LinFloat64Vector2D> pointList)
    {
        foreach (var point2 in pointList)
            DrawLineCurve(color, point1.ToXyLinVector3D(), point2.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector3D point1, IEnumerable<LinFloat64Vector3D> pointList)
    {
        foreach (var point2 in pointList)
            DrawLineCurve(color, point1, point2);

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector2D point1, params LinFloat64Vector2D[] pointList)
    {
        foreach (var point2 in pointList)
            DrawLineCurve(color, point1.ToXyLinVector3D(), point2.ToXyLinVector3D());

        return this;
    }

    public GeometryVisualizer DrawLineCurvesTo(Color color, LinFloat64Vector3D point1, params LinFloat64Vector3D[] pointList)
    {
        foreach (var point2 in pointList)
            DrawLineCurve(color, point1, point2);

        return this;
    }


    public GeometryVisualizer DrawCircleCurve(Color color, LinFloat64Vector3D center, LinFloat64Vector3D normal, double radius)
    {
        MainSceneComposer.AddCircleCurve(
            GrVisualCircleCurve3D.CreateStatic(
                GetNewSceneObjectName("circle"),
                CurveStyle.GetVisualStyle(color),
                center,
                normal,
                radius
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleCurve(Color color, LinFloat64Vector3D center, IParametricCurve3D normal, double radius)
    {
        MainSceneComposer.AddCircleCurve(
            GrVisualCircleCurve3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                CurveStyle.GetVisualStyle(color),
                center,
                AnimationSpecs.CreateAnimatedVector3D(normal),
                radius
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleCurve(Color color, LinFloat64Vector3D center, LinFloat64Vector3D normal, IFloat64ParametricScalar radius)
    {
        MainSceneComposer.AddCircleCurve(
            GrVisualCircleCurve3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                CurveStyle.GetVisualStyle(color),
                center,
                normal,
                AnimationSpecs.CreateAnimatedScalar(radius)
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleCurve(Color color, LinFloat64Vector3D center, IParametricCurve3D normal, IFloat64ParametricScalar radius)
    {
        MainSceneComposer.AddCircleCurve(
            GrVisualCircleCurve3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                CurveStyle.GetVisualStyle(color),
                center,
                AnimationSpecs.CreateAnimatedVector3D(normal),
                AnimationSpecs.CreateAnimatedScalar(radius)
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleCurve(Color color, IParametricCurve3D center, IParametricCurve3D normal, double radius)
    {
        MainSceneComposer.AddCircleCurve(
            GrVisualCircleCurve3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                CurveStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(center),
                AnimationSpecs.CreateAnimatedVector3D(normal),
                radius
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleCurve(Color color, IParametricCurve3D center, IParametricCurve3D normal, IFloat64ParametricScalar radius)
    {
        MainSceneComposer.AddCircleCurve(
            GrVisualCircleCurve3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                CurveStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(center),
                AnimationSpecs.CreateAnimatedVector3D(normal),
                AnimationSpecs.CreateAnimatedScalar(radius)
            )
        );

        return this;
    }


    public GeometryVisualizer DrawCurve(Color color, IFloat64ParametricCurve2D curve, Float64ScalarRange parameterRange)
    {
        return DrawCurve(
            color,
            curve.ToXyParametricCurve3D(),
            parameterRange
        );
    }

    public GeometryVisualizer DrawCurve(Color color, IParametricCurve3D curve, Float64ScalarRange parameterRange)
    {
        var samplingSpecs =
            new AdaptiveCurveSamplingOptions3D(
                5d.DegreesToDirectedAngle(),
                3,
                10
            );

        return DrawCurve(
            color,
            curve,
            parameterRange,
            samplingSpecs
        );
    }

    public GeometryVisualizer DrawCurve(Color color, IFloat64ParametricCurve2D curve, Float64ScalarRange parameterRange, AdaptiveCurveSamplingOptions3D samplingSpecs)
    {
        return DrawCurve(color, curve.ToXyParametricCurve3D(), parameterRange, samplingSpecs);
    }

    public GeometryVisualizer DrawCurve(Color color, IParametricCurve3D curve, Float64ScalarRange parameterRange, AdaptiveCurveSamplingOptions3D samplingSpecs)
    {
        MainSceneComposer.AddLinePath(
            GrVisualPointPathCurve3D.CreateStatic(
                GetNewSceneObjectName("curve"),
                CurveStyle.GetVisualStyle(color),
                curve.CreateAdaptiveCurve3D(
                    parameterRange,
                    samplingSpecs
                )
            )
        );

        return this;
    }


    public GeometryVisualizer DrawCircleSurface(Color color, LinFloat64Vector3D center, LinFloat64Vector3D normal, double radius)
    {
        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateStatic(
                GetNewSceneObjectName("circle"),
                SurfaceStyle.GetVisualStyle(color),
                center,
                normal,
                radius,
                false
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleSurface(Color color, LinFloat64Vector3D center, IParametricCurve3D normal, double radius)
    {
        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                SurfaceStyle.GetVisualStyle(color),
                center,
                AnimationSpecs.CreateAnimatedVector3D(normal),
                radius,
                false
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleSurface(Color color, LinFloat64Vector3D center, LinFloat64Vector3D normal, IFloat64ParametricScalar radius)
    {
        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                SurfaceStyle.GetVisualStyle(color),
                center,
                normal,
                AnimationSpecs.CreateAnimatedScalar(radius),
                false
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleSurface(Color color, LinFloat64Vector3D center, IParametricCurve3D normal, IFloat64ParametricScalar radius)
    {
        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                SurfaceStyle.GetVisualStyle(color),
                center,
                AnimationSpecs.CreateAnimatedVector3D(normal),
                AnimationSpecs.CreateAnimatedScalar(radius),
                false
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleSurface(Color color, IParametricCurve3D center, IParametricCurve3D normal, double radius)
    {
        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                SurfaceStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(center),
                AnimationSpecs.CreateAnimatedVector3D(normal),
                radius,
                false
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleSurface(Color color, IParametricCurve3D center, IParametricCurve3D normal, IFloat64ParametricScalar radius)
    {
        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateAnimated(
                GetNewSceneObjectName("circle"),
                SurfaceStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(center),
                AnimationSpecs.CreateAnimatedVector3D(normal),
                AnimationSpecs.CreateAnimatedScalar(radius),
                false
            )
        );

        return this;
    }


    public GeometryVisualizer DrawCircleSector(Color color, LinFloat64Vector3D center, LinFloat64Vector3D direction1, LinFloat64Vector3D direction2, double radius, IParametricPolarAngle angle)
    {
        MainSceneComposer.AddCircleArcSurface(
            GrVisualCircleArcSurface3D.CreateAnimated(
                GetNewSceneObjectName("circleArc"),
                SurfaceStyle.GetVisualStyle(color),
                center,
                direction1,
                direction2,
                AnimationSpecs.CreateAnimatedScalar(angle),
                radius,
                false
            )
        );

        return this;
    }

    public GeometryVisualizer DrawCircleSector(Color color, IParametricCurve3D center, IParametricCurve3D direction1, IParametricCurve3D direction2, IFloat64ParametricScalar radius, IParametricPolarAngle angle)
    {
        MainSceneComposer.AddCircleArcSurface(
            GrVisualCircleArcSurface3D.CreateAnimated(
                GetNewSceneObjectName("circleArc"),
                SurfaceStyle.GetVisualStyle(color),
                AnimationSpecs.CreateAnimatedVector3D(center),
                AnimationSpecs.CreateAnimatedVector3D(direction1),
                AnimationSpecs.CreateAnimatedVector3D(direction2),
                AnimationSpecs.CreateAnimatedScalar(angle),
                AnimationSpecs.CreateAnimatedScalar(radius),
                false
            )
        );

        return this;
    }


    public string GetHtmlCode()
    {
        return HtmlComposer.GetHtmlCode();
    }

    public void SaveHtmlFile()
    {
        SaveHtmlFile(Title.Pascalize());
    }

    public virtual void SaveHtmlFile(string htmlFileName)
    {
        var htmlCode = HtmlComposer.GetHtmlCode();

        var htmlFilePath = WorkingFolder.GetFilePath(
            htmlFileName,
            "html"
        );

        File.WriteAllText(htmlFilePath, htmlCode);
    }
}