using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Tilemaps;

public class TreeTile : Tile
{
    #if UNITY_EDITOR
        [MenuItem("Assets/Create/Tile/TreeTile")]
        public static void CreateTreeTile() {
            string path = EditorUtility.SaveFilePanelInProject("Save TreeTile", "TreeTile", "asset", "Save TreeTile", "Assets");

            if (string.IsNullOrEmpty(path))
                return;

            AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<TreeTile>(), path);
        }
    #endif
}
