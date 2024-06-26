using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshPhysicalMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsMeshPhysicalMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MeshPhysicalMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsMeshPhysicalMaterial :
    JsMeshStandardMaterial
{
    public static implicit operator JsMeshPhysicalMaterial(string jsTextCode)
    {
        return new JsMeshPhysicalMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMeshPhysicalMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMeshPhysicalMaterial _jsVariableValue;
    public JsMeshPhysicalMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"MeshPhysicalMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _clearcoatMap;
    public JsType ClearcoatMap
    {
        get => _clearcoatMap ?? throw new InvalidOperationException();
        set
        {
            if (_clearcoatMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clearcoatMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _clearcoatRoughness;
    public JsNumber ClearcoatRoughness
    {
        get => _clearcoatRoughness ?? throw new InvalidOperationException();
        set
        {
            if (_clearcoatRoughness is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clearcoatRoughness = {valueCode};");
        }
    }
        
    private readonly JsType _clearcoatRoughnessMap;
    public JsType ClearcoatRoughnessMap
    {
        get => _clearcoatRoughnessMap ?? throw new InvalidOperationException();
        set
        {
            if (_clearcoatRoughnessMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clearcoatRoughnessMap = {valueCode};");
        }
    }
        
    private readonly JsType _clearcoatNormalScale;
    public JsType ClearcoatNormalScale
    {
        get => _clearcoatNormalScale ?? throw new InvalidOperationException();
        set
        {
            if (_clearcoatNormalScale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clearcoatNormalScale = {valueCode};");
        }
    }
        
    private readonly JsType _clearcoatNormalMap;
    public JsType ClearcoatNormalMap
    {
        get => _clearcoatNormalMap ?? throw new InvalidOperationException();
        set
        {
            if (_clearcoatNormalMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clearcoatNormalMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _ior;
    public JsNumber Ior
    {
        get => _ior ?? throw new InvalidOperationException();
        set
        {
            if (_ior is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1.5";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.ior = {valueCode};");
        }
    }
        
    private readonly JsType _sheenTint;
    public JsType SheenTint
    {
        get => _sheenTint ?? throw new InvalidOperationException();
        set
        {
            if (_sheenTint is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sheenTint = {valueCode};");
        }
    }
        
    private readonly JsNumber _sheenRoughness;
    public JsNumber SheenRoughness
    {
        get => _sheenRoughness ?? throw new InvalidOperationException();
        set
        {
            if (_sheenRoughness is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sheenRoughness = {valueCode};");
        }
    }
        
    private readonly JsType _transmissionMap;
    public JsType TransmissionMap
    {
        get => _transmissionMap ?? throw new InvalidOperationException();
        set
        {
            if (_transmissionMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.transmissionMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _thickness;
    public JsNumber Thickness
    {
        get => _thickness ?? throw new InvalidOperationException();
        set
        {
            if (_thickness is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0.01";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.thickness = {valueCode};");
        }
    }
        
    private readonly JsType _thicknessMap;
    public JsType ThicknessMap
    {
        get => _thicknessMap ?? throw new InvalidOperationException();
        set
        {
            if (_thicknessMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.thicknessMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _attenuationDistance;
    public JsNumber AttenuationDistance
    {
        get => _attenuationDistance ?? throw new InvalidOperationException();
        set
        {
            if (_attenuationDistance is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.attenuationDistance = {valueCode};");
        }
    }
        
    private readonly JsType _attenuationTint;
    public JsType AttenuationTint
    {
        get => _attenuationTint ?? throw new InvalidOperationException();
        set
        {
            if (_attenuationTint is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.attenuationTint = {valueCode};");
        }
    }
        
    private readonly JsNumber _specularIntensity;
    public JsNumber SpecularIntensity
    {
        get => _specularIntensity ?? throw new InvalidOperationException();
        set
        {
            if (_specularIntensity is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.specularIntensity = {valueCode};");
        }
    }
        
    private readonly JsType _specularIntensityMap;
    public JsType SpecularIntensityMap
    {
        get => _specularIntensityMap ?? throw new InvalidOperationException();
        set
        {
            if (_specularIntensityMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.specularIntensityMap = {valueCode};");
        }
    }
        
    private readonly JsType _specularTint;
    public JsType SpecularTint
    {
        get => _specularTint ?? throw new InvalidOperationException();
        set
        {
            if (_specularTint is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.specularTint = {valueCode};");
        }
    }
        
    private readonly JsType _specularTintMap;
    public JsType SpecularTintMap
    {
        get => _specularTintMap ?? throw new InvalidOperationException();
        set
        {
            if (_specularTintMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.specularTintMap = {valueCode};");
        }
    }
        
    private readonly JsType _sheen;
    public JsType Sheen
    {
        get => _sheen ?? throw new InvalidOperationException();
        set
        {
            if (_sheen is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sheen = {valueCode};");
        }
    }
        
    private readonly JsType _clearcoat;
    public JsType Clearcoat
    {
        get => _clearcoat ?? throw new InvalidOperationException();
        set
        {
            if (_clearcoat is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clearcoat = {valueCode};");
        }
    }
        
    private readonly JsType _transmission;
    public JsType Transmission
    {
        get => _transmission ?? throw new InvalidOperationException();
        set
        {
            if (_transmission is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.transmission = {valueCode};");
        }
    }

    internal JsMeshPhysicalMaterial(JsTypeConstructor jsCodeSource, JsMeshPhysicalMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _defines = $"{variableName}.defines".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _clearcoatMap = $"{variableName}.clearcoatMap".AsJsTypeVariable();
        _clearcoatRoughness = $"{variableName}.clearcoatRoughness".AsJsNumberVariable();
        _clearcoatRoughnessMap = $"{variableName}.clearcoatRoughnessMap".AsJsTypeVariable();
        _clearcoatNormalScale = $"{variableName}.clearcoatNormalScale".AsJsTypeVariable();
        _clearcoatNormalMap = $"{variableName}.clearcoatNormalMap".AsJsTypeVariable();
        _ior = $"{variableName}.ior".AsJsNumberVariable();
        _sheenTint = $"{variableName}.sheenTint".AsJsTypeVariable();
        _sheenRoughness = $"{variableName}.sheenRoughness".AsJsNumberVariable();
        _transmissionMap = $"{variableName}.transmissionMap".AsJsTypeVariable();
        _thickness = $"{variableName}.thickness".AsJsNumberVariable();
        _thicknessMap = $"{variableName}.thicknessMap".AsJsTypeVariable();
        _attenuationDistance = $"{variableName}.attenuationDistance".AsJsNumberVariable();
        _attenuationTint = $"{variableName}.attenuationTint".AsJsTypeVariable();
        _specularIntensity = $"{variableName}.specularIntensity".AsJsNumberVariable();
        _specularIntensityMap = $"{variableName}.specularIntensityMap".AsJsTypeVariable();
        _specularTint = $"{variableName}.specularTint".AsJsTypeVariable();
        _specularTintMap = $"{variableName}.specularTintMap".AsJsTypeVariable();
        _sheen = $"{variableName}.sheen".AsJsTypeVariable();
        _clearcoat = $"{variableName}.clearcoat".AsJsTypeVariable();
        _transmission = $"{variableName}.transmission".AsJsTypeVariable();
    }

    public JsMeshPhysicalMaterial(JsType argParameters = null)
        : base(new JsMeshPhysicalMaterialConstructor(argParameters))
    {
    }

    public JsMeshPhysicalMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}