using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsOctahedronGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Detail { get; }
        
        


    internal JsOctahedronGeometryConstructor(JsNumber argRadius, JsNumber argDetail)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Detail = argDetail ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.OctahedronGeometry({Radius.GetJsCode()}, {Detail.GetJsCode()})";
    }
}
    
public partial class JsOctahedronGeometry :
    JsPolyhedronGeometry
{
    public static implicit operator JsOctahedronGeometry(string jsTextCode)
    {
        return new JsOctahedronGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsOctahedronGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsOctahedronGeometry _jsVariableValue;
    public JsOctahedronGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"OctahedronGeometry\"";
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

    internal JsOctahedronGeometry(JsTypeConstructor jsCodeSource, JsOctahedronGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsOctahedronGeometry(JsNumber argRadius = null, JsNumber argDetail = null)
        : base(new JsOctahedronGeometryConstructor(argRadius, argDetail))
    {
    }

        
}