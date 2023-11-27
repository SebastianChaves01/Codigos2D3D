using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVida : MonoBehaviour
{
    [SerializeField] int vidaActalEnemigo, vidaTotalEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        vidaActalEnemigo = vidaTotalEnemigo;
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaActalEnemigo <= 0) {
            Destroy(gameObject);
        }
    }


    public void BajarVidaEnemigo(int valorRestarVida) {
        vidaActalEnemigo -= valorRestarVida;

        
        
    }
}
