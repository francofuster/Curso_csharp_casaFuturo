using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{

    public VidaEnemigo _vidaEnemigo;

    // Update is called once per frame
    void Update()
    {
        if (_vidaEnemigo.Vida < 0.2f)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Proyectil")
        {
            if (_vidaEnemigo.Vida > 0.1f)
            {
                _vidaEnemigo.Vida -= 0.2f;
            }
        }
    }
}
