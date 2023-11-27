using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsRecogida3D : MonoBehaviour
{
    [SerializeField] GameObject itemsHijo;
    [SerializeField] float tiempoApagadTems, tiempoDestruirItems;
    [SerializeField] int valorItems = 1;

    [SerializeField] GameObject mascaraItems;

    Animator animator;
    Rigidbody rigidbody;
    AudioSource audioSource;
    Collider collider;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<Collider>();




    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            mascaraItems.SetActive(true);
            StartCoroutine(ActivadorMascaraItems());
            print("Activador de Mascara Items");


            if (animator != null)
            {

                animator.SetTrigger("ActuvadorItems");
                audioSource.Play();
                collider.enabled = false;
                Destroy(itemsHijo, tiempoApagadTems);
                Destroy(gameObject, tiempoDestruirItems);
                other.GetComponent<PlayerItems>().SumaItems(valorItems);





            }
            else
            {
                print("No A ");
            }
            print("hit!");
        }
    }

    IEnumerator ActivadorMascaraItems() {

        yield return new WaitForSeconds(1);
        mascaraItems.SetActive(false);
        print("Desactivador de Mascara Items");

    }
    
}

