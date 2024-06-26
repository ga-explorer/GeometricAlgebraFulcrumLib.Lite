using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAudioAnalyserConstructor :
    JsTypeConstructor
{
    public JsType Audio { get; }
        
    public JsNumber FftSize { get; }
        
        


    internal JsAudioAnalyserConstructor(JsType argAudio, JsNumber argFftSize)
    {
        Audio = argAudio ?? new JsObject();
        FftSize = argFftSize ?? (2048).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AudioAnalyser({Audio.GetJsCode()}, {FftSize.GetJsCode()})";
    }
}
    
public partial class JsAudioAnalyser :
    JsObjectType
{
    public static implicit operator JsAudioAnalyser(string jsTextCode)
    {
        return new JsAudioAnalyser(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAudioAnalyser value)
    {
        return value.GetJsCode();
    }


    private readonly JsAudioAnalyser _jsVariableValue;
    public JsAudioAnalyser JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _analyser;
    public JsType Analyser
    {
        get => _analyser ?? throw new InvalidOperationException();
        set
        {
            if (_analyser is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.analyser = {valueCode};");
        }
    }
        
    private readonly JsType _data;
    public JsType Data
    {
        get => _data ?? throw new InvalidOperationException();
        set
        {
            if (_data is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.data = {valueCode};");
        }
    }

    internal JsAudioAnalyser(JsTypeConstructor jsCodeSource, JsAudioAnalyser jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _analyser = $"{variableName}.analyser".AsJsTypeVariable();
        _data = $"{variableName}.data".AsJsTypeVariable();
    }

    public JsAudioAnalyser(JsType argAudio = null, JsNumber argFftSize = null)
        : base(new JsAudioAnalyserConstructor(argAudio, argFftSize))
    {
    }

    public JsType GetFrequencyData()
    {
        return CallMethod("getFrequencyData");
    }
        
    public JsType GetAverageFrequency()
    {
        return CallMethod("getAverageFrequency");
    }
        
        
}