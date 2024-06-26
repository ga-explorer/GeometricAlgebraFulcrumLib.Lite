using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSpriteMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsSpriteMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SpriteMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsSpriteMaterial :
    JsMaterial
{
    public static implicit operator JsSpriteMaterial(string jsTextCode)
    {
        return new JsSpriteMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSpriteMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsSpriteMaterial _jsVariableValue;
    public JsSpriteMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"SpriteMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _color;
    public JsType Color
    {
        get => _color ?? throw new InvalidOperationException();
        set
        {
            if (_color is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.color = {valueCode};");
        }
    }
        
    private readonly JsType _map;
    public JsType Map
    {
        get => _map ?? throw new InvalidOperationException();
        set
        {
            if (_map is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.map = {valueCode};");
        }
    }
        
    private readonly JsType _alphaMap;
    public JsType AlphaMap
    {
        get => _alphaMap ?? throw new InvalidOperationException();
        set
        {
            if (_alphaMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.alphaMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _rotation;
    public JsNumber Rotation
    {
        get => _rotation ?? throw new InvalidOperationException();
        set
        {
            if (_rotation is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.rotation = {valueCode};");
        }
    }
        
    private readonly JsBoolean _sizeAttenuation;
    public JsBoolean SizeAttenuation
    {
        get => _sizeAttenuation ?? throw new InvalidOperationException();
        set
        {
            if (_sizeAttenuation is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sizeAttenuation = {valueCode};");
        }
    }
        
    private readonly JsBoolean _transparent;
    public JsBoolean Transparent
    {
        get => _transparent ?? throw new InvalidOperationException();
        set
        {
            if (_transparent is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.transparent = {valueCode};");
        }
    }

    internal JsSpriteMaterial(JsTypeConstructor jsCodeSource, JsSpriteMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _map = $"{variableName}.map".AsJsTypeVariable();
        _alphaMap = $"{variableName}.alphaMap".AsJsTypeVariable();
        _rotation = $"{variableName}.rotation".AsJsNumberVariable();
        _sizeAttenuation = $"{variableName}.sizeAttenuation".AsJsBooleanVariable();
        _transparent = $"{variableName}.transparent".AsJsBooleanVariable();
    }

    public JsSpriteMaterial(JsType argParameters = null)
        : base(new JsSpriteMaterialConstructor(argParameters))
    {
    }

    public JsSpriteMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}