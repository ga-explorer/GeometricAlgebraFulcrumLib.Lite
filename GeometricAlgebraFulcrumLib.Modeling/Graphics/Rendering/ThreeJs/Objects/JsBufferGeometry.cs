using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBufferGeometryConstructor :
    JsTypeConstructor
{
        


    internal JsBufferGeometryConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.BufferGeometry()";
    }
}
    
public partial class JsBufferGeometry :
    JsEventDispatcher
{
    public static implicit operator JsBufferGeometry(string jsTextCode)
    {
        return new JsBufferGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBufferGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsBufferGeometry _jsVariableValue;
    public JsBufferGeometry JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

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
        
            var valueCode = value?.GetJsCode() ?? "\"BufferGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _index;
    public JsType Index
    {
        get => _index ?? throw new InvalidOperationException();
        set
        {
            if (_index is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.index = {valueCode};");
        }
    }
        
    private readonly JsType _attributes;
    public JsType Attributes
    {
        get => _attributes ?? throw new InvalidOperationException();
        set
        {
            if (_attributes is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.attributes = {valueCode};");
        }
    }
        
    private readonly JsType _morphAttributes;
    public JsType MorphAttributes
    {
        get => _morphAttributes ?? throw new InvalidOperationException();
        set
        {
            if (_morphAttributes is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.morphAttributes = {valueCode};");
        }
    }
        
    private readonly JsBoolean _morphTargetsRelative;
    public JsBoolean MorphTargetsRelative
    {
        get => _morphTargetsRelative ?? throw new InvalidOperationException();
        set
        {
            if (_morphTargetsRelative is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.morphTargetsRelative = {valueCode};");
        }
    }
        
    private readonly JsType _groups;
    public JsType Groups
    {
        get => _groups ?? throw new InvalidOperationException();
        set
        {
            if (_groups is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.groups = {valueCode};");
        }
    }
        
    private readonly JsType _boundingBox;
    public JsType BoundingBox
    {
        get => _boundingBox ?? throw new InvalidOperationException();
        set
        {
            if (_boundingBox is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.boundingBox = {valueCode};");
        }
    }
        
    private readonly JsType _boundingSphere;
    public JsType BoundingSphere
    {
        get => _boundingSphere ?? throw new InvalidOperationException();
        set
        {
            if (_boundingSphere is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.boundingSphere = {valueCode};");
        }
    }
        
    private readonly JsType _drawRange;
    public JsType DrawRange
    {
        get => _drawRange ?? throw new InvalidOperationException();
        set
        {
            if (_drawRange is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.drawRange = {valueCode};");
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

    internal JsBufferGeometry(JsTypeConstructor jsCodeSource, JsBufferGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _name = $"{variableName}.name".AsJsStringVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _index = $"{variableName}.index".AsJsTypeVariable();
        _attributes = $"{variableName}.attributes".AsJsTypeVariable();
        _morphAttributes = $"{variableName}.morphAttributes".AsJsTypeVariable();
        _morphTargetsRelative = $"{variableName}.morphTargetsRelative".AsJsBooleanVariable();
        _groups = $"{variableName}.groups".AsJsTypeVariable();
        _boundingBox = $"{variableName}.boundingBox".AsJsTypeVariable();
        _boundingSphere = $"{variableName}.boundingSphere".AsJsTypeVariable();
        _drawRange = $"{variableName}.drawRange".AsJsTypeVariable();
        _userData = $"{variableName}.userData".AsJsTypeVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsBufferGeometry()
        : base(new JsBufferGeometryConstructor())
    {
    }

    public JsType GetIndex()
    {
        return CallMethod("getIndex");
    }
        
    public JsBufferGeometry SetIndex(JsType argIndex = null)
    {
        CallMethodVoid("setIndex", argIndex ?? new JsObject());
            
        return this;
    }
        
    public JsType GetAttribute(JsType argName = null)
    {
        return CallMethod("getAttribute", argName ?? new JsObject());
    }
        
    public JsBufferGeometry SetAttribute(JsType argName = null, JsType argAttribute = null)
    {
        CallMethodVoid("setAttribute", argName ?? new JsObject(), argAttribute ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry DeleteAttribute(JsType argName = null)
    {
        CallMethodVoid("deleteAttribute", argName ?? new JsObject());
            
        return this;
    }
        
    public JsType HasAttribute(JsType argName = null)
    {
        return CallMethod("hasAttribute", argName ?? new JsObject());
    }
        
    public JsType AddGroup(JsType argStart = null, JsType argCount = null, JsNumber argMaterialIndex = null)
    {
        return CallMethod("addGroup", argStart ?? new JsObject(), argCount ?? new JsObject(), argMaterialIndex ?? (0).AsJsNumber());
    }
        
    public JsType ClearGroups()
    {
        return CallMethod("clearGroups");
    }
        
    public JsType SetDrawRange(JsType argStart = null, JsType argCount = null)
    {
        return CallMethod("setDrawRange", argStart ?? new JsObject(), argCount ?? new JsObject());
    }
        
    public JsBufferGeometry ApplyMatrix4(JsType argMatrix = null)
    {
        CallMethodVoid("applyMatrix4", argMatrix ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry ApplyQuaternion(JsType argQ = null)
    {
        CallMethodVoid("applyQuaternion", argQ ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry RotateX(JsType argAngle = null)
    {
        CallMethodVoid("rotateX", argAngle ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry RotateY(JsType argAngle = null)
    {
        CallMethodVoid("rotateY", argAngle ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry RotateZ(JsType argAngle = null)
    {
        CallMethodVoid("rotateZ", argAngle ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry Translate(JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        CallMethodVoid("translate", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry Scale(JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        CallMethodVoid("scale", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry LookAt(JsType argVector = null)
    {
        CallMethodVoid("lookAt", argVector ?? new JsObject());
            
        return this;
    }
        
    public JsBufferGeometry Center()
    {
        CallMethodVoid("center");
            
        return this;
    }
        
    public JsBufferGeometry SetFromPoints(JsType argPoints = null)
    {
        CallMethodVoid("setFromPoints", argPoints ?? new JsObject());
            
        return this;
    }
        
    public JsType ComputeBoundingBox()
    {
        return CallMethod("computeBoundingBox");
    }
        
    public JsType ComputeBoundingSphere()
    {
        return CallMethod("computeBoundingSphere");
    }
        
    public JsType ComputeTangents()
    {
        return CallMethod("computeTangents");
    }
        
    public JsType ComputeVertexNormals()
    {
        return CallMethod("computeVertexNormals");
    }
        
    public JsBufferGeometry Merge(JsType argGeometry = null, JsType argOffset = null)
    {
        CallMethodVoid("merge", argGeometry ?? new JsObject(), argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsType NormalizeNormals()
    {
        return CallMethod("normalizeNormals");
    }
        
    public JsBufferGeometry ToNonIndexed()
    {
        CallMethodVoid("toNonIndexed");
            
        return this;
    }
        
    public JsObject ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsBufferGeometry Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
        
}