using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshDistanceMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsMeshDistanceMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MeshDistanceMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsMeshDistanceMaterial :
    JsMaterial
{
    public static implicit operator JsMeshDistanceMaterial(string jsTextCode)
    {
        return new JsMeshDistanceMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMeshDistanceMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMeshDistanceMaterial _jsVariableValue;
    public JsMeshDistanceMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"MeshDistanceMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _referencePosition;
    public JsType ReferencePosition
    {
        get => _referencePosition ?? throw new InvalidOperationException();
        set
        {
            if (_referencePosition is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.referencePosition = {valueCode};");
        }
    }
        
    private readonly JsNumber _nearDistance;
    public JsNumber NearDistance
    {
        get => _nearDistance ?? throw new InvalidOperationException();
        set
        {
            if (_nearDistance is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.nearDistance = {valueCode};");
        }
    }
        
    private readonly JsNumber _farDistance;
    public JsNumber FarDistance
    {
        get => _farDistance ?? throw new InvalidOperationException();
        set
        {
            if (_farDistance is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1000";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.farDistance = {valueCode};");
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

    internal JsMeshDistanceMaterial(JsTypeConstructor jsCodeSource, JsMeshDistanceMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _referencePosition = $"{variableName}.referencePosition".AsJsTypeVariable();
        _nearDistance = $"{variableName}.nearDistance".AsJsNumberVariable();
        _farDistance = $"{variableName}.farDistance".AsJsNumberVariable();
        _map = $"{variableName}.map".AsJsTypeVariable();
        _alphaMap = $"{variableName}.alphaMap".AsJsTypeVariable();
        _displacementMap = $"{variableName}.displacementMap".AsJsTypeVariable();
        _displacementScale = $"{variableName}.displacementScale".AsJsNumberVariable();
        _displacementBias = $"{variableName}.displacementBias".AsJsNumberVariable();
        _fog = $"{variableName}.fog".AsJsBooleanVariable();
    }

    public JsMeshDistanceMaterial(JsType argParameters = null)
        : base(new JsMeshDistanceMaterialConstructor(argParameters))
    {
    }

    public JsMeshDistanceMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}