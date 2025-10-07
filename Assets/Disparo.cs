using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectil;

    public float VelocidadDisparo = 15f;
    public Transform disparoPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject proyectil1 = Instantiate(proyectil, disparoPos.position, disparoPos.rotation);
            proyectil1.GetComponent<Rigidbody>().AddForce(disparoPos.TransformDirection(new Vector3(0f, VelocidadDisparo, VelocidadDisparo)), ForceMode.Impulse);
        }
    }
}
