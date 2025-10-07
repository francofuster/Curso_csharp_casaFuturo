using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{

    public float Vida = 1f;

    private Image barraVida;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        barraVida = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.fillAmount = Vida;
    }
}
