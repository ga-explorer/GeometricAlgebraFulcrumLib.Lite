using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLightProbeConstructor :
    JsTypeConstructor
{
    public JsSphericalHarmonics3 Sh { get; }
        
    public JsNumber Intensity { get; }
        
        


    internal JsLightProbeConstructor(JsSphericalHarmonics3 argSh, JsNumber argIntensity)
    {
        Sh = argSh ?? new JsSphericalHarmonics3();
        Intensity = argIntensity ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LightProbe({Sh.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsLightProbe :
    JsLight
{
    public static implicit operator JsLightProbe(string jsTextCode)
    {
        return new JsLightProbe(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLightProbe value)
    {
        return value.GetJsCode();
    }


    private readonly JsLightProbe _jsVariableValue;
    public JsLightProbe JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsSphericalHarmonics3 _sh;
    public JsSphericalHarmonics3 Sh
    {
        get => _sh ?? throw new InvalidOperationException();
        set
        {
            if (_sh is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sh = {valueCode};");
        }
    }
        
    private readonly JsType _intensity;
    public JsType Intensity
    {
        get => _intensity ?? throw new InvalidOperationException();
        set
        {
            if (_intensity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.intensity = {valueCode};");
        }
    }

    internal JsLightProbe(JsTypeConstructor jsCodeSource, JsLightProbe jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _sh = $"{variableName}.sh".AsJsSphericalHarmonics3Variable();
        _intensity = $"{variableName}.intensity".AsJsTypeVariable();
    }

    public JsLightProbe(JsSphericalHarmonics3 argSh = null, JsNumber argIntensity = null)
        : base(new JsLightProbeConstructor(argSh, argIntensity))
    {
    }

    public JsLightProbe Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsLightProbe FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}