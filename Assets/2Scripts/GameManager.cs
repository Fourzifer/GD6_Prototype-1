using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    GameObject startText;
    GameObject poseFail;

    public AudioSource theMusic;

    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    AudioClip lastClip;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;

    //public int currentMultiplier;
    //public int multiplierTracker;
    //public int[] multiplierThresholds;

    public Text scoreText;
    //public Text multiText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: " + currentScore;
        //currentMultiplier = 1;

        startText = GameObject.Find("StartText");
        poseFail = GameObject.Find("PoseFail");
        poseFail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();

                startText.SetActive(false);
            }
        }
    }

    AudioClip RandomClip()
    {
        int attempts = 3;
        AudioClip newClip = audioClipArray[Random.Range(0, audioClipArray.Length)];

        while (newClip == lastClip && attempts > 0)
        {
            newClip = audioClipArray[Random.Range(0, audioClipArray.Length)];
            attempts--;
        }

        lastClip = newClip;
        return newClip;
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        //if (currentMultiplier - 1 < multiplierThresholds.Length)
        //    { 
        //    multiplierTracker++;

        //    if(multiplierThresholds[currentMultiplier-1] <= multiplierTracker)
        //    {
        //        multiplierTracker = 0;
        //        currentMultiplier++;
        //    }

        //    multiText.text = "Multiplier: x" + currentMultiplier;

        currentScore += scorePerNote; /** currentMultiplier;*/
        scoreText.text = "Score: " + currentScore;

        audioSource.PlayOneShot(RandomClip());
        //}
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        poseFail.SetActive(true);

        //currentMultiplier = 1;
        //multiplierTracker = 0;

        //multiText.text = "Multiplier: x" + currentMultiplier;

        StartCoroutine(ShowFail());
        IEnumerator ShowFail()
        {
            yield return new WaitForSeconds(1);

            poseFail.SetActive(false);
        }
    }
}