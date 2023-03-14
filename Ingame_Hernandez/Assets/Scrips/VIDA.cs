using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VIDA : MonoBehaviour
{
    public int vida = 100;
    public float vidaActual;
    public Image barraVida;
    public Respawn respawn;
  

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vida;
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.fillAmount = vidaActual / vida;
        muerte();
    }
    void muerte()
    {
        if (vidaActual<=0)
        {
            Debug.Log("HAS MUERTO");
            respawn.Respawnear();
            vidaActual = vida;
        }
        
    }
  
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemi"))
        {
            Debug.Log("Auch");
            vidaActual -= 10;                 
        }
    }
}
