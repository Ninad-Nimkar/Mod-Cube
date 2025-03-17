using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float rotation = 20;
   
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        
        
     
    }
    
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime, rotation,rotation);

        Material material = Renderer.material;
        material.color = new Color(Random.value,Random.value, Random.value, Random.value);

       int scale = Random.Range(1, 5);

        transform.localScale = new Vector3(scale, scale, scale);    
    }
}
