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
        arrowRenderer.sprite = revealedImage;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        arrowRenderer.sprite = defaultImage;
    }

    void Start()
    {
        arrowRenderer = GetComponent<SpriteRenderer>();
    }
}
