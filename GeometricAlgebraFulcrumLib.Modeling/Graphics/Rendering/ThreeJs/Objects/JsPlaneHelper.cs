using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPlaneHelperConstructor :
    JsTypeConstructor
{
    public JsType Plane { get; }
        
    public JsNumber Size { get; }
        
    public JsNumber Hex { get; }
        
        


    internal JsPlaneHelperConstructor(JsType argPlane, JsNumber argSize, JsNumber argHex)
    {
        Plane = argPlane ?? new JsObject();
        Size = argSize ?? (1).AsJsNumber();
        Hex = argHex ?? (16776960).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PlaneHelper({Plane.GetJsCode()}, {Size.GetJsCode()}, {Hex.GetJsCode()})";
    }
}
    
public partial class JsPlaneHelper :
    JsLine
{
    public static implicit operator JsPlaneHelper(string jsTextCode)
    {
        return new JsPlaneHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPlaneHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsPlaneHelper _jsVariableValue;
    public JsPlaneHelper JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"PlaneHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _plane;
    public JsType Plane
    {
        get => _plane ?? throw new InvalidOperationException();
        set
        {
            if (_plane is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.plane = {valueCode};");
        }
    }
        
    private readonly JsNumber _size;
    public JsNumber Size
    {
        get => _size ?? throw new InvalidOperationException();
        set
        {
            if (_size is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.size = {valueCode};");
        }
    }

    internal JsPlaneHelper(JsTypeConstructor jsCodeSource, JsPlaneHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _plane = $"{variableName}.plane".AsJsTypeVariable();
        _size = $"{variableName}.size".AsJsNumberVariable();
    }

    public JsPlaneHelper(JsType argPlane = null, JsNumber argSize = null, JsNumber argHex = null)
        : base(new JsPlaneHelperConstructor(argPlane, argSize, argHex))
    {
    }

    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
        
}