using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    bool canCollect = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canCollect)
        {
            canCollect = false;
            FindAnyObjectByType<LevelScore>().AddScore(1);
            FindAnyObjectByType<TotalFuits>().CollecFruits();
            Debug.Log(gameObject.name);
            Player player = collision.GetComponent<Player>();
            player.CollectFruit();
            Destroy(gameObject);
        }
    }
}
