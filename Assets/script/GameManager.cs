using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;

    }

    public GameObject rain;
    public GameObject Endpanal;
    public Text totalScoreTxt;
    public Text timeTxt;

    int totalScore = 0;

    float totalTime = 30.0f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("MakeRain", 0, 0.5f);
    }


    // Update is called once per frame
    void Update()
    {
        if (totalTime > 0f)

        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            totalTime = 0f;
            Endpanal.SetActive(true);
            Time.timeScale = 0f;
        }
        timeTxt.text = totalTime.ToString("N2");
        Debug.Log(totalTime);
    }
    void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();

    }
}


