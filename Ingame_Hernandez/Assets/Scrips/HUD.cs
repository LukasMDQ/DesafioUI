
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text TextoKills;
    public VidaEnemigo vidaEnemigo;

    
    void Start()
    {
        TextoKills.text = "KILLS: ";
    }

    
    void Update()
    {
        TextoKills.text = "Kills:  "+ VidaEnemigo.CantidadKills ;

    }
}
