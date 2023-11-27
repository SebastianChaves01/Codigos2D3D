using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetoConGravedad : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float fuerzaGravedad;    
    


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
            tiempoGravedad += 1f * Time.deltaTime;
            gravedadFinal = tiempoGravedad + fuerzaGravedad;            
            player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, gravedadFinal * Time.deltaTime);



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
          

        }

        
    }

   
}
