using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsArrayCameraConstructor :
    JsTypeConstructor
{
    public JsArray Array { get; }
        
        


    internal JsArrayCameraConstructor(JsArray argArray)
    {
        Array = argArray ?? new JsArray();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ArrayCamera({Array.GetJsCode()})";
    }
}
    
public partial class JsArrayCamera :
    JsPerspectiveCamera
{
    public static implicit operator JsArrayCamera(string jsTextCode)
    {
        return new JsArrayCamera(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsArrayCamera value)
    {
        return value.GetJsCode();
    }


    private readonly JsArrayCamera _jsVariableValue;
    public JsArrayCamera JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsArray _cameras;
    public JsArray Cameras
    {
        get => _cameras ?? throw new InvalidOperationException();
        set
        {
            if (_cameras is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cameras = {valueCode};");
        }
    }

    internal JsArrayCamera(JsTypeConstructor jsCodeSource, JsArrayCamera jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _cameras = $"{variableName}.cameras".AsJsArrayVariable();
    }

    public JsArrayCamera(JsArray argArray = null)
        : base(new JsArrayCameraConstructor(argArray))
    {
    }

        
}