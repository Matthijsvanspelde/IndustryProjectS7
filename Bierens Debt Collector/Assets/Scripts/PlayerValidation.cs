using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValidation : MonoBehaviour
{
    List<string> validationListPlayer = new List<string>();

    public List<string> ValidationListPlayer { get => validationListPlayer; set => validationListPlayer = value; }
}
