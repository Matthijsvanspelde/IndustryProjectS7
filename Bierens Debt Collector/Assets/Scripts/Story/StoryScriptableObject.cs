using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Story", menuName = "ScriptableObjects/StoryScriptable", order = 1)]
public class StoryScriptableObject : ScriptableObject
{
    [Header("story Leads To")]
    public StoryScriptableObject payResponse;
    public StoryScriptableObject conformtationResponse;
    public StoryScriptableObject excuse;
    public StoryScriptableObject CallBierensResponse;
    public StoryScriptableObject SendMemoryMail;
    public bool storyFinished;


    [Header("Mail setup")]
    [TextArea]
    public string mailTextBox;
    public string mailHeader;

    [Header("Other Events?")]
    public ValidationScriptableObject validation;
}
