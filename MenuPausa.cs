using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] GameObject panelPausa;
    [SerializeField] bool estadoPanelPausa;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            
            Debug.Log(!estadoPanelPausa);
            estadoPanelPausa= !estadoPanelPausa;
            Cursor.visible = estadoPanelPausa;
            panelPausa.SetActive(estadoPanelPausa);
            
        
        }
    }

    public void Pausa() {

        panelPausa.SetActive(false);
    }
}
