using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCompositeConstructor :
    JsTypeConstructor
{
    public JsType TargetGroup { get; }
        
    public JsType Path { get; }
        
    public JsType OptionalParsedPath { get; }
        
        


    internal JsCompositeConstructor(JsType argTargetGroup, JsType argPath, JsType argOptionalParsedPath)
    {
        TargetGroup = argTargetGroup ?? new JsObject();
        Path = argPath ?? new JsObject();
        OptionalParsedPath = argOptionalParsedPath ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Composite({TargetGroup.GetJsCode()}, {Path.GetJsCode()}, {OptionalParsedPath.GetJsCode()})";
    }
}
    
public partial class JsComposite :
    JsObjectType
{
    public static implicit operator JsComposite(string jsTextCode)
    {
        return new JsComposite(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsComposite value)
    {
        return value.GetJsCode();
    }


    private readonly JsComposite _jsVariableValue;
    public JsComposite JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsComposite(JsTypeConstructor jsCodeSource, JsComposite jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsComposite(JsType argTargetGroup = null, JsType argPath = null, JsType argOptionalParsedPath = null)
        : base(new JsCompositeConstructor(argTargetGroup, argPath, argOptionalParsedPath))
    {
    }

    public JsType GetValue(JsType argArray = null, JsType argOffset = null)
    {
        return CallMethod("getValue", argArray ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType SetValue(JsType argArray = null, JsType argOffset = null)
    {
        return CallMethod("setValue", argArray ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType Bind()
    {
        return CallMethod("bind");
    }
        
    public JsType Unbind()
    {
        return CallMethod("unbind");
    }
        
        
}