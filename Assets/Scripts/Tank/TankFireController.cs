using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankFireController : MonoBehaviour
{
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private int poolSize = 5;
    private GameObject[] shellPool;
    private int poolSelection = 0;

    [SerializeField] private Transform barrel;

    public InputAction fireAction;



    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();

        shellPool = new GameObject[poolSize];
        for(int i = 0; i < poolSize; i++)
        {
            GameObject shell = Instantiate(shellPrefab, barrel.position, transform.rotation);
            shellPool[i] = shell;
            shell.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fireAction.triggered)
        {
            if (shellPool[poolSelection].activeSelf == false)
            {
                shellPool[poolSelection].transform.position = barrel.position;
                shellPool[poolSelection].transform.rotation = transform.rotation;
                shellPool[poolSelection].SetActive(true);

                if(poolSelection < poolSize - 1)
                {
                    poolSelection++;
                }
                else
                {
                    poolSelection = 0;
                }
            }
        }   
    }
}
