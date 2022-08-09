using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetText : MonoBehaviour
{
    public float score = 0;
    public TMP_Text text;
    public GameObject player;
    private ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = player.GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        score = scoreKeeper.Score;
        text.SetText(score.ToString());
        Debug.Log("help");
        Debug.Log(score);
    }
}
