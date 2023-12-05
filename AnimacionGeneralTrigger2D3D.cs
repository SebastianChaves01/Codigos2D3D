using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionGeneralTrigger2D3D : MonoBehaviour
{
    Animator animator;

    

    /*
     --- INDICACIONES ---

    -> Crear un objeto  vaio padre y poner este codigo
    -> Colocar los objetos a realizar la animacion como hijos 
    -> Cear la animacion con los objetos hijos
    -> crear un parametro trigger llamado animacion
    -> crear un estado vacio  y colocarlo como animacion principal 
    -> conectar el estado vacio con la animacion anteriormente creada
    -> colocar el parametro como condicion  entre la transicion
    -> opcional
        -> si quiero repetir la animacion colocar una flecha de vuelta sin condicion
        -> si queiro dejar la animacion en el ultimo frame quito el loop de la animacion 
    */


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {

            //Nombre parametro ActivarAnimacion, lo pueden modificar a su gusto
            animator.SetTrigger("ActivarAnimacion");
            print("Animacion");
              
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetTrigger("ActivarAnimacion");
            print("Animacion");

        }
    }


}

 




