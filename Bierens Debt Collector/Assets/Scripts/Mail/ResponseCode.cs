using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseCode 
{
    public enum SendResponse { PAYNOW, CONFRONTATION, CALLBIERENS, RESEARCHCONFRONTATION }
    public SendResponse response;
}
