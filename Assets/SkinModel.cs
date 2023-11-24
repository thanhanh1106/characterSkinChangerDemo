using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinModel : MonoBehaviour
{
    public SkinType type;
    public string[] bonesName = null;

    public SkinnedMeshRenderer skinedMesh = null;



    public void UpdateBones(Transform boneRoot)
    {
        //skinedMesh.bones = new Transform[bonesName.Length];

        //for (int i = 0; i < skinedMesh.bones.Length; i++)
        //{
        //    Transform bone = CharacterSkin.bones[bonesName[i]]; ;
        //    skinedMesh.bones[i] = bone;
        //    if (skinedMesh.bones[i] == null)
        //        skinedMesh.bones[i] = bone;
        //}

        //skinedMesh.rootBone = boneRoot;
        
    }
}

public enum SkinType
{
    Upbody,

}
