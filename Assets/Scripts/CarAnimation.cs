using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarAnimation : MonoBehaviour
{
    public float duration = 1;
    public Ease ease = Ease.Linear;

    // Start is called before the first frame update
    void Start()
    {
        //se mover ate 6 na posicao x na duracao duration usando o ease EASE.

        transform.DOMoveX(25, duration).SetEase(ease);
    }
}
