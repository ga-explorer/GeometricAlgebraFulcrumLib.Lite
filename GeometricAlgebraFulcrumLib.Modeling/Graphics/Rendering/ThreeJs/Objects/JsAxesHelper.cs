using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsAxesHelperConstructor :
    JsTypeConstructor
{
    public JsNumber Size { get; }
        
        


    internal JsAxesHelperConstructor(JsNumber argSize)
    {
        Size = argSize ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.AxesHelper({Size.GetJsCode()})";
    }
}
    
public partial class JsAxesHelper :
    JsLineSegments
{
    public static implicit operator JsAxesHelper(string jsTextCode)
    {
        return new JsAxesHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsAxesHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsAxesHelper _jsVariableValue;
    public JsAxesHelper JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"AxesHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsAxesHelper(JsTypeConstructor jsCodeSource, JsAxesHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsAxesHelper(JsNumber argSize = null)
        : base(new JsAxesHelperConstructor(argSize))
    {
    }

    public JsAxesHelper SetColors(JsType argXAxisColor = null, JsType argYAxisColor = null, JsType argZAxisColor = null)
    {
        CallMethodVoid("setColors", argXAxisColor ?? new JsObject(), argYAxisColor ?? new JsObject(), argZAxisColor ?? new JsObject());
            
        return this;
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
        
}