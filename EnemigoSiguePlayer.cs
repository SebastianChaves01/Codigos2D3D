using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSiguePlayer : MonoBehaviour
{
    [SerializeField] int velocidadEnemigo, dsitanciaEnemigoPlayer, distanciaAtaqueEnemigo;
    [SerializeField] GameObject player;

    Animator animator;
    float distancia;   
    bool enemigoSiguePlayer;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        distancia=Vector3.Distance(player.transform.position, transform.position);

        if (distancia <= dsitanciaEnemigoPlayer)
        {
            animator.SetTrigger("Camina");
            gameObject.transform.LookAt( new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
            if (distancia >= distanciaAtaqueEnemigo)
            {
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, velocidadEnemigo * Time.deltaTime);
                animator.SetTrigger("NOAtaca");
            }
            else
            {

                animator.SetTrigger("Ataca");
            }



        }
        else {
            animator.SetTrigger("NOseguir");

        }
    }
}
