using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float EnemySpeed = 2.5f;

    void Update()
    {
        transform.Translate(EnemySpeed*Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Wall1")

        {
            transform.localScale = new Vector2(4, 4);
            EnemySpeed = EnemySpeed * -1;
        }
        if (other.collider.tag == "Wall2")
        {
            transform.localScale = new Vector2(-4, 4);
            EnemySpeed = EnemySpeed * -1;
        }
    }
}
