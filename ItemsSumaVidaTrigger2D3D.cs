using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSumaVidaTrigger2D3D : MonoBehaviour
{
    [SerializeField] int valorIncrementoVida;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerVida>())
            {
                collision.GetComponent<PlayerVida>().SumarVida(valorIncrementoVida);
                Destroy(gameObject);


            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<PlayerVida>())
            {
                other.GetComponent<PlayerVida>().SumarVida(valorIncrementoVida);
                Destroy(gameObject);

            }

        }
    }
}
