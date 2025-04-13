using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime * _speed;

        if(transform.position.y < -10)
        {
            transform.position = new Vector3(Random.Range(-4.56f, 4.56f), 11, 0);
        }
    }
}