using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{

    public float timeValue = 90;
    public Text timerText;
    public float finaldistance;
    public DistanceTravelled distance;
    public MoveCube moveCube;
    public ScoreManager scoreManager;
    public ScoreUi scoreUi;
    public GameObject scoreboard;
    public bool recordScore;

    public GlyphGen glyphGen;
    public TextMeshPro code;
    
    //public ReadInput readInput;


    //public TMPro.TextMeshProUGUI timerText;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreboard.gameObject.SetActive(false);
        code.text = GlyphGen.code;

    }

    // Update is called once per frame
    void Update()
    {
        if(moveCube.hasMoved == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                recordScore = false;
            }
            else if (timeValue < 1)
            {

                timeValue = 0;
                finaldistance = distance.totalDistance;
                Debug.Log(finaldistance);

                //watch for sudden stop, maybe change to an addforce op
                //moveCube.rb.velocity = new Vector3(0, 0, 0);

                if (recordScore == false)
                {
                    scoreboard.gameObject.SetActive(true);
                    scoreManager.AddScore(new Score(GlyphGen.code, finaldistance));//change readinput to code

                    scoreUi.getScores();
                    recordScore = true;
                }
                //scoreboard.gameObject.SetActive(true);
                //scoreUi.getScores();

            }
        }
        DisplayTime(timeValue);

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }


        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
