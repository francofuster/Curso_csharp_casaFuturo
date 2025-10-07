using UnityEngine;

public class MovimientoPersona : MonoBehaviour
{

    public float Velocidad = 5f; 

    public float FuerzaSalto = 5f;

    private Rigidbody rb;

    private bool puedeSaltar = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // transform.position += new Vector3(0f,0f, Velocidad * Time.deltaTime);
            transform.Translate(new Vector3(0f, 0f, Velocidad * Time.deltaTime));
              
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, 0f, -Velocidad * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            // transform.position += new Vector3(Velocidad * Time.deltaTime,0f, 0f);
            transform.Rotate(0f, Velocidad, 0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // transform.position += new Vector3(-Velocidad * Time.deltaTime,0f, 0f);
            transform.Rotate(0f, -Velocidad, 0f, Space.Self);
        }

        if(Input.GetKeyDown(KeyCode.Space) && puedeSaltar)
        {
            rb.AddForce(new Vector3(0f, FuerzaSalto, 0f), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Suelo")
        {
            puedeSaltar = true;
            Debug.Log("puede saltar");
        }
    }

    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Suelo")
        {
            puedeSaltar = false;
            Debug.Log("no puede saltar");
        }
    }
}
