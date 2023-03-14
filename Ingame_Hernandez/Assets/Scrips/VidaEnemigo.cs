using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{
    public int vida = 100;
    public GameObject efectoMuerte;
    public AudioSource _audSource;
    public AudioClip _Clip_Muerte;
    public float vidaActual;
    public Image barraVida;
    public static int CantidadKills;

    private void Start()
    {
        vidaActual = vida;
    }
    void Update()
    {
        muerteEnemigo();
        barraVida.fillAmount = vidaActual / vida;
    }
    void muerteEnemigo()
    {
        if (vidaActual<=0)
        {
            CantidadKills++;
            AudioSound(_Clip_Muerte);
            GameObject explosionEnemigo  = Instantiate(efectoMuerte,transform.position,transform.rotation);
            Destroy(explosionEnemigo,4);
            Destroy(gameObject);
            
        }
    }
    void AudioSound(AudioClip _Clip_Test)
    {
        _audSource.clip = _Clip_Test;
        _audSource.Play();
    }
}
