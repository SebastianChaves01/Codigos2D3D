using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMuereConCheckPoint : MonoBehaviour
{

    int vidaActualCheck, vidaTotalCheck;

   
    Animator animator;
    [SerializeField] GameObject grupoUIVivo, grupoUIMuerto;
    [SerializeField] Vector3  checkpointActual;
    // Start is called before the first frame update
    void Start()
    {
        checkpointActual = gameObject.transform.position;
        animator = GetComponent<Animator>();
        vidaTotalCheck = GetComponent<PlayerVida>().vidaTotal;
    }

    // Update is called once per frame
    void Update()
    {
        vidaActualCheck = GetComponent<PlayerVida>().vidaActual;
        
        if (vidaActualCheck <= 0) {
            grupoUIVivo.SetActive(false);
            grupoUIMuerto.SetActive(true);
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1;
                transform.position = checkpointActual;
                print("Check");                
                
                GetComponent<PlayerVida>().SumarVida(vidaTotalCheck);


                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


            }
            
            
            
        
        }
        else
        {
            grupoUIVivo.SetActive(true);
            grupoUIMuerto.SetActive(false);
        }
    }

    public void CambiarCheckPoint(Vector3 nuevoCheckPoint) {
        checkpointActual = nuevoCheckPoint;
    }

    void UsarCheck() { 
    
    }
}
