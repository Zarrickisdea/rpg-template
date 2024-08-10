using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(AttributeUniqueId))]
public class AttributeUniqueIdDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        SerializedProperty idProp = property.FindPropertyRelative("attributeId");

        var attributes = AttributeIdCollection.GetAllAttributes();
        string[] options = attributes.Select(x => x.Value).ToArray();
        int[] optionValues = attributes.Select(x => x.Key.AttributeId).ToArray();

        int selectedIndex = System.Array.IndexOf(optionValues, idProp.intValue);
        selectedIndex = EditorGUI.Popup(position, label.text, selectedIndex, options);

        if (selectedIndex >= 0 && selectedIndex < optionValues.Length)
        {
            idProp.intValue = optionValues[selectedIndex];
        }

        EditorGUI.EndProperty();
    }
}