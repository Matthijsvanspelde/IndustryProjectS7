using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebitorResponseScriptableObject : ScriptableObject
{
    private string smoes;
    private string betalingsWeigering;

    public string ReturnResponse()
    {
        if (smoes.Length > 0)
        {
            return smoes;
        }
        else
        {
            return betalingsWeigering;
        }
    }
}
