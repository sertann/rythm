using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    public GameObject projectile;
    public Transform shootPoint;
    int beat = 4;
    void Update()
    {
        TurnToMouse();
        if(Rythm.songPositionInBeats > beat)
        {
            Shoot();
            beat += 2;
        }
        

    }

    void TurnToMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.up = direction;
    }

    void Shoot()
    {
        Instantiate(projectile, shootPoint.position, Quaternion.identity);
    }
}
