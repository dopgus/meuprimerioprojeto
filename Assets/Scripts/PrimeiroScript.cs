using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
    public float position;

    void Start()
    {
        position = PlayerPrefs.GetFloat("POSICAO", 1);

        //position = position + 1;
        //aumentar o valor em uma posicao 
        position++;

        PlayerPrefs.SetFloat("POSICAO", 150);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
