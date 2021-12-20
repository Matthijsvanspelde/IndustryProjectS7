using UnityEngine;

public class PhoneSideTask : SideTask
{
    [SerializeField] private PhoneInteractable phoneInteractable;

    public override void StartTask()
    {
        phoneInteractable.StartRinging();
    }
}
