using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWebXRControllerConstructor :
    JsTypeConstructor
{
        


    internal JsWebXRControllerConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.WebXRController()";
    }
}
    
public partial class JsWebXRController :
    JsObjectType
{
    public static implicit operator JsWebXRController(string jsTextCode)
    {
        return new JsWebXRController(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWebXRController value)
    {
        return value.GetJsCode();
    }


    private readonly JsWebXRController _jsVariableValue;
    public JsWebXRController JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsWebXRController(JsTypeConstructor jsCodeSource, JsWebXRController jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsWebXRController()
        : base(new JsWebXRControllerConstructor())
    {
    }

    public JsType GetHandSpace()
    {
        return CallMethod("getHandSpace");
    }
        
    public JsType GetTargetRaySpace()
    {
        return CallMethod("getTargetRaySpace");
    }
        
    public JsType GetGripSpace()
    {
        return CallMethod("getGripSpace");
    }
        
    public JsWebXRController DispatchEvent(JsType argEvent = null)
    {
        CallMethodVoid("dispatchEvent", argEvent ?? new JsObject());
            
        return this;
    }
        
    public JsWebXRController Disconnect(JsType argInputSource = null)
    {
        CallMethodVoid("disconnect", argInputSource ?? new JsObject());
            
        return this;
    }
        
    public JsWebXRController Update(JsType argInputSource = null, JsType argFrame = null, JsType argReferenceSpace = null)
    {
        CallMethodVoid("update", argInputSource ?? new JsObject(), argFrame ?? new JsObject(), argReferenceSpace ?? new JsObject());
            
        return this;
    }
        
        
}