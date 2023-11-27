using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascaraAgua : MonoBehaviour
{
    [SerializeField] GameObject player;

    MeshRenderer meshRenderer;    
    AudioSource audioSource;

    
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();        
        audioSource = GetComponent<AudioSource>();
        meshRenderer.enabled = false;
        print("Apagar Mascara Agua");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Agua"))
        {
            print("Entro al agua");
            meshRenderer.enabled = true;
            player.GetComponent<Rigidbody>().drag = 5;            
            audioSource.Play();
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Agua"))
        {
            print("Entro al agua");
            meshRenderer.enabled = false;
            player.GetComponent<Rigidbody>().drag = 1;           
            audioSource.Stop();
        }
    }
}
