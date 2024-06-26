using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsRaycasterConstructor :
    JsTypeConstructor
{
    public JsType Origin { get; }
        
    public JsType Direction { get; }
        
    public JsNumber Near { get; }
        
    public JsNumber Far { get; }
        
        


    internal JsRaycasterConstructor(JsType argOrigin, JsType argDirection, JsNumber argNear, JsNumber argFar)
    {
        Origin = argOrigin ?? new JsObject();
        Direction = argDirection ?? new JsObject();
        Near = argNear ?? (0).AsJsNumber();
        Far = argFar ?? (double.PositiveInfinity).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Raycaster({Origin.GetJsCode()}, {Direction.GetJsCode()}, {Near.GetJsCode()}, {Far.GetJsCode()})";
    }
}
    
public partial class JsRaycaster :
    JsObjectType
{
    public static implicit operator JsRaycaster(string jsTextCode)
    {
        return new JsRaycaster(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsRaycaster value)
    {
        return value.GetJsCode();
    }


    private readonly JsRaycaster _jsVariableValue;
    public JsRaycaster JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _ray;
    public JsType Ray
    {
        get => _ray ?? throw new InvalidOperationException();
        set
        {
            if (_ray is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.ray = {valueCode};");
        }
    }
        
    private readonly JsNumber _near;
    public JsNumber Near
    {
        get => _near ?? throw new InvalidOperationException();
        set
        {
            if (_near is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.near = {valueCode};");
        }
    }
        
    private readonly JsNumber _far;
    public JsNumber Far
    {
        get => _far ?? throw new InvalidOperationException();
        set
        {
            if (_far is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "Infinity";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.far = {valueCode};");
        }
    }
        
    private readonly JsType _camera;
    public JsType Camera
    {
        get => _camera ?? throw new InvalidOperationException();
        set
        {
            if (_camera is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.camera = {valueCode};");
        }
    }
        
    private readonly JsType _layers;
    public JsType Layers
    {
        get => _layers ?? throw new InvalidOperationException();
        set
        {
            if (_layers is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.layers = {valueCode};");
        }
    }
        
    private readonly JsType _params;
    public JsType Params
    {
        get => _params ?? throw new InvalidOperationException();
        set
        {
            if (_params is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.params = {valueCode};");
        }
    }

    internal JsRaycaster(JsTypeConstructor jsCodeSource, JsRaycaster jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _ray = $"{variableName}.ray".AsJsTypeVariable();
        _near = $"{variableName}.near".AsJsNumberVariable();
        _far = $"{variableName}.far".AsJsNumberVariable();
        _camera = $"{variableName}.camera".AsJsTypeVariable();
        _layers = $"{variableName}.layers".AsJsTypeVariable();
        _params = $"{variableName}.params".AsJsTypeVariable();
    }

    public JsRaycaster(JsType argOrigin = null, JsType argDirection = null, JsNumber argNear = null, JsNumber argFar = null)
        : base(new JsRaycasterConstructor(argOrigin, argDirection, argNear, argFar))
    {
    }

    public JsType Set(JsType argOrigin = null, JsType argDirection = null)
    {
        return CallMethod("set", argOrigin ?? new JsObject(), argDirection ?? new JsObject());
    }
        
    public JsType SetFromCamera(JsType argCoords = null, JsType argCamera = null)
    {
        return CallMethod("setFromCamera", argCoords ?? new JsObject(), argCamera ?? new JsObject());
    }
        
    public JsArray IntersectObject(JsType argObject = null, JsBoolean argRecursive = null, JsArray argIntersects = null)
    {
        return CallMethod("intersectObject", argObject ?? new JsObject(), argRecursive ?? (true).AsJsBoolean(), argIntersects ?? new JsArray());
    }
        
    public JsArray IntersectObjects(JsType argObjects = null, JsBoolean argRecursive = null, JsArray argIntersects = null)
    {
        return CallMethod("intersectObjects", argObjects ?? new JsObject(), argRecursive ?? (true).AsJsBoolean(), argIntersects ?? new JsArray());
    }
        
        
}