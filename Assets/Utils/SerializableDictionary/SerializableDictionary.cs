using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
    [SerializeField] private List<KeyValuePair> _kvps;

    public void OnBeforeSerialize()
    {

    }

    public void OnAfterDeserialize()
    {
        this.Clear();

        foreach (var kvp in _kvps)
        {
            this[kvp.key] = kvp.value;
        }
    }

    [Serializable]
    public struct KeyValuePair
    {
        public TKey key;
        public TValue value;
    }
}

#if UNITY_EDITOR
public class SerializableDictionaryDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("_kvps"));
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        EditorGUI.PropertyField(position, property.FindPropertyRelative("_kvps"), label, true);
        EditorGUI.EndProperty();
    }
}

public class SerializableDictionaryKeyValuePairDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return Mathf.Max(
            EditorGUI.GetPropertyHeight(property.FindPropertyRelative("key")),
            EditorGUI.GetPropertyHeight(property.FindPropertyRelative("value"))
        );
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var keyProp = property.FindPropertyRelative("key");
        var keyHeight = EditorGUI.GetPropertyHeight(keyProp);
        var keyRect = new Rect(position.x, position.y, position.width / 2 - 4, keyHeight);

        var valueProp = property.FindPropertyRelative("value");
        var valueHeight = EditorGUI.GetPropertyHeight(valueProp);
        var valueRect = new Rect(position.center.x + 2, position.y, position.width / 2 - 4, valueHeight);

        EditorGUI.PropertyField(keyRect, keyProp, GUIContent.none);
        EditorGUI.PropertyField(valueRect, valueProp, GUIContent.none);
    }
}
#endif

#region Example

[Serializable]
public class AudioClipDictionary : SerializableDictionary<string, AudioClip>
{

}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(AudioClipDictionary))]
public class AudioClipDictionaryDrawer : SerializableDictionaryDrawer
{

}

[CustomPropertyDrawer(typeof(AudioClipDictionary.KeyValuePair))]
public class AudioClipDictionaryKeyValuePairDrawer : SerializableDictionaryKeyValuePairDrawer
{

}
#endif

#endregion
