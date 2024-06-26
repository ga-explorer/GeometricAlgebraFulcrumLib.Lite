using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLineSegmentsConstructor :
    JsTypeConstructor
{
    public JsType Geometry { get; }
        
    public JsType Material { get; }
        
        


    internal JsLineSegmentsConstructor(JsType argGeometry, JsType argMaterial)
    {
        Geometry = argGeometry ?? new JsObject();
        Material = argMaterial ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LineSegments({Geometry.GetJsCode()}, {Material.GetJsCode()})";
    }
}
    
public partial class JsLineSegments :
    JsLine
{
    public static implicit operator JsLineSegments(string jsTextCode)
    {
        return new JsLineSegments(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLineSegments value)
    {
        return value.GetJsCode();
    }


    private readonly JsLineSegments _jsVariableValue;
    public JsLineSegments JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LineSegments\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsLineSegments(JsTypeConstructor jsCodeSource, JsLineSegments jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsLineSegments(JsType argGeometry = null, JsType argMaterial = null)
        : base(new JsLineSegmentsConstructor(argGeometry, argMaterial))
    {
    }

    public JsLineSegments ComputeLineDistances()
    {
        CallMethodVoid("computeLineDistances");
            
        return this;
    }
        
        
}