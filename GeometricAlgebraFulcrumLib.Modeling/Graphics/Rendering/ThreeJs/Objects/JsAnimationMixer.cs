using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAnimationMixerConstructor :
    JsTypeConstructor
{
    public JsType Root { get; }
        
        


    internal JsAnimationMixerConstructor(JsType argRoot)
    {
        Root = argRoot ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AnimationMixer({Root.GetJsCode()})";
    }
}
    
public partial class JsAnimationMixer :
    JsEventDispatcher
{
    public static implicit operator JsAnimationMixer(string jsTextCode)
    {
        return new JsAnimationMixer(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAnimationMixer value)
    {
        return value.GetJsCode();
    }


    private readonly JsAnimationMixer _jsVariableValue;
    public JsAnimationMixer JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

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
        
    private readonly JsType _stats;
    public JsType Stats
    {
        get => _stats ?? throw new InvalidOperationException();
        set
        {
            if (_stats is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stats = {valueCode};");
        }
    }

    internal JsAnimationMixer(JsTypeConstructor jsCodeSource, JsAnimationMixer jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _time = $"{variableName}.time".AsJsNumberVariable();
        _timeScale = $"{variableName}.timeScale".AsJsNumberVariable();
        _stats = $"{variableName}.stats".AsJsTypeVariable();
    }

    public JsAnimationMixer(JsType argRoot = null)
        : base(new JsAnimationMixerConstructor(argRoot))
    {
    }

    public JsType _bindAction(JsType argAction = null, JsType argPrototypeAction = null)
    {
        return CallMethod("_bindAction", argAction ?? new JsObject(), argPrototypeAction ?? new JsObject());
    }
        
    public JsType _activateAction(JsType argAction = null)
    {
        return CallMethod("_activateAction", argAction ?? new JsObject());
    }
        
    public JsType _deactivateAction(JsType argAction = null)
    {
        return CallMethod("_deactivateAction", argAction ?? new JsObject());
    }
        
    public JsType _initMemoryManager()
    {
        return CallMethod("_initMemoryManager");
    }
        
    public JsType _isActiveAction(JsType argAction = null)
    {
        return CallMethod("_isActiveAction", argAction ?? new JsObject());
    }
        
    public JsType _addInactiveAction(JsType argAction = null, JsType argClipUuid = null, JsType argRootUuid = null)
    {
        return CallMethod("_addInactiveAction", argAction ?? new JsObject(), argClipUuid ?? new JsObject(), argRootUuid ?? new JsObject());
    }
        
    public JsType _removeInactiveAction(JsType argAction = null)
    {
        return CallMethod("_removeInactiveAction", argAction ?? new JsObject());
    }
        
    public JsType _removeInactiveBindingsForAction(JsType argAction = null)
    {
        return CallMethod("_removeInactiveBindingsForAction", argAction ?? new JsObject());
    }
        
    public JsType _lendAction(JsType argAction = null)
    {
        return CallMethod("_lendAction", argAction ?? new JsObject());
    }
        
    public JsType _takeBackAction(JsType argAction = null)
    {
        return CallMethod("_takeBackAction", argAction ?? new JsObject());
    }
        
    public JsType _addInactiveBinding(JsType argBinding = null, JsType argRootUuid = null, JsType argTrackName = null)
    {
        return CallMethod("_addInactiveBinding", argBinding ?? new JsObject(), argRootUuid ?? new JsObject(), argTrackName ?? new JsObject());
    }
        
    public JsType _removeInactiveBinding(JsType argBinding = null)
    {
        return CallMethod("_removeInactiveBinding", argBinding ?? new JsObject());
    }
        
    public JsType _lendBinding(JsType argBinding = null)
    {
        return CallMethod("_lendBinding", argBinding ?? new JsObject());
    }
        
    public JsType _takeBackBinding(JsType argBinding = null)
    {
        return CallMethod("_takeBackBinding", argBinding ?? new JsObject());
    }
        
    public JsType _lendControlInterpolant()
    {
        return CallMethod("_lendControlInterpolant");
    }
        
    public JsType _takeBackControlInterpolant(JsType argInterpolant = null)
    {
        return CallMethod("_takeBackControlInterpolant", argInterpolant ?? new JsObject());
    }
        
    public JsAnimationAction ClipAction(JsType argClip = null, JsType argOptionalRoot = null, JsType argBlendMode = null)
    {
        return CallMethod("clipAction", argClip ?? new JsObject(), argOptionalRoot ?? new JsObject(), argBlendMode ?? new JsObject());
    }
        
    public JsType ExistingAction(JsType argClip = null, JsType argOptionalRoot = null)
    {
        return CallMethod("existingAction", argClip ?? new JsObject(), argOptionalRoot ?? new JsObject());
    }
        
    public JsAnimationMixer StopAllAction()
    {
        CallMethodVoid("stopAllAction");
            
        return this;
    }
        
    public JsAnimationMixer Update(JsType argDeltaTime = null)
    {
        CallMethodVoid("update", argDeltaTime ?? new JsObject());
            
        return this;
    }
        
    public JsType SetTime(JsType argTimeInSeconds = null)
    {
        return CallMethod("setTime", argTimeInSeconds ?? new JsObject());
    }
        
    public JsType GetRoot()
    {
        return CallMethod("getRoot");
    }
        
    public JsType UncacheClip(JsType argClip = null)
    {
        return CallMethod("uncacheClip", argClip ?? new JsObject());
    }
        
    public JsType UncacheRoot(JsType argRoot = null)
    {
        return CallMethod("uncacheRoot", argRoot ?? new JsObject());
    }
        
    public JsType UncacheAction(JsType argClip = null, JsType argOptionalRoot = null)
    {
        return CallMethod("uncacheAction", argClip ?? new JsObject(), argOptionalRoot ?? new JsObject());
    }
        
        
}