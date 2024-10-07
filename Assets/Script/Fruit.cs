using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindAnyObjectByType<TotalFuits>().CollecFruits();

        Debug.Log(gameObject.name);
        Player player = collision.GetComponent<Player>();
        player.CollectFruit();
        Destroy(gameObject);
        
    }
}
