Projectile.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Projectile : MonoBehaviour
{
    public float speed = 10f;
 
    void Start()
    {
        Destroy(gameObject, 1f);
    }
 
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
GameController.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GameController : MonoBehaviour
{
    public static float gameSpeed;
 
    [Range(0, 5)]
    public float gameSpeedRegulator;
    public float speedRate = 0.5f;
    public float gameSpeedMax = 5;
 
    void Update()
    {
        if (gameSpeedRegulator <= gameSpeedMax)
        {
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        gameSpeed = gameSpeedRegulator;
    }
}
