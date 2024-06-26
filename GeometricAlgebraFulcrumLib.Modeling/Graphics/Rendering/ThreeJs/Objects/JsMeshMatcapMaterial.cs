using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshMatcapMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsMeshMatcapMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MeshMatcapMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsMeshMatcapMaterial :
    JsMaterial
{
    public static implicit operator JsMeshMatcapMaterial(string jsTextCode)
    {
        return new JsMeshMatcapMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMeshMatcapMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMeshMatcapMaterial _jsVariableValue;
    public JsMeshMatcapMaterial JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _defines;
    public JsType Defines
    {
        get => _defines ?? throw new InvalidOperationException();
        set
        {
            if (_defines is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.defines = {valueCode};");
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
        
            var valueCode = value?.GetJsCode() ?? "\"MeshMatcapMaterial\"";
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
        
    private readonly JsType _matcap;
    public JsType Matcap
    {
        get => _matcap ?? throw new InvalidOperationException();
        set
        {
            if (_matcap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matcap = {valueCode};");
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
        
    private readonly JsType _bumpMap;
    public JsType BumpMap
    {
        get => _bumpMap ?? throw new InvalidOperationException();
        set
        {
            if (_bumpMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bumpMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _bumpScale;
    public JsNumber BumpScale
    {
        get => _bumpScale ?? throw new InvalidOperationException();
        set
        {
            if (_bumpScale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bumpScale = {valueCode};");
        }
    }
        
    private readonly JsType _normalMap;
    public JsType NormalMap
    {
        get => _normalMap ?? throw new InvalidOperationException();
        set
        {
            if (_normalMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normalMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _normalMapType;
    public JsNumber NormalMapType
    {
        get => _normalMapType ?? throw new InvalidOperationException();
        set
        {
            if (_normalMapType is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normalMapType = {valueCode};");
        }
    }
        
    private readonly JsType _normalScale;
    public JsType NormalScale
    {
        get => _normalScale ?? throw new InvalidOperationException();
        set
        {
            if (_normalScale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normalScale = {valueCode};");
        }
    }
        
    private readonly JsType _displacementMap;
    public JsType DisplacementMap
    {
        get => _displacementMap ?? throw new InvalidOperationException();
        set
        {
            if (_displacementMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.displacementMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _displacementScale;
    public JsNumber DisplacementScale
    {
        get => _displacementScale ?? throw new InvalidOperationException();
        set
        {
            if (_displacementScale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.displacementScale = {valueCode};");
        }
    }
        
    private readonly JsNumber _displacementBias;
    public JsNumber DisplacementBias
    {
        get => _displacementBias ?? throw new InvalidOperationException();
        set
        {
            if (_displacementBias is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.displacementBias = {valueCode};");
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
        
    private readonly JsBoolean _flatShading;
    public JsBoolean FlatShading
    {
        get => _flatShading ?? throw new InvalidOperationException();
        set
        {
            if (_flatShading is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.flatShading = {valueCode};");
        }
    }

    internal JsMeshMatcapMaterial(JsTypeConstructor jsCodeSource, JsMeshMatcapMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _defines = $"{variableName}.defines".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _matcap = $"{variableName}.matcap".AsJsTypeVariable();
        _map = $"{variableName}.map".AsJsTypeVariable();
        _bumpMap = $"{variableName}.bumpMap".AsJsTypeVariable();
        _bumpScale = $"{variableName}.bumpScale".AsJsNumberVariable();
        _normalMap = $"{variableName}.normalMap".AsJsTypeVariable();
        _normalMapType = $"{variableName}.normalMapType".AsJsNumberVariable();
        _normalScale = $"{variableName}.normalScale".AsJsTypeVariable();
        _displacementMap = $"{variableName}.displacementMap".AsJsTypeVariable();
        _displacementScale = $"{variableName}.displacementScale".AsJsNumberVariable();
        _displacementBias = $"{variableName}.displacementBias".AsJsNumberVariable();
        _alphaMap = $"{variableName}.alphaMap".AsJsTypeVariable();
        _flatShading = $"{variableName}.flatShading".AsJsBooleanVariable();
    }

    public JsMeshMatcapMaterial(JsType argParameters = null)
        : base(new JsMeshMatcapMaterialConstructor(argParameters))
    {
    }

    public JsMeshMatcapMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}