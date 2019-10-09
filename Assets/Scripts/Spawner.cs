using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 5f;
    public GameObject aster;
    private float nextTimeToSpawn = 0f;
    private Vector2 posicion;

    // Update is called once per frame
    void Update()
    {
        posicionRandom();      
        if (Time.time >= nextTimeToSpawn)
        {
            //aster.GetComponent<aster>().SetPos(posicion);
            Instantiate(aster, posicion, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }

    void posicionRandom()
    {
        float l = Random.value, x, y;
        if (l > 0.5f)
        {
            x = Random.value;
            if (x > 0.5f)
            {
                x = 10;                
            }
            else
            {
                x = -10;                
            }
            y = Random.Range(-6, 6);
        }
        else
        {
            y = Random.value;
            if (y > 0.5f)
            {
                y = 6;               
            }
            else
            {
                y = -6;                
            }
            x = Random.Range(-10, 10);            
        }
        posicion = new Vector2(x, y);      
    }
    public Vector2 GetPosicion()
    {
        return posicion;
    }
}
