using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAnimationActionConstructor :
    JsTypeConstructor
{
    public JsType Mixer { get; }
        
    public JsType Clip { get; }
        
    public JsObject LocalRoot { get; }
        
    public JsType BlendMode { get; }
        
        


    internal JsAnimationActionConstructor(JsType argMixer, JsType argClip, JsObject argLocalRoot, JsType argBlendMode)
    {
        Mixer = argMixer ?? new JsObject();
        Clip = argClip ?? new JsObject();
        LocalRoot = argLocalRoot ?? new JsObject();
        BlendMode = argBlendMode ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AnimationAction({Mixer.GetJsCode()}, {Clip.GetJsCode()}, {LocalRoot.GetJsCode()}, {BlendMode.GetJsCode()})";
    }
}
    
public partial class JsAnimationAction :
    JsObjectType
{
    public static implicit operator JsAnimationAction(string jsTextCode)
    {
        return new JsAnimationAction(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAnimationAction value)
    {
        return value.GetJsCode();
    }


    private readonly JsAnimationAction _jsVariableValue;
    public JsAnimationAction JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _blendMode;
    public JsType BlendMode
    {
        get => _blendMode ?? throw new InvalidOperationException();
        set
        {
            if (_blendMode is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.blendMode = {valueCode};");
        }
    }
        
    private readonly JsNumber _loop;
    public JsNumber Loop
    {
        get => _loop ?? throw new InvalidOperationException();
        set
        {
            if (_loop is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "2201";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.loop = {valueCode};");
        }
    }
        
    private readonly JsNumber _time;
    public JsNumber Time
    {
        get => _time ?? throw new InvalidOperationException();
        set
        {
            if (_time is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.time = {valueCode};");
        }
    }
        
    private readonly JsNumber _timeScale;
    public JsNumber TimeScale
    {
        get => _timeScale ?? throw new InvalidOperationException();
        set
        {
            if (_timeScale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.timeScale = {valueCode};");
        }
    }
        
    private readonly JsNumber _weight;
    public JsNumber Weight
    {
        get => _weight ?? throw new InvalidOperationException();
        set
        {
            if (_weight is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.weight = {valueCode};");
        }
    }
        
    private readonly JsBoolean _paused;
    public JsBoolean Paused
    {
        get => _paused ?? throw new InvalidOperationException();
        set
        {
            if (_paused is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.paused = {valueCode};");
        }
    }
        
    private readonly JsBoolean _enabled;
    public JsBoolean Enabled
    {
        get => _enabled ?? throw new InvalidOperationException();
        set
        {
            if (_enabled is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.enabled = {valueCode};");
        }
    }
        
    private readonly JsBoolean _clampWhenFinished;
    public JsBoolean ClampWhenFinished
    {
        get => _clampWhenFinished ?? throw new InvalidOperationException();
        set
        {
            if (_clampWhenFinished is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.clampWhenFinished = {valueCode};");
        }
    }
        
    private readonly JsBoolean _zeroSlopeAtStart;
    public JsBoolean ZeroSlopeAtStart
    {
        get => _zeroSlopeAtStart ?? throw new InvalidOperationException();
        set
        {
            if (_zeroSlopeAtStart is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.zeroSlopeAtStart = {valueCode};");
        }
    }
        
    private readonly JsBoolean _zeroSlopeAtEnd;
    public JsBoolean ZeroSlopeAtEnd
    {
        get => _zeroSlopeAtEnd ?? throw new InvalidOperationException();
        set
        {
            if (_zeroSlopeAtEnd is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.zeroSlopeAtEnd = {valueCode};");
        }
    }
        
    private readonly JsType _repetitions;
    public JsType Repetitions
    {
        get => _repetitions ?? throw new InvalidOperationException();
        set
        {
            if (_repetitions is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.repetitions = {valueCode};");
        }
    }

    internal JsAnimationAction(JsTypeConstructor jsCodeSource, JsAnimationAction jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _blendMode = $"{variableName}.blendMode".AsJsTypeVariable();
        _loop = $"{variableName}.loop".AsJsNumberVariable();
        _time = $"{variableName}.time".AsJsNumberVariable();
        _timeScale = $"{variableName}.timeScale".AsJsNumberVariable();
        _weight = $"{variableName}.weight".AsJsNumberVariable();
        _paused = $"{variableName}.paused".AsJsBooleanVariable();
        _enabled = $"{variableName}.enabled".AsJsBooleanVariable();
        _clampWhenFinished = $"{variableName}.clampWhenFinished".AsJsBooleanVariable();
        _zeroSlopeAtStart = $"{variableName}.zeroSlopeAtStart".AsJsBooleanVariable();
        _zeroSlopeAtEnd = $"{variableName}.zeroSlopeAtEnd".AsJsBooleanVariable();
        _repetitions = $"{variableName}.repetitions".AsJsTypeVariable();
    }

    public JsAnimationAction(JsType argMixer = null, JsType argClip = null, JsObject argLocalRoot = null, JsType argBlendMode = null)
        : base(new JsAnimationActionConstructor(argMixer, argClip, argLocalRoot, argBlendMode))
    {
    }

    public JsAnimationAction Play()
    {
        CallMethodVoid("play");
            
        return this;
    }
        
    public JsType Stop()
    {
        return CallMethod("stop");
    }
        
    public JsType Reset()
    {
        return CallMethod("reset");
    }
        
    public JsType IsRunning()
    {
        return CallMethod("isRunning");
    }
        
    public JsType IsScheduled()
    {
        return CallMethod("isScheduled");
    }
        
    public JsAnimationAction StartAt(JsType argTime = null)
    {
        CallMethodVoid("startAt", argTime ?? new JsObject());
            
        return this;
    }
        
    public JsAnimationAction SetLoop(JsType argMode = null, JsType argRepetitions = null)
    {
        CallMethodVoid("setLoop", argMode ?? new JsObject(), argRepetitions ?? new JsObject());
            
        return this;
    }
        
    public JsType SetEffectiveWeight(JsType argWeight = null)
    {
        return CallMethod("setEffectiveWeight", argWeight ?? new JsObject());
    }
        
    public JsType GetEffectiveWeight()
    {
        return CallMethod("getEffectiveWeight");
    }
        
    public JsType FadeIn(JsType argDuration = null)
    {
        return CallMethod("fadeIn", argDuration ?? new JsObject());
    }
        
    public JsType FadeOut(JsType argDuration = null)
    {
        return CallMethod("fadeOut", argDuration ?? new JsObject());
    }
        
    public JsAnimationAction CrossFadeFrom(JsType argFadeOutAction = null, JsType argDuration = null, JsType argWarp = null)
    {
        CallMethodVoid("crossFadeFrom", argFadeOutAction ?? new JsObject(), argDuration ?? new JsObject(), argWarp ?? new JsObject());
            
        return this;
    }
        
    public JsType CrossFadeTo(JsType argFadeInAction = null, JsType argDuration = null, JsType argWarp = null)
    {
        return CallMethod("crossFadeTo", argFadeInAction ?? new JsObject(), argDuration ?? new JsObject(), argWarp ?? new JsObject());
    }
        
    public JsAnimationAction StopFading()
    {
        CallMethodVoid("stopFading");
            
        return this;
    }
        
    public JsType SetEffectiveTimeScale(JsType argTimeScale = null)
    {
        return CallMethod("setEffectiveTimeScale", argTimeScale ?? new JsObject());
    }
        
    public JsType GetEffectiveTimeScale()
    {
        return CallMethod("getEffectiveTimeScale");
    }
        
    public JsType SetDuration(JsType argDuration = null)
    {
        return CallMethod("setDuration", argDuration ?? new JsObject());
    }
        
    public JsType SyncWith(JsType argAction = null)
    {
        return CallMethod("syncWith", argAction ?? new JsObject());
    }
        
    public JsType Halt(JsType argDuration = null)
    {
        return CallMethod("halt", argDuration ?? new JsObject());
    }
        
    public JsAnimationAction Warp(JsType argStartTimeScale = null, JsType argEndTimeScale = null, JsType argDuration = null)
    {
        CallMethodVoid("warp", argStartTimeScale ?? new JsObject(), argEndTimeScale ?? new JsObject(), argDuration ?? new JsObject());
            
        return this;
    }
        
    public JsAnimationAction StopWarping()
    {
        CallMethodVoid("stopWarping");
            
        return this;
    }
        
    public JsType GetMixer()
    {
        return CallMethod("getMixer");
    }
        
    public JsType GetClip()
    {
        return CallMethod("getClip");
    }
        
    public JsType GetRoot()
    {
        return CallMethod("getRoot");
    }
        
    public JsType _update(JsType argTime = null, JsType argDeltaTime = null, JsType argTimeDirection = null, JsType argAccuIndex = null)
    {
        return CallMethod("_update", argTime ?? new JsObject(), argDeltaTime ?? new JsObject(), argTimeDirection ?? new JsObject(), argAccuIndex ?? new JsObject());
    }
        
    public JsType _updateWeight(JsType argTime = null)
    {
        return CallMethod("_updateWeight", argTime ?? new JsObject());
    }
        
    public JsType _updateTimeScale(JsType argTime = null)
    {
        return CallMethod("_updateTimeScale", argTime ?? new JsObject());
    }
        
    public JsType _updateTime(JsType argDeltaTime = null)
    {
        return CallMethod("_updateTime", argDeltaTime ?? new JsObject());
    }
        
    public JsType _setEndings(JsType argAtStart = null, JsType argAtEnd = null, JsType argPingPong = null)
    {
        return CallMethod("_setEndings", argAtStart ?? new JsObject(), argAtEnd ?? new JsObject(), argPingPong ?? new JsObject());
    }
        
    public JsAnimationAction _scheduleFading(JsType argDuration = null, JsType argWeightNow = null, JsType argWeightThen = null)
    {
        CallMethodVoid("_scheduleFading", argDuration ?? new JsObject(), argWeightNow ?? new JsObject(), argWeightThen ?? new JsObject());
            
        return this;
    }
        
        
}