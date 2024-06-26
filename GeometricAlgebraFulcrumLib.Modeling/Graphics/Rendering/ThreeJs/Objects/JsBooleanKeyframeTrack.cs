using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBooleanKeyframeTrackConstructor :
    JsTypeConstructor
{
        


    internal JsBooleanKeyframeTrackConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.BooleanKeyframeTrack()";
    }
}
    
public partial class JsBooleanKeyframeTrack :
    JsKeyframeTrack
{
    public static implicit operator JsBooleanKeyframeTrack(string jsTextCode)
    {
        return new JsBooleanKeyframeTrack(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBooleanKeyframeTrack value)
    {
        return value.GetJsCode();
    }


    private readonly JsBooleanKeyframeTrack _jsVariableValue;
    public JsBooleanKeyframeTrack JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsBooleanKeyframeTrack(JsTypeConstructor jsCodeSource, JsBooleanKeyframeTrack jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsBooleanKeyframeTrack()
        : base(new JsBooleanKeyframeTrackConstructor())
    {
    }

        
}