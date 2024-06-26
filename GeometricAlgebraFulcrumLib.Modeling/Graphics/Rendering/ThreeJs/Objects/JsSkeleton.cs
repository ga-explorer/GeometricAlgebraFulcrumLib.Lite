using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSkeletonConstructor :
    JsTypeConstructor
{
    public JsArray Bones { get; }
        
    public JsArray BoneInverses { get; }
        
        


    internal JsSkeletonConstructor(JsArray argBones, JsArray argBoneInverses)
    {
        Bones = argBones ?? new JsArray();
        BoneInverses = argBoneInverses ?? new JsArray();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Skeleton({Bones.GetJsCode()}, {BoneInverses.GetJsCode()})";
    }
}
    
public partial class JsSkeleton :
    JsObjectType
{
    public static implicit operator JsSkeleton(string jsTextCode)
    {
        return new JsSkeleton(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSkeleton value)
    {
        return value.GetJsCode();
    }


    private readonly JsSkeleton _jsVariableValue;
    public JsSkeleton JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _uuid;
    public JsType Uuid
    {
        get => _uuid ?? throw new InvalidOperationException();
        set
        {
            if (_uuid is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uuid = {valueCode};");
        }
    }
        
    private readonly JsType _bones;
    public JsType Bones
    {
        get => _bones ?? throw new InvalidOperationException();
        set
        {
            if (_bones is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bones = {valueCode};");
        }
    }
        
    private readonly JsArray _boneInverses;
    public JsArray BoneInverses
    {
        get => _boneInverses ?? throw new InvalidOperationException();
        set
        {
            if (_boneInverses is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.boneInverses = {valueCode};");
        }
    }
        
    private readonly JsType _boneMatrices;
    public JsType BoneMatrices
    {
        get => _boneMatrices ?? throw new InvalidOperationException();
        set
        {
            if (_boneMatrices is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.boneMatrices = {valueCode};");
        }
    }
        
    private readonly JsDataTexture _boneTexture;
    public JsDataTexture BoneTexture
    {
        get => _boneTexture ?? throw new InvalidOperationException();
        set
        {
            if (_boneTexture is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.boneTexture = {valueCode};");
        }
    }
        
    private readonly JsNumber _boneTextureSize;
    public JsNumber BoneTextureSize
    {
        get => _boneTextureSize ?? throw new InvalidOperationException();
        set
        {
            if (_boneTextureSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.boneTextureSize = {valueCode};");
        }
    }
        
    private readonly JsType _frame;
    public JsType Frame
    {
        get => _frame ?? throw new InvalidOperationException();
        set
        {
            if (_frame is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.frame = {valueCode};");
        }
    }

    internal JsSkeleton(JsTypeConstructor jsCodeSource, JsSkeleton jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _bones = $"{variableName}.bones".AsJsTypeVariable();
        _boneInverses = $"{variableName}.boneInverses".AsJsArrayVariable();
        _boneMatrices = $"{variableName}.boneMatrices".AsJsTypeVariable();
        _boneTexture = $"{variableName}.boneTexture".AsJsDataTextureVariable();
        _boneTextureSize = $"{variableName}.boneTextureSize".AsJsNumberVariable();
        _frame = $"{variableName}.frame".AsJsTypeVariable();
    }

    public JsSkeleton(JsArray argBones = null, JsArray argBoneInverses = null)
        : base(new JsSkeletonConstructor(argBones, argBoneInverses))
    {
    }

    public JsType Init()
    {
        return CallMethod("init");
    }
        
    public JsType CalculateInverses()
    {
        return CallMethod("calculateInverses");
    }
        
    public JsType Pose()
    {
        return CallMethod("pose");
    }
        
    public JsType Update()
    {
        return CallMethod("update");
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsSkeleton ComputeBoneTexture()
    {
        CallMethodVoid("computeBoneTexture");
            
        return this;
    }
        
    public JsType GetBoneByName(JsType argName = null)
    {
        return CallMethod("getBoneByName", argName ?? new JsObject());
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsSkeleton FromJSON(JsType argJson = null, JsType argBones = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject(), argBones ?? new JsObject());
            
        return this;
    }
        
    public JsObject ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}