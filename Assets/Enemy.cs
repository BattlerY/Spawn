using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(transform.position.x + 2*Time.deltaTime, transform.position.y);
    }
}
