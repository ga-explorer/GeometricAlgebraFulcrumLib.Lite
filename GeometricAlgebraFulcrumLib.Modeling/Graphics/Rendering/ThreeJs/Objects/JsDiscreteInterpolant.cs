using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDiscreteInterpolantConstructor :
    JsTypeConstructor
{
    public JsType ParameterPositions { get; }
        
    public JsType SampleValues { get; }
        
    public JsType SampleSize { get; }
        
    public JsType ResultBuffer { get; }
        
        


    internal JsDiscreteInterpolantConstructor(JsType argParameterPositions, JsType argSampleValues, JsType argSampleSize, JsType argResultBuffer)
    {
        ParameterPositions = argParameterPositions ?? new JsObject();
        SampleValues = argSampleValues ?? new JsObject();
        SampleSize = argSampleSize ?? new JsObject();
        ResultBuffer = argResultBuffer ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DiscreteInterpolant({ParameterPositions.GetJsCode()}, {SampleValues.GetJsCode()}, {SampleSize.GetJsCode()}, {ResultBuffer.GetJsCode()})";
    }
}
    
public partial class JsDiscreteInterpolant :
    JsInterpolant
{
    public static implicit operator JsDiscreteInterpolant(string jsTextCode)
    {
        return new JsDiscreteInterpolant(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDiscreteInterpolant value)
    {
        return value.GetJsCode();
    }


    private readonly JsDiscreteInterpolant _jsVariableValue;
    public JsDiscreteInterpolant JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsDiscreteInterpolant(JsTypeConstructor jsCodeSource, JsDiscreteInterpolant jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsDiscreteInterpolant(JsType argParameterPositions = null, JsType argSampleValues = null, JsType argSampleSize = null, JsType argResultBuffer = null)
        : base(new JsDiscreteInterpolantConstructor(argParameterPositions, argSampleValues, argSampleSize, argResultBuffer))
    {
    }

    public JsType Interpolate_(JsType argI1 = null)
    {
        return CallMethod("interpolate_", argI1 ?? new JsObject());
    }
        
        
}