using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTrigger : MonoBehaviour
{

    private SpriteRenderer arrowRenderer;
    public Sprite defaultImage;
    public Sprite revealedImage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object Entered the trigger");
        arrowRenderer.sprite = revealedImage;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Object Exited the trigger");
        arrowRenderer.sprite = defaultImage;
    }

    void Start()
    {
        arrowRenderer = GetComponent<SpriteRenderer>();
    }
}
