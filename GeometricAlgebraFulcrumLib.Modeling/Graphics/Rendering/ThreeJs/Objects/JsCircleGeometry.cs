using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCircleGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Segments { get; }
        
    public JsNumber ThetaStart { get; }
        
    public JsType ThetaLength { get; }
        
        


    internal JsCircleGeometryConstructor(JsNumber argRadius, JsNumber argSegments, JsNumber argThetaStart, JsType argThetaLength)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Segments = argSegments ?? (8).AsJsNumber();
        ThetaStart = argThetaStart ?? (0).AsJsNumber();
        ThetaLength = argThetaLength ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CircleGeometry({Radius.GetJsCode()}, {Segments.GetJsCode()}, {ThetaStart.GetJsCode()}, {ThetaLength.GetJsCode()})";
    }
}
    
public partial class JsCircleGeometry :
    JsBufferGeometry
{
    public static implicit operator JsCircleGeometry(string jsTextCode)
    {
        return new JsCircleGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCircleGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsCircleGeometry _jsVariableValue;
    public JsCircleGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"CircleGeometry\"";
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

    internal JsCircleGeometry(JsTypeConstructor jsCodeSource, JsCircleGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsCircleGeometry(JsNumber argRadius = null, JsNumber argSegments = null, JsNumber argThetaStart = null, JsType argThetaLength = null)
        : base(new JsCircleGeometryConstructor(argRadius, argSegments, argThetaStart, argThetaLength))
    {
    }

        
}