using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsHemisphereLightProbeConstructor :
    JsTypeConstructor
{
    public JsType SkyColor { get; }
        
    public JsType GroundColor { get; }
        
    public JsNumber Intensity { get; }
        
        


    internal JsHemisphereLightProbeConstructor(JsType argSkyColor, JsType argGroundColor, JsNumber argIntensity)
    {
        SkyColor = argSkyColor ?? new JsObject();
        GroundColor = argGroundColor ?? new JsObject();
        Intensity = argIntensity ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.HemisphereLightProbe({SkyColor.GetJsCode()}, {GroundColor.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsHemisphereLightProbe :
    JsLightProbe
{
    public static implicit operator JsHemisphereLightProbe(string jsTextCode)
    {
        return new JsHemisphereLightProbe(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsHemisphereLightProbe value)
    {
        return value.GetJsCode();
    }


    private readonly JsHemisphereLightProbe _jsVariableValue;
    public JsHemisphereLightProbe JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsHemisphereLightProbe(JsTypeConstructor jsCodeSource, JsHemisphereLightProbe jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsHemisphereLightProbe(JsType argSkyColor = null, JsType argGroundColor = null, JsNumber argIntensity = null)
        : base(new JsHemisphereLightProbeConstructor(argSkyColor, argGroundColor, argIntensity))
    {
    }

        
}