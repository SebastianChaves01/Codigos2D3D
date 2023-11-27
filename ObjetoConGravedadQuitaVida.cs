using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetoConGravedadQuitaVida : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float fuerzaGravedad,tiempoXDano;    
    [SerializeField] int dano;


    bool atraccion;
    float tiempoGravedad,gravedadFinal, tiempoDano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (atraccion)
        {
            tiempoGravedad += 1f*Time.deltaTime;
            gravedadFinal = tiempoGravedad + fuerzaGravedad;
            tiempoDano += 1 * Time.deltaTime;
            //print(tiempoDano);
            player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, gravedadFinal* Time.deltaTime);
            if (tiempoDano > tiempoXDano) {
                print("paso");
                tiempoDano = 0;                
                player.GetComponent<PlayerVida>().RestarVida(dano);
                
            }
            
            
        }
        else {
           
        }
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            atraccion = true;           
            print("Entro Player");

            
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            atraccion = false;
            print("Salio Player");
            tiempoGravedad = 0;
            tiempoDano = 0;

        }

        
    }

    IEnumerator TiempoDanoVida()
    {


        yield return new WaitForSeconds(50);
        print("bajar vida");
    }
}
