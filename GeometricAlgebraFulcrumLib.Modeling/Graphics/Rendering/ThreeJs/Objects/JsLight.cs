using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLightConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsNumber Intensity { get; }
        
        


    internal JsLightConstructor(JsType argColor, JsNumber argIntensity)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Light({Color.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsLight :
    JsObject3D
{
    public static implicit operator JsLight(string jsTextCode)
    {
        return new JsLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsLight _jsVariableValue;
    public JsLight JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Light\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
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
        
    private readonly JsNumber _intensity;
    public JsNumber Intensity
    {
        get => _intensity ?? throw new InvalidOperationException();
        set
        {
            if (_intensity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.intensity = {valueCode};");
        }
    }

    internal JsLight(JsTypeConstructor jsCodeSource, JsLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _intensity = $"{variableName}.intensity".AsJsNumberVariable();
    }

    public JsLight(JsType argColor = null, JsNumber argIntensity = null)
        : base(new JsLightConstructor(argColor, argIntensity))
    {
    }

    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsLight Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}