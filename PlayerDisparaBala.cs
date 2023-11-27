using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDisparaBala : MonoBehaviour
{
    [SerializeField] Transform pistola;
    [SerializeField] GameObject bala;    
    [SerializeField] TMP_Text textoBalasUI;
    public  int cantidadBalasTotales, cantidadBalasActuales;

    

    GameObject nuevaBala;

    // Start is called before the first frame update
    void Start()
    {
        cantidadBalasActuales = cantidadBalasTotales;
        textoBalasUI.text = cantidadBalasTotales.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        textoBalasUI.text = cantidadBalasActuales.ToString();
        if (Input.GetMouseButtonDown(0)) {

            if (cantidadBalasActuales > 0)
            {
               
               nuevaBala = Instantiate(bala, pistola.position, Quaternion.identity);
                nuevaBala.GetComponent<Rigidbody>().AddForce(pistola.forward * 1000);
                Destroy(nuevaBala, 1f);
                print("disparo");                
                cantidadBalasActuales--;
            }
            else {
                pistola.GetComponent<AudioSource>().Play();
                print("sin balas");
            }
                
        }


    }

    public void recogerBalas(int cantidadBalas) {
        cantidadBalasActuales += cantidadBalas;

    }


}
