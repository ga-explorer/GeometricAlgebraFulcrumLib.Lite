using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLightShadowConstructor :
    JsTypeConstructor
{
    public JsType Camera { get; }
        
        


    internal JsLightShadowConstructor(JsType argCamera)
    {
        Camera = argCamera ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LightShadow({Camera.GetJsCode()})";
    }
}
    
public partial class JsLightShadow :
    JsObjectType
{
    public static implicit operator JsLightShadow(string jsTextCode)
    {
        return new JsLightShadow(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLightShadow value)
    {
        return value.GetJsCode();
    }


    private readonly JsLightShadow _jsVariableValue;
    public JsLightShadow JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _camera;
    public JsType Camera
    {
        get => _camera ?? throw new InvalidOperationException();
        set
        {
            if (_camera is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.camera = {valueCode};");
        }
    }
        
    private readonly JsNumber _bias;
    public JsNumber Bias
    {
        get => _bias ?? throw new InvalidOperationException();
        set
        {
            if (_bias is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bias = {valueCode};");
        }
    }
        
    private readonly JsNumber _normalBias;
    public JsNumber NormalBias
    {
        get => _normalBias ?? throw new InvalidOperationException();
        set
        {
            if (_normalBias is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normalBias = {valueCode};");
        }
    }
        
    private readonly JsNumber _radius;
    public JsNumber Radius
    {
        get => _radius ?? throw new InvalidOperationException();
        set
        {
            if (_radius is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.radius = {valueCode};");
        }
    }
        
    private readonly JsNumber _blurSamples;
    public JsNumber BlurSamples
    {
        get => _blurSamples ?? throw new InvalidOperationException();
        set
        {
            if (_blurSamples is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "8";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blurSamples = {valueCode};");
        }
    }
        
    private readonly JsType _mapSize;
    public JsType MapSize
    {
        get => _mapSize ?? throw new InvalidOperationException();
        set
        {
            if (_mapSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.mapSize = {valueCode};");
        }
    }
        
    private readonly JsObject _map;
    public JsObject Map
    {
        get => _map ?? throw new InvalidOperationException();
        set
        {
            if (_map is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.map = {valueCode};");
        }
    }
        
    private readonly JsObject _mapPass;
    public JsObject MapPass
    {
        get => _mapPass ?? throw new InvalidOperationException();
        set
        {
            if (_mapPass is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.mapPass = {valueCode};");
        }
    }
        
    private readonly JsType _matrix;
    public JsType Matrix
    {
        get => _matrix ?? throw new InvalidOperationException();
        set
        {
            if (_matrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrix = {valueCode};");
        }
    }
        
    private readonly JsBoolean _autoUpdate;
    public JsBoolean AutoUpdate
    {
        get => _autoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_autoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.autoUpdate = {valueCode};");
        }
    }
        
    private readonly JsBoolean _needsUpdate;
    public JsBoolean NeedsUpdate
    {
        get => _needsUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_needsUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.needsUpdate = {valueCode};");
        }
    }

    internal JsLightShadow(JsTypeConstructor jsCodeSource, JsLightShadow jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _camera = $"{variableName}.camera".AsJsTypeVariable();
        _bias = $"{variableName}.bias".AsJsNumberVariable();
        _normalBias = $"{variableName}.normalBias".AsJsNumberVariable();
        _radius = $"{variableName}.radius".AsJsNumberVariable();
        _blurSamples = $"{variableName}.blurSamples".AsJsNumberVariable();
        _mapSize = $"{variableName}.mapSize".AsJsTypeVariable();
        _map = $"{variableName}.map".AsJsObjectVariable();
        _mapPass = $"{variableName}.mapPass".AsJsObjectVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _autoUpdate = $"{variableName}.autoUpdate".AsJsBooleanVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
    }

    public JsLightShadow(JsType argCamera = null)
        : base(new JsLightShadowConstructor(argCamera))
    {
    }

    public JsType GetViewportCount()
    {
        return CallMethod("getViewportCount");
    }
        
    public JsType GetFrustum()
    {
        return CallMethod("getFrustum");
    }
        
    public JsType UpdateMatrices(JsType argLight = null)
    {
        return CallMethod("updateMatrices", argLight ?? new JsObject());
    }
        
    public JsType GetViewport(JsType argViewportIndex = null)
    {
        return CallMethod("getViewport", argViewportIndex ?? new JsObject());
    }
        
    public JsType GetFrameExtents()
    {
        return CallMethod("getFrameExtents");
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsLightShadow Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsObject ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}