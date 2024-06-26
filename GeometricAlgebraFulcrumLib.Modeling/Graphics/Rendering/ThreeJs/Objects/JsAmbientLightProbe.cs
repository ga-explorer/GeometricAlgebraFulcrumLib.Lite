using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAmbientLightProbeConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsNumber Intensity { get; }
        
        


    internal JsAmbientLightProbeConstructor(JsType argColor, JsNumber argIntensity)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AmbientLightProbe({Color.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsAmbientLightProbe :
    JsLightProbe
{
    public static implicit operator JsAmbientLightProbe(string jsTextCode)
    {
        return new JsAmbientLightProbe(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAmbientLightProbe value)
    {
        return value.GetJsCode();
    }


    private readonly JsAmbientLightProbe _jsVariableValue;
    public JsAmbientLightProbe JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsAmbientLightProbe(JsTypeConstructor jsCodeSource, JsAmbientLightProbe jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsAmbientLightProbe(JsType argColor = null, JsNumber argIntensity = null)
        : base(new JsAmbientLightProbeConstructor(argColor, argIntensity))
    {
    }

        
}