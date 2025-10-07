using UnityEngine;

public class DisparoPersonaje : MonoBehaviour
{
    public GameObject proyectil;
    public Transform disparoPosicion;

    public float velocidadDisparo = 15f;

    public int tiempoVidaProyectil = 10;

    private bool puedeDisparar = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && puedeDisparar)
        {
            GameObject proyectil1 = Instantiate(proyectil, disparoPosicion.position, disparoPosicion.rotation);
            Destroy(proyectil1, tiempoVidaProyectil);

            proyectil1.GetComponent<Rigidbody>().AddForce(disparoPosicion.TransformDirection(new Vector3(0f, velocidadDisparo,velocidadDisparo)),
                ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Barrera")
        {
            puedeDisparar = true;
        }
        
    }
}
