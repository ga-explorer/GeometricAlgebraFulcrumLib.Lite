using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBoxGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Width { get; }
        
    public JsNumber Height { get; }
        
    public JsNumber Depth { get; }
        
    public JsNumber WidthSegments { get; }
        
    public JsNumber HeightSegments { get; }
        
    public JsNumber DepthSegments { get; }
        
        


    internal JsBoxGeometryConstructor(JsNumber argWidth, JsNumber argHeight, JsNumber argDepth, JsNumber argWidthSegments, JsNumber argHeightSegments, JsNumber argDepthSegments)
    {
        Width = argWidth ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        Depth = argDepth ?? (1).AsJsNumber();
        WidthSegments = argWidthSegments ?? (1).AsJsNumber();
        HeightSegments = argHeightSegments ?? (1).AsJsNumber();
        DepthSegments = argDepthSegments ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.BoxGeometry({Width.GetJsCode()}, {Height.GetJsCode()}, {Depth.GetJsCode()}, {WidthSegments.GetJsCode()}, {HeightSegments.GetJsCode()}, {DepthSegments.GetJsCode()})";
    }
}
    
public partial class JsBoxGeometry :
    JsBufferGeometry
{
    public static implicit operator JsBoxGeometry(string jsTextCode)
    {
        return new JsBoxGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBoxGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsBoxGeometry _jsVariableValue;
    public JsBoxGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"BoxGeometry\"";
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

    internal JsBoxGeometry(JsTypeConstructor jsCodeSource, JsBoxGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsBoxGeometry(JsNumber argWidth = null, JsNumber argHeight = null, JsNumber argDepth = null, JsNumber argWidthSegments = null, JsNumber argHeightSegments = null, JsNumber argDepthSegments = null)
        : base(new JsBoxGeometryConstructor(argWidth, argHeight, argDepth, argWidthSegments, argHeightSegments, argDepthSegments))
    {
    }

        
}