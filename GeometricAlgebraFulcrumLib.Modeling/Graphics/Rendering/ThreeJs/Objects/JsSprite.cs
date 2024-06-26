using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSpriteConstructor :
    JsTypeConstructor
{
    public JsType Material { get; }
        
        


    internal JsSpriteConstructor(JsType argMaterial)
    {
        Material = argMaterial ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Sprite({Material.GetJsCode()})";
    }
}
    
public partial class JsSprite :
    JsObject3D
{
    public static implicit operator JsSprite(string jsTextCode)
    {
        return new JsSprite(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSprite value)
    {
        return value.GetJsCode();
    }


    private readonly JsSprite _jsVariableValue;
    public JsSprite JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Sprite\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
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
        
    private readonly JsType _center;
    public JsType Center
    {
        get => _center ?? throw new InvalidOperationException();
        set
        {
            if (_center is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.center = {valueCode};");
        }
    }

    internal JsSprite(JsTypeConstructor jsCodeSource, JsSprite jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _material = $"{variableName}.material".AsJsTypeVariable();
        _center = $"{variableName}.center".AsJsTypeVariable();
    }

    public JsSprite(JsType argMaterial = null)
        : base(new JsSpriteConstructor(argMaterial))
    {
    }

    public JsType Raycast(JsType argRaycaster = null, JsType argIntersects = null)
    {
        return CallMethod("raycast", argRaycaster ?? new JsObject(), argIntersects ?? new JsObject());
    }
        
    public JsSprite Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}