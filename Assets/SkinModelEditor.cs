using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SkinModel))]
public class SkinModelEditor : Editor
{


    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        SkinModel skinModel = (SkinModel)target;

        if (GUILayout.Button("Save Bones"))
        {
            skinModel.skinedMesh = skinModel.GetComponent<SkinnedMeshRenderer>();
            skinModel.bonesName = new string[skinModel.skinedMesh.bones.Length];
            for (int i = 0; i < skinModel.skinedMesh.bones.Length; i++)
            {
                skinModel.bonesName[i] = skinModel.skinedMesh.bones[i].name;
            }
        }
    }
}
