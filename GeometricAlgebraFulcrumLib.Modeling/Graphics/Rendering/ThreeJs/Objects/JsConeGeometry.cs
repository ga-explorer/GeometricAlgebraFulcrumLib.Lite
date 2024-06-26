using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsConeGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Height { get; }
        
    public JsNumber RadialSegments { get; }
        
    public JsNumber HeightSegments { get; }
        
    public JsBoolean OpenEnded { get; }
        
    public JsNumber ThetaStart { get; }
        
    public JsType ThetaLength { get; }
        
        


    internal JsConeGeometryConstructor(JsNumber argRadius, JsNumber argHeight, JsNumber argRadialSegments, JsNumber argHeightSegments, JsBoolean argOpenEnded, JsNumber argThetaStart, JsType argThetaLength)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        RadialSegments = argRadialSegments ?? (8).AsJsNumber();
        HeightSegments = argHeightSegments ?? (1).AsJsNumber();
        OpenEnded = argOpenEnded ?? (false).AsJsBoolean();
        ThetaStart = argThetaStart ?? (0).AsJsNumber();
        ThetaLength = argThetaLength ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ConeGeometry({Radius.GetJsCode()}, {Height.GetJsCode()}, {RadialSegments.GetJsCode()}, {HeightSegments.GetJsCode()}, {OpenEnded.GetJsCode()}, {ThetaStart.GetJsCode()}, {ThetaLength.GetJsCode()})";
    }
}
    
public partial class JsConeGeometry :
    JsCylinderGeometry
{
    public static implicit operator JsConeGeometry(string jsTextCode)
    {
        return new JsConeGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsConeGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsConeGeometry _jsVariableValue;
    public JsConeGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"ConeGeometry\"";
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

    internal JsConeGeometry(JsTypeConstructor jsCodeSource, JsConeGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsConeGeometry(JsNumber argRadius = null, JsNumber argHeight = null, JsNumber argRadialSegments = null, JsNumber argHeightSegments = null, JsBoolean argOpenEnded = null, JsNumber argThetaStart = null, JsType argThetaLength = null)
        : base(new JsConeGeometryConstructor(argRadius, argHeight, argRadialSegments, argHeightSegments, argOpenEnded, argThetaStart, argThetaLength))
    {
    }

        
}