using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using MeuJogo.Bus.Manager;

public enum Animals
{
    Dog,
    Cat,
    Fish,
    Turtle,
    Bird,
    Pig
}

public class ScriptTest : MonoBehaviour
{

    public UnityEvent eventCallback;

    public EnemyBase enemyBase;

    public bool checkStatus = false;

    [Range(-5,5)]
    public int value01;
    public int value02;

    public int checkOne = 0;

    public Animals animal;
    public Animals animalType;

    public List<GameObject> listOfObjects;

    private void Attack()
    {
        foreach(var o in listOfObjects)
        {
            if(o != null)
            {
                var damageable = o.GetComponent<IDamageable<int>>();
                if (damageable != null)
                {
                    damageable.Damage(1);
                }
            }
            
        }
    }

    public void DebugLog()
    {
        Debug.Log("Cliquei no botao");
    }

    public List<AnimalSetup> animalSetup;

    /*public List<IKillable> damageablesList;

    private void Awake()
    {
        damageablesList = GameObject.FindObjectsOfType<IKillable>().ToList();
    }

    void Start()
    {
        
    }*/

    private void CheckSwitchCase(Animals a)
    {
        switch (a)
        {
            case Animals.Cat:
                OnReadCat();
                break;
            case Animals.Dog:
                OnReadDog();
                break;
            case Animals.Fish:
                OnReadFish();
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
            eventCallback.Invoke();

            CheckSwitchCase(Animals.Dog);
            ShowTextByAnimal(Animals.Dog);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            enemyBase.Attack();

         //CheckSwitchCase(Animals.Cat);
          //ShowTextByAnimal(Animals.Cat);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Attack();
            //CheckSwitchCase(Animals.Fish);
            //ShowTextByAnimal(Animals.Fish);   
        }
    }

    private void ShowTextByAnimal(Animals a)
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == a)
                Debug.Log(animal.text);
        }
    }

    private void CheckValues()
    {
        //if(true E true)
        if (value01 == 0)
        {
        }
        else if (value01 == 0)
        {
        }
        else if (value01 == 2)
        {
        }
    }

    private void OnReadCat()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if(animal.animalType == Animals.Cat)
            Debug.Log(animal.text);
        }
    }
    private void OnReadDog()
    {
        foreach(AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animals.Dog)
                Debug.Log(animal.text);
        }
    }

    private void OnReadFish()
    {
        foreach(AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animals.Fish)
                Debug.Log(animal.text);
        }
     
    }

    private void Update()
    {
        //CheckSwitchCase();
        CheckKeys();
        CheckValues();



        /*for (int i = 2; i >= 0; i--)
        {
            Debug.Log("i ->" + i);
        }

        //foreach(AnimalSetup animal in animalSetup)
        {
            Debug.Log(animal.animalType + " : : " + animal.text);
        }*/

    }

    [System.Serializable]
    public class AnimalSetup
    {
        public Animals animalType;
        public Animals animal;
        public string text;
    }
}

