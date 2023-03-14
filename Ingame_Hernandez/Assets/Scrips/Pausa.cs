
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool pausaActiva;
    public GameObject menuPausa;
    public GameObject menuHud;
    public TestSound testSound;
 


    void Start()
    {
        
    }

   
    void Update()
    {
        TogglePause();
    }
    void TogglePause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausaActiva == true)
            {
                ResumirJuego();
            }
            else
            {
                PausarJuego();
            }
        }
        void PausarJuego()
        {
            menuPausa.SetActive(true);
            menuHud.SetActive(false);
            pausaActiva= true;
            TestSound.PausarAudio();
            Time.timeScale = 0;
        }

        void ResumirJuego()
        {
            menuPausa.SetActive(false);
            menuHud.SetActive(true);
            pausaActiva= false;
            TestSound.PlayAudio();
            Time.timeScale = 1;

        }
    }
}
