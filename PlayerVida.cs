using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerVida : MonoBehaviour
{

    public int vidaTotal;
    public int vidaActual;
    [SerializeField] TMP_Text textoVida;
    // Start is called before the first frame update
    void Start()
    {
        if (vidaTotal <= 0){
            vidaTotal = 10;
        }

        vidaActual = vidaTotal;
        textoVida.text = vidaTotal.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        textoVida.text = vidaActual.ToString();

        if (vidaActual <= 0) {
            print("Dead");
        
        }
    }

    public void RestarVida(int restarVida) { 
        vidaActual -= restarVida;
        
    }

    public void SumarVida(int sumarVida)
    {
        vidaActual += sumarVida;

    }



}
