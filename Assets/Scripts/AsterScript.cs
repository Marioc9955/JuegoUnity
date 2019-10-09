using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsterScript : MonoBehaviour
{
    //public GameObject s;
    private float speed;
    private Vector2 direction;
    private Vector2 movement/*, pos*/;
    private Rigidbody2D rigidbodyComponent;
    float velRot;
    private void Start()
    {     
        rigidbodyComponent = GetComponent<Rigidbody2D>();
        DatosRandom();
    }

    // Update is called once per frame
    void Update()
    {       
        print(direction.ToString());
        movement = speed * direction;
        //pos = s.GetComponent<Spawner>().posicion; //Aqui se pretende obtener la posicion del asteroide al crearse para asignarle una direccion
        //Debug.Log(pos.ToString());
        rigidbodyComponent.angularVelocity = velRot;
        rigidbodyComponent.velocity = movement;
    }

    void FixedUpdate()
    {
        
    }

    void DatosRandom()
    {
        float x, y;
        velRot = Random.Range(-200f, 200f);
        speed = Random.Range(1f, 5f);
        //Esta cadena de if pretende darle una direccion al asteroide segun el limite donde aparece, segun su posicion
        //Debug.Log(s.posicion.x + ",,," + s.posicion.y);
        //if (s.posicion.x == -10)
        //{
        //    x = Random.Range(0.1f, 1f);
        //    y = Random.Range(-1f, 1f);
        //}
        //else if (s.posicion.x == 10)
        //{
        //    x = Random.Range(-1f, 0.1f);
        //    y = Random.Range(-1f, 1f);
        //}
        //else if (s.posicion.y == -6)
        //{
        //    x = Random.Range(-1f, 1f);
        //    y = Random.Range(0.1f, 1f);
        //}
        //else
        //{
        //    x = Random.Range(-1f, 1f);
        //    y = Random.Range(-1f, 0.1f);
        //}
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y).normalized;
    }

    //public void SetPos(Vector2 pos)
    //{
    //    this.pos = pos;
    //}
}
