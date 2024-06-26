using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsShaderMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsShaderMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ShaderMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsShaderMaterial :
    JsMaterial
{
    public static implicit operator JsShaderMaterial(string jsTextCode)
    {
        return new JsShaderMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsShaderMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsShaderMaterial _jsVariableValue;
    public JsShaderMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"ShaderMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
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
        
    private readonly JsType _uniforms;
    public JsType Uniforms
    {
        get => _uniforms ?? throw new InvalidOperationException();
        set
        {
            if (_uniforms is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uniforms = {valueCode};");
        }
    }
        
    private readonly JsNumber _linewidth;
    public JsNumber Linewidth
    {
        get => _linewidth ?? throw new InvalidOperationException();
        set
        {
            if (_linewidth is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.linewidth = {valueCode};");
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
        
    private readonly JsBoolean _lights;
    public JsBoolean Lights
    {
        get => _lights ?? throw new InvalidOperationException();
        set
        {
            if (_lights is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.lights = {valueCode};");
        }
    }
        
    private readonly JsBoolean _clipping;
    public JsBoolean Clipping
    {
        get => _clipping ?? throw new InvalidOperationException();
        set
        {
            if (_clipping is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clipping = {valueCode};");
        }
    }
        
    private readonly JsType _extensions;
    public JsType Extensions
    {
        get => _extensions ?? throw new InvalidOperationException();
        set
        {
            if (_extensions is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.extensions = {valueCode};");
        }
    }
        
    private readonly JsType _defaultAttributeValues;
    public JsType DefaultAttributeValues
    {
        get => _defaultAttributeValues ?? throw new InvalidOperationException();
        set
        {
            if (_defaultAttributeValues is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.defaultAttributeValues = {valueCode};");
        }
    }
        
    private readonly JsBoolean _uniformsNeedUpdate;
    public JsBoolean UniformsNeedUpdate
    {
        get => _uniformsNeedUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_uniformsNeedUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uniformsNeedUpdate = {valueCode};");
        }
    }
        
    private readonly JsType _glslVersion;
    public JsType GlslVersion
    {
        get => _glslVersion ?? throw new InvalidOperationException();
        set
        {
            if (_glslVersion is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.glslVersion = {valueCode};");
        }
    }
        
    private readonly JsType _fragmentShader;
    public JsType FragmentShader
    {
        get => _fragmentShader ?? throw new InvalidOperationException();
        set
        {
            if (_fragmentShader is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.fragmentShader = {valueCode};");
        }
    }
        
    private readonly JsType _vertexShader;
    public JsType VertexShader
    {
        get => _vertexShader ?? throw new InvalidOperationException();
        set
        {
            if (_vertexShader is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.vertexShader = {valueCode};");
        }
    }

    internal JsShaderMaterial(JsTypeConstructor jsCodeSource, JsShaderMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _defines = $"{variableName}.defines".AsJsTypeVariable();
        _uniforms = $"{variableName}.uniforms".AsJsTypeVariable();
        _linewidth = $"{variableName}.linewidth".AsJsNumberVariable();
        _wireframe = $"{variableName}.wireframe".AsJsBooleanVariable();
        _wireframeLinewidth = $"{variableName}.wireframeLinewidth".AsJsNumberVariable();
        _fog = $"{variableName}.fog".AsJsBooleanVariable();
        _lights = $"{variableName}.lights".AsJsBooleanVariable();
        _clipping = $"{variableName}.clipping".AsJsBooleanVariable();
        _extensions = $"{variableName}.extensions".AsJsTypeVariable();
        _defaultAttributeValues = $"{variableName}.defaultAttributeValues".AsJsTypeVariable();
        _uniformsNeedUpdate = $"{variableName}.uniformsNeedUpdate".AsJsBooleanVariable();
        _glslVersion = $"{variableName}.glslVersion".AsJsTypeVariable();
        _fragmentShader = $"{variableName}.fragmentShader".AsJsTypeVariable();
        _vertexShader = $"{variableName}.vertexShader".AsJsTypeVariable();
    }

    public JsShaderMaterial(JsType argParameters = null)
        : base(new JsShaderMaterialConstructor(argParameters))
    {
    }

    public JsShaderMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}