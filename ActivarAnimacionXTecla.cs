using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivarAnimacionXTecla : MonoBehaviour
{
    [SerializeField] GameObject texto;
    
    Animator animator;
    bool permitirAnimacion;

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {


        if (permitirAnimacion == true)
        {
            animator = GetComponent<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetTrigger("Tecla");
            }
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Hit Player");
            texto.SetActive(true);
            permitirAnimacion = true;

        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Hit Player");
            texto.SetActive(false);
            permitirAnimacion = false;

        }
    }
}
