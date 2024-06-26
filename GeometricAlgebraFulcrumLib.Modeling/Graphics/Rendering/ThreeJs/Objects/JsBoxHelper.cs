using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBoxHelperConstructor :
    JsTypeConstructor
{
    public JsType Object { get; }
        
    public JsNumber Color { get; }
        
        


    internal JsBoxHelperConstructor(JsType argObject, JsNumber argColor)
    {
        Object = argObject ?? new JsObject();
        Color = argColor ?? (16776960).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.BoxHelper({Object.GetJsCode()}, {Color.GetJsCode()})";
    }
}
    
public partial class JsBoxHelper :
    JsLineSegments
{
    public static implicit operator JsBoxHelper(string jsTextCode)
    {
        return new JsBoxHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBoxHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsBoxHelper _jsVariableValue;
    public JsBoxHelper JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _object;
    public JsType Object
    {
        get => _object ?? throw new InvalidOperationException();
        set
        {
            if (_object is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.object = {valueCode};");
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
        
            var valueCode = value?.GetJsCode() ?? "\"BoxHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsBoolean _matrixAutoUpdate;
    public JsBoolean MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }

    internal JsBoxHelper(JsTypeConstructor jsCodeSource, JsBoxHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _object = $"{variableName}.object".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsBooleanVariable();
    }

    public JsBoxHelper(JsType argObject = null, JsNumber argColor = null)
        : base(new JsBoxHelperConstructor(argObject, argColor))
    {
    }

    public JsType Update(JsType argObject = null)
    {
        return CallMethod("update", argObject ?? new JsObject());
    }
        
    public JsBoxHelper SetFromObject(JsType argObject = null)
    {
        CallMethodVoid("setFromObject", argObject ?? new JsObject());
            
        return this;
    }
        
    public JsBoxHelper Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}