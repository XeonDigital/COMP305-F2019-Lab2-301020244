using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScoreSO",menuName ="Game/ScoreBoard")]
[System.Serializable]
public class HighScoreSO : ScriptableObject
{
    // Start is called before the first frame update
    public float score;
    public float lives;
    public float highscore;
}
