using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSceneConstructor :
    JsTypeConstructor
{
        


    internal JsSceneConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Scene()";
    }
}
    
public partial class JsScene :
    JsObject3D
{
    public static implicit operator JsScene(string jsTextCode)
    {
        return new JsScene(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsScene value)
    {
        return value.GetJsCode();
    }


    private readonly JsScene _jsVariableValue;
    public JsScene JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Scene\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _background;
    public JsType Background
    {
        get => _background ?? throw new InvalidOperationException();
        set
        {
            if (_background is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.background = {valueCode};");
        }
    }
        
    private readonly JsType _environment;
    public JsType Environment
    {
        get => _environment ?? throw new InvalidOperationException();
        set
        {
            if (_environment is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.environment = {valueCode};");
        }
    }
        
    private readonly JsType _fog;
    public JsType Fog
    {
        get => _fog ?? throw new InvalidOperationException();
        set
        {
            if (_fog is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.fog = {valueCode};");
        }
    }
        
    private readonly JsType _overrideMaterial;
    public JsType OverrideMaterial
    {
        get => _overrideMaterial ?? throw new InvalidOperationException();
        set
        {
            if (_overrideMaterial is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.overrideMaterial = {valueCode};");
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
        
    private readonly JsType _matrixAutoUpdate;
    public JsType MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }

    internal JsScene(JsTypeConstructor jsCodeSource, JsScene jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _background = $"{variableName}.background".AsJsTypeVariable();
        _environment = $"{variableName}.environment".AsJsTypeVariable();
        _fog = $"{variableName}.fog".AsJsTypeVariable();
        _overrideMaterial = $"{variableName}.overrideMaterial".AsJsTypeVariable();
        _autoUpdate = $"{variableName}.autoUpdate".AsJsBooleanVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsTypeVariable();
    }

    public JsScene()
        : base(new JsSceneConstructor())
    {
    }

    public JsScene Copy(JsType argSource = null, JsType argRecursive = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject(), argRecursive ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}