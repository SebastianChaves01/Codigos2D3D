using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjetoQuitaVidaTriggerCollider2D3D : MonoBehaviour
{

    [SerializeField] int dano=1;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerVida>().RestarVida(dano);
            print("Trigger");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerVida>().RestarVida(dano);
            print("Collider");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerVida>().RestarVida(dano);
            print("Collider");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerVida>().RestarVida(dano);
            print("Collider");
        }
    }
}
