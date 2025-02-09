Player.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{
    public int points;
 
    public Projectile projectilePrefab;
 
    public float shootInterval;
    public float shootTimer;
 
    public Transform shootPoint;
 
    void Update()
    {
        Move();
 
        shootTimer -= Time.deltaTime;
 
        Shoot();
    }
 
    void Shoot()
    {
        if(shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
    }
 
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }
}
Mover.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Mover : MonoBehaviour
{
    public float speed = 2f;
 
    void Start()
    {
       Destroy(gameObject, 5f);
    }
 
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * (speed + GameController.gameSpeed) * Time.deltaTime;
    }
}
