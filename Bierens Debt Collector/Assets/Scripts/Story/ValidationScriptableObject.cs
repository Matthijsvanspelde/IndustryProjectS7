using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ValidationCompany", menuName = "ScriptableObjects/ValidationCompany", order = 1)]
public class ValidationScriptableObject : ScriptableObject
{
    public  List<string> ValidationText;
    public bool OpenButtonsCallBierens;
    public bool OpenButtonsConforntation;

}
