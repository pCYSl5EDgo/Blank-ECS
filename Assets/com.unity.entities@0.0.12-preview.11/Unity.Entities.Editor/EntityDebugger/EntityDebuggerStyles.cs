﻿

using UnityEditor;
using UnityEngine;

namespace Unity.Entities.Editor
{
    public static class EntityDebuggerStyles
    {

        public static GUIStyle ComponentRequired => StyleAsset.styles[0];
        public static GUIStyle ComponentSubtractive => StyleAsset.styles[1];
        public static GUIStyle ComponentReadOnly => StyleAsset.styles[2];
        public static GUIStyle ComponentReadWrite => StyleAsset.styles[3];

        private static GUIStyleAsset StyleAsset
        {
            get
            {
                if (!styleAsset)
                {
                    styleAsset = AssetDatabase.LoadAssetAtPath<GUIStyleAsset>(
                        "Assets/com.unity.entities@0.0.12-preview.11/Unity.Entities.Editor/Resources/EntityDebuggerStyles.asset");
                }

                return styleAsset;
            }
        }

        private static GUIStyleAsset styleAsset;
    }
}