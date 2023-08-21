using DataStructuresLib.Dictionary;
using DataStructuresLib.Files;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.BabylonJs;
using GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.Visuals.Space3D.Animations;
using GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.Visuals.Space3D.Curves;
using GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.Visuals.Space3D.Styles;
using GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.Visuals.Space3D.Surfaces;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using WebComposerLib.Html.Media;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public class RGaConformalVisualizer3D
{
    private int _sceneObjectIndex = 0;

    public RGaConformalSpace5D ConformalSpace { get; }
    
    public int FrameRate { get; } 

    public double MaxTime { get; }
    
    public GrVisualAnimationSpecs AnimationSpecs { get; }

    public string WorkingFolder { get; set; } 
        = @"D:\Projects\Study\Web\Babylon.js";

    public int CanvasWidth { get; set; } 
        = 1024;
    
    public int CanvasHeight { get; set; } 
        = 728;
    
    public int GridUnitCount { get; set; } 
        = 24;
    
    public double CameraDistance { get; set; } 
        = 15;

    public Float64Vector3D AxesOrigin { get; set; }
        = Float64Vector3D.Zero;

    public GrBabylonJsHtmlComposer3D HtmlComposer { get; private set; }

    public GrBabylonJsSceneComposer3D MainSceneComposer
        => HtmlComposer.FirstSceneComposer;

    public GrBabylonJsScene MainScene
        => HtmlComposer.FirstScene;

    public WclHtmlImageDataUrlCache ImageCache
        => HtmlComposer.ImageCache;

    public IReadOnlyDictionary<string, string> LaTeXDictionary { get; private set; }

    public double DefaultThickness { get; private set; } 
        = 0.075d;

    public GrVisualCurveStyle3D ActiveCurveStyle { get; private set; }

    public GrVisualSurfaceStyle3D ActiveSurfaceStyle { get; private set; }




    internal RGaConformalVisualizer3D(RGaConformalSpace5D conformalSpace)
    {
        ConformalSpace = conformalSpace;
        LaTeXDictionary = new Dictionary<string, string>();
        MaxTime = 0;
        FrameRate = 0;
        AnimationSpecs = GrVisualAnimationSpecs.Static;
    }
    
    internal RGaConformalVisualizer3D(RGaConformalSpace5D conformalSpace, int frameRate, double maxTime)
    {
        ConformalSpace = conformalSpace;
        LaTeXDictionary = new Dictionary<string, string>();
        MaxTime = maxTime;
        FrameRate = frameRate;
        AnimationSpecs = GrVisualAnimationSpecs.Create(FrameRate, MaxTime);
    }

    
    private int GetSceneObjectIndex()
    {
        var index = _sceneObjectIndex;

        _sceneObjectIndex++;

        return index;
    }

    private string GetSceneObjectName()
    {
        var name = $"sceneObject{_sceneObjectIndex}";

        _sceneObjectIndex++;

        return name;
    }

    private void InitializeSceneComposers(int index)
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
            CanvasFullScreen = false
        };
    }

    private void InitializeImageCache()
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


    public RGaConformalVisualizer3D BeginDrawing()
    {
        return BeginDrawing(new EmptyDictionary<string, string>());
    }
    
    public RGaConformalVisualizer3D BeginDrawing(IReadOnlyDictionary<string, string> laTeXDictionary)
    {
        _sceneObjectIndex = 0;

        LaTeXDictionary = laTeXDictionary;

        InitializeSceneComposers(0);
        
        if (LaTeXDictionary.Count > 0)
            InitializeImageCache();

        MainSceneComposer
            .AddDefaultGrid(GridUnitCount)
            .AddDefaultAxes(AxesOrigin)
            .AddDefaultEnvironment(GridUnitCount)
            .AddDefaultPerspectiveCamera(
                CameraDistance,
                "2 * Math.PI / 20",
                "2 * Math.PI / 5"
            );

        return this;
    }

    public RGaConformalVisualizer3D SetDefaultThickness(double thickness)
    {
        DefaultThickness = thickness;

        return this;
    }

    public RGaConformalVisualizer3D SetCurveStyle(Color curveColor)
    {
        ActiveCurveStyle = 
            new GrVisualCurveSolidLineStyle3D(curveColor);

        return this;
    }

    public RGaConformalVisualizer3D SetCurveStyle(Color curveColor, int dashOn, int dashOff, int dashPerLine)
    {
        ActiveCurveStyle = 
            new GrVisualCurveDashedLineStyle3D(
                curveColor, 
                new GrVisualDashedLineSpecs(dashOn, dashOff, dashPerLine)
            );

        return this;
    }

    public RGaConformalVisualizer3D SetCurveStyle(Color curveColor, double thickness)
    {
        ActiveCurveStyle = 
            MainSceneComposer
                .AddOrGetColorMaterial(curveColor)
                .CreateTubeCurveStyle(thickness);

        return this;
    }
    
    public RGaConformalVisualizer3D SetSurfaceStyle(Color surfaceColor)
    {
        ActiveSurfaceStyle = 
            MainSceneComposer
                .AddOrGetColorMaterial(surfaceColor)
                .CreateThinSurfaceStyle();

        return this;
    }
    
    public RGaConformalVisualizer3D SetSurfaceStyle(Color surfaceColor, double thickness)
    {
        ActiveSurfaceStyle = 
            MainSceneComposer
                .AddOrGetColorMaterial(surfaceColor)
                .CreateThickSurfaceStyle(thickness);

        return this;
    }

    public RGaConformalVisualizer3D DrawLaTeX(string key, Float64Vector3D origin)
    {
        MainSceneComposer.AddLaTeXText(
            key,
            ImageCache,
            origin,
            HtmlComposer.LaTeXScalingFactor
        );

        return this;
    }

    public RGaConformalVisualizer3D DrawIpnsPoints(IEnumerable<RGaFloat64Vector> mvList)
    {
        foreach (var mv in mvList)
            DrawIpnsPoint(mv);

        return this;
    }

    public RGaConformalVisualizer3D DrawIpnsPoint(RGaFloat64Vector mv)
    {
        //var round = 
        //    ConformalSpace.IpnsSphereToEGaCenter(mv);

        var name = $"point{GetSceneObjectIndex()}";
        var radius = DefaultThickness / 2;
        var center = ConformalSpace.EGaDecodeVector3D(
            ConformalSpace.IpnsSphereToEGaCenter(mv)
        );

        MainSceneComposer.AddSphereSurface(
            GrVisualSphereSurface3D.CreateStatic(
                name, 
                ActiveSurfaceStyle, 
                center, 
                radius
            )
        );

        return this;
    }

    public RGaConformalVisualizer3D DrawOpnsSphere(RGaFloat64KVector mv, bool drawCenter = false)
    {
        return DrawIpnsSphere(
            ConformalSpace.CGaDual(mv).GetVectorPart(),
            drawCenter
        );
    }

    public RGaConformalVisualizer3D DrawIpnsSphere(RGaFloat64Vector mv, bool drawCenter = false)
    {
        var round = 
            ConformalSpace.IpnsDecodeRound(mv);

        var name = $"sphere{GetSceneObjectIndex()}";
        var radius = Math.Max(round.RealRadius, DefaultThickness / 2);
        var center = round.Position.ToVector3D();

        MainSceneComposer.AddSphereSurface(
            GrVisualSphereSurface3D.CreateStatic(
                name, 
                ActiveSurfaceStyle, 
                center, 
                radius
            )
        );
        
        if (drawCenter)
        {
            MainSceneComposer.AddSphereSurface(
                GrVisualSphereSurface3D.CreateStatic(
                    name + "Center",
                    ActiveSurfaceStyle,
                    center,
                    DefaultThickness / 2
                )
            );
        }

        return this;
    }

    public RGaConformalVisualizer3D DrawOpnsPlaneAsDisc(RGaFloat64KVector mv, double radius)
    {
        return DrawIpnsPlaneAsDisc(
            ConformalSpace.CGaDual(mv).GetVectorPart(),
            radius
        );
    }

    public RGaConformalVisualizer3D DrawIpnsPlaneAsDisc(RGaFloat64Vector mv, double radius)
    {
        var flat = 
            ConformalSpace.IpnsDecodeFlat(mv);

        var name = $"plane{GetSceneObjectIndex()}";
        var center = flat.Position.ToVector3D();
        var normal = ConformalSpace.EGaDual(flat.Direction).GetVectorPartAsTuple3D();

        MainSceneComposer.AddCircleSurface(
            GrVisualCircleSurface3D.CreateStatic(
                name, 
                ActiveSurfaceStyle, 
                center, 
                normal,
                radius,
                false
            )
        );

        return this;
    }

    public RGaConformalVisualizer3D DrawOpnsCircle(RGaFloat64Bivector mv, bool drawCenter = false, bool drawPlane = false)
    {
        return DrawIpnsCircle(
            ConformalSpace.CGaDual(mv).GetBivectorPart(),
            drawCenter,
            drawPlane
        );
    }

    public RGaConformalVisualizer3D DrawIpnsCircle(RGaFloat64Bivector mv, bool drawCenter = false, bool drawPlane = false)
    {
        var round = 
            ConformalSpace.IpnsDecodeRound(mv);

        if (round.Direction.Grade != 2)
            throw new InvalidOperationException();
        
        var name = $"circle{GetSceneObjectIndex()}";
        var radius = Math.Max(round.RealRadius, DefaultThickness / 2);
        var center = round.Position.ToVector3D();
        var normal = ConformalSpace.EGaDual(round.Direction).GetVectorPartAsTuple3D();

        MainSceneComposer.AddCircle(
            GrVisualCircleCurve3D.CreateStatic(
                name, 
                ActiveCurveStyle, 
                center, 
                normal,
                radius
            )
        );
        
        if (drawCenter)
        {
            MainSceneComposer.AddSphereSurface(
                GrVisualSphereSurface3D.CreateStatic(
                    name + "Center",
                    ActiveSurfaceStyle,
                    center,
                    DefaultThickness / 2
                )
            );
        }

        return this;
    }

    public void GenerateHtml(string htmlFileName)
    {
        var htmlCode = HtmlComposer.GetHtmlCode();

        var htmlFilePath = WorkingFolder.GetFilePath(
            htmlFileName,
            "html"
        );

        File.WriteAllText(htmlFilePath, htmlCode);
    }
}