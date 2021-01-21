using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerInput : MonoBehaviour
{

    public bool isImgOn;
    public Image up;
    public Image down;
    public Image left;
    public Image right;

    void Start()
    {

        up.enabled = true;
        down.enabled = true;
        left.enabled = true;
        right.enabled = true;
        isImgOn = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            up.enabled = false;
            isImgOn = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            up.enabled = true;
            isImgOn = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            left.enabled = false;
            isImgOn = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            left.enabled = true;
            isImgOn = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            down.enabled = false;
            isImgOn = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            down.enabled = true;
            isImgOn = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            right.enabled = false;
            isImgOn = false;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            right.enabled = true;
            isImgOn = true;
        }

        //if (Input.GetKeyDown("w"))
        //{

        //    if (isImgOn == true)
        //    {

        //        img.enabled = false;
        //        isImgOn = false;
        //    }

        //    else
        //    {

        //        img.enabled = true;
        //        isImgOn = true;
        //    }
        //}
    }
}