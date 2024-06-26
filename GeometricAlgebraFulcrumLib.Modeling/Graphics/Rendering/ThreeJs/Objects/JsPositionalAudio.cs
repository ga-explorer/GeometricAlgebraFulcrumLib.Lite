using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPositionalAudioConstructor :
    JsTypeConstructor
{
    public JsType Listener { get; }
        
        


    internal JsPositionalAudioConstructor(JsType argListener)
    {
        Listener = argListener ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PositionalAudio({Listener.GetJsCode()})";
    }
}
    
public partial class JsPositionalAudio :
    JsAudio
{
    public static implicit operator JsPositionalAudio(string jsTextCode)
    {
        return new JsPositionalAudio(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPositionalAudio value)
    {
        return value.GetJsCode();
    }


    private readonly JsPositionalAudio _jsVariableValue;
    public JsPositionalAudio JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _panner;
    public JsType Panner
    {
        get => _panner ?? throw new InvalidOperationException();
        set
        {
            if (_panner is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.panner = {valueCode};");
        }
    }

    internal JsPositionalAudio(JsTypeConstructor jsCodeSource, JsPositionalAudio jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _panner = $"{variableName}.panner".AsJsTypeVariable();
    }

    public JsPositionalAudio(JsType argListener = null)
        : base(new JsPositionalAudioConstructor(argListener))
    {
    }

    public JsType GetOutput()
    {
        return CallMethod("getOutput");
    }
        
    public JsType GetRefDistance()
    {
        return CallMethod("getRefDistance");
    }
        
    public JsPositionalAudio SetRefDistance(JsType argValue = null)
    {
        CallMethodVoid("setRefDistance", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetRolloffFactor()
    {
        return CallMethod("getRolloffFactor");
    }
        
    public JsPositionalAudio SetRolloffFactor(JsType argValue = null)
    {
        CallMethodVoid("setRolloffFactor", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetDistanceModel()
    {
        return CallMethod("getDistanceModel");
    }
        
    public JsPositionalAudio SetDistanceModel(JsType argValue = null)
    {
        CallMethodVoid("setDistanceModel", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetMaxDistance()
    {
        return CallMethod("getMaxDistance");
    }
        
    public JsPositionalAudio SetMaxDistance(JsType argValue = null)
    {
        CallMethodVoid("setMaxDistance", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsPositionalAudio SetDirectionalCone(JsType argConeInnerAngle = null, JsType argConeOuterAngle = null, JsType argConeOuterGain = null)
    {
        CallMethodVoid("setDirectionalCone", argConeInnerAngle ?? new JsObject(), argConeOuterAngle ?? new JsObject(), argConeOuterGain ?? new JsObject());
            
        return this;
    }
        
    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
        
}