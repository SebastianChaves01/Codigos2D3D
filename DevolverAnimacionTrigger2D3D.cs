using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevolverAnimacionTrigger2D3D : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {

            animator.SetTrigger("DevolverAnimacion");
            print("Salio El player");
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            animator.SetTrigger("DevolverAnimacion");
            print("Salio El player");
        }
    }

}
