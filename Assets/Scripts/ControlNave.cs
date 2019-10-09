using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNave : MonoBehaviour
{
    public Animator anim;
    public GameObject punto;
    Rigidbody2D rb;
    Vector2 e;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Moverse();
        //Disparo();
    }
    
    void Moverse()
    {
        e = punto.transform.position - transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(e*2);
            anim.SetBool("cambio",true);
        }
        else
        {
            anim.SetBool("cambio", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-e); anim.SetBool("cambio", true);
        }
              
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "asteroide")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
