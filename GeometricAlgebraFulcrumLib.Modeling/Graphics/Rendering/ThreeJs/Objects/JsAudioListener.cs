using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAudioListenerConstructor :
    JsTypeConstructor
{
        


    internal JsAudioListenerConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.AudioListener()";
    }
}
    
public partial class JsAudioListener :
    JsObject3D
{
    public static implicit operator JsAudioListener(string jsTextCode)
    {
        return new JsAudioListener(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAudioListener value)
    {
        return value.GetJsCode();
    }


    private readonly JsAudioListener _jsVariableValue;
    public JsAudioListener JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"AudioListener\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
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
        
    private readonly JsType _filter;
    public JsType Filter
    {
        get => _filter ?? throw new InvalidOperationException();
        set
        {
            if (_filter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.filter = {valueCode};");
        }
    }
        
    private readonly JsNumber _timeDelta;
    public JsNumber TimeDelta
    {
        get => _timeDelta ?? throw new InvalidOperationException();
        set
        {
            if (_timeDelta is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.timeDelta = {valueCode};");
        }
    }

    internal JsAudioListener(JsTypeConstructor jsCodeSource, JsAudioListener jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _context = $"{variableName}.context".AsJsTypeVariable();
        _gain = $"{variableName}.gain".AsJsTypeVariable();
        _filter = $"{variableName}.filter".AsJsTypeVariable();
        _timeDelta = $"{variableName}.timeDelta".AsJsNumberVariable();
    }

    public JsAudioListener()
        : base(new JsAudioListenerConstructor())
    {
    }

    public JsType GetInput()
    {
        return CallMethod("getInput");
    }
        
    public JsAudioListener RemoveFilter()
    {
        CallMethodVoid("removeFilter");
            
        return this;
    }
        
    public JsType GetFilter()
    {
        return CallMethod("getFilter");
    }
        
    public JsAudioListener SetFilter(JsType argValue = null)
    {
        CallMethodVoid("setFilter", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetMasterVolume()
    {
        return CallMethod("getMasterVolume");
    }
        
    public JsAudioListener SetMasterVolume(JsType argValue = null)
    {
        CallMethodVoid("setMasterVolume", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
        
}