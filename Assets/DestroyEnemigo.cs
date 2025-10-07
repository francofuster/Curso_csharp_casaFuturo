using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemigo : MonoBehaviour
{
    public float Vida = 1f;
    public Image barraVida;

    void Update()
    {
        barraVida.fillAmount = Vida;
        if (Vida < 0.1f)
        {
            Destroy(gameObject);
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Proyectil")
        {
            Vida -= 0.2f;
        }
        
    }
}
