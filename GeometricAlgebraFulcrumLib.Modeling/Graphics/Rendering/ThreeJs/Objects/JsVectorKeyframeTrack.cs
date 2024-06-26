using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsVectorKeyframeTrackConstructor :
    JsTypeConstructor
{
        


    internal JsVectorKeyframeTrackConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.VectorKeyframeTrack()";
    }
}
    
public partial class JsVectorKeyframeTrack :
    JsKeyframeTrack
{
    public static implicit operator JsVectorKeyframeTrack(string jsTextCode)
    {
        return new JsVectorKeyframeTrack(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsVectorKeyframeTrack value)
    {
        return value.GetJsCode();
    }


    private readonly JsVectorKeyframeTrack _jsVariableValue;
    public JsVectorKeyframeTrack JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsVectorKeyframeTrack(JsTypeConstructor jsCodeSource, JsVectorKeyframeTrack jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsVectorKeyframeTrack()
        : base(new JsVectorKeyframeTrackConstructor())
    {
    }

        
}