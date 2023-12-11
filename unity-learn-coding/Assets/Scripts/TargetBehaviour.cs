using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetBehaviour : MonoBehaviour
{
    private int health = 100;
    public int healingSpeed;
    
    public Text uiMessage;
    public TextMeshPro uiHealth;

    Target targetSphere;
    Target targetCube;


    private void Start()
    {
        targetSphere = new Sphere();
        targetCube = new Cube();

        uiMessage = GameObject.FindWithTag("uiMessage").GetComponent<Text>();
        uiHealth = transform.GetChild(0).GetComponent<TextMeshPro>();
    }
    
    private void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 1)
        {
            health = 100;
        }
    }

    private void Update()
    {
        uiHealth.text = health.ToString();
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            if (gameObject.tag == "TargetSphere")
            {
                uiMessage.text = targetSphere.Reaction();
                TakeDamage(targetSphere.Damage());
            }
            else
            {
                uiMessage.text = targetCube.Reaction();
                TakeDamage(targetCube.Damage());
            }
        }

        
    }
}
