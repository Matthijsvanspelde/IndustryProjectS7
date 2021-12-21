using UnityEngine;

public class PrinterSideTask : SideTask
{
    [SerializeField] private PrinterInteractable printerInteractable;

    public override void StartTask()
    {
        printerInteractable.StartPrinting();
    }
}
