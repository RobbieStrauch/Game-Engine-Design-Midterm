using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Fairy Hit");
            AudioController.instance.isFairyHit = true;
            Destroy(gameObject);
        }
    }
}
