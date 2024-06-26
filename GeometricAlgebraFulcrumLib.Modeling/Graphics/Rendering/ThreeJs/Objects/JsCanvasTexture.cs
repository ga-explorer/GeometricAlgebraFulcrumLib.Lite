using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCanvasTextureConstructor :
    JsTypeConstructor
{
    public JsType Canvas { get; }
        
    public JsType Mapping { get; }
        
    public JsType WrapS { get; }
        
    public JsType WrapT { get; }
        
    public JsType MagFilter { get; }
        
    public JsType MinFilter { get; }
        
    public JsType Format { get; }
        
    public JsType Type { get; }
        
    public JsType Anisotropy { get; }
        
        


    internal JsCanvasTextureConstructor(JsType argCanvas, JsType argMapping, JsType argWrapS, JsType argWrapT, JsType argMagFilter, JsType argMinFilter, JsType argFormat, JsType argType, JsType argAnisotropy)
    {
        Canvas = argCanvas ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? new JsObject();
        WrapT = argWrapT ?? new JsObject();
        MagFilter = argMagFilter ?? new JsObject();
        MinFilter = argMinFilter ?? new JsObject();
        Format = argFormat ?? new JsObject();
        Type = argType ?? new JsObject();
        Anisotropy = argAnisotropy ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CanvasTexture({Canvas.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Format.GetJsCode()}, {Type.GetJsCode()}, {Anisotropy.GetJsCode()})";
    }
}
    
public partial class JsCanvasTexture :
    JsTexture
{
    public static implicit operator JsCanvasTexture(string jsTextCode)
    {
        return new JsCanvasTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCanvasTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsCanvasTexture _jsVariableValue;
    public JsCanvasTexture JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsBoolean _needsUpdate;
    public JsBoolean NeedsUpdate
    {
        get => _needsUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_needsUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.needsUpdate = {valueCode};");
        }
    }

    internal JsCanvasTexture(JsTypeConstructor jsCodeSource, JsCanvasTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
    }

    public JsCanvasTexture(JsType argCanvas = null, JsType argMapping = null, JsType argWrapS = null, JsType argWrapT = null, JsType argMagFilter = null, JsType argMinFilter = null, JsType argFormat = null, JsType argType = null, JsType argAnisotropy = null)
        : base(new JsCanvasTextureConstructor(argCanvas, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argFormat, argType, argAnisotropy))
    {
    }

        
}