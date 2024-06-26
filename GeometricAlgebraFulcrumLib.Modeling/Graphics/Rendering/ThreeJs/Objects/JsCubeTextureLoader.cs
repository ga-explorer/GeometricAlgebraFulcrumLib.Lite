using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCubeTextureLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsCubeTextureLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CubeTextureLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsCubeTextureLoader :
    JsLoader
{
    public static implicit operator JsCubeTextureLoader(string jsTextCode)
    {
        return new JsCubeTextureLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCubeTextureLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsCubeTextureLoader _jsVariableValue;
    public JsCubeTextureLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsCubeTextureLoader(JsTypeConstructor jsCodeSource, JsCubeTextureLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsCubeTextureLoader(JsType argManager = null)
        : base(new JsCubeTextureLoaderConstructor(argManager))
    {
    }

    public JsCubeTexture Load(JsType argUrls = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrls ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
        
}