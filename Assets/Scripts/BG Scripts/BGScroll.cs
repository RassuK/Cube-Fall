using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_Speed = 0.3f;
    private MeshRenderer mesh_Renderer;
    private string MainTexture = "_MainTex";
    void Start()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        Scroll();
    }

    void Scroll(){
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(MainTexture);
        offset.y += Time.deltaTime * scroll_Speed;

        mesh_Renderer.sharedMaterial.SetTextureOffset(MainTexture, offset);
    }


}
