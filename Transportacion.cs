using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transportacion : MonoBehaviour
{
    [SerializeField] Transform portalB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            other.transform.position = portalB.position;
        }
    }
}
