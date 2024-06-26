using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsColorKeyframeTrackConstructor :
    JsTypeConstructor
{
        


    internal JsColorKeyframeTrackConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.ColorKeyframeTrack()";
    }
}
    
public partial class JsColorKeyframeTrack :
    JsKeyframeTrack
{
    public static implicit operator JsColorKeyframeTrack(string jsTextCode)
    {
        return new JsColorKeyframeTrack(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsColorKeyframeTrack value)
    {
        return value.GetJsCode();
    }


    private readonly JsColorKeyframeTrack _jsVariableValue;
    public JsColorKeyframeTrack JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsColorKeyframeTrack(JsTypeConstructor jsCodeSource, JsColorKeyframeTrack jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsColorKeyframeTrack()
        : base(new JsColorKeyframeTrackConstructor())
    {
    }

        
}