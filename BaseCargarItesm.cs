using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseCargarItesm : MonoBehaviour
{
    [SerializeField] float distanciaEntregaItems;
    [SerializeField] GameObject player;
    [SerializeField] TMP_Text text3DItems;
    [SerializeField] int cantidaItemsNecesarios;
    
    float distancia;
    int numeroItems,numeroItemsActuales;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();        
        text3DItems.text = "Faltan " + cantidaItemsNecesarios + " items";
    }

    // Update is called once per frame
    void Update()
    {
        text3DItems.transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        distancia = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distancia <= distanciaEntregaItems)
        {
            text3DItems.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {

                numeroItems = player.GetComponent<PlayerItems>().cantidadItems;
                numeroItemsActuales += numeroItems;
                cantidaItemsNecesarios -= numeroItems;                
                text3DItems.text = "Faltan " + cantidaItemsNecesarios + " items";

                if (cantidaItemsNecesarios <= 0)
                {
                    animator.SetTrigger("E");
                    print("la cantidad necesaria" + cantidaItemsNecesarios);
                    text3DItems.text = "Faltan " + 0 + " items";

                }
                player.GetComponent<PlayerItems>().cantidadItems = 0;



                print(numeroItems);

            }
            print("player cerca");
        }
        else {
            text3DItems.enabled = false;
        }
    }
}
