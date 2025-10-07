using UnityEngine;

public class VidaProyectil : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
