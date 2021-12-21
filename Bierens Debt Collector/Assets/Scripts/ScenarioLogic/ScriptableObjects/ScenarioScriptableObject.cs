using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ScenarioScriptableObject : ScriptableObject
{
    public EmailModel model;
    public List<PlayerResponseScriptableObject> responseScriptableObjects;
}
