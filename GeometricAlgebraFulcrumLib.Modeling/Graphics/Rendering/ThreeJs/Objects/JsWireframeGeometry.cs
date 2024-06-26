using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWireframeGeometryConstructor :
    JsTypeConstructor
{
    public JsType Geometry { get; }
        
        


    internal JsWireframeGeometryConstructor(JsType argGeometry)
    {
        Geometry = argGeometry ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.WireframeGeometry({Geometry.GetJsCode()})";
    }
}
    
public partial class JsWireframeGeometry :
    JsBufferGeometry
{
    public static implicit operator JsWireframeGeometry(string jsTextCode)
    {
        return new JsWireframeGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWireframeGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsWireframeGeometry _jsVariableValue;
    public JsWireframeGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"WireframeGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsWireframeGeometry(JsTypeConstructor jsCodeSource, JsWireframeGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsWireframeGeometry(JsType argGeometry = null)
        : base(new JsWireframeGeometryConstructor(argGeometry))
    {
    }

        
}