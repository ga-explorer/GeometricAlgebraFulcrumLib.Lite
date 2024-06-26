using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPointLightConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsType Intensity { get; }
        
    public JsNumber Distance { get; }
        
    public JsNumber Decay { get; }
        
        


    internal JsPointLightConstructor(JsType argColor, JsType argIntensity, JsNumber argDistance, JsNumber argDecay)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? new JsObject();
        Distance = argDistance ?? (0).AsJsNumber();
        Decay = argDecay ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PointLight({Color.GetJsCode()}, {Intensity.GetJsCode()}, {Distance.GetJsCode()}, {Decay.GetJsCode()})";
    }
}
    
public partial class JsPointLight :
    JsLight
{
    public static implicit operator JsPointLight(string jsTextCode)
    {
        return new JsPointLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPointLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsPointLight _jsVariableValue;
    public JsPointLight JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"PointLight\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _distance;
    public JsNumber Distance
    {
        get => _distance ?? throw new InvalidOperationException();
        set
        {
            if (_distance is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.distance = {valueCode};");
        }
    }
        
    private readonly JsNumber _decay;
    public JsNumber Decay
    {
        get => _decay ?? throw new InvalidOperationException();
        set
        {
            if (_decay is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.decay = {valueCode};");
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
        
    private readonly JsType _power;
    public JsType Power
    {
        get => _power ?? throw new InvalidOperationException();
        set
        {
            if (_power is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.power = {valueCode};");
        }
    }

    internal JsPointLight(JsTypeConstructor jsCodeSource, JsPointLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _distance = $"{variableName}.distance".AsJsNumberVariable();
        _decay = $"{variableName}.decay".AsJsNumberVariable();
        _shadow = $"{variableName}.shadow".AsJsTypeVariable();
        _power = $"{variableName}.power".AsJsTypeVariable();
    }

    public JsPointLight(JsType argColor = null, JsType argIntensity = null, JsNumber argDistance = null, JsNumber argDecay = null)
        : base(new JsPointLightConstructor(argColor, argIntensity, argDistance, argDecay))
    {
    }

    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsPointLight Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}