using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUpdateController : MonoBehaviour
{
    [SerializeField] private GameController gameController;
public void CreateUIButtonsForScenarios()
    {
        List<StoryScriptableObject> objects = gameController.GetStoryScriptableObjects();
        foreach(StoryScriptableObject storyScriptableObject in objects)
        {

        }

    }
    public void LoadScenario(int index)
    {
        
        gameController.LoadScenario(index);
    }
    public void GoToNextObject(StoryScriptableObject storyScriptableObject)
    {
        gameController.NextStoryPart(storyScriptableObject);
    }
}
