using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsShapeGeometryConstructor :
    JsTypeConstructor
{
    public JsShape Shapes { get; }
        
    public JsNumber CurveSegments { get; }
        
        


    internal JsShapeGeometryConstructor(JsShape argShapes, JsNumber argCurveSegments)
    {
        Shapes = argShapes ?? new JsShape(new JsArray(new JsVector2((0).AsJsNumber(), (0.5).AsJsNumber()), new JsVector2((-0.5).AsJsNumber(), (-0.5).AsJsNumber()), new JsVector2((0.5).AsJsNumber(), (-0.5).AsJsNumber())));
        CurveSegments = argCurveSegments ?? (12).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ShapeGeometry({Shapes.GetJsCode()}, {CurveSegments.GetJsCode()})";
    }
}
    
public partial class JsShapeGeometry :
    JsBufferGeometry
{
    public static implicit operator JsShapeGeometry(string jsTextCode)
    {
        return new JsShapeGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsShapeGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsShapeGeometry _jsVariableValue;
    public JsShapeGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"ShapeGeometry\"";
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

    internal JsShapeGeometry(JsTypeConstructor jsCodeSource, JsShapeGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsShapeGeometry(JsShape argShapes = null, JsNumber argCurveSegments = null)
        : base(new JsShapeGeometryConstructor(argShapes, argCurveSegments))
    {
    }

    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}