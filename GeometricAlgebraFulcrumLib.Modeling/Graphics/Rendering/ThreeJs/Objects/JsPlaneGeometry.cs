using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPlaneGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Width { get; }
        
    public JsNumber Height { get; }
        
    public JsNumber WidthSegments { get; }
        
    public JsNumber HeightSegments { get; }
        
        


    internal JsPlaneGeometryConstructor(JsNumber argWidth, JsNumber argHeight, JsNumber argWidthSegments, JsNumber argHeightSegments)
    {
        Width = argWidth ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        WidthSegments = argWidthSegments ?? (1).AsJsNumber();
        HeightSegments = argHeightSegments ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PlaneGeometry({Width.GetJsCode()}, {Height.GetJsCode()}, {WidthSegments.GetJsCode()}, {HeightSegments.GetJsCode()})";
    }
}
    
public partial class JsPlaneGeometry :
    JsBufferGeometry
{
    public static implicit operator JsPlaneGeometry(string jsTextCode)
    {
        return new JsPlaneGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPlaneGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsPlaneGeometry _jsVariableValue;
    public JsPlaneGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"PlaneGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _parameters;
    public JsType Parameters
    {
        get => _parameters ?? throw new InvalidOperationException();
        set
        {
            if (_parameters is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parameters = {valueCode};");
        }
    }

    internal JsPlaneGeometry(JsTypeConstructor jsCodeSource, JsPlaneGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsPlaneGeometry(JsNumber argWidth = null, JsNumber argHeight = null, JsNumber argWidthSegments = null, JsNumber argHeightSegments = null)
        : base(new JsPlaneGeometryConstructor(argWidth, argHeight, argWidthSegments, argHeightSegments))
    {
    }

        
}