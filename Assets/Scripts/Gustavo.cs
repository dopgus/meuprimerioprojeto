using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gustavo : MonoBehaviour
{

   
   public int Cena = 10;
    
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Key  B");
            Cena = Cena - 2;
        }

    }
}
