using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSphereGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber WidthSegments { get; }
        
    public JsNumber HeightSegments { get; }
        
    public JsNumber PhiStart { get; }
        
    public JsType PhiLength { get; }
        
    public JsNumber ThetaStart { get; }
        
    public JsType ThetaLength { get; }
        
        


    internal JsSphereGeometryConstructor(JsNumber argRadius, JsNumber argWidthSegments, JsNumber argHeightSegments, JsNumber argPhiStart, JsType argPhiLength, JsNumber argThetaStart, JsType argThetaLength)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        WidthSegments = argWidthSegments ?? (32).AsJsNumber();
        HeightSegments = argHeightSegments ?? (16).AsJsNumber();
        PhiStart = argPhiStart ?? (0).AsJsNumber();
        PhiLength = argPhiLength ?? new JsObject();
        ThetaStart = argThetaStart ?? (0).AsJsNumber();
        ThetaLength = argThetaLength ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SphereGeometry({Radius.GetJsCode()}, {WidthSegments.GetJsCode()}, {HeightSegments.GetJsCode()}, {PhiStart.GetJsCode()}, {PhiLength.GetJsCode()}, {ThetaStart.GetJsCode()}, {ThetaLength.GetJsCode()})";
    }
}
    
public partial class JsSphereGeometry :
    JsBufferGeometry
{
    public static implicit operator JsSphereGeometry(string jsTextCode)
    {
        return new JsSphereGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSphereGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsSphereGeometry _jsVariableValue;
    public JsSphereGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"SphereGeometry\"";
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

    internal JsSphereGeometry(JsTypeConstructor jsCodeSource, JsSphereGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsSphereGeometry(JsNumber argRadius = null, JsNumber argWidthSegments = null, JsNumber argHeightSegments = null, JsNumber argPhiStart = null, JsType argPhiLength = null, JsNumber argThetaStart = null, JsType argThetaLength = null)
        : base(new JsSphereGeometryConstructor(argRadius, argWidthSegments, argHeightSegments, argPhiStart, argPhiLength, argThetaStart, argThetaLength))
    {
    }

        
}