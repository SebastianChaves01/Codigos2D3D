using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTripulayAtaca : MonoBehaviour
{

    [SerializeField] Transform[] puntosRecorrido;
    [SerializeField] Vector3 puntoInicial, puntoActual, puntoFinal;
    [SerializeField] float velociadMovimiento, distanciaAdetectar, distancaiAatacar,velocidadAtaque;
    [SerializeField] GameObject player;

    Animator animator;
    float distancia;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.transform.position = puntosRecorrido[0].position;
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= distanciaAdetectar)
        {
            
            
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidadAtaque * Time.deltaTime );
            if (distancia <= distancaiAatacar)
            {


                animator.SetTrigger("Atacar");
            }
            else {
                animator.SetTrigger("NOAtacar");
            }
           
            animator.SetTrigger("Seguir");

        }
        else {
            animator.SetTrigger("NOseguir");
            if (transform.position == puntosRecorrido[0].position)
            {
                puntoFinal = puntosRecorrido[1].position;


            }
            else if (transform.position == puntosRecorrido[1].position)
            {
                puntoFinal = puntosRecorrido[0].position;

            }
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, puntoFinal, velociadMovimiento * Time.deltaTime);
        }

        
        
    }
}
