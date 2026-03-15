using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorGrabXR_Advanced : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    public Transform Door_Klinke_R;

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);

        transform.position = Door_Klinke_R.position;
        transform.rotation = Door_Klinke_R.rotation;
    }
}