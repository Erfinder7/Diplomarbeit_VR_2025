using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorGrabXR : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    public Transform Door_Klinke;

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);

        transform.position = Door_Klinke.position;
        transform.rotation = Door_Klinke.rotation;
    }
}