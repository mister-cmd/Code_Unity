using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    int health = 5;
    //Уровень NPC
    int level = 1;
    //Скорость NPC
    float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
