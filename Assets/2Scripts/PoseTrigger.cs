using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseTrigger : MonoBehaviour
{

    private SpriteRenderer poseRenderer;
    public Sprite noPose;
    public Sprite pose1;
    public Sprite pose2;
    public Sprite pose3;

    //private bool shit;

    // Start is called before the first frame update
    void Start()
    {
        //shit = true;
        poseRenderer = GetComponent<SpriteRenderer>();
        poseRenderer.sprite = noPose;
    }

    //private void RevealPoses()
    //{
    //    if (GameObject.Find("GameManager").GetComponent<GameManager>().currentScore >= 100)
    //    {
    //        Debug.Log("Pose Change");
    //        poseRenderer.sprite = pose;
    //    }
    //}

    void Update()
    {
        //if (shit == true)
        //{
        //    Debug.Log("Pose Change");
        //    poseRenderer.sprite = pose;
        //}

        if (GameObject.Find("GameManager").GetComponent<GameManager>().currentScore >= 1000)
        {
            poseRenderer.sprite = pose1;
        }

        if (GameObject.Find("GameManager").GetComponent<GameManager>().currentScore >= 3000)
        {
            poseRenderer.sprite = pose2;
        }

        if (GameObject.Find("GameManager").GetComponent<GameManager>().currentScore >= 6000)
        {
            poseRenderer.sprite = pose3;
        }
    }
}