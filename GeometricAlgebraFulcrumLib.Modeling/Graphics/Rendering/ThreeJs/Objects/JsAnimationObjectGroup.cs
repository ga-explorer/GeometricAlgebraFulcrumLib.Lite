using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAnimationObjectGroupConstructor :
    JsTypeConstructor
{
        


    internal JsAnimationObjectGroupConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.AnimationObjectGroup()";
    }
}
    
public partial class JsAnimationObjectGroup :
    JsObjectType
{
    public static implicit operator JsAnimationObjectGroup(string jsTextCode)
    {
        return new JsAnimationObjectGroup(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAnimationObjectGroup value)
    {
        return value.GetJsCode();
    }


    private readonly JsAnimationObjectGroup _jsVariableValue;
    public JsAnimationObjectGroup JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _uuid;
    public JsType Uuid
    {
        get => _uuid ?? throw new InvalidOperationException();
        set
        {
            if (_uuid is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uuid = {valueCode};");
        }
    }
        
    private readonly JsNumber _nCachedObjects_;
    public JsNumber NCachedObjects_
    {
        get => _nCachedObjects_ ?? throw new InvalidOperationException();
        set
        {
            if (_nCachedObjects_ is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.nCachedObjects_ = {valueCode};");
        }
    }
        
    private readonly JsType _stats;
    public JsType Stats
    {
        get => _stats ?? throw new InvalidOperationException();
        set
        {
            if (_stats is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stats = {valueCode};");
        }
    }

    internal JsAnimationObjectGroup(JsTypeConstructor jsCodeSource, JsAnimationObjectGroup jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _nCachedObjects_ = $"{variableName}.nCachedObjects_".AsJsNumberVariable();
        _stats = $"{variableName}.stats".AsJsTypeVariable();
    }

    public JsAnimationObjectGroup()
        : base(new JsAnimationObjectGroupConstructor())
    {
    }

    public JsType Add()
    {
        return CallMethod("add");
    }
        
    public JsType Remove()
    {
        return CallMethod("remove");
    }
        
    public JsType Uncache()
    {
        return CallMethod("uncache");
    }
        
    public JsArray Subscribe_(JsType argPath = null, JsType argParsedPath = null)
    {
        return CallMethod("subscribe_", argPath ?? new JsObject(), argParsedPath ?? new JsObject());
    }
        
    public JsType Unsubscribe_(JsType argPath = null)
    {
        return CallMethod("unsubscribe_", argPath ?? new JsObject());
    }
        
        
}