using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShellManager : MonoBehaviour
{
    [SerializeField] private float shellSpeed = 10.0f;
    [SerializeField] private float shellLife = 5.0f;
    private float timer;

    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * shellSpeed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer >= shellLife)
            GameObject.Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
        }
    }
}
