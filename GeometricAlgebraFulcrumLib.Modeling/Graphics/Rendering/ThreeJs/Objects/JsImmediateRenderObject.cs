using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsImmediateRenderObjectConstructor :
    JsTypeConstructor
{
    public JsType Material { get; }
        
        


    internal JsImmediateRenderObjectConstructor(JsType argMaterial)
    {
        Material = argMaterial ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ImmediateRenderObject({Material.GetJsCode()})";
    }
}
    
public partial class JsImmediateRenderObject :
    JsObject3D
{
    public static implicit operator JsImmediateRenderObject(string jsTextCode)
    {
        return new JsImmediateRenderObject(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsImmediateRenderObject value)
    {
        return value.GetJsCode();
    }


    private readonly JsImmediateRenderObject _jsVariableValue;
    public JsImmediateRenderObject JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _material;
    public JsType Material
    {
        get => _material ?? throw new InvalidOperationException();
        set
        {
            if (_material is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.material = {valueCode};");
        }
    }
        
    private readonly JsType _render;
    public JsType Render
    {
        get => _render ?? throw new InvalidOperationException();
        set
        {
            if (_render is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.render = {valueCode};");
        }
    }
        
    private readonly JsBoolean _hasPositions;
    public JsBoolean HasPositions
    {
        get => _hasPositions ?? throw new InvalidOperationException();
        set
        {
            if (_hasPositions is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.hasPositions = {valueCode};");
        }
    }
        
    private readonly JsBoolean _hasNormals;
    public JsBoolean HasNormals
    {
        get => _hasNormals ?? throw new InvalidOperationException();
        set
        {
            if (_hasNormals is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.hasNormals = {valueCode};");
        }
    }
        
    private readonly JsBoolean _hasColors;
    public JsBoolean HasColors
    {
        get => _hasColors ?? throw new InvalidOperationException();
        set
        {
            if (_hasColors is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.hasColors = {valueCode};");
        }
    }
        
    private readonly JsBoolean _hasUvs;
    public JsBoolean HasUvs
    {
        get => _hasUvs ?? throw new InvalidOperationException();
        set
        {
            if (_hasUvs is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.hasUvs = {valueCode};");
        }
    }
        
    private readonly JsObject _positionArray;
    public JsObject PositionArray
    {
        get => _positionArray ?? throw new InvalidOperationException();
        set
        {
            if (_positionArray is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.positionArray = {valueCode};");
        }
    }
        
    private readonly JsObject _normalArray;
    public JsObject NormalArray
    {
        get => _normalArray ?? throw new InvalidOperationException();
        set
        {
            if (_normalArray is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normalArray = {valueCode};");
        }
    }
        
    private readonly JsObject _colorArray;
    public JsObject ColorArray
    {
        get => _colorArray ?? throw new InvalidOperationException();
        set
        {
            if (_colorArray is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.colorArray = {valueCode};");
        }
    }
        
    private readonly JsObject _uvArray;
    public JsObject UvArray
    {
        get => _uvArray ?? throw new InvalidOperationException();
        set
        {
            if (_uvArray is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uvArray = {valueCode};");
        }
    }
        
    private readonly JsNumber _count;
    public JsNumber Count
    {
        get => _count ?? throw new InvalidOperationException();
        set
        {
            if (_count is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.count = {valueCode};");
        }
    }

    internal JsImmediateRenderObject(JsTypeConstructor jsCodeSource, JsImmediateRenderObject jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _material = $"{variableName}.material".AsJsTypeVariable();
        _render = $"{variableName}.render".AsJsTypeVariable();
        _hasPositions = $"{variableName}.hasPositions".AsJsBooleanVariable();
        _hasNormals = $"{variableName}.hasNormals".AsJsBooleanVariable();
        _hasColors = $"{variableName}.hasColors".AsJsBooleanVariable();
        _hasUvs = $"{variableName}.hasUvs".AsJsBooleanVariable();
        _positionArray = $"{variableName}.positionArray".AsJsObjectVariable();
        _normalArray = $"{variableName}.normalArray".AsJsObjectVariable();
        _colorArray = $"{variableName}.colorArray".AsJsObjectVariable();
        _uvArray = $"{variableName}.uvArray".AsJsObjectVariable();
        _count = $"{variableName}.count".AsJsNumberVariable();
    }

    public JsImmediateRenderObject(JsType argMaterial = null)
        : base(new JsImmediateRenderObjectConstructor(argMaterial))
    {
    }

        
}