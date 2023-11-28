using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasCollider2D3D2Coordenadas : MonoBehaviour
{
    [SerializeField] Transform[] puntosRecorrido;
    [SerializeField] Vector3   puntoFinal;
    [SerializeField] float velociadMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = puntosRecorrido[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == puntosRecorrido[0].position)
        {
            puntoFinal = puntosRecorrido[1].position;
            print("Punto 1");


        }
        else if (transform.position == puntosRecorrido[1].position)
        {
            puntoFinal = puntosRecorrido[0].position;

        }

        print(puntoFinal);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, puntoFinal, velociadMovimiento * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("hit Player");
            collision.gameObject.transform.parent = gameObject.transform;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("hit Player");
            collision.gameObject.transform.parent = null;
        }
    }
}
