using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerItems : MonoBehaviour
{
    
    [SerializeField] TMP_Text textUIItems;
    public int cantidadItems;
    // Start is called before the first frame update
    void Start()
    {
        textUIItems.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        textUIItems.text = cantidadItems.ToString();
    }

    public  void SumaItems(int items) {
        cantidadItems +=  items;
        //textUIItems.text = cantidadItems.ToString();
    }
}