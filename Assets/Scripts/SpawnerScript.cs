using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject colliderObject;
    public Transform respawnPoint;
    public GameObject spring;
    SpringScript externalSpringScript;
    LifesScript externalLifeScript;
    // Start is called before the first frame update
    void Start()
    {
        externalSpringScript = spring.GetComponent<SpringScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            externalSpringScript.ballIn = true;
            ball.transform.position = respawnPoint.position;
            colliderObject.GetComponent<Collider>().isTrigger = true;
        }
    }
}
