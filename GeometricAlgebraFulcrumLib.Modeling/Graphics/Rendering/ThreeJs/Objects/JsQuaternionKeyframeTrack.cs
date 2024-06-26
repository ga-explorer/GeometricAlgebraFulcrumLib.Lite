using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsQuaternionKeyframeTrackConstructor :
    JsTypeConstructor
{
        


    internal JsQuaternionKeyframeTrackConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.QuaternionKeyframeTrack()";
    }
}
    
public partial class JsQuaternionKeyframeTrack :
    JsKeyframeTrack
{
    public static implicit operator JsQuaternionKeyframeTrack(string jsTextCode)
    {
        return new JsQuaternionKeyframeTrack(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsQuaternionKeyframeTrack value)
    {
        return value.GetJsCode();
    }


    private readonly JsQuaternionKeyframeTrack _jsVariableValue;
    public JsQuaternionKeyframeTrack JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsQuaternionKeyframeTrack(JsTypeConstructor jsCodeSource, JsQuaternionKeyframeTrack jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsQuaternionKeyframeTrack()
        : base(new JsQuaternionKeyframeTrackConstructor())
    {
    }

    public JsType InterpolantFactoryMethodLinear(JsType argResult = null)
    {
        return CallMethod("InterpolantFactoryMethodLinear", argResult ?? new JsObject());
    }
        
        
}