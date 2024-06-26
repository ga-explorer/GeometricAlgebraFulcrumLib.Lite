using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSpotLightHelperConstructor :
    JsTypeConstructor
{
    public JsType Light { get; }
        
    public JsType Color { get; }
        
        


    internal JsSpotLightHelperConstructor(JsType argLight, JsType argColor)
    {
        Light = argLight ?? new JsObject();
        Color = argColor ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SpotLightHelper({Light.GetJsCode()}, {Color.GetJsCode()})";
    }
}
    
public partial class JsSpotLightHelper :
    JsObject3D
{
    public static implicit operator JsSpotLightHelper(string jsTextCode)
    {
        return new JsSpotLightHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSpotLightHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsSpotLightHelper _jsVariableValue;
    public JsSpotLightHelper JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _light;
    public JsType Light
    {
        get => _light ?? throw new InvalidOperationException();
        set
        {
            if (_light is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.light = {valueCode};");
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
        
    private readonly JsBoolean _matrixAutoUpdate;
    public JsBoolean MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }
        
    private readonly JsType _color;
    public JsType Color
    {
        get => _color ?? throw new InvalidOperationException();
        set
        {
            if (_color is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.color = {valueCode};");
        }
    }
        
    private readonly JsType _cone;
    public JsType Cone
    {
        get => _cone ?? throw new InvalidOperationException();
        set
        {
            if (_cone is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cone = {valueCode};");
        }
    }

    internal JsSpotLightHelper(JsTypeConstructor jsCodeSource, JsSpotLightHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _light = $"{variableName}.light".AsJsTypeVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsBooleanVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _cone = $"{variableName}.cone".AsJsTypeVariable();
    }

    public JsSpotLightHelper(JsType argLight = null, JsType argColor = null)
        : base(new JsSpotLightHelperConstructor(argLight, argColor))
    {
    }

    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsType Update()
    {
        return CallMethod("update");
    }
        
        
}