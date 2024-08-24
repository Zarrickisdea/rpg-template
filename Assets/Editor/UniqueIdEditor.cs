using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public abstract class BaseUniqueIdDrawer<T> : PropertyDrawer where T : IUniqueId<T>
{
    private List<KeyValuePair<T, string>> cachedIds;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        // Since Id is a property, not a field, we need to handle it differently
        int currentId = GetIdValue(property);

        if (cachedIds == null)
        {
            cachedIds = GetIds().ToList();
        }

        if (!cachedIds.Any())
        {
            Debug.LogWarning($"No Unique Ids found for {typeof(T).Name}.");
            EditorGUI.LabelField(position, label.text, "No Ids available");
            EditorGUI.EndProperty();
            return;
        }

        string[] options = cachedIds.Select(x => x.Value).ToArray();
        int[] optionValues = cachedIds.Select(x => x.Key.Id).ToArray();

        int selectedIndex = Array.IndexOf(optionValues, currentId);
        selectedIndex = EditorGUI.Popup(position, label.text, selectedIndex, options);

        if (selectedIndex >= 0 && selectedIndex < optionValues.Length)
        {
            SetIdValue(property, optionValues[selectedIndex]);
        }

        EditorGUI.EndProperty();
    }

    private int GetIdValue(SerializedProperty property)
    {
        // Assuming the IUniqueId<T> is the root property itself
        return property.FindPropertyRelative("Id").intValue;
    }

    private void SetIdValue(SerializedProperty property, int value)
    {
        property.FindPropertyRelative("Id").intValue = value;
    }

    public abstract IEnumerable<KeyValuePair<T, string>> GetIds();

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight;
    }
}

[CustomPropertyDrawer(typeof(AttributeUniqueId))]
public class AttributeUniqueIdDrawer : BaseUniqueIdDrawer<AttributeUniqueId>
{
    public override IEnumerable<KeyValuePair<AttributeUniqueId, string>> GetIds()
    {
        return AttributeIdCollection.GetAllIds();
    }
}

[CustomPropertyDrawer(typeof(ParameterUniqueId))]
public class ParameterUniqueIdDrawer : BaseUniqueIdDrawer<ParameterUniqueId>
{
    public override IEnumerable<KeyValuePair<ParameterUniqueId, string>> GetIds()
    {
        return ParameterIdCollection.GetAllIds();
    }
}