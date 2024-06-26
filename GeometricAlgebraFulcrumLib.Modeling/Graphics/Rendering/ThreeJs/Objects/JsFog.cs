using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsFogConstructor :
    JsTypeConstructor
{
    public JsType Color { get; }
        
    public JsNumber Near { get; }
        
    public JsNumber Far { get; }
        
        


    internal JsFogConstructor(JsType argColor, JsNumber argNear, JsNumber argFar)
    {
        Color = argColor ?? new JsObject();
        Near = argNear ?? (1).AsJsNumber();
        Far = argFar ?? (1000).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Fog({Color.GetJsCode()}, {Near.GetJsCode()}, {Far.GetJsCode()})";
    }
}
    
public partial class JsFog :
    JsObjectType
{
    public static implicit operator JsFog(string jsTextCode)
    {
        return new JsFog(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsFog value)
    {
        return value.GetJsCode();
    }


    private readonly JsFog _jsVariableValue;
    public JsFog JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsString _name;
    public JsString Name
    {
        get => _name ?? throw new InvalidOperationException();
        set
        {
            if (_name is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.name = {valueCode};");
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
        
    private readonly JsNumber _near;
    public JsNumber Near
    {
        get => _near ?? throw new InvalidOperationException();
        set
        {
            if (_near is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.near = {valueCode};");
        }
    }
        
    private readonly JsNumber _far;
    public JsNumber Far
    {
        get => _far ?? throw new InvalidOperationException();
        set
        {
            if (_far is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1000";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.far = {valueCode};");
        }
    }

    internal JsFog(JsTypeConstructor jsCodeSource, JsFog jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _name = $"{variableName}.name".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _near = $"{variableName}.near".AsJsNumberVariable();
        _far = $"{variableName}.far".AsJsNumberVariable();
    }

    public JsFog(JsType argColor = null, JsNumber argNear = null, JsNumber argFar = null)
        : base(new JsFogConstructor(argColor, argNear, argFar))
    {
    }

    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}