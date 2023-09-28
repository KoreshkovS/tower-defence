using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goblin : MonoBehaviour
{
    [SerializeField] private int _speed;

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);

        if (collision.CompareTag("Cannon"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
