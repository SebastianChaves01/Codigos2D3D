using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSumaPuntoTrigger2D3DConSonido : MonoBehaviour
{
    [SerializeField] int valorItems,tiempoVidaItesms;

    [SerializeField] AudioSource sonidoInicial;
    [SerializeField] AudioSource sonidoFinal;

   
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerItems>().SumaItems(valorItems);
            sonidoInicial.Stop();
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            sonidoFinal.Play();
            Destroy(gameObject, tiempoVidaItesms);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            collision.GetComponent<PlayerItems>().SumaItems(valorItems);
            sonidoInicial.Stop();
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            sonidoFinal.Play();
            Destroy(gameObject, tiempoVidaItesms);
        }
    }


}
