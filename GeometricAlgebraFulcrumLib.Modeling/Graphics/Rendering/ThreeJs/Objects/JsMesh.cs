using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshConstructor :
    JsTypeConstructor
{
    public JsBufferGeometry Geometry { get; }
        
    public JsMaterial Material { get; }
        
        


    internal JsMeshConstructor(JsBufferGeometry argGeometry, JsMaterial argMaterial)
    {
        Geometry = argGeometry ?? new JsBufferGeometry();
        Material = argMaterial ?? new JsMeshBasicMaterial();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Mesh({Geometry.GetJsCode()}, {Material.GetJsCode()})";
    }
}
    
public partial class JsMesh :
    JsObject3D
{
    public static implicit operator JsMesh(string jsTextCode)
    {
        return new JsMesh(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMesh value)
    {
        return value.GetJsCode();
    }


    private readonly JsMesh _jsVariableValue;
    public JsMesh JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Mesh\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsBufferGeometry _geometry;
    public JsBufferGeometry Geometry
    {
        get => _geometry ?? throw new InvalidOperationException();
        set
        {
            if (_geometry is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.geometry = {valueCode};");
        }
    }
        
    private readonly JsMeshBasicMaterial _material;
    public JsMeshBasicMaterial Material
    {
        get => _material ?? throw new InvalidOperationException();
        set
        {
            if (_material is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.material = {valueCode};");
        }
    }
        
    private readonly JsType _morphTargetInfluences;
    public JsType MorphTargetInfluences
    {
        get => _morphTargetInfluences ?? throw new InvalidOperationException();
        set
        {
            if (_morphTargetInfluences is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.morphTargetInfluences = {valueCode};");
        }
    }
        
    private readonly JsType _morphTargetDictionary;
    public JsType MorphTargetDictionary
    {
        get => _morphTargetDictionary ?? throw new InvalidOperationException();
        set
        {
            if (_morphTargetDictionary is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.morphTargetDictionary = {valueCode};");
        }
    }

    internal JsMesh(JsTypeConstructor jsCodeSource, JsMesh jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _geometry = $"{variableName}.geometry".AsJsBufferGeometryVariable();
        _material = $"{variableName}.material".AsJsMeshBasicMaterialVariable();
        _morphTargetInfluences = $"{variableName}.morphTargetInfluences".AsJsTypeVariable();
        _morphTargetDictionary = $"{variableName}.morphTargetDictionary".AsJsTypeVariable();
    }

    public JsMesh(JsBufferGeometry argGeometry = null, JsMaterial argMaterial = null)
        : base(new JsMeshConstructor(argGeometry, argMaterial))
    {
    }

    public JsMesh Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType UpdateMorphTargets()
    {
        return CallMethod("updateMorphTargets");
    }
        
    public JsType Raycast(JsType argRaycaster = null, JsType argIntersects = null)
    {
        return CallMethod("raycast", argRaycaster ?? new JsObject(), argIntersects ?? new JsObject());
    }
        
        
}