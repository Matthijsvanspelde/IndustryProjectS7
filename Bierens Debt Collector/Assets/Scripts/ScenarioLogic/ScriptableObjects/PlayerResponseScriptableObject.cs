using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerResponseScriptableObject : ScriptableObject
{
    private string DemandingPlayerResponse;
    private string RequestingPlayerResponse;
    private string ThreatheningPlayerResponse;

public string GetPlayerResponse()
    {
        if (DemandingPlayerResponse.Length > 0)
        {
            return DemandingPlayerResponse;
        }
       else if (RequestingPlayerResponse.Length > 0)
        {
            return RequestingPlayerResponse;
        }
        else
        {
            return ThreatheningPlayerResponse;
        }
    }
}
