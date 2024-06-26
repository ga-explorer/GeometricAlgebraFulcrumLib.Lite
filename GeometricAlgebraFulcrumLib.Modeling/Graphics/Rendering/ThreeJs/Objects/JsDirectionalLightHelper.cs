using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDirectionalLightHelperConstructor :
    JsTypeConstructor
{
    public JsType Light { get; }
        
    public JsType Size { get; }
        
    public JsType Color { get; }
        
        


    internal JsDirectionalLightHelperConstructor(JsType argLight, JsType argSize, JsType argColor)
    {
        Light = argLight ?? new JsObject();
        Size = argSize ?? new JsObject();
        Color = argColor ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DirectionalLightHelper({Light.GetJsCode()}, {Size.GetJsCode()}, {Color.GetJsCode()})";
    }
}
    
public partial class JsDirectionalLightHelper :
    JsObject3D
{
    public static implicit operator JsDirectionalLightHelper(string jsTextCode)
    {
        return new JsDirectionalLightHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDirectionalLightHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsDirectionalLightHelper _jsVariableValue;
    public JsDirectionalLightHelper JsValue 
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
        
    private readonly JsType _lightPlane;
    public JsType LightPlane
    {
        get => _lightPlane ?? throw new InvalidOperationException();
        set
        {
            if (_lightPlane is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.lightPlane = {valueCode};");
        }
    }
        
    private readonly JsType _targetLine;
    public JsType TargetLine
    {
        get => _targetLine ?? throw new InvalidOperationException();
        set
        {
            if (_targetLine is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.targetLine = {valueCode};");
        }
    }

    internal JsDirectionalLightHelper(JsTypeConstructor jsCodeSource, JsDirectionalLightHelper jsVariableValue = null)
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
        _lightPlane = $"{variableName}.lightPlane".AsJsTypeVariable();
        _targetLine = $"{variableName}.targetLine".AsJsTypeVariable();
    }

    public JsDirectionalLightHelper(JsType argLight = null, JsType argSize = null, JsType argColor = null)
        : base(new JsDirectionalLightHelperConstructor(argLight, argSize, argColor))
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