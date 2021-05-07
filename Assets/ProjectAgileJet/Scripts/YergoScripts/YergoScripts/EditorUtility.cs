using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace YergoScripts.EditorUtilities
{
    public static class Functions
    {
        public static T DrawObjectField<T>(string label, UnityEngine.Object obj, bool allowSceneObject, params GUILayoutOption[] options) where T : UnityEngine.Object =>
            EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObject, options) as T;
    }

}