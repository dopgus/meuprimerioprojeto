using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animais
{
    Turtle,
    Bird,
    Pig
}

public class ProjetoScript : MonoBehaviour
{

    public Animais animal;
    public Animais animalType;

    public List<AnimalSetup> animalSetup;
    
    void Start()
    {
        
    }


    private void CheckSwitchCase(Animais a)
    {
        switch (a)
        {
            case Animais.Turtle:
                OnReadTurtle();
                break;
            case Animais.Pig:
                OnReadPig();
                break;
            case Animais.Bird:
                OnReadBird();
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }

    private void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //CheckSwitchCase(Animals.Pig);
            ShowTextByAnimal(Animais.Pig);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //CheckSwitchCase(Animals.Turtle);
            ShowTextByAnimal(Animais.Turtle);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //CheckSwitchCase(Animals.Bird);
            ShowTextByAnimal(Animais.Bird);
        }
    }

    private void ShowTextByAnimal(Animais a)
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == a)
                Debug.Log(animal.text);
        }
    }


    private void OnReadTurtle()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animais.Turtle)
                Debug.Log(animal.text);
        }
    }
    private void OnReadPig()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animais.Pig)
                Debug.Log(animal.text);
        }
    }

    private void OnReadBird()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animais.Bird)
                Debug.Log(animal.text);
        }

    }

    private void Update()
    {
        CheckKeys();
    }

    [System.Serializable]
    public class AnimalSetup
    {
        public Animais animalType;
        public Animais animal;
        public string text;
    }
}
