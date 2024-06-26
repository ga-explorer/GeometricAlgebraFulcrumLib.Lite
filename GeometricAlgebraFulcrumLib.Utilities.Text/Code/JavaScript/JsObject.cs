using System.Collections;
using System.Diagnostics.CodeAnalysis;
using GeometricAlgebraFulcrumLib.Utilities.Text.Text;

namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public class JsObject :
    JsObjectType
{
    public sealed class JsObjectConstructor :
        JsTypeConstructor,
        IReadOnlyDictionary<string, JsType>
    {
        private readonly Dictionary<string, JsType> _propertiesDictionary;

        public int Count 
            => _propertiesDictionary.Count;
        
        public JsType this[string key] 
            => _propertiesDictionary[key];

        public IEnumerable<string> Keys 
            => _propertiesDictionary.Keys;

        public IEnumerable<JsType> Values 
            => _propertiesDictionary.Values;


        public JsObjectConstructor()
        {
            _propertiesDictionary = new Dictionary<string, JsType>();
        }

        public JsObjectConstructor([NotNull] IReadOnlyDictionary<string, JsType> propertiesDictionary)
        {
            _propertiesDictionary =
                propertiesDictionary is Dictionary<string, JsType> dict
                    ? dict
                    : propertiesDictionary.ToDictionary(
                        pair => pair.Key,
                        pair => pair.Value
                    );
        }

            
        public override string GetJsCode()
        {
            return _propertiesDictionary.Select(
                keyValuePair => $"{keyValuePair.Key}: {keyValuePair.Value.GetJsCode()}"
            ).Concatenate(", ", "{", "}");
        }

        public bool ContainsKey(string key)
        {
            return _propertiesDictionary.ContainsKey(key);
        }

        public bool TryGetValue(string key, out JsType value)
        {
            return _propertiesDictionary.TryGetValue(key, out value);
        }

        public IEnumerator<KeyValuePair<string, JsType>> GetEnumerator()
        {
            return _propertiesDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

        
    public static implicit operator JsObject(Dictionary<string, JsType> propertiesDictionary)
    {
        return new JsObject(
            new JsObjectConstructor(propertiesDictionary)
        );
    }

    public static implicit operator JsObject(string jsTextCode)
    {
        return new JsObject(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsObject value)
    {
        return value.GetJsCode();
    }


    private readonly JsObject _jsVariableValue;
    public JsObject JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;


    public JsObject(JsTypeConstructor jsCodeSource, JsObject jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
    }

    public JsObject()
        : base(new JsObjectConstructor())
    {
    }

    public JsObject(IReadOnlyDictionary<string, JsType> propertiesDictionary)
        : base(new JsObjectConstructor(propertiesDictionary))
    {
    }
}