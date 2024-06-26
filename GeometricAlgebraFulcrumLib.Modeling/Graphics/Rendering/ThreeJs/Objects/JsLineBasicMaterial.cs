using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLineBasicMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsLineBasicMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LineBasicMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsLineBasicMaterial :
    JsMaterial
{
    public static implicit operator JsLineBasicMaterial(string jsTextCode)
    {
        return new JsLineBasicMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLineBasicMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsLineBasicMaterial _jsVariableValue;
    public JsLineBasicMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LineBasicMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _color;
    public JsType Color
    {
        get => _color ?? throw new InvalidOperationException();
        set
        {
            if (_color is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.color = {valueCode};");
        }
    }
        
    private readonly JsNumber _linewidth;
    public JsNumber Linewidth
    {
        get => _linewidth ?? throw new InvalidOperationException();
        set
        {
            if (_linewidth is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.linewidth = {valueCode};");
        }
    }
        
    private readonly JsString _linecap;
    public JsString Linecap
    {
        get => _linecap ?? throw new InvalidOperationException();
        set
        {
            if (_linecap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"round\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.linecap = {valueCode};");
        }
    }
        
    private readonly JsString _linejoin;
    public JsString Linejoin
    {
        get => _linejoin ?? throw new InvalidOperationException();
        set
        {
            if (_linejoin is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"round\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.linejoin = {valueCode};");
        }
    }

    internal JsLineBasicMaterial(JsTypeConstructor jsCodeSource, JsLineBasicMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _linewidth = $"{variableName}.linewidth".AsJsNumberVariable();
        _linecap = $"{variableName}.linecap".AsJsStringVariable();
        _linejoin = $"{variableName}.linejoin".AsJsStringVariable();
    }

    public JsLineBasicMaterial(JsType argParameters = null)
        : base(new JsLineBasicMaterialConstructor(argParameters))
    {
    }

    public JsLineBasicMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}