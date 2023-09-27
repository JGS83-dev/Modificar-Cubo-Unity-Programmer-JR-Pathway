using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Texture2D[] texturas;
    public static float randomY = 0.0f;
    public static float randomZ = 0.0f;
    
    void Start()
    {
        randomY = Random.Range(0.0f, 3.0f);
        randomZ = Random.Range(0.0f, 3.0f);
        int texturaId = Random.Range(0,texturas.Length);
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 4f;
        
        Material material = Renderer.material;

        material.mainTexture = texturas[texturaId];
        material.color = new Color(0.5f, 2.0f, 0.3f, 0.4f);
        
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, randomY, randomZ);
    }
}
