using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Balloon")
        {
            if(collision.gameObject.name == "Blue Balloon(Clone)")
            {
                Score.AddPoints(10);
            }
            else
            {
                Score.AddPoints(1);
            }
            Destroy(gameObject, 0.07f);
            Destroy(collision.gameObject, 0.07f);
        }
    }
}
