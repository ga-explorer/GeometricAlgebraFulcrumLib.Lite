namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public class JsFloat32Array :
    JsObjectType
{
    internal sealed class JsFloat32ArrayConstructor :
        JsTypeConstructor
    {
        public JsNumber Size { get; }


        internal JsFloat32ArrayConstructor()
        {
            Size = null;
        }

        internal JsFloat32ArrayConstructor(JsNumber argSize)
        {
            Size = argSize;
        }

        public override string GetJsCode()
        {
            if (Size is null)
                return "new Float32Array()";

            return $"new Float32Array({Size.GetJsCode()})";
        }
    }
        

    public static implicit operator JsFloat32Array(string jsTextCode)
    {
        return new JsFloat32Array(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsFloat32Array value)
    {
        return value.GetJsCode();
    }


    private readonly JsFloat32Array _jsVariableValue;
    public JsFloat32Array JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;


    public JsFloat32Array(JsTypeConstructor jsCodeSource, JsFloat32Array jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
    }

    public JsFloat32Array(JsNumber argSize = null)
        : base(new JsFloat32ArrayConstructor(argSize))
    {

    }
}