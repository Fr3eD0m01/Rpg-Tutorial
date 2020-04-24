using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToSkinnedMesh : MonoBehaviour
{
 
    [ContextMenu("Convert To Skinned Mesh")]
    void Convert()
    {
        SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        MeshFilter meshFilter = GetComponent<MeshFilter>();


        
        skinnedMeshRenderer.sharedMesh = meshFilter.sharedMesh;
        skinnedMeshRenderer.sharedMaterials = meshRenderer.sharedMaterials;

        DestroyImmediate(meshRenderer);
        DestroyImmediate(meshFilter);
        DestroyImmediate(this);
    }

}
