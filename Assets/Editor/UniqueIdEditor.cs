using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(UniqueIdPropertyDrawer))]
public class BaseUniqueIdDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        var attribute = this.attribute as UniqueIdPropertyDrawer;

        if (attribute == null)
        {
            EditorGUI.LabelField(position, label.text, "Missing Unique Id");
            EditorGUI.EndProperty();
            return;
        }

        var idType = attribute.IdType;
        var genericCollectionType = typeof(GenericStaticStatCollection<>).MakeGenericType(idType);
        var getAllIds = genericCollectionType.GetMethod("GetAllIds");

        if (getAllIds == null)
        {
            EditorGUI.LabelField(position, label.text, "Missing Get All Ids Method");
            EditorGUI.EndProperty();
            return;
        }

        var allIds = getAllIds.Invoke(null, null) as System.Collections.IEnumerable;
        if (allIds == null)
        {
            EditorGUI.LabelField(position, label.text, "Missing All Ids");
            EditorGUI.EndProperty();
            return;
        }

        var options = allIds.Cast<object>().Select(x => (KeyValuePair<IUniqueId<object>, string>)x).ToList();

        string[] displayOptions = options.Select(x => x.Value).ToArray();
        int[] optionIds = options.Select(x => x.Key.Id).ToArray();

        SerializedProperty idProperty = property.FindPropertyRelative("Id");
        int currentId = idProperty.intValue;
        int currentIndex = Array.IndexOf(optionIds, currentId);

        int newIndex = EditorGUI.Popup(position, label.text, currentIndex, displayOptions);
        if (newIndex != currentIndex && newIndex != -1)
        {
            idProperty.intValue = optionIds[newIndex];
        }

        EditorGUI.EndProperty();
    }
}


