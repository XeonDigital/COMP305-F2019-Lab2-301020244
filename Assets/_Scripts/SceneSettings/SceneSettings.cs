using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneSettings", menuName = "Scene/Settings")]
[System.Serializable]
public class SceneSettings : ScriptableObject
{
    [Header("Labels")]
    public bool scoreLabelEnabled;
    public bool livesLabelEnabled;
    public bool highScoreLabelEnabled;
    public bool startLabelSetActive;
    public bool highScoreLabelText;
    public bool startLabelActive;
    public bool endLabelActive;
    [Header("Button")]
    public bool startButtonActive;
    public bool restartButtonActive;
    public bool startButtonSetActive;
    public bool endLabelSetActive;
    [Header("Scene Config")]
    public SoundClip activeSoundClip;
    public Scene scene;
}
