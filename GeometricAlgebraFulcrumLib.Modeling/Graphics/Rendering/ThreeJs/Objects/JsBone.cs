using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBoneConstructor :
    JsTypeConstructor
{
        


    internal JsBoneConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Bone()";
    }
}
    
public partial class JsBone :
    JsObject3D
{
    public static implicit operator JsBone(string jsTextCode)
    {
        return new JsBone(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBone value)
    {
        return value.GetJsCode();
    }


    private readonly JsBone _jsVariableValue;
    public JsBone JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Bone\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsBone(JsTypeConstructor jsCodeSource, JsBone jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsBone()
        : base(new JsBoneConstructor())
    {
    }

        
}