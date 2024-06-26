using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSkinnedMeshConstructor :
    JsTypeConstructor
{
    public JsType Geometry { get; }
        
    public JsType Material { get; }
        
        


    internal JsSkinnedMeshConstructor(JsType argGeometry, JsType argMaterial)
    {
        Geometry = argGeometry ?? new JsObject();
        Material = argMaterial ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SkinnedMesh({Geometry.GetJsCode()}, {Material.GetJsCode()})";
    }
}
    
public partial class JsSkinnedMesh :
    JsMesh
{
    public static implicit operator JsSkinnedMesh(string jsTextCode)
    {
        return new JsSkinnedMesh(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSkinnedMesh value)
    {
        return value.GetJsCode();
    }


    private readonly JsSkinnedMesh _jsVariableValue;
    public JsSkinnedMesh JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"SkinnedMesh\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsString _bindMode;
    public JsString BindMode
    {
        get => _bindMode ?? throw new InvalidOperationException();
        set
        {
            if (_bindMode is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"attached\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bindMode = {valueCode};");
        }
    }
        
    private readonly JsType _bindMatrix;
    public JsType BindMatrix
    {
        get => _bindMatrix ?? throw new InvalidOperationException();
        set
        {
            if (_bindMatrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bindMatrix = {valueCode};");
        }
    }
        
    private readonly JsType _bindMatrixInverse;
    public JsType BindMatrixInverse
    {
        get => _bindMatrixInverse ?? throw new InvalidOperationException();
        set
        {
            if (_bindMatrixInverse is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bindMatrixInverse = {valueCode};");
        }
    }
        
    private readonly JsType _skeleton;
    public JsType Skeleton
    {
        get => _skeleton ?? throw new InvalidOperationException();
        set
        {
            if (_skeleton is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.skeleton = {valueCode};");
        }
    }

    internal JsSkinnedMesh(JsTypeConstructor jsCodeSource, JsSkinnedMesh jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _bindMode = $"{variableName}.bindMode".AsJsStringVariable();
        _bindMatrix = $"{variableName}.bindMatrix".AsJsTypeVariable();
        _bindMatrixInverse = $"{variableName}.bindMatrixInverse".AsJsTypeVariable();
        _skeleton = $"{variableName}.skeleton".AsJsTypeVariable();
    }

    public JsSkinnedMesh(JsType argGeometry = null, JsType argMaterial = null)
        : base(new JsSkinnedMeshConstructor(argGeometry, argMaterial))
    {
    }

    public JsSkinnedMesh Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Bind(JsType argSkeleton = null, JsType argBindMatrix = null)
    {
        return CallMethod("bind", argSkeleton ?? new JsObject(), argBindMatrix ?? new JsObject());
    }
        
    public JsType Pose()
    {
        return CallMethod("pose");
    }
        
    public JsType NormalizeSkinWeights()
    {
        return CallMethod("normalizeSkinWeights");
    }
        
    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
    public JsType BoneTransform(JsType argIndex = null, JsType argTarget = null)
    {
        return CallMethod("boneTransform", argIndex ?? new JsObject(), argTarget ?? new JsObject());
    }
        
        
}