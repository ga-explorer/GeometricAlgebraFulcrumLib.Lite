using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBufferGeometryLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsBufferGeometryLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.BufferGeometryLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsBufferGeometryLoader :
    JsLoader
{
    public static implicit operator JsBufferGeometryLoader(string jsTextCode)
    {
        return new JsBufferGeometryLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBufferGeometryLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsBufferGeometryLoader _jsVariableValue;
    public JsBufferGeometryLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsBufferGeometryLoader(JsTypeConstructor jsCodeSource, JsBufferGeometryLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsBufferGeometryLoader(JsType argManager = null)
        : base(new JsBufferGeometryLoaderConstructor(argManager))
    {
    }

    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
    public JsType Parse(JsType argJson = null)
    {
        return CallMethod("parse", argJson ?? new JsObject());
    }
        
        
}