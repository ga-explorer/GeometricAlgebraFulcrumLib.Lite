using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLODConstructor :
    JsTypeConstructor
{
        


    internal JsLODConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.LOD()";
    }
}
    
public partial class JsLOD :
    JsObject3D
{
    public static implicit operator JsLOD(string jsTextCode)
    {
        return new JsLOD(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLOD value)
    {
        return value.GetJsCode();
    }


    private readonly JsLOD _jsVariableValue;
    public JsLOD JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LOD\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsBoolean _autoUpdate;
    public JsBoolean AutoUpdate
    {
        get => _autoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_autoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.autoUpdate = {valueCode};");
        }
    }

    internal JsLOD(JsTypeConstructor jsCodeSource, JsLOD jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _autoUpdate = $"{variableName}.autoUpdate".AsJsBooleanVariable();
    }

    public JsLOD()
        : base(new JsLODConstructor())
    {
    }

    public JsLOD Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsLOD AddLevel(JsType argObject = null, JsNumber argDistance = null)
    {
        CallMethodVoid("addLevel", argObject ?? new JsObject(), argDistance ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsType GetCurrentLevel()
    {
        return CallMethod("getCurrentLevel");
    }
        
    public JsType GetObjectForDistance(JsType argDistance = null)
    {
        return CallMethod("getObjectForDistance", argDistance ?? new JsObject());
    }
        
    public JsType Raycast(JsType argRaycaster = null, JsType argIntersects = null)
    {
        return CallMethod("raycast", argRaycaster ?? new JsObject(), argIntersects ?? new JsObject());
    }
        
    public JsType Update(JsType argCamera = null)
    {
        return CallMethod("update", argCamera ?? new JsObject());
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}