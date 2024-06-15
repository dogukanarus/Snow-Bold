using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrailEffect;
    CapsuleCollider2D board;

    void Start()
    {
        board = GetComponent<CapsuleCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" && board.IsTouching(other.collider))
        {
            dustTrailEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrailEffect.Stop();
        }
    }
}
