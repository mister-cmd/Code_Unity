using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    int health = 5;
    //������� NPC
    int level = 1;
    //�������� NPC
    float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("������: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        health = health + level;
        print("������: " + health);
    }
}
