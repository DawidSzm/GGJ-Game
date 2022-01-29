using System;
using UnityEngine;
using UnityEngine.SceneManagement;

using Object = UnityEngine.Object;

#if UNITY_EDITOR
using UnityEditor;
#endif

[AttributeUsage(validOn: AttributeTargets.Field)]
public sealed class SceneAttribute : PropertyAttribute {}

#if UNITY_EDITOR
[CustomPropertyDrawer(type: typeof(SceneAttribute))]
public class SceneAttributeDrawer : PropertyDrawer 
{
    public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType != SerializedPropertyType.Integer)
        {
            EditorGUI.HelpBox(position: rect, message: "ERROR: SceneAttribute only works on Integers", type: MessageType.Error);
            return;
        }

        SceneAsset selectedScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(assetPath: SceneUtility.GetScenePathByBuildIndex(buildIndex: property.intValue));

        EditorGUI.BeginProperty(totalPosition: rect, label: label, property: property);
        {
            EditorGUI.BeginChangeCheck();

            Object newScene = EditorGUI.ObjectField(position: rect, label: label, obj: selectedScene,
                objType: typeof(SceneAsset), allowSceneObjects: false);

            //TODO: Add warning HelpBox if scene isn't in build order.

            if(EditorGUI.EndChangeCheck())
            {
                String __path = AssetDatabase.GetAssetPath(assetObject: newScene);

                property.intValue = SceneUtility.GetBuildIndexByScenePath(scenePath: __path);
            }
        }
        EditorGUI.EndProperty();
    }
}
#endif