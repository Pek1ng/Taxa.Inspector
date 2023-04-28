using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(LableTextAttribute))]
public class LableTextAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var a = attribute as LableTextAttribute;

        label.text = a.DisplayName;

        EditorGUI.PropertyField(position, property, label);
    }
}
