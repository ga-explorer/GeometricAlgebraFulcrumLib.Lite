using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsQuaternionLinearInterpolantConstructor :
    JsTypeConstructor
{
    public JsType ParameterPositions { get; }
        
    public JsType SampleValues { get; }
        
    public JsType SampleSize { get; }
        
    public JsType ResultBuffer { get; }
        
        


    internal JsQuaternionLinearInterpolantConstructor(JsType argParameterPositions, JsType argSampleValues, JsType argSampleSize, JsType argResultBuffer)
    {
        ParameterPositions = argParameterPositions ?? new JsObject();
        SampleValues = argSampleValues ?? new JsObject();
        SampleSize = argSampleSize ?? new JsObject();
        ResultBuffer = argResultBuffer ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.QuaternionLinearInterpolant({ParameterPositions.GetJsCode()}, {SampleValues.GetJsCode()}, {SampleSize.GetJsCode()}, {ResultBuffer.GetJsCode()})";
    }
}
    
public partial class JsQuaternionLinearInterpolant :
    JsInterpolant
{
    public static implicit operator JsQuaternionLinearInterpolant(string jsTextCode)
    {
        return new JsQuaternionLinearInterpolant(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsQuaternionLinearInterpolant value)
    {
        return value.GetJsCode();
    }


    private readonly JsQuaternionLinearInterpolant _jsVariableValue;
    public JsQuaternionLinearInterpolant JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsQuaternionLinearInterpolant(JsTypeConstructor jsCodeSource, JsQuaternionLinearInterpolant jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsQuaternionLinearInterpolant(JsType argParameterPositions = null, JsType argSampleValues = null, JsType argSampleSize = null, JsType argResultBuffer = null)
        : base(new JsQuaternionLinearInterpolantConstructor(argParameterPositions, argSampleValues, argSampleSize, argResultBuffer))
    {
    }

    public JsType Interpolate_(JsType argI1 = null, JsType argT0 = null, JsType argT = null, JsType argT1 = null)
    {
        return CallMethod("interpolate_", argI1 ?? new JsObject(), argT0 ?? new JsObject(), argT ?? new JsObject(), argT1 ?? new JsObject());
    }
        
        
}