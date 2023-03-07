using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    #region VARIAVEIS
    [Header("Variaveis")]
public int doors = 4;

public float life = 10f;
public float damage = 0.5f;

public bool canAcelerate = false;

    [Header("Referencias")]
    private GameObject _meuObject;
   private Transform _myTransform;

    [Header("Cor")]
    public Color color = Color.red;

    [Header("Inputs")]
    public KeyCode keyCode = KeyCode.Space;
    #endregion

    public void ChangeColor(Color newColor)
    {
        color = newColor;
        life = life - damage;
    }

    public void Test()
    {
        Debug.Log("Test");
    }

    public void Test(int i)
    {
        Debug.Log("TestInt");
    }
    public void Test(float i)
    {
        Debug.Log("TestFloat");
    }

    public void Acelerate()
    {
        canAcelerate = true;
    }
    #region METODOS
    private void Awake()
    {
        Debug.Log("Awake comecou");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start comecou");
        GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update ");

        if (Input.GetKeyDown(keyCode))
        {
            ChangeColor(Color.yellow);
        }
      else  if (Input.GetKeyUp(keyCode))
        {
            ChangeColor(Color.magenta);
        }
      else  if (Input.GetKey(keyCode))
        {
            ChangeColor(Color.blue);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down");
        }

        if (Input.GetButtonDown("Fire1"))
        {

        }
    }

    /*private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }*/
    #endregion
}
