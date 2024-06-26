using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInstancedBufferGeometryConstructor :
    JsTypeConstructor
{
        


    internal JsInstancedBufferGeometryConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.InstancedBufferGeometry()";
    }
}
    
public partial class JsInstancedBufferGeometry :
    JsBufferGeometry
{
    public static implicit operator JsInstancedBufferGeometry(string jsTextCode)
    {
        return new JsInstancedBufferGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInstancedBufferGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsInstancedBufferGeometry _jsVariableValue;
    public JsInstancedBufferGeometry JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"InstancedBufferGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _instanceCount;
    public JsType InstanceCount
    {
        get => _instanceCount ?? throw new InvalidOperationException();
        set
        {
            if (_instanceCount is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.instanceCount = {valueCode};");
        }
    }

    internal JsInstancedBufferGeometry(JsTypeConstructor jsCodeSource, JsInstancedBufferGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _instanceCount = $"{variableName}.instanceCount".AsJsTypeVariable();
    }

    public JsInstancedBufferGeometry()
        : base(new JsInstancedBufferGeometryConstructor())
    {
    }

    public JsInstancedBufferGeometry Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}