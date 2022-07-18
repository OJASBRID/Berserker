using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUImanager : MonoBehaviour
{
    [SerializeField]
    public Text score_text;
    public Score _score;
     void Update( )
    {
        score_text.text = "" + (int)_score.score;
    }
}
