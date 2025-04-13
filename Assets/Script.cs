using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game 
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Text _text;
        private int hp = 3;

        private void Update()
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < 2.50f)
            {
                transform.position += Vector3.up * Time.deltaTime * _speed;
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -2.50f)
            {
                transform.position += Vector3.down * Time.deltaTime * _speed;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 5.85f)
            {
                transform.position += Vector3.right * Time.deltaTime * _speed;
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x > -5.85f)
            {
                transform.position += Vector3.left * Time.deltaTime * _speed;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision) 
        {
            if(collision.CompareTag("Enemy"))
            {
                hp--;
                _text.text = hp.ToString(); // Исправлено здесь
            }
        }
    }
}