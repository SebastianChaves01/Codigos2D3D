using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMuereReiniciandoEscena : MonoBehaviour
{

    int playervida;

   
    Animator animator;
    [SerializeField] GameObject grupoUIVivo, grupoUIMuerto;
    // Start is called before the first frame update
    void Start()
    {
         
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playervida = GetComponent<PlayerVida>().vidaActual;
        
        if (playervida <= 0) {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Space)) {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                
            }
            
            grupoUIVivo.SetActive(false);
            grupoUIMuerto.SetActive(true);
        
        }
    }
}
