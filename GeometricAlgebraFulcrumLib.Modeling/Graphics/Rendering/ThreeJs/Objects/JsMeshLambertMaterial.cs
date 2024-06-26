using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshLambertMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsMeshLambertMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MeshLambertMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsMeshLambertMaterial :
    JsMaterial
{
    public static implicit operator JsMeshLambertMaterial(string jsTextCode)
    {
        return new JsMeshLambertMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMeshLambertMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMeshLambertMaterial _jsVariableValue;
    public JsMeshLambertMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"MeshLambertMaterial\"";
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
        
    private readonly JsType _lightMap;
    public JsType LightMap
    {
        get => _lightMap ?? throw new InvalidOperationException();
        set
        {
            if (_lightMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.lightMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _lightMapIntensity;
    public JsNumber LightMapIntensity
    {
        get => _lightMapIntensity ?? throw new InvalidOperationException();
        set
        {
            if (_lightMapIntensity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.lightMapIntensity = {valueCode};");
        }
    }
        
    private readonly JsType _aoMap;
    public JsType AoMap
    {
        get => _aoMap ?? throw new InvalidOperationException();
        set
        {
            if (_aoMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aoMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _aoMapIntensity;
    public JsNumber AoMapIntensity
    {
        get => _aoMapIntensity ?? throw new InvalidOperationException();
        set
        {
            if (_aoMapIntensity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aoMapIntensity = {valueCode};");
        }
    }
        
    private readonly JsType _emissive;
    public JsType Emissive
    {
        get => _emissive ?? throw new InvalidOperationException();
        set
        {
            if (_emissive is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.emissive = {valueCode};");
        }
    }
        
    private readonly JsNumber _emissiveIntensity;
    public JsNumber EmissiveIntensity
    {
        get => _emissiveIntensity ?? throw new InvalidOperationException();
        set
        {
            if (_emissiveIntensity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.emissiveIntensity = {valueCode};");
        }
    }
        
    private readonly JsType _emissiveMap;
    public JsType EmissiveMap
    {
        get => _emissiveMap ?? throw new InvalidOperationException();
        set
        {
            if (_emissiveMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.emissiveMap = {valueCode};");
        }
    }
        
    private readonly JsType _specularMap;
    public JsType SpecularMap
    {
        get => _specularMap ?? throw new InvalidOperationException();
        set
        {
            if (_specularMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.specularMap = {valueCode};");
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
        
    private readonly JsType _envMap;
    public JsType EnvMap
    {
        get => _envMap ?? throw new InvalidOperationException();
        set
        {
            if (_envMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.envMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _combine;
    public JsNumber Combine
    {
        get => _combine ?? throw new InvalidOperationException();
        set
        {
            if (_combine is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.combine = {valueCode};");
        }
    }
        
    private readonly JsNumber _reflectivity;
    public JsNumber Reflectivity
    {
        get => _reflectivity ?? throw new InvalidOperationException();
        set
        {
            if (_reflectivity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.reflectivity = {valueCode};");
        }
    }
        
    private readonly JsNumber _refractionRatio;
    public JsNumber RefractionRatio
    {
        get => _refractionRatio ?? throw new InvalidOperationException();
        set
        {
            if (_refractionRatio is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0.98";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.refractionRatio = {valueCode};");
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
        
    private readonly JsString _wireframeLinecap;
    public JsString WireframeLinecap
    {
        get => _wireframeLinecap ?? throw new InvalidOperationException();
        set
        {
            if (_wireframeLinecap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"round\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wireframeLinecap = {valueCode};");
        }
    }
        
    private readonly JsString _wireframeLinejoin;
    public JsString WireframeLinejoin
    {
        get => _wireframeLinejoin ?? throw new InvalidOperationException();
        set
        {
            if (_wireframeLinejoin is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"round\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wireframeLinejoin = {valueCode};");
        }
    }

    internal JsMeshLambertMaterial(JsTypeConstructor jsCodeSource, JsMeshLambertMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _map = $"{variableName}.map".AsJsTypeVariable();
        _lightMap = $"{variableName}.lightMap".AsJsTypeVariable();
        _lightMapIntensity = $"{variableName}.lightMapIntensity".AsJsNumberVariable();
        _aoMap = $"{variableName}.aoMap".AsJsTypeVariable();
        _aoMapIntensity = $"{variableName}.aoMapIntensity".AsJsNumberVariable();
        _emissive = $"{variableName}.emissive".AsJsTypeVariable();
        _emissiveIntensity = $"{variableName}.emissiveIntensity".AsJsNumberVariable();
        _emissiveMap = $"{variableName}.emissiveMap".AsJsTypeVariable();
        _specularMap = $"{variableName}.specularMap".AsJsTypeVariable();
        _alphaMap = $"{variableName}.alphaMap".AsJsTypeVariable();
        _envMap = $"{variableName}.envMap".AsJsTypeVariable();
        _combine = $"{variableName}.combine".AsJsNumberVariable();
        _reflectivity = $"{variableName}.reflectivity".AsJsNumberVariable();
        _refractionRatio = $"{variableName}.refractionRatio".AsJsNumberVariable();
        _wireframe = $"{variableName}.wireframe".AsJsBooleanVariable();
        _wireframeLinewidth = $"{variableName}.wireframeLinewidth".AsJsNumberVariable();
        _wireframeLinecap = $"{variableName}.wireframeLinecap".AsJsStringVariable();
        _wireframeLinejoin = $"{variableName}.wireframeLinejoin".AsJsStringVariable();
    }

    public JsMeshLambertMaterial(JsType argParameters = null)
        : base(new JsMeshLambertMaterialConstructor(argParameters))
    {
    }

    public JsMeshLambertMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}