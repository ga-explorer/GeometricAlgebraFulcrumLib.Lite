using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLineDashedMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsLineDashedMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LineDashedMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsLineDashedMaterial :
    JsLineBasicMaterial
{
    public static implicit operator JsLineDashedMaterial(string jsTextCode)
    {
        return new JsLineDashedMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLineDashedMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsLineDashedMaterial _jsVariableValue;
    public JsLineDashedMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LineDashedMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _scale;
    public JsNumber Scale
    {
        get => _scale ?? throw new InvalidOperationException();
        set
        {
            if (_scale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.scale = {valueCode};");
        }
    }
        
    private readonly JsNumber _dashSize;
    public JsNumber DashSize
    {
        get => _dashSize ?? throw new InvalidOperationException();
        set
        {
            if (_dashSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "3";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.dashSize = {valueCode};");
        }
    }
        
    private readonly JsNumber _gapSize;
    public JsNumber GapSize
    {
        get => _gapSize ?? throw new InvalidOperationException();
        set
        {
            if (_gapSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.gapSize = {valueCode};");
        }
    }

    internal JsLineDashedMaterial(JsTypeConstructor jsCodeSource, JsLineDashedMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _scale = $"{variableName}.scale".AsJsNumberVariable();
        _dashSize = $"{variableName}.dashSize".AsJsNumberVariable();
        _gapSize = $"{variableName}.gapSize".AsJsNumberVariable();
    }

    public JsLineDashedMaterial(JsType argParameters = null)
        : base(new JsLineDashedMaterialConstructor(argParameters))
    {
    }

    public JsLineDashedMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}