using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAmbientLightConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsType Intensity { get; }
        
        


    internal JsAmbientLightConstructor(JsType argColor, JsType argIntensity)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AmbientLight({Color.GetJsCode()}, {Intensity.GetJsCode()})";
    }
}
    
public partial class JsAmbientLight :
    JsLight
{
    public static implicit operator JsAmbientLight(string jsTextCode)
    {
        return new JsAmbientLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAmbientLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsAmbientLight _jsVariableValue;
    public JsAmbientLight JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"AmbientLight\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsAmbientLight(JsTypeConstructor jsCodeSource, JsAmbientLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsAmbientLight(JsType argColor = null, JsType argIntensity = null)
        : base(new JsAmbientLightConstructor(argColor, argIntensity))
    {
    }

        
}