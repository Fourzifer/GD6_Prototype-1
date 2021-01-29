using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("Object Entered the trigger");
    //}

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Object is within the trigger");
    }

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    Debug.Log("Object Exited the trigger");
    //}

    public bool canBePressed;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.activeSelf)
        { 
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();

            gameObject.SetActive(false);
        }
    }
    }
}
