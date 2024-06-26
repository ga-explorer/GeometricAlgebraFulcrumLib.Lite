using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsEventDispatcherConstructor :
    JsTypeConstructor
{
        


    internal JsEventDispatcherConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.EventDispatcher()";
    }
}
    
public partial class JsEventDispatcher :
    JsObjectType
{
    public static implicit operator JsEventDispatcher(string jsTextCode)
    {
        return new JsEventDispatcher(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsEventDispatcher value)
    {
        return value.GetJsCode();
    }


    private readonly JsEventDispatcher _jsVariableValue;
    public JsEventDispatcher JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsEventDispatcher(JsTypeConstructor jsCodeSource, JsEventDispatcher jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsEventDispatcher()
        : base(new JsEventDispatcherConstructor())
    {
    }

    public JsType AddEventListener(JsType argType = null, JsType argListener = null)
    {
        return CallMethod("addEventListener", argType ?? new JsObject(), argListener ?? new JsObject());
    }
        
    public JsType HasEventListener(JsType argType = null, JsType argListener = null)
    {
        return CallMethod("hasEventListener", argType ?? new JsObject(), argListener ?? new JsObject());
    }
        
    public JsType RemoveEventListener(JsType argType = null, JsType argListener = null)
    {
        return CallMethod("removeEventListener", argType ?? new JsObject(), argListener ?? new JsObject());
    }
        
    public JsType DispatchEvent(JsType argEvent = null)
    {
        return CallMethod("dispatchEvent", argEvent ?? new JsObject());
    }
        
        
}