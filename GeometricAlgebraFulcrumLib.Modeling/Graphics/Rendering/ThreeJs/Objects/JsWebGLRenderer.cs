using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWebGLRendererConstructor :
    JsTypeConstructor
{
        


    internal JsWebGLRendererConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.WebGLRenderer()";
    }
}
    
public partial class JsWebGLRenderer :
    JsObject
{
    public static implicit operator JsWebGLRenderer(string jsTextCode)
    {
        return new JsWebGLRenderer(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWebGLRenderer value)
    {
        return value.GetJsCode();
    }


    private readonly JsWebGLRenderer _jsVariableValue;
    public JsWebGLRenderer JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsWebGLRenderer(JsTypeConstructor jsCodeSource, JsWebGLRenderer jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsWebGLRenderer()
        : base(new JsWebGLRendererConstructor())
    {
    }

        
}