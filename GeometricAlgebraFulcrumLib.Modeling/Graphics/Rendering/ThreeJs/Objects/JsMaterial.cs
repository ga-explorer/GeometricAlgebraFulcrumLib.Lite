using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMaterialConstructor :
    JsTypeConstructor
{
        


    internal JsMaterialConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Material()";
    }
}
    
public partial class JsMaterial :
    JsEventDispatcher
{
    public static implicit operator JsMaterial(string jsTextCode)
    {
        return new JsMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMaterial _jsVariableValue;
    public JsMaterial JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _uuid;
    public JsType Uuid
    {
        get => _uuid ?? throw new InvalidOperationException();
        set
        {
            if (_uuid is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uuid = {valueCode};");
        }
    }
        
    private readonly JsString _name;
    public JsString Name
    {
        get => _name ?? throw new InvalidOperationException();
        set
        {
            if (_name is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.name = {valueCode};");
        }
    }
        
    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"Material\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsBoolean _fog;
    public JsBoolean Fog
    {
        get => _fog ?? throw new InvalidOperationException();
        set
        {
            if (_fog is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.fog = {valueCode};");
        }
    }
        
    private readonly JsNumber _blending;
    public JsNumber Blending
    {
        get => _blending ?? throw new InvalidOperationException();
        set
        {
            if (_blending is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blending = {valueCode};");
        }
    }
        
    private readonly JsNumber _side;
    public JsNumber Side
    {
        get => _side ?? throw new InvalidOperationException();
        set
        {
            if (_side is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.side = {valueCode};");
        }
    }
        
    private readonly JsBoolean _vertexColors;
    public JsBoolean VertexColors
    {
        get => _vertexColors ?? throw new InvalidOperationException();
        set
        {
            if (_vertexColors is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.vertexColors = {valueCode};");
        }
    }
        
    private readonly JsNumber _opacity;
    public JsNumber Opacity
    {
        get => _opacity ?? throw new InvalidOperationException();
        set
        {
            if (_opacity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.opacity = {valueCode};");
        }
    }
        
    private readonly JsNumber _format;
    public JsNumber Format
    {
        get => _format ?? throw new InvalidOperationException();
        set
        {
            if (_format is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1023";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.format = {valueCode};");
        }
    }
        
    private readonly JsBoolean _transparent;
    public JsBoolean Transparent
    {
        get => _transparent ?? throw new InvalidOperationException();
        set
        {
            if (_transparent is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.transparent = {valueCode};");
        }
    }
        
    private readonly JsNumber _blendSrc;
    public JsNumber BlendSrc
    {
        get => _blendSrc ?? throw new InvalidOperationException();
        set
        {
            if (_blendSrc is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "204";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendSrc = {valueCode};");
        }
    }
        
    private readonly JsNumber _blendDst;
    public JsNumber BlendDst
    {
        get => _blendDst ?? throw new InvalidOperationException();
        set
        {
            if (_blendDst is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "205";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendDst = {valueCode};");
        }
    }
        
    private readonly JsNumber _blendEquation;
    public JsNumber BlendEquation
    {
        get => _blendEquation ?? throw new InvalidOperationException();
        set
        {
            if (_blendEquation is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "100";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendEquation = {valueCode};");
        }
    }
        
    private readonly JsType _blendSrcAlpha;
    public JsType BlendSrcAlpha
    {
        get => _blendSrcAlpha ?? throw new InvalidOperationException();
        set
        {
            if (_blendSrcAlpha is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendSrcAlpha = {valueCode};");
        }
    }
        
    private readonly JsType _blendDstAlpha;
    public JsType BlendDstAlpha
    {
        get => _blendDstAlpha ?? throw new InvalidOperationException();
        set
        {
            if (_blendDstAlpha is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendDstAlpha = {valueCode};");
        }
    }
        
    private readonly JsType _blendEquationAlpha;
    public JsType BlendEquationAlpha
    {
        get => _blendEquationAlpha ?? throw new InvalidOperationException();
        set
        {
            if (_blendEquationAlpha is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendEquationAlpha = {valueCode};");
        }
    }
        
    private readonly JsNumber _depthFunc;
    public JsNumber DepthFunc
    {
        get => _depthFunc ?? throw new InvalidOperationException();
        set
        {
            if (_depthFunc is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "3";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depthFunc = {valueCode};");
        }
    }
        
    private readonly JsBoolean _depthTest;
    public JsBoolean DepthTest
    {
        get => _depthTest ?? throw new InvalidOperationException();
        set
        {
            if (_depthTest is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depthTest = {valueCode};");
        }
    }
        
    private readonly JsBoolean _depthWrite;
    public JsBoolean DepthWrite
    {
        get => _depthWrite ?? throw new InvalidOperationException();
        set
        {
            if (_depthWrite is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depthWrite = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilWriteMask;
    public JsNumber StencilWriteMask
    {
        get => _stencilWriteMask ?? throw new InvalidOperationException();
        set
        {
            if (_stencilWriteMask is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "255";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilWriteMask = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilFunc;
    public JsNumber StencilFunc
    {
        get => _stencilFunc ?? throw new InvalidOperationException();
        set
        {
            if (_stencilFunc is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "519";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilFunc = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilRef;
    public JsNumber StencilRef
    {
        get => _stencilRef ?? throw new InvalidOperationException();
        set
        {
            if (_stencilRef is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilRef = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilFuncMask;
    public JsNumber StencilFuncMask
    {
        get => _stencilFuncMask ?? throw new InvalidOperationException();
        set
        {
            if (_stencilFuncMask is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "255";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilFuncMask = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilFail;
    public JsNumber StencilFail
    {
        get => _stencilFail ?? throw new InvalidOperationException();
        set
        {
            if (_stencilFail is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "7680";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilFail = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilZFail;
    public JsNumber StencilZFail
    {
        get => _stencilZFail ?? throw new InvalidOperationException();
        set
        {
            if (_stencilZFail is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "7680";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilZFail = {valueCode};");
        }
    }
        
    private readonly JsNumber _stencilZPass;
    public JsNumber StencilZPass
    {
        get => _stencilZPass ?? throw new InvalidOperationException();
        set
        {
            if (_stencilZPass is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "7680";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilZPass = {valueCode};");
        }
    }
        
    private readonly JsBoolean _stencilWrite;
    public JsBoolean StencilWrite
    {
        get => _stencilWrite ?? throw new InvalidOperationException();
        set
        {
            if (_stencilWrite is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilWrite = {valueCode};");
        }
    }
        
    private readonly JsObject _clippingPlanes;
    public JsObject ClippingPlanes
    {
        get => _clippingPlanes ?? throw new InvalidOperationException();
        set
        {
            if (_clippingPlanes is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clippingPlanes = {valueCode};");
        }
    }
        
    private readonly JsBoolean _clipIntersection;
    public JsBoolean ClipIntersection
    {
        get => _clipIntersection ?? throw new InvalidOperationException();
        set
        {
            if (_clipIntersection is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clipIntersection = {valueCode};");
        }
    }
        
    private readonly JsBoolean _clipShadows;
    public JsBoolean ClipShadows
    {
        get => _clipShadows ?? throw new InvalidOperationException();
        set
        {
            if (_clipShadows is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clipShadows = {valueCode};");
        }
    }
        
    private readonly JsType _shadowSide;
    public JsType ShadowSide
    {
        get => _shadowSide ?? throw new InvalidOperationException();
        set
        {
            if (_shadowSide is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.shadowSide = {valueCode};");
        }
    }
        
    private readonly JsBoolean _colorWrite;
    public JsBoolean ColorWrite
    {
        get => _colorWrite ?? throw new InvalidOperationException();
        set
        {
            if (_colorWrite is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.colorWrite = {valueCode};");
        }
    }
        
    private readonly JsType _precision;
    public JsType Precision
    {
        get => _precision ?? throw new InvalidOperationException();
        set
        {
            if (_precision is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.precision = {valueCode};");
        }
    }
        
    private readonly JsBoolean _polygonOffset;
    public JsBoolean PolygonOffset
    {
        get => _polygonOffset ?? throw new InvalidOperationException();
        set
        {
            if (_polygonOffset is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.polygonOffset = {valueCode};");
        }
    }
        
    private readonly JsNumber _polygonOffsetFactor;
    public JsNumber PolygonOffsetFactor
    {
        get => _polygonOffsetFactor ?? throw new InvalidOperationException();
        set
        {
            if (_polygonOffsetFactor is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.polygonOffsetFactor = {valueCode};");
        }
    }
        
    private readonly JsNumber _polygonOffsetUnits;
    public JsNumber PolygonOffsetUnits
    {
        get => _polygonOffsetUnits ?? throw new InvalidOperationException();
        set
        {
            if (_polygonOffsetUnits is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.polygonOffsetUnits = {valueCode};");
        }
    }
        
    private readonly JsBoolean _dithering;
    public JsBoolean Dithering
    {
        get => _dithering ?? throw new InvalidOperationException();
        set
        {
            if (_dithering is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.dithering = {valueCode};");
        }
    }
        
    private readonly JsBoolean _alphaToCoverage;
    public JsBoolean AlphaToCoverage
    {
        get => _alphaToCoverage ?? throw new InvalidOperationException();
        set
        {
            if (_alphaToCoverage is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.alphaToCoverage = {valueCode};");
        }
    }
        
    private readonly JsBoolean _premultipliedAlpha;
    public JsBoolean PremultipliedAlpha
    {
        get => _premultipliedAlpha ?? throw new InvalidOperationException();
        set
        {
            if (_premultipliedAlpha is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.premultipliedAlpha = {valueCode};");
        }
    }
        
    private readonly JsBoolean _visible;
    public JsBoolean Visible
    {
        get => _visible ?? throw new InvalidOperationException();
        set
        {
            if (_visible is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.visible = {valueCode};");
        }
    }
        
    private readonly JsBoolean _toneMapped;
    public JsBoolean ToneMapped
    {
        get => _toneMapped ?? throw new InvalidOperationException();
        set
        {
            if (_toneMapped is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.toneMapped = {valueCode};");
        }
    }
        
    private readonly JsType _userData;
    public JsType UserData
    {
        get => _userData ?? throw new InvalidOperationException();
        set
        {
            if (_userData is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.userData = {valueCode};");
        }
    }
        
    private readonly JsNumber _version;
    public JsNumber Version
    {
        get => _version ?? throw new InvalidOperationException();
        set
        {
            if (_version is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.version = {valueCode};");
        }
    }
        
    private readonly JsType _alphaTest;
    public JsType AlphaTest
    {
        get => _alphaTest ?? throw new InvalidOperationException();
        set
        {
            if (_alphaTest is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.alphaTest = {valueCode};");
        }
    }
        
    private readonly JsType _flatShading;
    public JsType FlatShading
    {
        get => _flatShading ?? throw new InvalidOperationException();
        set
        {
            if (_flatShading is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.flatShading = {valueCode};");
        }
    }

    internal JsMaterial(JsTypeConstructor jsCodeSource, JsMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _name = $"{variableName}.name".AsJsStringVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _fog = $"{variableName}.fog".AsJsBooleanVariable();
        _blending = $"{variableName}.blending".AsJsNumberVariable();
        _side = $"{variableName}.side".AsJsNumberVariable();
        _vertexColors = $"{variableName}.vertexColors".AsJsBooleanVariable();
        _opacity = $"{variableName}.opacity".AsJsNumberVariable();
        _format = $"{variableName}.format".AsJsNumberVariable();
        _transparent = $"{variableName}.transparent".AsJsBooleanVariable();
        _blendSrc = $"{variableName}.blendSrc".AsJsNumberVariable();
        _blendDst = $"{variableName}.blendDst".AsJsNumberVariable();
        _blendEquation = $"{variableName}.blendEquation".AsJsNumberVariable();
        _blendSrcAlpha = $"{variableName}.blendSrcAlpha".AsJsTypeVariable();
        _blendDstAlpha = $"{variableName}.blendDstAlpha".AsJsTypeVariable();
        _blendEquationAlpha = $"{variableName}.blendEquationAlpha".AsJsTypeVariable();
        _depthFunc = $"{variableName}.depthFunc".AsJsNumberVariable();
        _depthTest = $"{variableName}.depthTest".AsJsBooleanVariable();
        _depthWrite = $"{variableName}.depthWrite".AsJsBooleanVariable();
        _stencilWriteMask = $"{variableName}.stencilWriteMask".AsJsNumberVariable();
        _stencilFunc = $"{variableName}.stencilFunc".AsJsNumberVariable();
        _stencilRef = $"{variableName}.stencilRef".AsJsNumberVariable();
        _stencilFuncMask = $"{variableName}.stencilFuncMask".AsJsNumberVariable();
        _stencilFail = $"{variableName}.stencilFail".AsJsNumberVariable();
        _stencilZFail = $"{variableName}.stencilZFail".AsJsNumberVariable();
        _stencilZPass = $"{variableName}.stencilZPass".AsJsNumberVariable();
        _stencilWrite = $"{variableName}.stencilWrite".AsJsBooleanVariable();
        _clippingPlanes = $"{variableName}.clippingPlanes".AsJsObjectVariable();
        _clipIntersection = $"{variableName}.clipIntersection".AsJsBooleanVariable();
        _clipShadows = $"{variableName}.clipShadows".AsJsBooleanVariable();
        _shadowSide = $"{variableName}.shadowSide".AsJsTypeVariable();
        _colorWrite = $"{variableName}.colorWrite".AsJsBooleanVariable();
        _precision = $"{variableName}.precision".AsJsTypeVariable();
        _polygonOffset = $"{variableName}.polygonOffset".AsJsBooleanVariable();
        _polygonOffsetFactor = $"{variableName}.polygonOffsetFactor".AsJsNumberVariable();
        _polygonOffsetUnits = $"{variableName}.polygonOffsetUnits".AsJsNumberVariable();
        _dithering = $"{variableName}.dithering".AsJsBooleanVariable();
        _alphaToCoverage = $"{variableName}.alphaToCoverage".AsJsBooleanVariable();
        _premultipliedAlpha = $"{variableName}.premultipliedAlpha".AsJsBooleanVariable();
        _visible = $"{variableName}.visible".AsJsBooleanVariable();
        _toneMapped = $"{variableName}.toneMapped".AsJsBooleanVariable();
        _userData = $"{variableName}.userData".AsJsTypeVariable();
        _version = $"{variableName}.version".AsJsNumberVariable();
        _alphaTest = $"{variableName}.alphaTest".AsJsTypeVariable();
        _flatShading = $"{variableName}.flatShading".AsJsTypeVariable();
    }

    public JsMaterial()
        : base(new JsMaterialConstructor())
    {
    }

    public JsType OnBuild()
    {
        return CallMethod("onBuild");
    }
        
    public JsType OnBeforeRender()
    {
        return CallMethod("onBeforeRender");
    }
        
    public JsType OnBeforeCompile()
    {
        return CallMethod("onBeforeCompile");
    }
        
    public JsType CustomProgramCacheKey()
    {
        return CallMethod("customProgramCacheKey");
    }
        
    public JsType SetValues(JsType argValues = null)
    {
        return CallMethod("setValues", argValues ?? new JsObject());
    }
        
    public JsObject ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
        
}