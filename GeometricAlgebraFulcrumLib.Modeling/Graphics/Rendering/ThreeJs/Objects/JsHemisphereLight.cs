using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsHemisphereLightConstructor :
    JsTypeConstructor
{
    public JsType SkyColor { get; }
        
    public JsType GroundColor { get; }
        
    public JsType Intensity { get; }
        
        


    internal JsHemisphereLightConstructor(JsType argSkyColor, JsType argGroundColor, JsType argIntensity)
    {
        SkyColor = argSkyColor ?? new JsObject();
        GroundColor = argGroundColor ?? new JsObject();
        Intensity = argIntensity ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.HemisphereLight({SkyColor.GetJsCode()}, {GroundColor.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsHemisphereLight :
    JsLight
{
    public static implicit operator JsHemisphereLight(string jsTextCode)
    {
        return new JsHemisphereLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsHemisphereLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsHemisphereLight _jsVariableValue;
    public JsHemisphereLight JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"HemisphereLight\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _groundColor;
    public JsType GroundColor
    {
        get => _groundColor ?? throw new InvalidOperationException();
        set
        {
            if (_groundColor is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.groundColor = {valueCode};");
        }
    }

    internal JsHemisphereLight(JsTypeConstructor jsCodeSource, JsHemisphereLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _groundColor = $"{variableName}.groundColor".AsJsTypeVariable();
    }

    public JsHemisphereLight(JsType argSkyColor = null, JsType argGroundColor = null, JsType argIntensity = null)
        : base(new JsHemisphereLightConstructor(argSkyColor, argGroundColor, argIntensity))
    {
    }

    public JsHemisphereLight Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}