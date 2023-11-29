using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChechPoint : MonoBehaviour
{
    [SerializeField] float tiempoDestruccion;
    [SerializeField] AudioSource audioCheck;

    private void Start()
    {
        audioCheck = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerMuereConCheckPoint>().CambiarCheckPoint(transform.position);
            print("Nuevo check" + transform.position);
            GetComponent<MeshRenderer>().enabled=false;
            if (audioCheck != null) {
                audioCheck.Play();
            }                
            Destroy(gameObject, tiempoDestruccion);
        }
    }
}
