using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsGroupConstructor :
    JsTypeConstructor
{
        


    internal JsGroupConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Group()";
    }
}
    
public partial class JsGroup :
    JsObject3D
{
    public static implicit operator JsGroup(string jsTextCode)
    {
        return new JsGroup(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsGroup value)
    {
        return value.GetJsCode();
    }


    private readonly JsGroup _jsVariableValue;
    public JsGroup JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Group\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsGroup(JsTypeConstructor jsCodeSource, JsGroup jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsGroup()
        : base(new JsGroupConstructor())
    {
    }

        
}