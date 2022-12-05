using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderGround : MonoBehaviour
{
    public AudioClip offGroundSnd;
    private AudioSource playerAudio;

    private float _force = 100.0f;
    private Rigidbody playerRb;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.y < 0)
        {
            playerRb.velocity = Vector3.zero;
            playerRb.angularVelocity = Vector3.zero;
            playerRb.AddForce(Vector3.up * _force, ForceMode.Impulse);
            playerAudio.PlayOneShot(offGroundSnd, 1.0f);
        }
    }
}
