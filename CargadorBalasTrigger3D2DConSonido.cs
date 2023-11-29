using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargadorBalasTrigger3D2D : MonoBehaviour
{
    [SerializeField] int balasRecogidas;

    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerDisparaBala>().recogerBalas(balasRecogidas);
            gameObject.GetComponent<MeshRenderer>().enabled= false;
            gameObject.GetComponent<Collider>().enabled = false;
            audio.Play();
            Destroy(gameObject, 1);


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerDisparaBala>().recogerBalas(balasRecogidas);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            audio.Play();
            Destroy(gameObject, 1);


        }
    }
}
