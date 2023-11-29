using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionGeneralTrigger2D3D : MonoBehaviour
{
    Animator animator;



    /*
    -> Crear un objeto  vaio padre y poner este codigo
    -> Colocar los objetos a realizar la animacion com hijos 
    -> Cear la animacion
    -> crear un parametro trigger llamado animacion
    -> crear un estado vacio  y colcoarlo como animacion principal 
    -> conectar el estado vacio y conectarla con la animacion anteriormente creada
    -> colocar el parametro como condicion  entre la transicion
    -> opcional
        -> si quiero repetir la animacion colocar una flecha de vuelta sin condicion
        -> si queiro dejar la animacion en el ultimo frame quiro el loop
    */

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            animator.SetTrigger("animacion");
              


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetTrigger("animacion");



        }
    }


}

 




