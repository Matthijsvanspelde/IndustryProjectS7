using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ScenarioScriptableObject : ScriptableObject
{
    public MailModel model;
    public List<PlayerResponseScriptableObject> responseScriptableObjects;
}
