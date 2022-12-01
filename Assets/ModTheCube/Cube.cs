using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float switchColor = 0f;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        transform.localScale = Vector3.one * Random.Range(0.1f, 5f);

        Material material = Renderer.material;
        material.renderQueue = 2;

        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        
    }

    void Update()
    {
        transform.Rotate(Random.Range(0f, 20f) * Time.deltaTime, Random.Range(0f, 20f) * Time.deltaTime, Random.Range(0f, 20f) * Time.deltaTime);


        if (switchColor >= 2f)
        {
            Renderer.material.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
            switchColor = 0f;
        }
        else { switchColor = switchColor += 1f * Time.deltaTime; }
        
        Debug.Log(switchColor);
    }
}
