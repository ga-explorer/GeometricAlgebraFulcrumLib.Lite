using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBox3HelperConstructor :
    JsTypeConstructor
{
    public JsType Box { get; }
        
    public JsNumber Color { get; }
        
        


    internal JsBox3HelperConstructor(JsType argBox, JsNumber argColor)
    {
        Box = argBox ?? new JsObject();
        Color = argColor ?? (16776960).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Box3Helper({Box.GetJsCode()}, {Color.GetJsCode()})";
    }
}
    
public partial class JsBox3Helper :
    JsLineSegments
{
    public static implicit operator JsBox3Helper(string jsTextCode)
    {
        return new JsBox3Helper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBox3Helper value)
    {
        return value.GetJsCode();
    }


    private readonly JsBox3Helper _jsVariableValue;
    public JsBox3Helper JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _box;
    public JsType Box
    {
        get => _box ?? throw new InvalidOperationException();
        set
        {
            if (_box is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.box = {valueCode};");
        }
    }
        
    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"Box3Helper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsBox3Helper(JsTypeConstructor jsCodeSource, JsBox3Helper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _box = $"{variableName}.box".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsBox3Helper(JsType argBox = null, JsNumber argColor = null)
        : base(new JsBox3HelperConstructor(argBox, argColor))
    {
    }

    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
        
}