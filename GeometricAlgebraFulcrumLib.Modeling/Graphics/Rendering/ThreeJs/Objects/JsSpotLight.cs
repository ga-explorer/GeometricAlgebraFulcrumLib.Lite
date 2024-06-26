using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSpotLightConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsType Intensity { get; }
        
    public JsNumber Distance { get; }
        
    public JsType Angle { get; }
        
    public JsNumber Penumbra { get; }
        
    public JsNumber Decay { get; }
        
        


    internal JsSpotLightConstructor(JsType argColor, JsType argIntensity, JsNumber argDistance, JsType argAngle, JsNumber argPenumbra, JsNumber argDecay)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? new JsObject();
        Distance = argDistance ?? (0).AsJsNumber();
        Angle = argAngle ?? new JsObject();
        Penumbra = argPenumbra ?? (0).AsJsNumber();
        Decay = argDecay ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SpotLight({Color.GetJsCode()}, {Intensity.GetJsCode()}, {Distance.GetJsCode()}, {Angle.GetJsCode()}, {Penumbra.GetJsCode()}, {Decay.GetJsCode()})";
    }
}
    
public partial class JsSpotLight :
    JsLight
{
    public static implicit operator JsSpotLight(string jsTextCode)
    {
        return new JsSpotLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSpotLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsSpotLight _jsVariableValue;
    public JsSpotLight JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"SpotLight\"";
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
        
    private readonly JsType _angle;
    public JsType Angle
    {
        get => _angle ?? throw new InvalidOperationException();
        set
        {
            if (_angle is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.angle = {valueCode};");
        }
    }
        
    private readonly JsNumber _penumbra;
    public JsNumber Penumbra
    {
        get => _penumbra ?? throw new InvalidOperationException();
        set
        {
            if (_penumbra is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.penumbra = {valueCode};");
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

    internal JsSpotLight(JsTypeConstructor jsCodeSource, JsSpotLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _target = $"{variableName}.target".AsJsTypeVariable();
        _distance = $"{variableName}.distance".AsJsNumberVariable();
        _angle = $"{variableName}.angle".AsJsTypeVariable();
        _penumbra = $"{variableName}.penumbra".AsJsNumberVariable();
        _decay = $"{variableName}.decay".AsJsNumberVariable();
        _shadow = $"{variableName}.shadow".AsJsTypeVariable();
        _power = $"{variableName}.power".AsJsTypeVariable();
    }

    public JsSpotLight(JsType argColor = null, JsType argIntensity = null, JsNumber argDistance = null, JsType argAngle = null, JsNumber argPenumbra = null, JsNumber argDecay = null)
        : base(new JsSpotLightConstructor(argColor, argIntensity, argDistance, argAngle, argPenumbra, argDecay))
    {
    }

    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsSpotLight Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}