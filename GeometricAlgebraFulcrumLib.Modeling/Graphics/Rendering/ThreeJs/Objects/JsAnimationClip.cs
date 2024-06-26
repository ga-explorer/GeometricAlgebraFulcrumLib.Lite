using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAnimationClipConstructor :
    JsTypeConstructor
{
    public JsType Name { get; }
        
    public JsNumber Duration { get; }
        
    public JsType Tracks { get; }
        
    public JsNumber BlendMode { get; }
        
        


    internal JsAnimationClipConstructor(JsType argName, JsNumber argDuration, JsType argTracks, JsNumber argBlendMode)
    {
        Name = argName ?? new JsObject();
        Duration = argDuration ?? (-1).AsJsNumber();
        Tracks = argTracks ?? new JsObject();
        BlendMode = argBlendMode ?? ThreeJsConstants.NormalAnimationBlendMode;
    }

    public override string GetJsCode()
    {
        return $"new THREE.AnimationClip({Name.GetJsCode()}, {Duration.GetJsCode()}, {Tracks.GetJsCode()}, {BlendMode.GetJsCode()})";
    }
}
    
public partial class JsAnimationClip :
    JsObjectType
{
    public static implicit operator JsAnimationClip(string jsTextCode)
    {
        return new JsAnimationClip(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAnimationClip value)
    {
        return value.GetJsCode();
    }


    private readonly JsAnimationClip _jsVariableValue;
    public JsAnimationClip JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _name;
    public JsType Name
    {
        get => _name ?? throw new InvalidOperationException();
        set
        {
            if (_name is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.name = {valueCode};");
        }
    }
        
    private readonly JsType _tracks;
    public JsType Tracks
    {
        get => _tracks ?? throw new InvalidOperationException();
        set
        {
            if (_tracks is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.tracks = {valueCode};");
        }
    }
        
    private readonly JsNumber _duration;
    public JsNumber Duration
    {
        get => _duration ?? throw new InvalidOperationException();
        set
        {
            if (_duration is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "-1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.duration = {valueCode};");
        }
    }
        
    private readonly JsNumber _blendMode;
    public JsNumber BlendMode
    {
        get => _blendMode ?? throw new InvalidOperationException();
        set
        {
            if (_blendMode is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.NormalAnimationBlendMode;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendMode = {valueCode};");
        }
    }
        
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

    internal JsAnimationClip(JsTypeConstructor jsCodeSource, JsAnimationClip jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _name = $"{variableName}.name".AsJsTypeVariable();
        _tracks = $"{variableName}.tracks".AsJsTypeVariable();
        _duration = $"{variableName}.duration".AsJsNumberVariable();
        _blendMode = $"{variableName}.blendMode".AsJsNumberVariable();
        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
    }

    public JsAnimationClip(JsType argName = null, JsNumber argDuration = null, JsType argTracks = null, JsNumber argBlendMode = null)
        : base(new JsAnimationClipConstructor(argName, argDuration, argTracks, argBlendMode))
    {
    }

    public JsAnimationClip ResetDuration()
    {
        CallMethodVoid("resetDuration");
            
        return this;
    }
        
    public JsAnimationClip Trim()
    {
        CallMethodVoid("trim");
            
        return this;
    }
        
    public JsType Validate()
    {
        return CallMethod("validate");
    }
        
    public JsAnimationClip Optimize()
    {
        CallMethodVoid("optimize");
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}