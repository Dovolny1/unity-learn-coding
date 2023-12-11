using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartingCube : MonoBehaviour
{
    public TextMeshPro header;
    public bool Launch;
    public float timer = 3f;

    private void Update()
    {
        if (Launch)
        {
            timer -= 1 * Time.deltaTime;
            if (timer < 0 )
            {
                SceneManager.LoadScene(1);
            }
            header.text = "Starting in " + timer.ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            if (!Launch)
            {
                Launch = true;
            }   
        }
    }
}
