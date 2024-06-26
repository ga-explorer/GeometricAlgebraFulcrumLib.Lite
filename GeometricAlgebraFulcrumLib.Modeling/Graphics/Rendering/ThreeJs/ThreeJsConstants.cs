using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;
using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs;

public static class ThreeJsConstants
{
    public static JsString REVISION { get; } = "THREE.REVISION".AsJsStringVariable(("133dev").AsJsString());
        
    public static JsObject MOUSE { get; } = "THREE.MOUSE".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"LEFT", (0).AsJsNumber()},
        {"MIDDLE", (1).AsJsNumber()},
        {"RIGHT", (2).AsJsNumber()},
        {"ROTATE", (0).AsJsNumber()},
        {"DOLLY", (1).AsJsNumber()},
        {"PAN", (2).AsJsNumber()}
    }.AsJsObject());
        
    public static JsObject TOUCH { get; } = "THREE.TOUCH".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"ROTATE", (0).AsJsNumber()},
        {"PAN", (1).AsJsNumber()},
        {"DOLLY_PAN", (2).AsJsNumber()},
        {"DOLLY_ROTATE", (3).AsJsNumber()}
    }.AsJsObject());
        
    public static JsNumber CullFaceNone { get; } = "THREE.CullFaceNone".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber CullFaceBack { get; } = "THREE.CullFaceBack".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber CullFaceFront { get; } = "THREE.CullFaceFront".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber CullFaceFrontBack { get; } = "THREE.CullFaceFrontBack".AsJsNumberVariable((3).AsJsNumber());
        
    public static JsNumber BasicShadowMap { get; } = "THREE.BasicShadowMap".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber PCFShadowMap { get; } = "THREE.PCFShadowMap".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber PCFSoftShadowMap { get; } = "THREE.PCFSoftShadowMap".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber VSMShadowMap { get; } = "THREE.VSMShadowMap".AsJsNumberVariable((3).AsJsNumber());
        
    public static JsNumber FrontSide { get; } = "THREE.FrontSide".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber BackSide { get; } = "THREE.BackSide".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber DoubleSide { get; } = "THREE.DoubleSide".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber FlatShading { get; } = "THREE.FlatShading".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber SmoothShading { get; } = "THREE.SmoothShading".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber NoBlending { get; } = "THREE.NoBlending".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber NormalBlending { get; } = "THREE.NormalBlending".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber AdditiveBlending { get; } = "THREE.AdditiveBlending".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber SubtractiveBlending { get; } = "THREE.SubtractiveBlending".AsJsNumberVariable((3).AsJsNumber());
        
    public static JsNumber MultiplyBlending { get; } = "THREE.MultiplyBlending".AsJsNumberVariable((4).AsJsNumber());
        
    public static JsNumber CustomBlending { get; } = "THREE.CustomBlending".AsJsNumberVariable((5).AsJsNumber());
        
    public static JsNumber AddEquation { get; } = "THREE.AddEquation".AsJsNumberVariable((100).AsJsNumber());
        
    public static JsNumber SubtractEquation { get; } = "THREE.SubtractEquation".AsJsNumberVariable((101).AsJsNumber());
        
    public static JsNumber ReverseSubtractEquation { get; } = "THREE.ReverseSubtractEquation".AsJsNumberVariable((102).AsJsNumber());
        
    public static JsNumber MinEquation { get; } = "THREE.MinEquation".AsJsNumberVariable((103).AsJsNumber());
        
    public static JsNumber MaxEquation { get; } = "THREE.MaxEquation".AsJsNumberVariable((104).AsJsNumber());
        
    public static JsNumber ZeroFactor { get; } = "THREE.ZeroFactor".AsJsNumberVariable((200).AsJsNumber());
        
    public static JsNumber OneFactor { get; } = "THREE.OneFactor".AsJsNumberVariable((201).AsJsNumber());
        
    public static JsNumber SrcColorFactor { get; } = "THREE.SrcColorFactor".AsJsNumberVariable((202).AsJsNumber());
        
    public static JsNumber OneMinusSrcColorFactor { get; } = "THREE.OneMinusSrcColorFactor".AsJsNumberVariable((203).AsJsNumber());
        
    public static JsNumber SrcAlphaFactor { get; } = "THREE.SrcAlphaFactor".AsJsNumberVariable((204).AsJsNumber());
        
    public static JsNumber OneMinusSrcAlphaFactor { get; } = "THREE.OneMinusSrcAlphaFactor".AsJsNumberVariable((205).AsJsNumber());
        
    public static JsNumber DstAlphaFactor { get; } = "THREE.DstAlphaFactor".AsJsNumberVariable((206).AsJsNumber());
        
    public static JsNumber OneMinusDstAlphaFactor { get; } = "THREE.OneMinusDstAlphaFactor".AsJsNumberVariable((207).AsJsNumber());
        
    public static JsNumber DstColorFactor { get; } = "THREE.DstColorFactor".AsJsNumberVariable((208).AsJsNumber());
        
    public static JsNumber OneMinusDstColorFactor { get; } = "THREE.OneMinusDstColorFactor".AsJsNumberVariable((209).AsJsNumber());
        
    public static JsNumber SrcAlphaSaturateFactor { get; } = "THREE.SrcAlphaSaturateFactor".AsJsNumberVariable((210).AsJsNumber());
        
    public static JsNumber NeverDepth { get; } = "THREE.NeverDepth".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber AlwaysDepth { get; } = "THREE.AlwaysDepth".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber LessDepth { get; } = "THREE.LessDepth".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber LessEqualDepth { get; } = "THREE.LessEqualDepth".AsJsNumberVariable((3).AsJsNumber());
        
    public static JsNumber EqualDepth { get; } = "THREE.EqualDepth".AsJsNumberVariable((4).AsJsNumber());
        
    public static JsNumber GreaterEqualDepth { get; } = "THREE.GreaterEqualDepth".AsJsNumberVariable((5).AsJsNumber());
        
    public static JsNumber GreaterDepth { get; } = "THREE.GreaterDepth".AsJsNumberVariable((6).AsJsNumber());
        
    public static JsNumber NotEqualDepth { get; } = "THREE.NotEqualDepth".AsJsNumberVariable((7).AsJsNumber());
        
    public static JsNumber MultiplyOperation { get; } = "THREE.MultiplyOperation".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber MixOperation { get; } = "THREE.MixOperation".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber AddOperation { get; } = "THREE.AddOperation".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber NoToneMapping { get; } = "THREE.NoToneMapping".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber LinearToneMapping { get; } = "THREE.LinearToneMapping".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber ReinhardToneMapping { get; } = "THREE.ReinhardToneMapping".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber CineonToneMapping { get; } = "THREE.CineonToneMapping".AsJsNumberVariable((3).AsJsNumber());
        
    public static JsNumber ACESFilmicToneMapping { get; } = "THREE.ACESFilmicToneMapping".AsJsNumberVariable((4).AsJsNumber());
        
    public static JsNumber CustomToneMapping { get; } = "THREE.CustomToneMapping".AsJsNumberVariable((5).AsJsNumber());
        
    public static JsNumber UVMapping { get; } = "THREE.UVMapping".AsJsNumberVariable((300).AsJsNumber());
        
    public static JsNumber CubeReflectionMapping { get; } = "THREE.CubeReflectionMapping".AsJsNumberVariable((301).AsJsNumber());
        
    public static JsNumber CubeRefractionMapping { get; } = "THREE.CubeRefractionMapping".AsJsNumberVariable((302).AsJsNumber());
        
    public static JsNumber EquirectangularReflectionMapping { get; } = "THREE.EquirectangularReflectionMapping".AsJsNumberVariable((303).AsJsNumber());
        
    public static JsNumber EquirectangularRefractionMapping { get; } = "THREE.EquirectangularRefractionMapping".AsJsNumberVariable((304).AsJsNumber());
        
    public static JsNumber CubeUVReflectionMapping { get; } = "THREE.CubeUVReflectionMapping".AsJsNumberVariable((306).AsJsNumber());
        
    public static JsNumber CubeUVRefractionMapping { get; } = "THREE.CubeUVRefractionMapping".AsJsNumberVariable((307).AsJsNumber());
        
    public static JsNumber RepeatWrapping { get; } = "THREE.RepeatWrapping".AsJsNumberVariable((1000).AsJsNumber());
        
    public static JsNumber ClampToEdgeWrapping { get; } = "THREE.ClampToEdgeWrapping".AsJsNumberVariable((1001).AsJsNumber());
        
    public static JsNumber MirroredRepeatWrapping { get; } = "THREE.MirroredRepeatWrapping".AsJsNumberVariable((1002).AsJsNumber());
        
    public static JsNumber NearestFilter { get; } = "THREE.NearestFilter".AsJsNumberVariable((1003).AsJsNumber());
        
    public static JsNumber NearestMipmapNearestFilter { get; } = "THREE.NearestMipmapNearestFilter".AsJsNumberVariable((1004).AsJsNumber());
        
    public static JsNumber NearestMipMapNearestFilter { get; } = "THREE.NearestMipMapNearestFilter".AsJsNumberVariable((1004).AsJsNumber());
        
    public static JsNumber NearestMipmapLinearFilter { get; } = "THREE.NearestMipmapLinearFilter".AsJsNumberVariable((1005).AsJsNumber());
        
    public static JsNumber NearestMipMapLinearFilter { get; } = "THREE.NearestMipMapLinearFilter".AsJsNumberVariable((1005).AsJsNumber());
        
    public static JsNumber LinearFilter { get; } = "THREE.LinearFilter".AsJsNumberVariable((1006).AsJsNumber());
        
    public static JsNumber LinearMipmapNearestFilter { get; } = "THREE.LinearMipmapNearestFilter".AsJsNumberVariable((1007).AsJsNumber());
        
    public static JsNumber LinearMipMapNearestFilter { get; } = "THREE.LinearMipMapNearestFilter".AsJsNumberVariable((1007).AsJsNumber());
        
    public static JsNumber LinearMipmapLinearFilter { get; } = "THREE.LinearMipmapLinearFilter".AsJsNumberVariable((1008).AsJsNumber());
        
    public static JsNumber LinearMipMapLinearFilter { get; } = "THREE.LinearMipMapLinearFilter".AsJsNumberVariable((1008).AsJsNumber());
        
    public static JsNumber UnsignedByteType { get; } = "THREE.UnsignedByteType".AsJsNumberVariable((1009).AsJsNumber());
        
    public static JsNumber ByteType { get; } = "THREE.ByteType".AsJsNumberVariable((1010).AsJsNumber());
        
    public static JsNumber ShortType { get; } = "THREE.ShortType".AsJsNumberVariable((1011).AsJsNumber());
        
    public static JsNumber UnsignedShortType { get; } = "THREE.UnsignedShortType".AsJsNumberVariable((1012).AsJsNumber());
        
    public static JsNumber IntType { get; } = "THREE.IntType".AsJsNumberVariable((1013).AsJsNumber());
        
    public static JsNumber UnsignedIntType { get; } = "THREE.UnsignedIntType".AsJsNumberVariable((1014).AsJsNumber());
        
    public static JsNumber FloatType { get; } = "THREE.FloatType".AsJsNumberVariable((1015).AsJsNumber());
        
    public static JsNumber HalfFloatType { get; } = "THREE.HalfFloatType".AsJsNumberVariable((1016).AsJsNumber());
        
    public static JsNumber UnsignedShort4444Type { get; } = "THREE.UnsignedShort4444Type".AsJsNumberVariable((1017).AsJsNumber());
        
    public static JsNumber UnsignedShort5551Type { get; } = "THREE.UnsignedShort5551Type".AsJsNumberVariable((1018).AsJsNumber());
        
    public static JsNumber UnsignedShort565Type { get; } = "THREE.UnsignedShort565Type".AsJsNumberVariable((1019).AsJsNumber());
        
    public static JsNumber UnsignedInt248Type { get; } = "THREE.UnsignedInt248Type".AsJsNumberVariable((1020).AsJsNumber());
        
    public static JsNumber AlphaFormat { get; } = "THREE.AlphaFormat".AsJsNumberVariable((1021).AsJsNumber());
        
    public static JsNumber RGBFormat { get; } = "THREE.RGBFormat".AsJsNumberVariable((1022).AsJsNumber());
        
    public static JsNumber RGBAFormat { get; } = "THREE.RGBAFormat".AsJsNumberVariable((1023).AsJsNumber());
        
    public static JsNumber LuminanceFormat { get; } = "THREE.LuminanceFormat".AsJsNumberVariable((1024).AsJsNumber());
        
    public static JsNumber LuminanceAlphaFormat { get; } = "THREE.LuminanceAlphaFormat".AsJsNumberVariable((1025).AsJsNumber());
        
    public static JsNumber RGBEFormat { get; } = "THREE.RGBEFormat".AsJsNumberVariable(RGBAFormat);
        
    public static JsNumber DepthFormat { get; } = "THREE.DepthFormat".AsJsNumberVariable((1026).AsJsNumber());
        
    public static JsNumber DepthStencilFormat { get; } = "THREE.DepthStencilFormat".AsJsNumberVariable((1027).AsJsNumber());
        
    public static JsNumber RedFormat { get; } = "THREE.RedFormat".AsJsNumberVariable((1028).AsJsNumber());
        
    public static JsNumber RedIntegerFormat { get; } = "THREE.RedIntegerFormat".AsJsNumberVariable((1029).AsJsNumber());
        
    public static JsNumber RGFormat { get; } = "THREE.RGFormat".AsJsNumberVariable((1030).AsJsNumber());
        
    public static JsNumber RGIntegerFormat { get; } = "THREE.RGIntegerFormat".AsJsNumberVariable((1031).AsJsNumber());
        
    public static JsNumber RGBIntegerFormat { get; } = "THREE.RGBIntegerFormat".AsJsNumberVariable((1032).AsJsNumber());
        
    public static JsNumber RGBAIntegerFormat { get; } = "THREE.RGBAIntegerFormat".AsJsNumberVariable((1033).AsJsNumber());
        
    public static JsNumber RGBS3TCDXT1Format { get; } = "THREE.RGB_S3TC_DXT1_Format".AsJsNumberVariable((33776).AsJsNumber());
        
    public static JsNumber RGBAS3TCDXT1Format { get; } = "THREE.RGBA_S3TC_DXT1_Format".AsJsNumberVariable((33777).AsJsNumber());
        
    public static JsNumber RGBAS3TCDXT3Format { get; } = "THREE.RGBA_S3TC_DXT3_Format".AsJsNumberVariable((33778).AsJsNumber());
        
    public static JsNumber RGBAS3TCDXT5Format { get; } = "THREE.RGBA_S3TC_DXT5_Format".AsJsNumberVariable((33779).AsJsNumber());
        
    public static JsNumber RGBPVRTC4BPPV1Format { get; } = "THREE.RGB_PVRTC_4BPPV1_Format".AsJsNumberVariable((35840).AsJsNumber());
        
    public static JsNumber RGBPVRTC2BPPV1Format { get; } = "THREE.RGB_PVRTC_2BPPV1_Format".AsJsNumberVariable((35841).AsJsNumber());
        
    public static JsNumber RGBAPVRTC4BPPV1Format { get; } = "THREE.RGBA_PVRTC_4BPPV1_Format".AsJsNumberVariable((35842).AsJsNumber());
        
    public static JsNumber RGBAPVRTC2BPPV1Format { get; } = "THREE.RGBA_PVRTC_2BPPV1_Format".AsJsNumberVariable((35843).AsJsNumber());
        
    public static JsNumber RGBETC1Format { get; } = "THREE.RGB_ETC1_Format".AsJsNumberVariable((36196).AsJsNumber());
        
    public static JsNumber RGBETC2Format { get; } = "THREE.RGB_ETC2_Format".AsJsNumberVariable((37492).AsJsNumber());
        
    public static JsNumber RGBAETC2EACFormat { get; } = "THREE.RGBA_ETC2_EAC_Format".AsJsNumberVariable((37496).AsJsNumber());
        
    public static JsNumber RGBAASTC4x4Format { get; } = "THREE.RGBA_ASTC_4x4_Format".AsJsNumberVariable((37808).AsJsNumber());
        
    public static JsNumber RGBAASTC5x4Format { get; } = "THREE.RGBA_ASTC_5x4_Format".AsJsNumberVariable((37809).AsJsNumber());
        
    public static JsNumber RGBAASTC5x5Format { get; } = "THREE.RGBA_ASTC_5x5_Format".AsJsNumberVariable((37810).AsJsNumber());
        
    public static JsNumber RGBAASTC6x5Format { get; } = "THREE.RGBA_ASTC_6x5_Format".AsJsNumberVariable((37811).AsJsNumber());
        
    public static JsNumber RGBAASTC6x6Format { get; } = "THREE.RGBA_ASTC_6x6_Format".AsJsNumberVariable((37812).AsJsNumber());
        
    public static JsNumber RGBAASTC8x5Format { get; } = "THREE.RGBA_ASTC_8x5_Format".AsJsNumberVariable((37813).AsJsNumber());
        
    public static JsNumber RGBAASTC8x6Format { get; } = "THREE.RGBA_ASTC_8x6_Format".AsJsNumberVariable((37814).AsJsNumber());
        
    public static JsNumber RGBAASTC8x8Format { get; } = "THREE.RGBA_ASTC_8x8_Format".AsJsNumberVariable((37815).AsJsNumber());
        
    public static JsNumber RGBAASTC10x5Format { get; } = "THREE.RGBA_ASTC_10x5_Format".AsJsNumberVariable((37816).AsJsNumber());
        
    public static JsNumber RGBAASTC10x6Format { get; } = "THREE.RGBA_ASTC_10x6_Format".AsJsNumberVariable((37817).AsJsNumber());
        
    public static JsNumber RGBAASTC10x8Format { get; } = "THREE.RGBA_ASTC_10x8_Format".AsJsNumberVariable((37818).AsJsNumber());
        
    public static JsNumber RGBAASTC10x10Format { get; } = "THREE.RGBA_ASTC_10x10_Format".AsJsNumberVariable((37819).AsJsNumber());
        
    public static JsNumber RGBAASTC12x10Format { get; } = "THREE.RGBA_ASTC_12x10_Format".AsJsNumberVariable((37820).AsJsNumber());
        
    public static JsNumber RGBAASTC12x12Format { get; } = "THREE.RGBA_ASTC_12x12_Format".AsJsNumberVariable((37821).AsJsNumber());
        
    public static JsNumber RGBABPTCFormat { get; } = "THREE.RGBA_BPTC_Format".AsJsNumberVariable((36492).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC4x4Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_4x4_Format".AsJsNumberVariable((37840).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC5x4Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_5x4_Format".AsJsNumberVariable((37841).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC5x5Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_5x5_Format".AsJsNumberVariable((37842).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC6x5Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_6x5_Format".AsJsNumberVariable((37843).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC6x6Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_6x6_Format".AsJsNumberVariable((37844).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC8x5Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_8x5_Format".AsJsNumberVariable((37845).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC8x6Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_8x6_Format".AsJsNumberVariable((37846).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC8x8Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_8x8_Format".AsJsNumberVariable((37847).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC10x5Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_10x5_Format".AsJsNumberVariable((37848).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC10x6Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_10x6_Format".AsJsNumberVariable((37849).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC10x8Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_10x8_Format".AsJsNumberVariable((37850).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC10x10Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_10x10_Format".AsJsNumberVariable((37851).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC12x10Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_12x10_Format".AsJsNumberVariable((37852).AsJsNumber());
        
    public static JsNumber SRGB8ALPHA8ASTC12x12Format { get; } = "THREE.SRGB8_ALPHA8_ASTC_12x12_Format".AsJsNumberVariable((37853).AsJsNumber());
        
    public static JsNumber LoopOnce { get; } = "THREE.LoopOnce".AsJsNumberVariable((2200).AsJsNumber());
        
    public static JsNumber LoopRepeat { get; } = "THREE.LoopRepeat".AsJsNumberVariable((2201).AsJsNumber());
        
    public static JsNumber LoopPingPong { get; } = "THREE.LoopPingPong".AsJsNumberVariable((2202).AsJsNumber());
        
    public static JsNumber InterpolateDiscrete { get; } = "THREE.InterpolateDiscrete".AsJsNumberVariable((2300).AsJsNumber());
        
    public static JsNumber InterpolateLinear { get; } = "THREE.InterpolateLinear".AsJsNumberVariable((2301).AsJsNumber());
        
    public static JsNumber InterpolateSmooth { get; } = "THREE.InterpolateSmooth".AsJsNumberVariable((2302).AsJsNumber());
        
    public static JsNumber ZeroCurvatureEnding { get; } = "THREE.ZeroCurvatureEnding".AsJsNumberVariable((2400).AsJsNumber());
        
    public static JsNumber ZeroSlopeEnding { get; } = "THREE.ZeroSlopeEnding".AsJsNumberVariable((2401).AsJsNumber());
        
    public static JsNumber WrapAroundEnding { get; } = "THREE.WrapAroundEnding".AsJsNumberVariable((2402).AsJsNumber());
        
    public static JsNumber NormalAnimationBlendMode { get; } = "THREE.NormalAnimationBlendMode".AsJsNumberVariable((2500).AsJsNumber());
        
    public static JsNumber AdditiveAnimationBlendMode { get; } = "THREE.AdditiveAnimationBlendMode".AsJsNumberVariable((2501).AsJsNumber());
        
    public static JsNumber TrianglesDrawMode { get; } = "THREE.TrianglesDrawMode".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber TriangleStripDrawMode { get; } = "THREE.TriangleStripDrawMode".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber TriangleFanDrawMode { get; } = "THREE.TriangleFanDrawMode".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsNumber LinearEncoding { get; } = "THREE.LinearEncoding".AsJsNumberVariable((3000).AsJsNumber());
        
    public static JsNumber SRGBEncoding { get; } = "THREE.sRGBEncoding".AsJsNumberVariable((3001).AsJsNumber());
        
    public static JsNumber GammaEncoding { get; } = "THREE.GammaEncoding".AsJsNumberVariable((3007).AsJsNumber());
        
    public static JsNumber RGBEEncoding { get; } = "THREE.RGBEEncoding".AsJsNumberVariable((3002).AsJsNumber());
        
    public static JsNumber LogLuvEncoding { get; } = "THREE.LogLuvEncoding".AsJsNumberVariable((3003).AsJsNumber());
        
    public static JsNumber RGBM7Encoding { get; } = "THREE.RGBM7Encoding".AsJsNumberVariable((3004).AsJsNumber());
        
    public static JsNumber RGBM16Encoding { get; } = "THREE.RGBM16Encoding".AsJsNumberVariable((3005).AsJsNumber());
        
    public static JsNumber RGBDEncoding { get; } = "THREE.RGBDEncoding".AsJsNumberVariable((3006).AsJsNumber());
        
    public static JsNumber BasicDepthPacking { get; } = "THREE.BasicDepthPacking".AsJsNumberVariable((3200).AsJsNumber());
        
    public static JsNumber RGBADepthPacking { get; } = "THREE.RGBADepthPacking".AsJsNumberVariable((3201).AsJsNumber());
        
    public static JsNumber TangentSpaceNormalMap { get; } = "THREE.TangentSpaceNormalMap".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber ObjectSpaceNormalMap { get; } = "THREE.ObjectSpaceNormalMap".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber ZeroStencilOp { get; } = "THREE.ZeroStencilOp".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber KeepStencilOp { get; } = "THREE.KeepStencilOp".AsJsNumberVariable((7680).AsJsNumber());
        
    public static JsNumber ReplaceStencilOp { get; } = "THREE.ReplaceStencilOp".AsJsNumberVariable((7681).AsJsNumber());
        
    public static JsNumber IncrementStencilOp { get; } = "THREE.IncrementStencilOp".AsJsNumberVariable((7682).AsJsNumber());
        
    public static JsNumber DecrementStencilOp { get; } = "THREE.DecrementStencilOp".AsJsNumberVariable((7683).AsJsNumber());
        
    public static JsNumber IncrementWrapStencilOp { get; } = "THREE.IncrementWrapStencilOp".AsJsNumberVariable((34055).AsJsNumber());
        
    public static JsNumber DecrementWrapStencilOp { get; } = "THREE.DecrementWrapStencilOp".AsJsNumberVariable((34056).AsJsNumber());
        
    public static JsNumber InvertStencilOp { get; } = "THREE.InvertStencilOp".AsJsNumberVariable((5386).AsJsNumber());
        
    public static JsNumber NeverStencilFunc { get; } = "THREE.NeverStencilFunc".AsJsNumberVariable((512).AsJsNumber());
        
    public static JsNumber LessStencilFunc { get; } = "THREE.LessStencilFunc".AsJsNumberVariable((513).AsJsNumber());
        
    public static JsNumber EqualStencilFunc { get; } = "THREE.EqualStencilFunc".AsJsNumberVariable((514).AsJsNumber());
        
    public static JsNumber LessEqualStencilFunc { get; } = "THREE.LessEqualStencilFunc".AsJsNumberVariable((515).AsJsNumber());
        
    public static JsNumber GreaterStencilFunc { get; } = "THREE.GreaterStencilFunc".AsJsNumberVariable((516).AsJsNumber());
        
    public static JsNumber NotEqualStencilFunc { get; } = "THREE.NotEqualStencilFunc".AsJsNumberVariable((517).AsJsNumber());
        
    public static JsNumber GreaterEqualStencilFunc { get; } = "THREE.GreaterEqualStencilFunc".AsJsNumberVariable((518).AsJsNumber());
        
    public static JsNumber AlwaysStencilFunc { get; } = "THREE.AlwaysStencilFunc".AsJsNumberVariable((519).AsJsNumber());
        
    public static JsNumber StaticDrawUsage { get; } = "THREE.StaticDrawUsage".AsJsNumberVariable((35044).AsJsNumber());
        
    public static JsNumber DynamicDrawUsage { get; } = "THREE.DynamicDrawUsage".AsJsNumberVariable((35048).AsJsNumber());
        
    public static JsNumber StreamDrawUsage { get; } = "THREE.StreamDrawUsage".AsJsNumberVariable((35040).AsJsNumber());
        
    public static JsNumber StaticReadUsage { get; } = "THREE.StaticReadUsage".AsJsNumberVariable((35045).AsJsNumber());
        
    public static JsNumber DynamicReadUsage { get; } = "THREE.DynamicReadUsage".AsJsNumberVariable((35049).AsJsNumber());
        
    public static JsNumber StreamReadUsage { get; } = "THREE.StreamReadUsage".AsJsNumberVariable((35041).AsJsNumber());
        
    public static JsNumber StaticCopyUsage { get; } = "THREE.StaticCopyUsage".AsJsNumberVariable((35046).AsJsNumber());
        
    public static JsNumber DynamicCopyUsage { get; } = "THREE.DynamicCopyUsage".AsJsNumberVariable((35050).AsJsNumber());
        
    public static JsNumber StreamCopyUsage { get; } = "THREE.StreamCopyUsage".AsJsNumberVariable((35042).AsJsNumber());
        
    public static JsString GLSL1 { get; } = "THREE.GLSL1".AsJsStringVariable(("100").AsJsString());
        
    public static JsString GLSL3 { get; } = "THREE.GLSL3".AsJsStringVariable(("300 es").AsJsString());
        
    public static JsType DEG2RAD { get; } = "THREE.DEG2RAD".AsJsTypeVariable(new JsObject());
        
    public static JsType RAD2DEG { get; } = "THREE.RAD2DEG".AsJsTypeVariable(new JsObject());
        
    public static JsType HasRandomUUID { get; } = "THREE.hasRandomUUID".AsJsTypeVariable(new JsObject());
        
    public static JsObject TYPEDARRAYS { get; } = "THREE.TYPED_ARRAYS".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"Int8Array", new JsObject()},
        {"Uint8Array", new JsObject()},
        {"Uint8ClampedArray", new JsObject()},
        {"Int16Array", new JsObject()},
        {"Uint16Array", new JsObject()},
        {"Int32Array", new JsObject()},
        {"Uint32Array", new JsObject()},
        {"Float32Array", new JsObject()},
        {"Float64Array", new JsObject()}
    }.AsJsObject());
        
    public static JsObject UniformsUtils { get; } = "THREE.UniformsUtils".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"clone", new JsObject()},
        {"merge", new JsObject()}
    }.AsJsObject());
        
    public static JsNumber Fov { get; } = "THREE.fov".AsJsNumberVariable((90).AsJsNumber());
        
    public static JsNumber Aspect { get; } = "THREE.aspect".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsString VertexG { get; } = "THREE.vertex$g".AsJsStringVariable(("varying vec2 vUv;\nuniform mat3 uvTransform;\nvoid main() {\n\tvUv = ( uvTransform * vec3( uv, 1 ) ).xy;\n\tgl_Position = vec4( position.xy, 1.0, 1.0 );\n}").AsJsString());
        
    public static JsString FragmentG { get; } = "THREE.fragment$g".AsJsStringVariable(("uniform sampler2D t2D;\nvarying vec2 vUv;\nvoid main() {\n\tvec4 texColor = texture2D( t2D, vUv );\n\tgl_FragColor = mapTexelToLinear( texColor );\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n}").AsJsString());
        
    public static JsString VertexF { get; } = "THREE.vertex$f".AsJsStringVariable(("varying vec3 vWorldDirection;\n#include <common>\nvoid main() {\n\tvWorldDirection = transformDirection( position, modelMatrix );\n\t#include <begin_vertex>\n\t#include <project_vertex>\n\tgl_Position.z = gl_Position.w;\n}").AsJsString());
        
    public static JsString FragmentF { get; } = "THREE.fragment$f".AsJsStringVariable(("#include <envmap_common_pars_fragment>\nuniform float opacity;\nvarying vec3 vWorldDirection;\n#include <cube_uv_reflection_fragment>\nvoid main() {\n\tvec3 vReflect = vWorldDirection;\n\t#include <envmap_fragment>\n\tgl_FragColor = envColor;\n\tgl_FragColor.a *= opacity;\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n}").AsJsString());
        
    public static JsString VertexE { get; } = "THREE.vertex$e".AsJsStringVariable(("#include <common>\n#include <uv_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvarying vec2 vHighPrecisionZW;\nvoid main() {\n\t#include <uv_vertex>\n\t#include <skinbase_vertex>\n\t#ifdef USE_DISPLACEMENTMAP\n\t\t#include <beginnormal_vertex>\n\t\t#include <morphnormal_vertex>\n\t\t#include <skinnormal_vertex>\n\t#endif\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\tvHighPrecisionZW = gl_Position.zw;\n}").AsJsString());
        
    public static JsString FragmentE { get; } = "THREE.fragment$e".AsJsStringVariable(("#if DEPTH_PACKING == 3200\n\tuniform float opacity;\n#endif\n#include <common>\n#include <packing>\n#include <uv_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvarying vec2 vHighPrecisionZW;\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( 1.0 );\n\t#if DEPTH_PACKING == 3200\n\t\tdiffuseColor.a = opacity;\n\t#endif\n\t#include <map_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <logdepthbuf_fragment>\n\tfloat fragCoordZ = 0.5 * vHighPrecisionZW[0] / vHighPrecisionZW[1] + 0.5;\n\t#if DEPTH_PACKING == 3200\n\t\tgl_FragColor = vec4( vec3( 1.0 - fragCoordZ ), opacity );\n\t#elif DEPTH_PACKING == 3201\n\t\tgl_FragColor = packDepthToRGBA( fragCoordZ );\n\t#endif\n}").AsJsString());
        
    public static JsString VertexD { get; } = "THREE.vertex$d".AsJsStringVariable(("#define DISTANCE\nvarying vec3 vWorldPosition;\n#include <common>\n#include <uv_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <skinbase_vertex>\n\t#ifdef USE_DISPLACEMENTMAP\n\t\t#include <beginnormal_vertex>\n\t\t#include <morphnormal_vertex>\n\t\t#include <skinnormal_vertex>\n\t#endif\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <worldpos_vertex>\n\t#include <clipping_planes_vertex>\n\tvWorldPosition = worldPosition.xyz;\n}").AsJsString());
        
    public static JsString FragmentD { get; } = "THREE.fragment$d".AsJsStringVariable(("#define DISTANCE\nuniform vec3 referencePosition;\nuniform float nearDistance;\nuniform float farDistance;\nvarying vec3 vWorldPosition;\n#include <common>\n#include <packing>\n#include <uv_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main () {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( 1.0 );\n\t#include <map_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\tfloat dist = length( vWorldPosition - referencePosition );\n\tdist = ( dist - nearDistance ) / ( farDistance - nearDistance );\n\tdist = saturate( dist );\n\tgl_FragColor = packDepthToRGBA( dist );\n}").AsJsString());
        
    public static JsString VertexC { get; } = "THREE.vertex$c".AsJsStringVariable(("varying vec3 vWorldDirection;\n#include <common>\nvoid main() {\n\tvWorldDirection = transformDirection( position, modelMatrix );\n\t#include <begin_vertex>\n\t#include <project_vertex>\n}").AsJsString());
        
    public static JsString FragmentC { get; } = "THREE.fragment$c".AsJsStringVariable(("uniform sampler2D tEquirect;\nvarying vec3 vWorldDirection;\n#include <common>\nvoid main() {\n\tvec3 direction = normalize( vWorldDirection );\n\tvec2 sampleUV = equirectUv( direction );\n\tvec4 texColor = texture2D( tEquirect, sampleUV );\n\tgl_FragColor = mapTexelToLinear( texColor );\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n}").AsJsString());
        
    public static JsString VertexB { get; } = "THREE.vertex$b".AsJsStringVariable(("uniform float scale;\nattribute float lineDistance;\nvarying float vLineDistance;\n#include <common>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\tvLineDistance = scale * lineDistance;\n\t#include <color_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString FragmentB { get; } = "THREE.fragment$b".AsJsStringVariable(("uniform vec3 diffuse;\nuniform float opacity;\nuniform float dashSize;\nuniform float totalSize;\nvarying float vLineDistance;\n#include <common>\n#include <color_pars_fragment>\n#include <fog_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tif ( mod( vLineDistance, totalSize ) > dashSize ) {\n\t\tdiscard;\n\t}\n\tvec3 outgoingLight = vec3( 0.0 );\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\t#include <logdepthbuf_fragment>\n\t#include <color_fragment>\n\toutgoingLight = diffuseColor.rgb;\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n}").AsJsString());
        
    public static JsString VertexA { get; } = "THREE.vertex$a".AsJsStringVariable(("#include <common>\n#include <uv_pars_vertex>\n#include <uv2_pars_vertex>\n#include <envmap_pars_vertex>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <uv2_vertex>\n\t#include <color_vertex>\n\t#if defined ( USE_ENVMAP ) || defined ( USE_SKINNING )\n\t\t#include <beginnormal_vertex>\n\t\t#include <morphnormal_vertex>\n\t\t#include <skinbase_vertex>\n\t\t#include <skinnormal_vertex>\n\t\t#include <defaultnormal_vertex>\n\t#endif\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\t#include <worldpos_vertex>\n\t#include <envmap_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString FragmentA { get; } = "THREE.fragment$a".AsJsStringVariable(("uniform vec3 diffuse;\nuniform float opacity;\n#ifndef FLAT_SHADED\n\tvarying vec3 vNormal;\n#endif\n#include <common>\n#include <dithering_pars_fragment>\n#include <color_pars_fragment>\n#include <uv_pars_fragment>\n#include <uv2_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <aomap_pars_fragment>\n#include <lightmap_pars_fragment>\n#include <envmap_common_pars_fragment>\n#include <envmap_pars_fragment>\n#include <cube_uv_reflection_fragment>\n#include <fog_pars_fragment>\n#include <specularmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <color_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <specularmap_fragment>\n\tReflectedLight reflectedLight = ReflectedLight( vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ) );\n\t#ifdef USE_LIGHTMAP\n\t\tvec4 lightMapTexel= texture2D( lightMap, vUv2 );\n\t\treflectedLight.indirectDiffuse += lightMapTexelToLinear( lightMapTexel ).rgb * lightMapIntensity;\n\t#else\n\t\treflectedLight.indirectDiffuse += vec3( 1.0 );\n\t#endif\n\t#include <aomap_fragment>\n\treflectedLight.indirectDiffuse *= diffuseColor.rgb;\n\tvec3 outgoingLight = reflectedLight.indirectDiffuse;\n\t#include <envmap_fragment>\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n\t#include <dithering_fragment>\n}").AsJsString());
        
    public static JsString Vertex9 { get; } = "THREE.vertex$9".AsJsStringVariable(("#define LAMBERT\nvarying vec3 vLightFront;\nvarying vec3 vIndirectFront;\n#ifdef DOUBLE_SIDED\n\tvarying vec3 vLightBack;\n\tvarying vec3 vIndirectBack;\n#endif\n#include <common>\n#include <uv_pars_vertex>\n#include <uv2_pars_vertex>\n#include <envmap_pars_vertex>\n#include <bsdfs>\n#include <lights_pars_begin>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <shadowmap_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <uv2_vertex>\n\t#include <color_vertex>\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\t#include <worldpos_vertex>\n\t#include <envmap_vertex>\n\t#include <lights_lambert_vertex>\n\t#include <shadowmap_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString Fragment9 { get; } = "THREE.fragment$9".AsJsStringVariable(("uniform vec3 diffuse;\nuniform vec3 emissive;\nuniform float opacity;\nvarying vec3 vLightFront;\nvarying vec3 vIndirectFront;\n#ifdef DOUBLE_SIDED\n\tvarying vec3 vLightBack;\n\tvarying vec3 vIndirectBack;\n#endif\n#include <common>\n#include <packing>\n#include <dithering_pars_fragment>\n#include <color_pars_fragment>\n#include <uv_pars_fragment>\n#include <uv2_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <aomap_pars_fragment>\n#include <lightmap_pars_fragment>\n#include <emissivemap_pars_fragment>\n#include <envmap_common_pars_fragment>\n#include <envmap_pars_fragment>\n#include <cube_uv_reflection_fragment>\n#include <bsdfs>\n#include <lights_pars_begin>\n#include <fog_pars_fragment>\n#include <shadowmap_pars_fragment>\n#include <shadowmask_pars_fragment>\n#include <specularmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\tReflectedLight reflectedLight = ReflectedLight( vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ) );\n\tvec3 totalEmissiveRadiance = emissive;\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <color_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <specularmap_fragment>\n\t#include <emissivemap_fragment>\n\t#ifdef DOUBLE_SIDED\n\t\treflectedLight.indirectDiffuse += ( gl_FrontFacing ) ? vIndirectFront : vIndirectBack;\n\t#else\n\t\treflectedLight.indirectDiffuse += vIndirectFront;\n\t#endif\n\t#include <lightmap_fragment>\n\treflectedLight.indirectDiffuse *= BRDF_Lambert( diffuseColor.rgb );\n\t#ifdef DOUBLE_SIDED\n\t\treflectedLight.directDiffuse = ( gl_FrontFacing ) ? vLightFront : vLightBack;\n\t#else\n\t\treflectedLight.directDiffuse = vLightFront;\n\t#endif\n\treflectedLight.directDiffuse *= BRDF_Lambert( diffuseColor.rgb ) * getShadowMask();\n\t#include <aomap_fragment>\n\tvec3 outgoingLight = reflectedLight.directDiffuse + reflectedLight.indirectDiffuse + totalEmissiveRadiance;\n\t#include <envmap_fragment>\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n\t#include <dithering_fragment>\n}").AsJsString());
        
    public static JsString Vertex8 { get; } = "THREE.vertex$8".AsJsStringVariable(("#define MATCAP\nvarying vec3 vViewPosition;\n#include <common>\n#include <uv_pars_vertex>\n#include <color_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <fog_pars_vertex>\n#include <normal_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <color_vertex>\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <normal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\t#include <fog_vertex>\n\tvViewPosition = - mvPosition.xyz;\n}").AsJsString());
        
    public static JsString Fragment8 { get; } = "THREE.fragment$8".AsJsStringVariable(("#define MATCAP\nuniform vec3 diffuse;\nuniform float opacity;\nuniform sampler2D matcap;\nvarying vec3 vViewPosition;\n#include <common>\n#include <dithering_pars_fragment>\n#include <color_pars_fragment>\n#include <uv_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <fog_pars_fragment>\n#include <normal_pars_fragment>\n#include <bumpmap_pars_fragment>\n#include <normalmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <color_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <normal_fragment_begin>\n\t#include <normal_fragment_maps>\n\tvec3 viewDir = normalize( vViewPosition );\n\tvec3 x = normalize( vec3( viewDir.z, 0.0, - viewDir.x ) );\n\tvec3 y = cross( viewDir, x );\n\tvec2 uv = vec2( dot( x, normal ), dot( y, normal ) ) * 0.495 + 0.5;\n\t#ifdef USE_MATCAP\n\t\tvec4 matcapColor = texture2D( matcap, uv );\n\t\tmatcapColor = matcapTexelToLinear( matcapColor );\n\t#else\n\t\tvec4 matcapColor = vec4( 1.0 );\n\t#endif\n\tvec3 outgoingLight = diffuseColor.rgb * matcapColor.rgb;\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n\t#include <dithering_fragment>\n}").AsJsString());
        
    public static JsString Vertex7 { get; } = "THREE.vertex$7".AsJsStringVariable(("#define NORMAL\n#if defined( FLAT_SHADED ) || defined( USE_BUMPMAP ) || defined( TANGENTSPACE_NORMALMAP )\n\tvarying vec3 vViewPosition;\n#endif\n#include <common>\n#include <uv_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <normal_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <normal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n#if defined( FLAT_SHADED ) || defined( USE_BUMPMAP ) || defined( TANGENTSPACE_NORMALMAP )\n\tvViewPosition = - mvPosition.xyz;\n#endif\n}").AsJsString());
        
    public static JsString Fragment7 { get; } = "THREE.fragment$7".AsJsStringVariable(("#define NORMAL\nuniform float opacity;\n#if defined( FLAT_SHADED ) || defined( USE_BUMPMAP ) || defined( TANGENTSPACE_NORMALMAP )\n\tvarying vec3 vViewPosition;\n#endif\n#include <packing>\n#include <uv_pars_fragment>\n#include <normal_pars_fragment>\n#include <bumpmap_pars_fragment>\n#include <normalmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\t#include <logdepthbuf_fragment>\n\t#include <normal_fragment_begin>\n\t#include <normal_fragment_maps>\n\tgl_FragColor = vec4( packNormalToRGB( normal ), opacity );\n}").AsJsString());
        
    public static JsString Vertex6 { get; } = "THREE.vertex$6".AsJsStringVariable(("#define PHONG\nvarying vec3 vViewPosition;\n#include <common>\n#include <uv_pars_vertex>\n#include <uv2_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <envmap_pars_vertex>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <normal_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <shadowmap_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <uv2_vertex>\n\t#include <color_vertex>\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <normal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\tvViewPosition = - mvPosition.xyz;\n\t#include <worldpos_vertex>\n\t#include <envmap_vertex>\n\t#include <shadowmap_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString Fragment6 { get; } = "THREE.fragment$6".AsJsStringVariable(("#define PHONG\nuniform vec3 diffuse;\nuniform vec3 emissive;\nuniform vec3 specular;\nuniform float shininess;\nuniform float opacity;\n#include <common>\n#include <packing>\n#include <dithering_pars_fragment>\n#include <color_pars_fragment>\n#include <uv_pars_fragment>\n#include <uv2_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <aomap_pars_fragment>\n#include <lightmap_pars_fragment>\n#include <emissivemap_pars_fragment>\n#include <envmap_common_pars_fragment>\n#include <envmap_pars_fragment>\n#include <cube_uv_reflection_fragment>\n#include <fog_pars_fragment>\n#include <bsdfs>\n#include <lights_pars_begin>\n#include <normal_pars_fragment>\n#include <lights_phong_pars_fragment>\n#include <shadowmap_pars_fragment>\n#include <bumpmap_pars_fragment>\n#include <normalmap_pars_fragment>\n#include <specularmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\tReflectedLight reflectedLight = ReflectedLight( vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ) );\n\tvec3 totalEmissiveRadiance = emissive;\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <color_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <specularmap_fragment>\n\t#include <normal_fragment_begin>\n\t#include <normal_fragment_maps>\n\t#include <emissivemap_fragment>\n\t#include <lights_phong_fragment>\n\t#include <lights_fragment_begin>\n\t#include <lights_fragment_maps>\n\t#include <lights_fragment_end>\n\t#include <aomap_fragment>\n\tvec3 outgoingLight = reflectedLight.directDiffuse + reflectedLight.indirectDiffuse + reflectedLight.directSpecular + reflectedLight.indirectSpecular + totalEmissiveRadiance;\n\t#include <envmap_fragment>\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n\t#include <dithering_fragment>\n}").AsJsString());
        
    public static JsString Vertex5 { get; } = "THREE.vertex$5".AsJsStringVariable(("#define STANDARD\nvarying vec3 vViewPosition;\n#ifdef USE_TRANSMISSION\n\tvarying vec3 vWorldPosition;\n#endif\n#include <common>\n#include <uv_pars_vertex>\n#include <uv2_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <normal_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <shadowmap_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <uv2_vertex>\n\t#include <color_vertex>\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <normal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\tvViewPosition = - mvPosition.xyz;\n\t#include <worldpos_vertex>\n\t#include <shadowmap_vertex>\n\t#include <fog_vertex>\n#ifdef USE_TRANSMISSION\n\tvWorldPosition = worldPosition.xyz;\n#endif\n}").AsJsString());
        
    public static JsString Fragment5 { get; } = "THREE.fragment$5".AsJsStringVariable(("#define STANDARD\n#ifdef PHYSICAL\n\t#define IOR\n\t#define SPECULAR\n#endif\nuniform vec3 diffuse;\nuniform vec3 emissive;\nuniform float roughness;\nuniform float metalness;\nuniform float opacity;\n#ifdef IOR\n\tuniform float ior;\n#endif\n#ifdef SPECULAR\n\tuniform float specularIntensity;\n\tuniform vec3 specularTint;\n\t#ifdef USE_SPECULARINTENSITYMAP\n\t\tuniform sampler2D specularIntensityMap;\n\t#endif\n\t#ifdef USE_SPECULARTINTMAP\n\t\tuniform sampler2D specularTintMap;\n\t#endif\n#endif\n#ifdef USE_CLEARCOAT\n\tuniform float clearcoat;\n\tuniform float clearcoatRoughness;\n#endif\n#ifdef USE_SHEEN\n\tuniform vec3 sheenTint;\n\tuniform float sheenRoughness;\n#endif\nvarying vec3 vViewPosition;\n#include <common>\n#include <packing>\n#include <dithering_pars_fragment>\n#include <color_pars_fragment>\n#include <uv_pars_fragment>\n#include <uv2_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <aomap_pars_fragment>\n#include <lightmap_pars_fragment>\n#include <emissivemap_pars_fragment>\n#include <bsdfs>\n#include <cube_uv_reflection_fragment>\n#include <envmap_common_pars_fragment>\n#include <envmap_physical_pars_fragment>\n#include <fog_pars_fragment>\n#include <lights_pars_begin>\n#include <normal_pars_fragment>\n#include <lights_physical_pars_fragment>\n#include <transmission_pars_fragment>\n#include <shadowmap_pars_fragment>\n#include <bumpmap_pars_fragment>\n#include <normalmap_pars_fragment>\n#include <clearcoat_pars_fragment>\n#include <roughnessmap_pars_fragment>\n#include <metalnessmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\tReflectedLight reflectedLight = ReflectedLight( vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ) );\n\tvec3 totalEmissiveRadiance = emissive;\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <color_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <roughnessmap_fragment>\n\t#include <metalnessmap_fragment>\n\t#include <normal_fragment_begin>\n\t#include <normal_fragment_maps>\n\t#include <clearcoat_normal_fragment_begin>\n\t#include <clearcoat_normal_fragment_maps>\n\t#include <emissivemap_fragment>\n\t#include <lights_physical_fragment>\n\t#include <lights_fragment_begin>\n\t#include <lights_fragment_maps>\n\t#include <lights_fragment_end>\n\t#include <aomap_fragment>\n\tvec3 totalDiffuse = reflectedLight.directDiffuse + reflectedLight.indirectDiffuse;\n\tvec3 totalSpecular = reflectedLight.directSpecular + reflectedLight.indirectSpecular;\n\t#include <transmission_fragment>\n\tvec3 outgoingLight = totalDiffuse + totalSpecular + totalEmissiveRadiance;\n\t#ifdef USE_CLEARCOAT\n\t\tfloat dotNVcc = saturate( dot( geometry.clearcoatNormal, geometry.viewDir ) );\n\t\tvec3 Fcc = F_Schlick( material.clearcoatF0, material.clearcoatF90, dotNVcc );\n\t\toutgoingLight = outgoingLight * ( 1.0 - clearcoat * Fcc ) + clearcoatSpecular * clearcoat;\n\t#endif\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n\t#include <dithering_fragment>\n}").AsJsString());
        
    public static JsString Vertex4 { get; } = "THREE.vertex$4".AsJsStringVariable(("#define TOON\nvarying vec3 vViewPosition;\n#include <common>\n#include <uv_pars_vertex>\n#include <uv2_pars_vertex>\n#include <displacementmap_pars_vertex>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <normal_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <shadowmap_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\t#include <uv2_vertex>\n\t#include <color_vertex>\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <normal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <displacementmap_vertex>\n\t#include <project_vertex>\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\tvViewPosition = - mvPosition.xyz;\n\t#include <worldpos_vertex>\n\t#include <shadowmap_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString Fragment4 { get; } = "THREE.fragment$4".AsJsStringVariable(("#define TOON\nuniform vec3 diffuse;\nuniform vec3 emissive;\nuniform float opacity;\n#include <common>\n#include <packing>\n#include <dithering_pars_fragment>\n#include <color_pars_fragment>\n#include <uv_pars_fragment>\n#include <uv2_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <aomap_pars_fragment>\n#include <lightmap_pars_fragment>\n#include <emissivemap_pars_fragment>\n#include <gradientmap_pars_fragment>\n#include <fog_pars_fragment>\n#include <bsdfs>\n#include <lights_pars_begin>\n#include <normal_pars_fragment>\n#include <lights_toon_pars_fragment>\n#include <shadowmap_pars_fragment>\n#include <bumpmap_pars_fragment>\n#include <normalmap_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\tReflectedLight reflectedLight = ReflectedLight( vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ), vec3( 0.0 ) );\n\tvec3 totalEmissiveRadiance = emissive;\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <color_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\t#include <normal_fragment_begin>\n\t#include <normal_fragment_maps>\n\t#include <emissivemap_fragment>\n\t#include <lights_toon_fragment>\n\t#include <lights_fragment_begin>\n\t#include <lights_fragment_maps>\n\t#include <lights_fragment_end>\n\t#include <aomap_fragment>\n\tvec3 outgoingLight = reflectedLight.directDiffuse + reflectedLight.indirectDiffuse + totalEmissiveRadiance;\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n\t#include <dithering_fragment>\n}").AsJsString());
        
    public static JsString Vertex3 { get; } = "THREE.vertex$3".AsJsStringVariable(("uniform float size;\nuniform float scale;\n#include <common>\n#include <color_pars_vertex>\n#include <fog_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <color_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <project_vertex>\n\tgl_PointSize = size;\n\t#ifdef USE_SIZEATTENUATION\n\t\tbool isPerspective = isPerspectiveMatrix( projectionMatrix );\n\t\tif ( isPerspective ) gl_PointSize *= ( scale / - mvPosition.z );\n\t#endif\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\t#include <worldpos_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString Fragment3 { get; } = "THREE.fragment$3".AsJsStringVariable(("uniform vec3 diffuse;\nuniform float opacity;\n#include <common>\n#include <color_pars_fragment>\n#include <map_particle_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <fog_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec3 outgoingLight = vec3( 0.0 );\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\t#include <logdepthbuf_fragment>\n\t#include <map_particle_fragment>\n\t#include <color_fragment>\n\t#include <alphatest_fragment>\n\toutgoingLight = diffuseColor.rgb;\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n\t#include <premultiplied_alpha_fragment>\n}").AsJsString());
        
    public static JsString Vertex2 { get; } = "THREE.vertex$2".AsJsStringVariable(("#include <common>\n#include <fog_pars_vertex>\n#include <morphtarget_pars_vertex>\n#include <skinning_pars_vertex>\n#include <shadowmap_pars_vertex>\nvoid main() {\n\t#include <beginnormal_vertex>\n\t#include <morphnormal_vertex>\n\t#include <skinbase_vertex>\n\t#include <skinnormal_vertex>\n\t#include <defaultnormal_vertex>\n\t#include <begin_vertex>\n\t#include <morphtarget_vertex>\n\t#include <skinning_vertex>\n\t#include <project_vertex>\n\t#include <worldpos_vertex>\n\t#include <shadowmap_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString Fragment2 { get; } = "THREE.fragment$2".AsJsStringVariable(("uniform vec3 color;\nuniform float opacity;\n#include <common>\n#include <packing>\n#include <fog_pars_fragment>\n#include <bsdfs>\n#include <lights_pars_begin>\n#include <shadowmap_pars_fragment>\n#include <shadowmask_pars_fragment>\nvoid main() {\n\tgl_FragColor = vec4( color, opacity * ( 1.0 - getShadowMask() ) );\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n}").AsJsString());
        
    public static JsString Vertex1 { get; } = "THREE.vertex$1".AsJsStringVariable(("uniform float rotation;\nuniform vec2 center;\n#include <common>\n#include <uv_pars_vertex>\n#include <fog_pars_vertex>\n#include <logdepthbuf_pars_vertex>\n#include <clipping_planes_pars_vertex>\nvoid main() {\n\t#include <uv_vertex>\n\tvec4 mvPosition = modelViewMatrix * vec4( 0.0, 0.0, 0.0, 1.0 );\n\tvec2 scale;\n\tscale.x = length( vec3( modelMatrix[ 0 ].x, modelMatrix[ 0 ].y, modelMatrix[ 0 ].z ) );\n\tscale.y = length( vec3( modelMatrix[ 1 ].x, modelMatrix[ 1 ].y, modelMatrix[ 1 ].z ) );\n\t#ifndef USE_SIZEATTENUATION\n\t\tbool isPerspective = isPerspectiveMatrix( projectionMatrix );\n\t\tif ( isPerspective ) scale *= - mvPosition.z;\n\t#endif\n\tvec2 alignedPosition = ( position.xy - ( center - vec2( 0.5 ) ) ) * scale;\n\tvec2 rotatedPosition;\n\trotatedPosition.x = cos( rotation ) * alignedPosition.x - sin( rotation ) * alignedPosition.y;\n\trotatedPosition.y = sin( rotation ) * alignedPosition.x + cos( rotation ) * alignedPosition.y;\n\tmvPosition.xy += rotatedPosition;\n\tgl_Position = projectionMatrix * mvPosition;\n\t#include <logdepthbuf_vertex>\n\t#include <clipping_planes_vertex>\n\t#include <fog_vertex>\n}").AsJsString());
        
    public static JsString Fragment1 { get; } = "THREE.fragment$1".AsJsStringVariable(("uniform vec3 diffuse;\nuniform float opacity;\n#include <common>\n#include <uv_pars_fragment>\n#include <map_pars_fragment>\n#include <alphamap_pars_fragment>\n#include <alphatest_pars_fragment>\n#include <fog_pars_fragment>\n#include <logdepthbuf_pars_fragment>\n#include <clipping_planes_pars_fragment>\nvoid main() {\n\t#include <clipping_planes_fragment>\n\tvec3 outgoingLight = vec3( 0.0 );\n\tvec4 diffuseColor = vec4( diffuse, opacity );\n\t#include <logdepthbuf_fragment>\n\t#include <map_fragment>\n\t#include <alphamap_fragment>\n\t#include <alphatest_fragment>\n\toutgoingLight = diffuseColor.rgb;\n\t#include <output_fragment>\n\t#include <tonemapping_fragment>\n\t#include <encodings_fragment>\n\t#include <fog_fragment>\n}").AsJsString());
        
    public static JsObject ShaderChunk { get; } = "THREE.ShaderChunk".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"alphamap_fragment", new JsObject()},
        {"alphamap_pars_fragment", new JsObject()},
        {"alphatest_fragment", new JsObject()},
        {"alphatest_pars_fragment", new JsObject()},
        {"aomap_fragment", new JsObject()},
        {"aomap_pars_fragment", new JsObject()},
        {"begin_vertex", new JsObject()},
        {"beginnormal_vertex", new JsObject()},
        {"bsdfs", new JsObject()},
        {"bumpmap_pars_fragment", new JsObject()},
        {"clipping_planes_fragment", new JsObject()},
        {"clipping_planes_pars_fragment", new JsObject()},
        {"clipping_planes_pars_vertex", new JsObject()},
        {"clipping_planes_vertex", new JsObject()},
        {"color_fragment", new JsObject()},
        {"color_pars_fragment", new JsObject()},
        {"color_pars_vertex", new JsObject()},
        {"color_vertex", new JsObject()},
        {"common", new JsObject()},
        {"cube_uv_reflection_fragment", new JsObject()},
        {"defaultnormal_vertex", new JsObject()},
        {"displacementmap_pars_vertex", new JsObject()},
        {"displacementmap_vertex", new JsObject()},
        {"emissivemap_fragment", new JsObject()},
        {"emissivemap_pars_fragment", new JsObject()},
        {"encodings_fragment", new JsObject()},
        {"encodings_pars_fragment", new JsObject()},
        {"envmap_fragment", new JsObject()},
        {"envmap_common_pars_fragment", new JsObject()},
        {"envmap_pars_fragment", new JsObject()},
        {"envmap_pars_vertex", new JsObject()},
        {"envmap_physical_pars_fragment", new JsObject()},
        {"envmap_vertex", new JsObject()},
        {"fog_vertex", new JsObject()},
        {"fog_pars_vertex", new JsObject()},
        {"fog_fragment", new JsObject()},
        {"fog_pars_fragment", new JsObject()},
        {"gradientmap_pars_fragment", new JsObject()},
        {"lightmap_fragment", new JsObject()},
        {"lightmap_pars_fragment", new JsObject()},
        {"lights_lambert_vertex", new JsObject()},
        {"lights_pars_begin", new JsObject()},
        {"lights_toon_fragment", new JsObject()},
        {"lights_toon_pars_fragment", new JsObject()},
        {"lights_phong_fragment", new JsObject()},
        {"lights_phong_pars_fragment", new JsObject()},
        {"lights_physical_fragment", new JsObject()},
        {"lights_physical_pars_fragment", new JsObject()},
        {"lights_fragment_begin", new JsObject()},
        {"lights_fragment_maps", new JsObject()},
        {"lights_fragment_end", new JsObject()},
        {"logdepthbuf_fragment", new JsObject()},
        {"logdepthbuf_pars_fragment", new JsObject()},
        {"logdepthbuf_pars_vertex", new JsObject()},
        {"logdepthbuf_vertex", new JsObject()},
        {"map_fragment", new JsObject()},
        {"map_pars_fragment", new JsObject()},
        {"map_particle_fragment", new JsObject()},
        {"map_particle_pars_fragment", new JsObject()},
        {"metalnessmap_fragment", new JsObject()},
        {"metalnessmap_pars_fragment", new JsObject()},
        {"morphnormal_vertex", new JsObject()},
        {"morphtarget_pars_vertex", new JsObject()},
        {"morphtarget_vertex", new JsObject()},
        {"normal_fragment_begin", new JsObject()},
        {"normal_fragment_maps", new JsObject()},
        {"normal_pars_fragment", new JsObject()},
        {"normal_pars_vertex", new JsObject()},
        {"normal_vertex", new JsObject()},
        {"normalmap_pars_fragment", new JsObject()},
        {"clearcoat_normal_fragment_begin", new JsObject()},
        {"clearcoat_normal_fragment_maps", new JsObject()},
        {"clearcoat_pars_fragment", new JsObject()},
        {"output_fragment", new JsObject()},
        {"packing", new JsObject()},
        {"premultiplied_alpha_fragment", new JsObject()},
        {"project_vertex", new JsObject()},
        {"dithering_fragment", new JsObject()},
        {"dithering_pars_fragment", new JsObject()},
        {"roughnessmap_fragment", new JsObject()},
        {"roughnessmap_pars_fragment", new JsObject()},
        {"shadowmap_pars_fragment", new JsObject()},
        {"shadowmap_pars_vertex", new JsObject()},
        {"shadowmap_vertex", new JsObject()},
        {"shadowmask_pars_fragment", new JsObject()},
        {"skinbase_vertex", new JsObject()},
        {"skinning_pars_vertex", new JsObject()},
        {"skinning_vertex", new JsObject()},
        {"skinnormal_vertex", new JsObject()},
        {"specularmap_fragment", new JsObject()},
        {"specularmap_pars_fragment", new JsObject()},
        {"tonemapping_fragment", new JsObject()},
        {"tonemapping_pars_fragment", new JsObject()},
        {"transmission_fragment", new JsObject()},
        {"transmission_pars_fragment", new JsObject()},
        {"uv_pars_fragment", new JsObject()},
        {"uv_pars_vertex", new JsObject()},
        {"uv_vertex", new JsObject()},
        {"uv2_pars_fragment", new JsObject()},
        {"uv2_pars_vertex", new JsObject()},
        {"uv2_vertex", new JsObject()},
        {"worldpos_vertex", new JsObject()},
        {"background_vert", VertexG},
        {"background_frag", FragmentG},
        {"cube_vert", VertexF},
        {"cube_frag", FragmentF},
        {"depth_vert", VertexE},
        {"depth_frag", FragmentE},
        {"distanceRGBA_vert", VertexD},
        {"distanceRGBA_frag", FragmentD},
        {"equirect_vert", VertexC},
        {"equirect_frag", FragmentC},
        {"linedashed_vert", VertexB},
        {"linedashed_frag", FragmentB},
        {"meshbasic_vert", VertexA},
        {"meshbasic_frag", FragmentA},
        {"meshlambert_vert", Vertex9},
        {"meshlambert_frag", Fragment9},
        {"meshmatcap_vert", Vertex8},
        {"meshmatcap_frag", Fragment8},
        {"meshnormal_vert", Vertex7},
        {"meshnormal_frag", Fragment7},
        {"meshphong_vert", Vertex6},
        {"meshphong_frag", Fragment6},
        {"meshphysical_vert", Vertex5},
        {"meshphysical_frag", Fragment5},
        {"meshtoon_vert", Vertex4},
        {"meshtoon_frag", Fragment4},
        {"points_vert", Vertex3},
        {"points_frag", Fragment3},
        {"shadow_vert", Vertex2},
        {"shadow_frag", Fragment2},
        {"sprite_vert", Vertex1},
        {"sprite_frag", Fragment1}
    }.AsJsObject());
        
    public static JsObject UniformsLib { get; } = "THREE.UniformsLib".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"common", new Dictionary<string, JsType>()
        {
            {"diffuse", new Dictionary<string, JsType>()
            {
                {"value", new JsColor((16777215).AsJsNumber())}
            }.AsJsObject()},
            {"opacity", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"map", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"uvTransform", new Dictionary<string, JsType>()
            {
                {"value", new JsMatrix3()}
            }.AsJsObject()},
            {"uv2Transform", new Dictionary<string, JsType>()
            {
                {"value", new JsMatrix3()}
            }.AsJsObject()},
            {"alphaMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"alphaTest", new Dictionary<string, JsType>()
            {
                {"value", (0).AsJsNumber()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"specularmap", new Dictionary<string, JsType>()
        {
            {"specularMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"envmap", new Dictionary<string, JsType>()
        {
            {"envMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"flipEnvMap", new Dictionary<string, JsType>()
            {
                {"value", (-1).AsJsNumber()}
            }.AsJsObject()},
            {"reflectivity", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"ior", new Dictionary<string, JsType>()
            {
                {"value", (1.5).AsJsNumber()}
            }.AsJsObject()},
            {"refractionRatio", new Dictionary<string, JsType>()
            {
                {"value", (0.98).AsJsNumber()}
            }.AsJsObject()},
            {"maxMipLevel", new Dictionary<string, JsType>()
            {
                {"value", (0).AsJsNumber()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"aomap", new Dictionary<string, JsType>()
        {
            {"aoMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"aoMapIntensity", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"lightmap", new Dictionary<string, JsType>()
        {
            {"lightMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"lightMapIntensity", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"emissivemap", new Dictionary<string, JsType>()
        {
            {"emissiveMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"bumpmap", new Dictionary<string, JsType>()
        {
            {"bumpMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"bumpScale", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"normalmap", new Dictionary<string, JsType>()
        {
            {"normalMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"normalScale", new Dictionary<string, JsType>()
            {
                {"value", new JsVector2((1).AsJsNumber(), (1).AsJsNumber())}
            }.AsJsObject()}
        }.AsJsObject()},
        {"displacementmap", new Dictionary<string, JsType>()
        {
            {"displacementMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"displacementScale", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"displacementBias", new Dictionary<string, JsType>()
            {
                {"value", (0).AsJsNumber()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"roughnessmap", new Dictionary<string, JsType>()
        {
            {"roughnessMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"metalnessmap", new Dictionary<string, JsType>()
        {
            {"metalnessMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"gradientmap", new Dictionary<string, JsType>()
        {
            {"gradientMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"fog", new Dictionary<string, JsType>()
        {
            {"fogDensity", new Dictionary<string, JsType>()
            {
                {"value", (0.00025).AsJsNumber()}
            }.AsJsObject()},
            {"fogNear", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"fogFar", new Dictionary<string, JsType>()
            {
                {"value", (2000).AsJsNumber()}
            }.AsJsObject()},
            {"fogColor", new Dictionary<string, JsType>()
            {
                {"value", new JsColor((16777215).AsJsNumber())}
            }.AsJsObject()}
        }.AsJsObject()},
        {"lights", new Dictionary<string, JsType>()
        {
            {"ambientLightColor", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"lightProbe", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"directionalLights", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"direction", new JsObject()},
                    {"color", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"directionalLightShadows", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"shadowBias", new JsObject()},
                    {"shadowNormalBias", new JsObject()},
                    {"shadowRadius", new JsObject()},
                    {"shadowMapSize", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"directionalShadowMap", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"directionalShadowMatrix", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"spotLights", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"color", new JsObject()},
                    {"position", new JsObject()},
                    {"direction", new JsObject()},
                    {"distance", new JsObject()},
                    {"coneCos", new JsObject()},
                    {"penumbraCos", new JsObject()},
                    {"decay", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"spotLightShadows", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"shadowBias", new JsObject()},
                    {"shadowNormalBias", new JsObject()},
                    {"shadowRadius", new JsObject()},
                    {"shadowMapSize", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"spotShadowMap", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"spotShadowMatrix", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"pointLights", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"color", new JsObject()},
                    {"position", new JsObject()},
                    {"decay", new JsObject()},
                    {"distance", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"pointLightShadows", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"shadowBias", new JsObject()},
                    {"shadowNormalBias", new JsObject()},
                    {"shadowRadius", new JsObject()},
                    {"shadowMapSize", new JsObject()},
                    {"shadowCameraNear", new JsObject()},
                    {"shadowCameraFar", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"pointShadowMap", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"pointShadowMatrix", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()}
            }.AsJsObject()},
            {"hemisphereLights", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"direction", new JsObject()},
                    {"skyColor", new JsObject()},
                    {"groundColor", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"rectAreaLights", new Dictionary<string, JsType>()
            {
                {"value", new JsArray()},
                {"properties", new Dictionary<string, JsType>()
                {
                    {"color", new JsObject()},
                    {"position", new JsObject()},
                    {"width", new JsObject()},
                    {"height", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"ltc_1", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"ltc_2", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"points", new Dictionary<string, JsType>()
        {
            {"diffuse", new Dictionary<string, JsType>()
            {
                {"value", new JsColor((16777215).AsJsNumber())}
            }.AsJsObject()},
            {"opacity", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"size", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"scale", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"map", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"alphaMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"alphaTest", new Dictionary<string, JsType>()
            {
                {"value", (0).AsJsNumber()}
            }.AsJsObject()},
            {"uvTransform", new Dictionary<string, JsType>()
            {
                {"value", new JsMatrix3()}
            }.AsJsObject()}
        }.AsJsObject()},
        {"sprite", new Dictionary<string, JsType>()
        {
            {"diffuse", new Dictionary<string, JsType>()
            {
                {"value", new JsColor((16777215).AsJsNumber())}
            }.AsJsObject()},
            {"opacity", new Dictionary<string, JsType>()
            {
                {"value", (1).AsJsNumber()}
            }.AsJsObject()},
            {"center", new Dictionary<string, JsType>()
            {
                {"value", new JsVector2((0.5).AsJsNumber(), (0.5).AsJsNumber())}
            }.AsJsObject()},
            {"rotation", new Dictionary<string, JsType>()
            {
                {"value", (0).AsJsNumber()}
            }.AsJsObject()},
            {"map", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"alphaMap", new Dictionary<string, JsType>()
            {
                {"value", new JsObject()}
            }.AsJsObject()},
            {"alphaTest", new Dictionary<string, JsType>()
            {
                {"value", (0).AsJsNumber()}
            }.AsJsObject()},
            {"uvTransform", new Dictionary<string, JsType>()
            {
                {"value", new JsMatrix3()}
            }.AsJsObject()}
        }.AsJsObject()}
    }.AsJsObject());
        
    public static JsObject ShaderLib { get; } = "THREE.ShaderLib".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"basic", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"lambert", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"phong", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"standard", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"toon", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"matcap", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"points", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"dashed", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"depth", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"normal", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"sprite", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"background", new Dictionary<string, JsType>()
        {
            {"uniforms", new Dictionary<string, JsType>()
            {
                {"uvTransform", new Dictionary<string, JsType>()
                {
                    {"value", new JsMatrix3()}
                }.AsJsObject()},
                {"t2D", new Dictionary<string, JsType>()
                {
                    {"value", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"cube", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"equirect", new Dictionary<string, JsType>()
        {
            {"uniforms", new Dictionary<string, JsType>()
            {
                {"tEquirect", new Dictionary<string, JsType>()
                {
                    {"value", new JsObject()}
                }.AsJsObject()}
            }.AsJsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"distanceRGBA", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()},
        {"shadow", new Dictionary<string, JsType>()
        {
            {"uniforms", new JsObject()},
            {"vertexShader", new JsObject()},
            {"fragmentShader", new JsObject()}
        }.AsJsObject()}
    }.AsJsObject());
        
    public static JsNumber LODMIN { get; } = "THREE.LOD_MIN".AsJsNumberVariable((4).AsJsNumber());
        
    public static JsNumber LODMAX { get; } = "THREE.LOD_MAX".AsJsNumberVariable((8).AsJsNumber());
        
    public static JsType SIZEMAX { get; } = "THREE.SIZE_MAX".AsJsTypeVariable(new JsObject());
        
    public static JsArray EXTRALODSIGMA { get; } = "THREE.EXTRA_LOD_SIGMA".AsJsArrayVariable(new JsArray((0.125).AsJsNumber(), (0.215).AsJsNumber(), (0.35).AsJsNumber(), (0.446).AsJsNumber(), (0.526).AsJsNumber(), (0.582).AsJsNumber()));
        
    public static JsType TOTALLODS { get; } = "THREE.TOTAL_LODS".AsJsTypeVariable(new JsObject());
        
    public static JsNumber MAXSAMPLES { get; } = "THREE.MAX_SAMPLES".AsJsNumberVariable((20).AsJsNumber());
        
    public static JsObject ENCODINGS { get; } = "THREE.ENCODINGS".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"LinearEncoding", (0).AsJsNumber()},
        {"sRGBEncoding", (1).AsJsNumber()},
        {"RGBEEncoding", (2).AsJsNumber()},
        {"RGBM7Encoding", (3).AsJsNumber()},
        {"RGBM16Encoding", (4).AsJsNumber()},
        {"RGBDEncoding", (5).AsJsNumber()},
        {"GammaEncoding", (6).AsJsNumber()}
    }.AsJsObject());
        
    public static JsType PHI { get; } = "THREE.PHI".AsJsTypeVariable(new JsObject());
        
    public static JsType INVPHI { get; } = "THREE.INV_PHI".AsJsTypeVariable(new JsObject());
        
    public static JsTexture EmptyTexture { get; } = "THREE.emptyTexture".AsJsTextureVariable(new JsTexture());
        
    public static JsDataTexture2DArray EmptyTexture2dArray { get; } = "THREE.emptyTexture2dArray".AsJsDataTexture2DArrayVariable(new JsDataTexture2DArray());
        
    public static JsDataTexture3D EmptyTexture3d { get; } = "THREE.emptyTexture3d".AsJsDataTexture3DVariable(new JsDataTexture3D());
        
    public static JsCubeTexture EmptyCubeTexture { get; } = "THREE.emptyCubeTexture".AsJsCubeTextureVariable(new JsCubeTexture());
        
    public static JsArray ArrayCacheF32 { get; } = "THREE.arrayCacheF32".AsJsArrayVariable(new JsArray());
        
    public static JsArray ArrayCacheI32 { get; } = "THREE.arrayCacheI32".AsJsArrayVariable(new JsArray());
        
    public static JsFloat32Array Mat4array { get; } = "THREE.mat4array".AsJsFloat32ArrayVariable(new JsFloat32Array((16).AsJsNumber()));
        
    public static JsFloat32Array Mat3array { get; } = "THREE.mat3array".AsJsFloat32ArrayVariable(new JsFloat32Array((9).AsJsNumber()));
        
    public static JsFloat32Array Mat2array { get; } = "THREE.mat2array".AsJsFloat32ArrayVariable(new JsFloat32Array((4).AsJsNumber()));
        
    public static JsObject RePathPart { get; } = "THREE.RePathPart".AsJsObjectVariable(new JsObject());
        
    public static JsObject IncludePattern { get; } = "THREE.includePattern".AsJsObjectVariable(new JsObject());
        
    public static JsObject DeprecatedUnrollLoopPattern { get; } = "THREE.deprecatedUnrollLoopPattern".AsJsObjectVariable(new JsObject());
        
    public static JsObject UnrollLoopPattern { get; } = "THREE.unrollLoopPattern".AsJsObjectVariable(new JsObject());
        
    public static JsString Vertex { get; } = "THREE.vertex".AsJsStringVariable(("void main() {\n\tgl_Position = vec4( position, 1.0 );\n}").AsJsString());
        
    public static JsString Fragment { get; } = "THREE.fragment".AsJsStringVariable(("uniform sampler2D shadow_pass;\nuniform vec2 resolution;\nuniform float radius;\nuniform float samples;\n#include <packing>\nvoid main() {\n\tfloat mean = 0.0;\n\tfloat squared_mean = 0.0;\n\tfloat uvStride = samples <= 1.0 ? 0.0 : 2.0 / ( samples - 1.0 );\n\tfloat uvStart = samples <= 1.0 ? 0.0 : - 1.0;\n\tfor ( float i = 0.0; i < samples; i ++ ) {\n\t\tfloat uvOffset = uvStart + i * uvStride;\n\t\t#ifdef HORIZONTAL_PASS\n\t\t\tvec2 distribution = unpackRGBATo2Half( texture2D( shadow_pass, ( gl_FragCoord.xy + vec2( uvOffset, 0.0 ) * radius ) / resolution ) );\n\t\t\tmean += distribution.x;\n\t\t\tsquared_mean += distribution.y * distribution.y + distribution.x * distribution.x;\n\t\t#else\n\t\t\tfloat depth = unpackRGBAToDepth( texture2D( shadow_pass, ( gl_FragCoord.xy + vec2( 0.0, uvOffset ) * radius ) / resolution ) );\n\t\t\tmean += depth;\n\t\t\tsquared_mean += depth * depth;\n\t\t#endif\n\t}\n\tmean = mean / samples;\n\tsquared_mean = squared_mean / samples;\n\tfloat std_dev = sqrt( squared_mean - mean * mean );\n\tgl_FragColor = pack2HalfToRGBA( vec2( mean, std_dev ) );\n}").AsJsString());
        
    public static JsVector3 Tmp { get; } = "THREE.tmp".AsJsVector3Variable(new JsVector3());
        
    public static JsCubicPoly Px { get; } = "THREE.px".AsJsCubicPolyVariable(new JsCubicPoly());
        
    public static JsCubicPoly Py { get; } = "THREE.py".AsJsCubicPolyVariable(new JsCubicPoly());
        
    public static JsCubicPoly Pz { get; } = "THREE.pz".AsJsCubicPolyVariable(new JsCubicPoly());
        
    public static JsObject Earcut { get; } = "THREE.Earcut".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"triangulate", new JsObject()}
    }.AsJsObject());
        
    public static JsObject WorldUVGenerator { get; } = "THREE.WorldUVGenerator".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"generateTopUV", new JsObject()},
        {"generateSideWallUV", new JsObject()}
    }.AsJsObject());
        
    public static JsObject AnimationUtils { get; } = "THREE.AnimationUtils".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"arraySlice", new JsObject()},
        {"convertArray", new JsObject()},
        {"isTypedArray", new JsObject()},
        {"getKeyframeOrder", new JsObject()},
        {"sortedArray", new JsObject()},
        {"flattenJSON", new JsObject()},
        {"subclip", new JsObject()},
        {"makeClipAdditive", new JsObject()}
    }.AsJsObject());
        
    public static JsObject Cache { get; } = "THREE.Cache".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"enabled", (false).AsJsBoolean()},
        {"files", new JsObject()},
        {"add", new JsObject()},
        {"get", new JsObject()},
        {"remove", new JsObject()},
        {"clear", new JsObject()}
    }.AsJsObject());
        
    public static JsLoadingManager DefaultLoadingManager { get; } = "THREE.DefaultLoadingManager".AsJsLoadingManagerVariable(new JsLoadingManager());
        
    public static JsObject Loading { get; } = "THREE.loading".AsJsObjectVariable(new JsObject());
        
    public static JsObject TEXTUREMAPPING { get; } = "THREE.TEXTURE_MAPPING".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"UVMapping", UVMapping},
        {"CubeReflectionMapping", CubeReflectionMapping},
        {"CubeRefractionMapping", CubeRefractionMapping},
        {"EquirectangularReflectionMapping", EquirectangularReflectionMapping},
        {"EquirectangularRefractionMapping", EquirectangularRefractionMapping},
        {"CubeUVReflectionMapping", CubeUVReflectionMapping},
        {"CubeUVRefractionMapping", CubeUVRefractionMapping}
    }.AsJsObject());
        
    public static JsObject TEXTUREWRAPPING { get; } = "THREE.TEXTURE_WRAPPING".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"RepeatWrapping", RepeatWrapping},
        {"ClampToEdgeWrapping", ClampToEdgeWrapping},
        {"MirroredRepeatWrapping", MirroredRepeatWrapping}
    }.AsJsObject());
        
    public static JsObject TEXTUREFILTER { get; } = "THREE.TEXTURE_FILTER".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"NearestFilter", NearestFilter},
        {"NearestMipmapNearestFilter", NearestMipmapNearestFilter},
        {"NearestMipmapLinearFilter", NearestMipmapLinearFilter},
        {"LinearFilter", LinearFilter},
        {"LinearMipmapNearestFilter", LinearMipmapNearestFilter},
        {"LinearMipmapLinearFilter", LinearMipmapLinearFilter}
    }.AsJsObject());
        
    public static JsObject AudioContext { get; } = "THREE.AudioContext".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"getContext", new JsObject()},
        {"setContext", new JsObject()}
    }.AsJsObject());
        
    public static JsNumber LineStrip { get; } = "THREE.LineStrip".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber LinePieces { get; } = "THREE.LinePieces".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber NoColors { get; } = "THREE.NoColors".AsJsNumberVariable((0).AsJsNumber());
        
    public static JsNumber FaceColors { get; } = "THREE.FaceColors".AsJsNumberVariable((1).AsJsNumber());
        
    public static JsNumber VertexColors { get; } = "THREE.VertexColors".AsJsNumberVariable((2).AsJsNumber());
        
    public static JsObject SceneUtils { get; } = "THREE.SceneUtils".AsJsObjectVariable(new Dictionary<string, JsType>()
    {
        {"createMultiMaterialObject", new JsObject()},
        {"detach", new JsObject()},
        {"attach", new JsObject()}
    }.AsJsObject());
        
        
}