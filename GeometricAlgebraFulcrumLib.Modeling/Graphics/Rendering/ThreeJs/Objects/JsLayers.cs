using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLayersConstructor :
    JsTypeConstructor
{
        


    internal JsLayersConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Layers()";
    }
}
    
public partial class JsLayers :
    JsObjectType
{
    public static implicit operator JsLayers(string jsTextCode)
    {
        return new JsLayers(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLayers value)
    {
        return value.GetJsCode();
    }


    private readonly JsLayers _jsVariableValue;
    public JsLayers JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _mask;
    public JsType Mask
    {
        get => _mask ?? throw new InvalidOperationException();
        set
        {
            if (_mask is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.mask = {valueCode};");
        }
    }

    internal JsLayers(JsTypeConstructor jsCodeSource, JsLayers jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _mask = $"{variableName}.mask".AsJsTypeVariable();
    }

    public JsLayers()
        : base(new JsLayersConstructor())
    {
    }

    public JsType Set(JsType argChannel = null)
    {
        return CallMethod("set", argChannel ?? new JsObject());
    }
        
    public JsType Enable(JsType argChannel = null)
    {
        return CallMethod("enable", argChannel ?? new JsObject());
    }
        
    public JsType EnableAll()
    {
        return CallMethod("enableAll");
    }
        
    public JsType Toggle(JsType argChannel = null)
    {
        return CallMethod("toggle", argChannel ?? new JsObject());
    }
        
    public JsType Disable(JsType argChannel = null)
    {
        return CallMethod("disable", argChannel ?? new JsObject());
    }
        
    public JsType DisableAll()
    {
        return CallMethod("disableAll");
    }
        
    public JsType Test(JsType argLayers = null)
    {
        return CallMethod("test", argLayers ?? new JsObject());
    }
        
        
}