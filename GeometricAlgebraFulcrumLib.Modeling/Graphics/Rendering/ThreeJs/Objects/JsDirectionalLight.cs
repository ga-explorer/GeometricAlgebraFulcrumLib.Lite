using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDirectionalLightConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsType Intensity { get; }
        
        


    internal JsDirectionalLightConstructor(JsType argColor, JsType argIntensity)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DirectionalLight({Color.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsDirectionalLight :
    JsLight
{
    public static implicit operator JsDirectionalLight(string jsTextCode)
    {
        return new JsDirectionalLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDirectionalLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsDirectionalLight _jsVariableValue;
    public JsDirectionalLight JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"DirectionalLight\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _target;
    public JsType Target
    {
        get => _target ?? throw new InvalidOperationException();
        set
        {
            if (_target is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.target = {valueCode};");
        }
    }
        
    private readonly JsType _shadow;
    public JsType Shadow
    {
        get => _shadow ?? throw new InvalidOperationException();
        set
        {
            if (_shadow is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.shadow = {valueCode};");
        }
    }

    internal JsDirectionalLight(JsTypeConstructor jsCodeSource, JsDirectionalLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _target = $"{variableName}.target".AsJsTypeVariable();
        _shadow = $"{variableName}.shadow".AsJsTypeVariable();
    }

    public JsDirectionalLight(JsType argColor = null, JsType argIntensity = null)
        : base(new JsDirectionalLightConstructor(argColor, argIntensity))
    {
    }

    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsDirectionalLight Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}