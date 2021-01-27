using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTrigger : MonoBehaviour
{

    private SpriteRenderer arrowRenderer;
    public Sprite noImage;
    public Sprite revealedImage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        arrowRenderer.sprite = revealedImage;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        arrowRenderer.sprite = noImage;
    }

    void Start()
    {
        arrowRenderer = GetComponent<SpriteRenderer>();
        arrowRenderer.sprite = noImage;
    }
}
