using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsStringKeyframeTrackConstructor :
    JsTypeConstructor
{
        


    internal JsStringKeyframeTrackConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.StringKeyframeTrack()";
    }
}
    
public partial class JsStringKeyframeTrack :
    JsKeyframeTrack
{
    public static implicit operator JsStringKeyframeTrack(string jsTextCode)
    {
        return new JsStringKeyframeTrack(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsStringKeyframeTrack value)
    {
        return value.GetJsCode();
    }


    private readonly JsStringKeyframeTrack _jsVariableValue;
    public JsStringKeyframeTrack JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsStringKeyframeTrack(JsTypeConstructor jsCodeSource, JsStringKeyframeTrack jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsStringKeyframeTrack()
        : base(new JsStringKeyframeTrackConstructor())
    {
    }

        
}