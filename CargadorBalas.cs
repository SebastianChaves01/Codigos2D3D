using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargadorBalas : MonoBehaviour
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
            other.GetComponent<PlayerDisparaBala>().cantidadBalasActuales = balasRecogidas;
            gameObject.GetComponent<MeshRenderer>().enabled= false;
            gameObject.GetComponent<Collider>().enabled = false;
            audio.Play();
            Destroy(gameObject, 1);


        }
    }
}
