using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsRectAreaLightConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsType Intensity { get; }
        
    public JsNumber Width { get; }
        
    public JsNumber Height { get; }
        
        


    internal JsRectAreaLightConstructor(JsType argColor, JsType argIntensity, JsNumber argWidth, JsNumber argHeight)
    {
        Color = argColor ?? new JsObject();
        Intensity = argIntensity ?? new JsObject();
        Width = argWidth ?? (10).AsJsNumber();
        Height = argHeight ?? (10).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.RectAreaLight({Color.GetJsCode()}, {Intensity.GetJsCode()}, {Width.GetJsCode()}, {Height.GetJsCode()})";
    }
}
    
public partial class JsRectAreaLight :
    JsLight
{
    public static implicit operator JsRectAreaLight(string jsTextCode)
    {
        return new JsRectAreaLight(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsRectAreaLight value)
    {
        return value.GetJsCode();
    }


    private readonly JsRectAreaLight _jsVariableValue;
    public JsRectAreaLight JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"RectAreaLight\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _width;
    public JsNumber Width
    {
        get => _width ?? throw new InvalidOperationException();
        set
        {
            if (_width is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "10";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.width = {valueCode};");
        }
    }
        
    private readonly JsNumber _height;
    public JsNumber Height
    {
        get => _height ?? throw new InvalidOperationException();
        set
        {
            if (_height is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "10";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.height = {valueCode};");
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

    internal JsRectAreaLight(JsTypeConstructor jsCodeSource, JsRectAreaLight jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _width = $"{variableName}.width".AsJsNumberVariable();
        _height = $"{variableName}.height".AsJsNumberVariable();
        _power = $"{variableName}.power".AsJsTypeVariable();
    }

    public JsRectAreaLight(JsType argColor = null, JsType argIntensity = null, JsNumber argWidth = null, JsNumber argHeight = null)
        : base(new JsRectAreaLightConstructor(argColor, argIntensity, argWidth, argHeight))
    {
    }

    public JsRectAreaLight Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}