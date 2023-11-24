using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class CharacterSkin : MonoBehaviour
{
    [System.Serializable]
    public class SkinStruct
    {
        public SkinType type;
        public Transform root = null;
        public Transform boneRoot = null;
    }

    public SkinStruct[] skinStruct = null;
    public Transform[] trans = null;


    public Transform rootBone = null;


    public Dictionary<string, Transform> bones = new Dictionary<string, Transform>();



    private void Awake()
    {
        foreach (Transform child in trans)
        {
            bones.Add(child.name, child);
        }

        LoadSkin("upBody_hood", SkinType.Upbody);
    }

    public void LoadSkin(string skinName, SkinType type)
    {
        GameObject model = Resources.Load<GameObject>($"Skin/Upbody/{skinName}");
        SkinStruct skin = skinStruct.First(i => i.type == type);
        GameObject obj = Instantiate(model, skin.root);
        SkinModel skinModel = obj.GetComponent<SkinModel>();


        skinModel.skinedMesh = skinModel.GetComponent<SkinnedMeshRenderer>();

        skinModel.skinedMesh.rootBone = skin.boneRoot;

        //skinModel.skinedMesh.bones = new Transform[skinModel.bonesName.Length];

        Transform[] array = new Transform[skinModel.bonesName.Length];

        for (int i = 0; i < skinModel.skinedMesh.bones.Length; i++)
        {
            Transform bone = bones[skinModel.bonesName[i]]; ;
            array[i] = bone;
        }

        skinModel.skinedMesh.bones = array;
    }

}
