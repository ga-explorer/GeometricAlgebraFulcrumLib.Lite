using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshNormalMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsMeshNormalMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MeshNormalMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsMeshNormalMaterial :
    JsMaterial
{
    public static implicit operator JsMeshNormalMaterial(string jsTextCode)
    {
        return new JsMeshNormalMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMeshNormalMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMeshNormalMaterial _jsVariableValue;
    public JsMeshNormalMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"MeshNormalMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
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
        
    private readonly JsBoolean _wireframe;
    public JsBoolean Wireframe
    {
        get => _wireframe ?? throw new InvalidOperationException();
        set
        {
            if (_wireframe is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wireframe = {valueCode};");
        }
    }
        
    private readonly JsNumber _wireframeLinewidth;
    public JsNumber WireframeLinewidth
    {
        get => _wireframeLinewidth ?? throw new InvalidOperationException();
        set
        {
            if (_wireframeLinewidth is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wireframeLinewidth = {valueCode};");
        }
    }
        
    private readonly JsBoolean _fog;
    public JsBoolean Fog
    {
        get => _fog ?? throw new InvalidOperationException();
        set
        {
            if (_fog is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.fog = {valueCode};");
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

    internal JsMeshNormalMaterial(JsTypeConstructor jsCodeSource, JsMeshNormalMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _bumpMap = $"{variableName}.bumpMap".AsJsTypeVariable();
        _bumpScale = $"{variableName}.bumpScale".AsJsNumberVariable();
        _normalMap = $"{variableName}.normalMap".AsJsTypeVariable();
        _normalMapType = $"{variableName}.normalMapType".AsJsNumberVariable();
        _normalScale = $"{variableName}.normalScale".AsJsTypeVariable();
        _displacementMap = $"{variableName}.displacementMap".AsJsTypeVariable();
        _displacementScale = $"{variableName}.displacementScale".AsJsNumberVariable();
        _displacementBias = $"{variableName}.displacementBias".AsJsNumberVariable();
        _wireframe = $"{variableName}.wireframe".AsJsBooleanVariable();
        _wireframeLinewidth = $"{variableName}.wireframeLinewidth".AsJsNumberVariable();
        _fog = $"{variableName}.fog".AsJsBooleanVariable();
        _flatShading = $"{variableName}.flatShading".AsJsBooleanVariable();
    }

    public JsMeshNormalMaterial(JsType argParameters = null)
        : base(new JsMeshNormalMaterialConstructor(argParameters))
    {
    }

    public JsMeshNormalMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}