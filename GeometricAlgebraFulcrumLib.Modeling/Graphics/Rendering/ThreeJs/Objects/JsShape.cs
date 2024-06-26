using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsShapeConstructor :
    JsTypeConstructor
{
    public JsType Points { get; }
        
        


    internal JsShapeConstructor(JsType argPoints)
    {
        Points = argPoints ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Shape({Points.GetJsCode()})";
    }
}
    
public partial class JsShape :
    JsPath
{
    public static implicit operator JsShape(string jsTextCode)
    {
        return new JsShape(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsShape value)
    {
        return value.GetJsCode();
    }


    private readonly JsShape _jsVariableValue;
    public JsShape JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _uuid;
    public JsType Uuid
    {
        get => _uuid ?? throw new InvalidOperationException();
        set
        {
            if (_uuid is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uuid = {valueCode};");
        }
    }
        
    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"Shape\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _holes;
    public JsType Holes
    {
        get => _holes ?? throw new InvalidOperationException();
        set
        {
            if (_holes is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.holes = {valueCode};");
        }
    }

    internal JsShape(JsTypeConstructor jsCodeSource, JsShape jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _holes = $"{variableName}.holes".AsJsTypeVariable();
    }

    public JsShape(JsType argPoints = null)
        : base(new JsShapeConstructor(argPoints))
    {
    }

    public JsArray GetPointsHoles(JsType argDivisions = null)
    {
        return CallMethod("getPointsHoles", argDivisions ?? new JsObject());
    }
        
    public JsType ExtractPoints(JsType argDivisions = null)
    {
        return CallMethod("extractPoints", argDivisions ?? new JsObject());
    }
        
    public JsShape Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsShape FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}