using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAnimationLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsAnimationLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AnimationLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsAnimationLoader :
    JsLoader
{
    public static implicit operator JsAnimationLoader(string jsTextCode)
    {
        return new JsAnimationLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAnimationLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsAnimationLoader _jsVariableValue;
    public JsAnimationLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsAnimationLoader(JsTypeConstructor jsCodeSource, JsAnimationLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsAnimationLoader(JsType argManager = null)
        : base(new JsAnimationLoaderConstructor(argManager))
    {
    }

    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
    public JsArray Parse(JsType argJson = null)
    {
        return CallMethod("parse", argJson ?? new JsObject());
    }
        
        
}