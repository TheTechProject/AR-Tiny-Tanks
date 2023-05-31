using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShellManager : MonoBehaviour
{
    [SerializeField] private float shellSpeed = 10.0f;
    [SerializeField] private float shellLife = 5.0f;
    private float timer;

    private Rigidbody rigidbody;

    //private Vector3 velocity;

    private void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.right * shellSpeed;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += velocity * shellSpeed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer >= shellLife)
            gameObject.SetActive(false);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
        }
    }*/
}
