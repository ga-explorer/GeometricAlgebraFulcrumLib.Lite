using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsExtrudeGeometryConstructor :
    JsTypeConstructor
{
    public JsShape Shapes { get; }
        
    public JsObject Options { get; }
        
        


    internal JsExtrudeGeometryConstructor(JsShape argShapes, JsObject argOptions)
    {
        Shapes = argShapes ?? new JsShape(new JsArray(new JsVector2((0.5).AsJsNumber(), (0.5).AsJsNumber()), new JsVector2((-0.5).AsJsNumber(), (0.5).AsJsNumber()), new JsVector2((-0.5).AsJsNumber(), (-0.5).AsJsNumber()), new JsVector2((0.5).AsJsNumber(), (-0.5).AsJsNumber())));
        Options = argOptions ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ExtrudeGeometry({Shapes.GetJsCode()}, {Options.GetJsCode()})";
    }
}
    
public partial class JsExtrudeGeometry :
    JsBufferGeometry
{
    public static implicit operator JsExtrudeGeometry(string jsTextCode)
    {
        return new JsExtrudeGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsExtrudeGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsExtrudeGeometry _jsVariableValue;
    public JsExtrudeGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"ExtrudeGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _parameters;
    public JsType Parameters
    {
        get => _parameters ?? throw new InvalidOperationException();
        set
        {
            if (_parameters is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parameters = {valueCode};");
        }
    }

    internal JsExtrudeGeometry(JsTypeConstructor jsCodeSource, JsExtrudeGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsExtrudeGeometry(JsShape argShapes = null, JsObject argOptions = null)
        : base(new JsExtrudeGeometryConstructor(argShapes, argOptions))
    {
    }

    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}