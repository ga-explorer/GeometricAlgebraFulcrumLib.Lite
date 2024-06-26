using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsEdgesGeometryConstructor :
    JsTypeConstructor
{
    public JsType Geometry { get; }
        
    public JsType ThresholdAngle { get; }
        
        


    internal JsEdgesGeometryConstructor(JsType argGeometry, JsType argThresholdAngle)
    {
        Geometry = argGeometry ?? new JsObject();
        ThresholdAngle = argThresholdAngle ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.EdgesGeometry({Geometry.GetJsCode()}, {ThresholdAngle.GetJsCode()})";
    }
}
    
public partial class JsEdgesGeometry :
    JsBufferGeometry
{
    public static implicit operator JsEdgesGeometry(string jsTextCode)
    {
        return new JsEdgesGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsEdgesGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsEdgesGeometry _jsVariableValue;
    public JsEdgesGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"EdgesGeometry\"";
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

    internal JsEdgesGeometry(JsTypeConstructor jsCodeSource, JsEdgesGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsEdgesGeometry(JsType argGeometry = null, JsType argThresholdAngle = null)
        : base(new JsEdgesGeometryConstructor(argGeometry, argThresholdAngle))
    {
    }

        
}