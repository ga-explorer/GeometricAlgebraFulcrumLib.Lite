using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLatheGeometryConstructor :
    JsTypeConstructor
{
    public JsArray Points { get; }
        
    public JsNumber Segments { get; }
        
    public JsNumber PhiStart { get; }
        
    public JsType PhiLength { get; }
        
        


    internal JsLatheGeometryConstructor(JsArray argPoints, JsNumber argSegments, JsNumber argPhiStart, JsType argPhiLength)
    {
        Points = argPoints ?? new JsArray(new JsVector2((0).AsJsNumber(), (0.5).AsJsNumber()), new JsVector2((0.5).AsJsNumber(), (0).AsJsNumber()), new JsVector2((0).AsJsNumber(), (-0.5).AsJsNumber()));
        Segments = argSegments ?? (12).AsJsNumber();
        PhiStart = argPhiStart ?? (0).AsJsNumber();
        PhiLength = argPhiLength ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LatheGeometry({Points.GetJsCode()}, {Segments.GetJsCode()}, {PhiStart.GetJsCode()}, {PhiLength.GetJsCode()})";
    }
}
    
public partial class JsLatheGeometry :
    JsBufferGeometry
{
    public static implicit operator JsLatheGeometry(string jsTextCode)
    {
        return new JsLatheGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLatheGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsLatheGeometry _jsVariableValue;
    public JsLatheGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LatheGeometry\"";
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

    internal JsLatheGeometry(JsTypeConstructor jsCodeSource, JsLatheGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsLatheGeometry(JsArray argPoints = null, JsNumber argSegments = null, JsNumber argPhiStart = null, JsType argPhiLength = null)
        : base(new JsLatheGeometryConstructor(argPoints, argSegments, argPhiStart, argPhiLength))
    {
    }

        
}