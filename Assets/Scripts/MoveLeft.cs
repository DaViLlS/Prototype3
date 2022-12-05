using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 30;
    private PlayerController playerControllerScript;
    private float _leftBound = -15;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (playerControllerScript.gameOver == false) transform.Translate(Vector3.left * Time.deltaTime * _speed);

        if (transform.position.x < _leftBound && gameObject.CompareTag("Obstacle")) Destroy(gameObject);
    }
}
