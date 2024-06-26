using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsObject3DConstructor :
    JsTypeConstructor
{
        


    internal JsObject3DConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Object3D()";
    }
}
    
public partial class JsObject3D :
    JsEventDispatcher
{
    public static implicit operator JsObject3D(string jsTextCode)
    {
        return new JsObject3D(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsObject3D value)
    {
        return value.GetJsCode();
    }


    private readonly JsObject3D _jsVariableValue;
    public JsObject3D JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector3 _position;
    public JsVector3 Position
    {
        get => _position ?? throw new InvalidOperationException();
        set
        {
            if (_position is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.position = {valueCode};");
        }
    }
        
    private readonly JsEuler _rotation;
    public JsEuler Rotation
    {
        get => _rotation ?? throw new InvalidOperationException();
        set
        {
            if (_rotation is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.rotation = {valueCode};");
        }
    }
        
    private readonly JsQuaternion _quaternion;
    public JsQuaternion Quaternion
    {
        get => _quaternion ?? throw new InvalidOperationException();
        set
        {
            if (_quaternion is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.quaternion = {valueCode};");
        }
    }
        
    private readonly JsVector3 _scale;
    public JsVector3 Scale
    {
        get => _scale ?? throw new InvalidOperationException();
        set
        {
            if (_scale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.scale = {valueCode};");
        }
    }
        
    private readonly JsType _uuid;
    public JsType Uuid
    {
        get => _uuid ?? throw new InvalidOperationException();
        set
        {
            if (_uuid is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uuid = {valueCode};");
        }
    }
        
    private readonly JsString _name;
    public JsString Name
    {
        get => _name ?? throw new InvalidOperationException();
        set
        {
            if (_name is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.name = {valueCode};");
        }
    }
        
    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"Object3D\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsObject _parent;
    public JsObject Parent
    {
        get => _parent ?? throw new InvalidOperationException();
        set
        {
            if (_parent is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parent = {valueCode};");
        }
    }
        
    private readonly JsType _children;
    public JsType Children
    {
        get => _children ?? throw new InvalidOperationException();
        set
        {
            if (_children is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.children = {valueCode};");
        }
    }
        
    private readonly JsType _up;
    public JsType Up
    {
        get => _up ?? throw new InvalidOperationException();
        set
        {
            if (_up is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.up = {valueCode};");
        }
    }
        
    private readonly JsType _matrix;
    public JsType Matrix
    {
        get => _matrix ?? throw new InvalidOperationException();
        set
        {
            if (_matrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrix = {valueCode};");
        }
    }
        
    private readonly JsType _matrixWorld;
    public JsType MatrixWorld
    {
        get => _matrixWorld ?? throw new InvalidOperationException();
        set
        {
            if (_matrixWorld is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixWorld = {valueCode};");
        }
    }
        
    private readonly JsType _matrixAutoUpdate;
    public JsType MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }
        
    private readonly JsBoolean _matrixWorldNeedsUpdate;
    public JsBoolean MatrixWorldNeedsUpdate
    {
        get => _matrixWorldNeedsUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixWorldNeedsUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixWorldNeedsUpdate = {valueCode};");
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
        
    private readonly JsBoolean _visible;
    public JsBoolean Visible
    {
        get => _visible ?? throw new InvalidOperationException();
        set
        {
            if (_visible is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.visible = {valueCode};");
        }
    }
        
    private readonly JsBoolean _castShadow;
    public JsBoolean CastShadow
    {
        get => _castShadow ?? throw new InvalidOperationException();
        set
        {
            if (_castShadow is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.castShadow = {valueCode};");
        }
    }
        
    private readonly JsBoolean _receiveShadow;
    public JsBoolean ReceiveShadow
    {
        get => _receiveShadow ?? throw new InvalidOperationException();
        set
        {
            if (_receiveShadow is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.receiveShadow = {valueCode};");
        }
    }
        
    private readonly JsBoolean _frustumCulled;
    public JsBoolean FrustumCulled
    {
        get => _frustumCulled ?? throw new InvalidOperationException();
        set
        {
            if (_frustumCulled is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.frustumCulled = {valueCode};");
        }
    }
        
    private readonly JsNumber _renderOrder;
    public JsNumber RenderOrder
    {
        get => _renderOrder ?? throw new InvalidOperationException();
        set
        {
            if (_renderOrder is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.renderOrder = {valueCode};");
        }
    }
        
    private readonly JsType _animations;
    public JsType Animations
    {
        get => _animations ?? throw new InvalidOperationException();
        set
        {
            if (_animations is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.animations = {valueCode};");
        }
    }
        
    private readonly JsType _userData;
    public JsType UserData
    {
        get => _userData ?? throw new InvalidOperationException();
        set
        {
            if (_userData is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.userData = {valueCode};");
        }
    }

    internal JsObject3D(JsTypeConstructor jsCodeSource, JsObject3D jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _position = $"{variableName}.position".AsJsVector3Variable();
        _rotation = $"{variableName}.rotation".AsJsEulerVariable();
        _quaternion = $"{variableName}.quaternion".AsJsQuaternionVariable();
        _scale = $"{variableName}.scale".AsJsVector3Variable();
        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _name = $"{variableName}.name".AsJsStringVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _parent = $"{variableName}.parent".AsJsObjectVariable();
        _children = $"{variableName}.children".AsJsTypeVariable();
        _up = $"{variableName}.up".AsJsTypeVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _matrixWorld = $"{variableName}.matrixWorld".AsJsTypeVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsTypeVariable();
        _matrixWorldNeedsUpdate = $"{variableName}.matrixWorldNeedsUpdate".AsJsBooleanVariable();
        _layers = $"{variableName}.layers".AsJsTypeVariable();
        _visible = $"{variableName}.visible".AsJsBooleanVariable();
        _castShadow = $"{variableName}.castShadow".AsJsBooleanVariable();
        _receiveShadow = $"{variableName}.receiveShadow".AsJsBooleanVariable();
        _frustumCulled = $"{variableName}.frustumCulled".AsJsBooleanVariable();
        _renderOrder = $"{variableName}.renderOrder".AsJsNumberVariable();
        _animations = $"{variableName}.animations".AsJsTypeVariable();
        _userData = $"{variableName}.userData".AsJsTypeVariable();
    }

    public JsObject3D()
        : base(new JsObject3DConstructor())
    {
    }

    public JsType OnBeforeRender()
    {
        return CallMethod("onBeforeRender");
    }
        
    public JsType OnAfterRender()
    {
        return CallMethod("onAfterRender");
    }
        
    public JsType ApplyMatrix4(JsType argMatrix = null)
    {
        return CallMethod("applyMatrix4", argMatrix ?? new JsObject());
    }
        
    public JsObject3D ApplyQuaternion(JsType argQ = null)
    {
        CallMethodVoid("applyQuaternion", argQ ?? new JsObject());
            
        return this;
    }
        
    public JsType SetRotationFromAxisAngle(JsType argAxis = null, JsType argAngle = null)
    {
        return CallMethod("setRotationFromAxisAngle", argAxis ?? new JsObject(), argAngle ?? new JsObject());
    }
        
    public JsType SetRotationFromEuler(JsType argEuler = null)
    {
        return CallMethod("setRotationFromEuler", argEuler ?? new JsObject());
    }
        
    public JsType SetRotationFromMatrix(JsType argM = null)
    {
        return CallMethod("setRotationFromMatrix", argM ?? new JsObject());
    }
        
    public JsType SetRotationFromQuaternion(JsType argQ = null)
    {
        return CallMethod("setRotationFromQuaternion", argQ ?? new JsObject());
    }
        
    public JsObject3D RotateOnAxis(JsType argAxis = null, JsType argAngle = null)
    {
        CallMethodVoid("rotateOnAxis", argAxis ?? new JsObject(), argAngle ?? new JsObject());
            
        return this;
    }
        
    public JsObject3D RotateOnWorldAxis(JsType argAxis = null, JsType argAngle = null)
    {
        CallMethodVoid("rotateOnWorldAxis", argAxis ?? new JsObject(), argAngle ?? new JsObject());
            
        return this;
    }
        
    public JsType RotateX(JsType argAngle = null)
    {
        return CallMethod("rotateX", argAngle ?? new JsObject());
    }
        
    public JsType RotateY(JsType argAngle = null)
    {
        return CallMethod("rotateY", argAngle ?? new JsObject());
    }
        
    public JsType RotateZ(JsType argAngle = null)
    {
        return CallMethod("rotateZ", argAngle ?? new JsObject());
    }
        
    public JsObject3D TranslateOnAxis(JsType argAxis = null, JsType argDistance = null)
    {
        CallMethodVoid("translateOnAxis", argAxis ?? new JsObject(), argDistance ?? new JsObject());
            
        return this;
    }
        
    public JsType TranslateX(JsType argDistance = null)
    {
        return CallMethod("translateX", argDistance ?? new JsObject());
    }
        
    public JsType TranslateY(JsType argDistance = null)
    {
        return CallMethod("translateY", argDistance ?? new JsObject());
    }
        
    public JsType TranslateZ(JsType argDistance = null)
    {
        return CallMethod("translateZ", argDistance ?? new JsObject());
    }
        
    public JsType LocalToWorld(JsType argVector = null)
    {
        return CallMethod("localToWorld", argVector ?? new JsObject());
    }
        
    public JsType WorldToLocal(JsType argVector = null)
    {
        return CallMethod("worldToLocal", argVector ?? new JsObject());
    }
        
    public JsType LookAt(JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        return CallMethod("lookAt", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
    }
        
    public JsObject3D Add(JsType argObject = null)
    {
        CallMethodVoid("add", argObject ?? new JsObject());
            
        return this;
    }
        
    public JsObject3D Remove(JsType argObject = null)
    {
        CallMethodVoid("remove", argObject ?? new JsObject());
            
        return this;
    }
        
    public JsObject3D RemoveFromParent()
    {
        CallMethodVoid("removeFromParent");
            
        return this;
    }
        
    public JsObject3D Clear()
    {
        CallMethodVoid("clear");
            
        return this;
    }
        
    public JsObject3D Attach(JsType argObject = null)
    {
        CallMethodVoid("attach", argObject ?? new JsObject());
            
        return this;
    }
        
    public JsType GetObjectById(JsType argId = null)
    {
        return CallMethod("getObjectById", argId ?? new JsObject());
    }
        
    public JsType GetObjectByName(JsType argName = null)
    {
        return CallMethod("getObjectByName", argName ?? new JsObject());
    }
        
    public JsObject3D GetObjectByProperty(JsType argName = null, JsType argValue = null)
    {
        CallMethodVoid("getObjectByProperty", argName ?? new JsObject(), argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetWorldPosition(JsType argTarget = null)
    {
        return CallMethod("getWorldPosition", argTarget ?? new JsObject());
    }
        
    public JsType GetWorldQuaternion(JsType argTarget = null)
    {
        return CallMethod("getWorldQuaternion", argTarget ?? new JsObject());
    }
        
    public JsType GetWorldScale(JsType argTarget = null)
    {
        return CallMethod("getWorldScale", argTarget ?? new JsObject());
    }
        
    public JsType GetWorldDirection(JsType argTarget = null)
    {
        return CallMethod("getWorldDirection", argTarget ?? new JsObject());
    }
        
    public JsType Raycast()
    {
        return CallMethod("raycast");
    }
        
    public JsType Traverse(JsType argCallback = null)
    {
        return CallMethod("traverse", argCallback ?? new JsObject());
    }
        
    public JsType TraverseVisible(JsType argCallback = null)
    {
        return CallMethod("traverseVisible", argCallback ?? new JsObject());
    }
        
    public JsType TraverseAncestors(JsType argCallback = null)
    {
        return CallMethod("traverseAncestors", argCallback ?? new JsObject());
    }
        
    public JsType UpdateMatrix()
    {
        return CallMethod("updateMatrix");
    }
        
    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
    public JsType UpdateWorldMatrix(JsType argUpdateParents = null, JsType argUpdateChildren = null)
    {
        return CallMethod("updateWorldMatrix", argUpdateParents ?? new JsObject(), argUpdateChildren ?? new JsObject());
    }
        
    public JsObject ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
    public JsType Clone(JsType argRecursive = null)
    {
        return CallMethod("clone", argRecursive ?? new JsObject());
    }
        
    public JsObject3D Copy(JsType argSource = null, JsBoolean argRecursive = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject(), argRecursive ?? (true).AsJsBoolean());
            
        return this;
    }
        
        
}