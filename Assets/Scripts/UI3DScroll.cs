using UnityEngine;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

// 3D Masking Original Script from:  https://forum.unity3d.com/threads/ui-and-masking-3d-meshes-in-a-scrollrect.358475/
[ExecuteInEditMode]
public class UI3DScroll : MonoBehaviour {

    public List<MeshFilter> meshFilters = new List<MeshFilter>();

    void Start()
    {
        if (meshFilters.Count > 0)
            meshFilters.Clear();
        meshFilters.AddRange(transform.GetComponentsInChildren<MeshFilter>());
        
    }

    void ResetData()
    {
        meshFilters.ForEach(delegate (MeshFilter meshFilter)
        {
            var cr = meshFilter.transform.GetComponent<CanvasRenderer>();
            cr.SetMesh(meshFilter.sharedMesh);

            List<Material> materials = meshFilter.transform.GetComponent<Renderer>().sharedMaterials.ToList();

            for (int i = 0; i < materials.Count; i++)
            {
                cr.materialCount = materials.Count;
                cr.SetMaterial(materials[i], i);
            }
        });
    }

    void OnEnable()
    {
        ResetData();
    }

    void OnValidate()
    {
        ResetData();
    }
}
