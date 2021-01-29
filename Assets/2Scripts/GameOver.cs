using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameOverText = GameObject.Find("GameOverText");
        //gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            Debug.Log("GAME OVER");

            //gameOverText.SetActive(true);
        }
    }
}
