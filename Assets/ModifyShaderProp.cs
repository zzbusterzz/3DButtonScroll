using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyShaderProp : MonoBehaviour {
    public float Stencil_Comparison = 8;
    public float Stencil_ID = 0;
    public float Stencil_Operation = 0;
    public float Stencil_Write_Mask = 255;
    public float Stencil_Read_Mask = 255;
    
	// Use this for initialization
	void Start () {
        Material m = transform.GetComponent<MeshRenderer>().material;
        m.SetFloat("Stencil Comparison", Stencil_Comparison);
        m.SetFloat("Stencil ID", Stencil_ID);
        m.SetFloat("Stencil Operation", Stencil_Operation);
        m.SetFloat("Stencil Write Mask", Stencil_Write_Mask);
        m.SetFloat("Stencil Read Mask", Stencil_Read_Mask);


        //_StencilComp("", Float) = 8
        //_Stencil("", Float) = 0
        //_StencilOp("", Float) = 0
        //_StencilWriteMask("Stencil Write Mask", Float) = 255
        //_StencilReadMask("Stencil Read Mask", Float) = 255
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
