using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Spikes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        player.Die();
    }

}
