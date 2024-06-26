using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAudioLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsAudioLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AudioLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsAudioLoader :
    JsLoader
{
    public static implicit operator JsAudioLoader(string jsTextCode)
    {
        return new JsAudioLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAudioLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsAudioLoader _jsVariableValue;
    public JsAudioLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsAudioLoader(JsTypeConstructor jsCodeSource, JsAudioLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsAudioLoader(JsType argManager = null)
        : base(new JsAudioLoaderConstructor(argManager))
    {
    }

    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
        
}