using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsUniformConstructor :
    JsTypeConstructor
{
    public JsType Value { get; }
        
        


    internal JsUniformConstructor(JsType argValue)
    {
        Value = argValue ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Uniform({Value.GetJsCode()})";
    }
}
    
public partial class JsUniform :
    JsObjectType
{
    public static implicit operator JsUniform(string jsTextCode)
    {
        return new JsUniform(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsUniform value)
    {
        return value.GetJsCode();
    }


    private readonly JsUniform _jsVariableValue;
    public JsUniform JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _value;
    public JsType Value
    {
        get => _value ?? throw new InvalidOperationException();
        set
        {
            if (_value is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.value = {valueCode};");
        }
    }

    internal JsUniform(JsTypeConstructor jsCodeSource, JsUniform jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _value = $"{variableName}.value".AsJsTypeVariable();
    }

    public JsUniform(JsType argValue = null)
        : base(new JsUniformConstructor(argValue))
    {
    }

    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}