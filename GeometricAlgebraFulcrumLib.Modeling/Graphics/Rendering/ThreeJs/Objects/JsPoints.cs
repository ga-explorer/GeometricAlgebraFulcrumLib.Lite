using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPointsConstructor :
    JsTypeConstructor
{
    public JsBufferGeometry Geometry { get; }
        
    public JsPointsMaterial Material { get; }
        
        


    internal JsPointsConstructor(JsBufferGeometry argGeometry, JsPointsMaterial argMaterial)
    {
        Geometry = argGeometry ?? new JsBufferGeometry();
        Material = argMaterial ?? new JsPointsMaterial();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Points({Geometry.GetJsCode()}, {Material.GetJsCode()})";
    }
}
    
public partial class JsPoints :
    JsObject3D
{
    public static implicit operator JsPoints(string jsTextCode)
    {
        return new JsPoints(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPoints value)
    {
        return value.GetJsCode();
    }


    private readonly JsPoints _jsVariableValue;
    public JsPoints JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Points\"";
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
        
    private readonly JsPointsMaterial _material;
    public JsPointsMaterial Material
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

    internal JsPoints(JsTypeConstructor jsCodeSource, JsPoints jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _geometry = $"{variableName}.geometry".AsJsBufferGeometryVariable();
        _material = $"{variableName}.material".AsJsPointsMaterialVariable();
        _morphTargetInfluences = $"{variableName}.morphTargetInfluences".AsJsTypeVariable();
        _morphTargetDictionary = $"{variableName}.morphTargetDictionary".AsJsTypeVariable();
    }

    public JsPoints(JsBufferGeometry argGeometry = null, JsPointsMaterial argMaterial = null)
        : base(new JsPointsConstructor(argGeometry, argMaterial))
    {
    }

    public JsPoints Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Raycast(JsType argRaycaster = null, JsType argIntersects = null)
    {
        return CallMethod("raycast", argRaycaster ?? new JsObject(), argIntersects ?? new JsObject());
    }
        
    public JsType UpdateMorphTargets()
    {
        return CallMethod("updateMorphTargets");
    }
        
        
}