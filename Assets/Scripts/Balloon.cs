using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private void Update()
    {
        Destroy(gameObject, 3.5f);
    }
}
