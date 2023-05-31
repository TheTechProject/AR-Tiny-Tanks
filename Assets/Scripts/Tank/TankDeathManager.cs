using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankDeathManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Shell")
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
