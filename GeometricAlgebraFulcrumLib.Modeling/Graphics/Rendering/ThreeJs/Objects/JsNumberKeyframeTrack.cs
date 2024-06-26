using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsNumberKeyframeTrackConstructor :
    JsTypeConstructor
{
        


    internal JsNumberKeyframeTrackConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.NumberKeyframeTrack()";
    }
}
    
public partial class JsNumberKeyframeTrack :
    JsKeyframeTrack
{
    public static implicit operator JsNumberKeyframeTrack(string jsTextCode)
    {
        return new JsNumberKeyframeTrack(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsNumberKeyframeTrack value)
    {
        return value.GetJsCode();
    }


    private readonly JsNumberKeyframeTrack _jsVariableValue;
    public JsNumberKeyframeTrack JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsNumberKeyframeTrack(JsTypeConstructor jsCodeSource, JsNumberKeyframeTrack jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsNumberKeyframeTrack()
        : base(new JsNumberKeyframeTrackConstructor())
    {
    }

        
}