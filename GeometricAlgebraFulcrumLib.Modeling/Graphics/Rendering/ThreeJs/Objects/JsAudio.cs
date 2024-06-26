using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAudioConstructor :
    JsTypeConstructor
{
    public JsType Listener { get; }
        
        


    internal JsAudioConstructor(JsType argListener)
    {
        Listener = argListener ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Audio({Listener.GetJsCode()})";
    }
}
    
public partial class JsAudio :
    JsObject3D
{
    public static implicit operator JsAudio(string jsTextCode)
    {
        return new JsAudio(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAudio value)
    {
        return value.GetJsCode();
    }


    private readonly JsAudio _jsVariableValue;
    public JsAudio JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Audio\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _listener;
    public JsType Listener
    {
        get => _listener ?? throw new InvalidOperationException();
        set
        {
            if (_listener is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.listener = {valueCode};");
        }
    }
        
    private readonly JsType _context;
    public JsType Context
    {
        get => _context ?? throw new InvalidOperationException();
        set
        {
            if (_context is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.context = {valueCode};");
        }
    }
        
    private readonly JsType _gain;
    public JsType Gain
    {
        get => _gain ?? throw new InvalidOperationException();
        set
        {
            if (_gain is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.gain = {valueCode};");
        }
    }
        
    private readonly JsBoolean _autoplay;
    public JsBoolean Autoplay
    {
        get => _autoplay ?? throw new InvalidOperationException();
        set
        {
            if (_autoplay is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.autoplay = {valueCode};");
        }
    }
        
    private readonly JsType _buffer;
    public JsType Buffer
    {
        get => _buffer ?? throw new InvalidOperationException();
        set
        {
            if (_buffer is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.buffer = {valueCode};");
        }
    }
        
    private readonly JsNumber _detune;
    public JsNumber Detune
    {
        get => _detune ?? throw new InvalidOperationException();
        set
        {
            if (_detune is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.detune = {valueCode};");
        }
    }
        
    private readonly JsBoolean _loop;
    public JsBoolean Loop
    {
        get => _loop ?? throw new InvalidOperationException();
        set
        {
            if (_loop is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.loop = {valueCode};");
        }
    }
        
    private readonly JsNumber _loopStart;
    public JsNumber LoopStart
    {
        get => _loopStart ?? throw new InvalidOperationException();
        set
        {
            if (_loopStart is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.loopStart = {valueCode};");
        }
    }
        
    private readonly JsNumber _loopEnd;
    public JsNumber LoopEnd
    {
        get => _loopEnd ?? throw new InvalidOperationException();
        set
        {
            if (_loopEnd is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.loopEnd = {valueCode};");
        }
    }
        
    private readonly JsNumber _offset;
    public JsNumber Offset
    {
        get => _offset ?? throw new InvalidOperationException();
        set
        {
            if (_offset is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.offset = {valueCode};");
        }
    }
        
    private readonly JsNumber _playbackRate;
    public JsNumber PlaybackRate
    {
        get => _playbackRate ?? throw new InvalidOperationException();
        set
        {
            if (_playbackRate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.playbackRate = {valueCode};");
        }
    }
        
    private readonly JsBoolean _isPlaying;
    public JsBoolean IsPlaying
    {
        get => _isPlaying ?? throw new InvalidOperationException();
        set
        {
            if (_isPlaying is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.isPlaying = {valueCode};");
        }
    }
        
    private readonly JsBoolean _hasPlaybackControl;
    public JsBoolean HasPlaybackControl
    {
        get => _hasPlaybackControl ?? throw new InvalidOperationException();
        set
        {
            if (_hasPlaybackControl is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.hasPlaybackControl = {valueCode};");
        }
    }
        
    private readonly JsType _source;
    public JsType Source
    {
        get => _source ?? throw new InvalidOperationException();
        set
        {
            if (_source is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.source = {valueCode};");
        }
    }
        
    private readonly JsString _sourceType;
    public JsString SourceType
    {
        get => _sourceType ?? throw new InvalidOperationException();
        set
        {
            if (_sourceType is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"empty\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sourceType = {valueCode};");
        }
    }
        
    private readonly JsType _filters;
    public JsType Filters
    {
        get => _filters ?? throw new InvalidOperationException();
        set
        {
            if (_filters is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.filters = {valueCode};");
        }
    }

    internal JsAudio(JsTypeConstructor jsCodeSource, JsAudio jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _listener = $"{variableName}.listener".AsJsTypeVariable();
        _context = $"{variableName}.context".AsJsTypeVariable();
        _gain = $"{variableName}.gain".AsJsTypeVariable();
        _autoplay = $"{variableName}.autoplay".AsJsBooleanVariable();
        _buffer = $"{variableName}.buffer".AsJsTypeVariable();
        _detune = $"{variableName}.detune".AsJsNumberVariable();
        _loop = $"{variableName}.loop".AsJsBooleanVariable();
        _loopStart = $"{variableName}.loopStart".AsJsNumberVariable();
        _loopEnd = $"{variableName}.loopEnd".AsJsNumberVariable();
        _offset = $"{variableName}.offset".AsJsNumberVariable();
        _playbackRate = $"{variableName}.playbackRate".AsJsNumberVariable();
        _isPlaying = $"{variableName}.isPlaying".AsJsBooleanVariable();
        _hasPlaybackControl = $"{variableName}.hasPlaybackControl".AsJsBooleanVariable();
        _source = $"{variableName}.source".AsJsTypeVariable();
        _sourceType = $"{variableName}.sourceType".AsJsStringVariable();
        _filters = $"{variableName}.filters".AsJsTypeVariable();
    }

    public JsAudio(JsType argListener = null)
        : base(new JsAudioConstructor(argListener))
    {
    }

    public JsType GetOutput()
    {
        return CallMethod("getOutput");
    }
        
    public JsAudio SetNodeSource(JsType argAudioNode = null)
    {
        CallMethodVoid("setNodeSource", argAudioNode ?? new JsObject());
            
        return this;
    }
        
    public JsAudio SetMediaElementSource(JsType argMediaElement = null)
    {
        CallMethodVoid("setMediaElementSource", argMediaElement ?? new JsObject());
            
        return this;
    }
        
    public JsAudio SetMediaStreamSource(JsType argMediaStream = null)
    {
        CallMethodVoid("setMediaStreamSource", argMediaStream ?? new JsObject());
            
        return this;
    }
        
    public JsAudio SetBuffer(JsType argAudioBuffer = null)
    {
        CallMethodVoid("setBuffer", argAudioBuffer ?? new JsObject());
            
        return this;
    }
        
    public JsType Play(JsNumber argDelay = null)
    {
        return CallMethod("play", argDelay ?? (0).AsJsNumber());
    }
        
    public JsAudio Pause()
    {
        CallMethodVoid("pause");
            
        return this;
    }
        
    public JsAudio Stop()
    {
        CallMethodVoid("stop");
            
        return this;
    }
        
    public JsAudio Connect()
    {
        CallMethodVoid("connect");
            
        return this;
    }
        
    public JsAudio Disconnect()
    {
        CallMethodVoid("disconnect");
            
        return this;
    }
        
    public JsType GetFilters()
    {
        return CallMethod("getFilters");
    }
        
    public JsAudio SetFilters(JsType argValue = null)
    {
        CallMethodVoid("setFilters", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsAudio SetDetune(JsType argValue = null)
    {
        CallMethodVoid("setDetune", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetDetune()
    {
        return CallMethod("getDetune");
    }
        
    public JsType GetFilter()
    {
        return CallMethod("getFilter");
    }
        
    public JsType SetFilter(JsType argFilter = null)
    {
        return CallMethod("setFilter", argFilter ?? new JsObject());
    }
        
    public JsAudio SetPlaybackRate(JsType argValue = null)
    {
        CallMethodVoid("setPlaybackRate", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetPlaybackRate()
    {
        return CallMethod("getPlaybackRate");
    }
        
    public JsType OnEnded()
    {
        return CallMethod("onEnded");
    }
        
    public JsType GetLoop()
    {
        return CallMethod("getLoop");
    }
        
    public JsAudio SetLoop(JsType argValue = null)
    {
        CallMethodVoid("setLoop", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsAudio SetLoopStart(JsType argValue = null)
    {
        CallMethodVoid("setLoopStart", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsAudio SetLoopEnd(JsType argValue = null)
    {
        CallMethodVoid("setLoopEnd", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetVolume()
    {
        return CallMethod("getVolume");
    }
        
    public JsAudio SetVolume(JsType argValue = null)
    {
        CallMethodVoid("setVolume", argValue ?? new JsObject());
            
        return this;
    }
        
        
}