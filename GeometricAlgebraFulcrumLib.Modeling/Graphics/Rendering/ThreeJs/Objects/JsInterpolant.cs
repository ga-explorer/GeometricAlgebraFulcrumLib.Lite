using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInterpolantConstructor :
    JsTypeConstructor
{
    public JsType ParameterPositions { get; }
        
    public JsType SampleValues { get; }
        
    public JsType SampleSize { get; }
        
    public JsType ResultBuffer { get; }
        
        


    internal JsInterpolantConstructor(JsType argParameterPositions, JsType argSampleValues, JsType argSampleSize, JsType argResultBuffer)
    {
        ParameterPositions = argParameterPositions ?? new JsObject();
        SampleValues = argSampleValues ?? new JsObject();
        SampleSize = argSampleSize ?? new JsObject();
        ResultBuffer = argResultBuffer ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Interpolant({ParameterPositions.GetJsCode()}, {SampleValues.GetJsCode()}, {SampleSize.GetJsCode()}, {ResultBuffer.GetJsCode()})";
    }
}
    
public partial class JsInterpolant :
    JsObjectType
{
    public static implicit operator JsInterpolant(string jsTextCode)
    {
        return new JsInterpolant(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInterpolant value)
    {
        return value.GetJsCode();
    }


    private readonly JsInterpolant _jsVariableValue;
    public JsInterpolant JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _parameterPositions;
    public JsType ParameterPositions
    {
        get => _parameterPositions ?? throw new InvalidOperationException();
        set
        {
            if (_parameterPositions is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parameterPositions = {valueCode};");
        }
    }
        
    private readonly JsType _resultBuffer;
    public JsType ResultBuffer
    {
        get => _resultBuffer ?? throw new InvalidOperationException();
        set
        {
            if (_resultBuffer is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.resultBuffer = {valueCode};");
        }
    }
        
    private readonly JsType _sampleValues;
    public JsType SampleValues
    {
        get => _sampleValues ?? throw new InvalidOperationException();
        set
        {
            if (_sampleValues is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.sampleValues = {valueCode};");
        }
    }
        
    private readonly JsType _valueSize;
    public JsType ValueSize
    {
        get => _valueSize ?? throw new InvalidOperationException();
        set
        {
            if (_valueSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.valueSize = {valueCode};");
        }
    }
        
    private readonly JsObject _settings;
    public JsObject Settings
    {
        get => _settings ?? throw new InvalidOperationException();
        set
        {
            if (_settings is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.settings = {valueCode};");
        }
    }
        
    private readonly JsType _defaultSettings_;
    public JsType DefaultSettings_
    {
        get => _defaultSettings_ ?? throw new InvalidOperationException();
        set
        {
            if (_defaultSettings_ is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.DefaultSettings_ = {valueCode};");
        }
    }

    internal JsInterpolant(JsTypeConstructor jsCodeSource, JsInterpolant jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _parameterPositions = $"{variableName}.parameterPositions".AsJsTypeVariable();
        _resultBuffer = $"{variableName}.resultBuffer".AsJsTypeVariable();
        _sampleValues = $"{variableName}.sampleValues".AsJsTypeVariable();
        _valueSize = $"{variableName}.valueSize".AsJsTypeVariable();
        _settings = $"{variableName}.settings".AsJsObjectVariable();
        _defaultSettings_ = $"{variableName}.DefaultSettings_".AsJsTypeVariable();
    }

    public JsInterpolant(JsType argParameterPositions = null, JsType argSampleValues = null, JsType argSampleSize = null, JsType argResultBuffer = null)
        : base(new JsInterpolantConstructor(argParameterPositions, argSampleValues, argSampleSize, argResultBuffer))
    {
    }

    public JsType Evaluate(JsType argT = null)
    {
        return CallMethod("evaluate", argT ?? new JsObject());
    }
        
    public JsType GetSettings_()
    {
        return CallMethod("getSettings_");
    }
        
    public JsType CopySampleValue_(JsType argIndex = null)
    {
        return CallMethod("copySampleValue_", argIndex ?? new JsObject());
    }
        
    public JsType Interpolate_()
    {
        return CallMethod("interpolate_");
    }
        
    public JsType IntervalChanged_()
    {
        return CallMethod("intervalChanged_");
    }
        
        
}