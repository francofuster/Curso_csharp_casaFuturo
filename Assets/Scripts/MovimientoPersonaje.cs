using System.Threading;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float Velocidad = 5f;

    public Vector3 DireccionVertical;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += DireccionVertical * Velocidad * Time.deltaTime;
        }

    }
}
