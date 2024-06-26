using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsClockConstructor :
    JsTypeConstructor
{
    public JsBoolean AutoStart { get; }
        
        


    internal JsClockConstructor(JsBoolean argAutoStart)
    {
        AutoStart = argAutoStart ?? (true).AsJsBoolean();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Clock({AutoStart.GetJsCode()})";
    }
}
    
public partial class JsClock :
    JsObjectType
{
    public static implicit operator JsClock(string jsTextCode)
    {
        return new JsClock(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsClock value)
    {
        return value.GetJsCode();
    }


    private readonly JsClock _jsVariableValue;
    public JsClock JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsBoolean _autoStart;
    public JsBoolean AutoStart
    {
        get => _autoStart ?? throw new InvalidOperationException();
        set
        {
            if (_autoStart is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.autoStart = {valueCode};");
        }
    }
        
    private readonly JsNumber _startTime;
    public JsNumber StartTime
    {
        get => _startTime ?? throw new InvalidOperationException();
        set
        {
            if (_startTime is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.startTime = {valueCode};");
        }
    }
        
    private readonly JsNumber _oldTime;
    public JsNumber OldTime
    {
        get => _oldTime ?? throw new InvalidOperationException();
        set
        {
            if (_oldTime is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.oldTime = {valueCode};");
        }
    }
        
    private readonly JsNumber _elapsedTime;
    public JsNumber ElapsedTime
    {
        get => _elapsedTime ?? throw new InvalidOperationException();
        set
        {
            if (_elapsedTime is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.elapsedTime = {valueCode};");
        }
    }
        
    private readonly JsBoolean _running;
    public JsBoolean Running
    {
        get => _running ?? throw new InvalidOperationException();
        set
        {
            if (_running is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.running = {valueCode};");
        }
    }

    internal JsClock(JsTypeConstructor jsCodeSource, JsClock jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _autoStart = $"{variableName}.autoStart".AsJsBooleanVariable();
        _startTime = $"{variableName}.startTime".AsJsNumberVariable();
        _oldTime = $"{variableName}.oldTime".AsJsNumberVariable();
        _elapsedTime = $"{variableName}.elapsedTime".AsJsNumberVariable();
        _running = $"{variableName}.running".AsJsBooleanVariable();
    }

    public JsClock(JsBoolean argAutoStart = null)
        : base(new JsClockConstructor(argAutoStart))
    {
    }

    public JsType Start()
    {
        return CallMethod("start");
    }
        
    public JsType Stop()
    {
        return CallMethod("stop");
    }
        
    public JsType GetElapsedTime()
    {
        return CallMethod("getElapsedTime");
    }
        
    public JsType GetDelta()
    {
        return CallMethod("getDelta");
    }
        
        
}