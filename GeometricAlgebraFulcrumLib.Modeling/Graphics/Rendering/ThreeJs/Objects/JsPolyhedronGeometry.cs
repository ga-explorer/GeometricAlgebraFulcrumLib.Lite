using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPolyhedronGeometryConstructor :
    JsTypeConstructor
{
    public JsArray Vertices { get; }
        
    public JsArray Indices { get; }
        
    public JsNumber Radius { get; }
        
    public JsNumber Detail { get; }
        
        


    internal JsPolyhedronGeometryConstructor(JsArray argVertices, JsArray argIndices, JsNumber argRadius, JsNumber argDetail)
    {
        Vertices = argVertices ?? new JsArray();
        Indices = argIndices ?? new JsArray();
        Radius = argRadius ?? (1).AsJsNumber();
        Detail = argDetail ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PolyhedronGeometry({Vertices.GetJsCode()}, {Indices.GetJsCode()}, {Radius.GetJsCode()}, {Detail.GetJsCode()})";
    }
}
    
public partial class JsPolyhedronGeometry :
    JsBufferGeometry
{
    public static implicit operator JsPolyhedronGeometry(string jsTextCode)
    {
        return new JsPolyhedronGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPolyhedronGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsPolyhedronGeometry _jsVariableValue;
    public JsPolyhedronGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"PolyhedronGeometry\"";
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

    internal JsPolyhedronGeometry(JsTypeConstructor jsCodeSource, JsPolyhedronGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsPolyhedronGeometry(JsArray argVertices = null, JsArray argIndices = null, JsNumber argRadius = null, JsNumber argDetail = null)
        : base(new JsPolyhedronGeometryConstructor(argVertices, argIndices, argRadius, argDetail))
    {
    }

        
}