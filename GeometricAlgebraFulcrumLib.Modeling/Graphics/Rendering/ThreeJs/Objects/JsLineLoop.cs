using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLineLoopConstructor :
    JsTypeConstructor
{
    public JsType Geometry { get; }
        
    public JsType Material { get; }
        
        


    internal JsLineLoopConstructor(JsType argGeometry, JsType argMaterial)
    {
        Geometry = argGeometry ?? new JsObject();
        Material = argMaterial ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LineLoop({Geometry.GetJsCode()}, {Material.GetJsCode()})";
    }
}
    
public partial class JsLineLoop :
    JsLine
{
    public static implicit operator JsLineLoop(string jsTextCode)
    {
        return new JsLineLoop(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLineLoop value)
    {
        return value.GetJsCode();
    }


    private readonly JsLineLoop _jsVariableValue;
    public JsLineLoop JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LineLoop\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsLineLoop(JsTypeConstructor jsCodeSource, JsLineLoop jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsLineLoop(JsType argGeometry = null, JsType argMaterial = null)
        : base(new JsLineLoopConstructor(argGeometry, argMaterial))
    {
    }

        
}