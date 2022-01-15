using UnityEngine;

public class Website : MonoBehaviour
{
    [SerializeField] private string address;


    public string Address { get => address; private set => address = value; }



}
