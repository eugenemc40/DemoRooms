using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SoundAndColourInteract : XRBaseInteractor
{
    private XRBaseInteractor currentInteractable = null;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {

    }

    private void SetInteractable(Collider other)
    {

    }

    private void OnTriggerExit(UnityEngine.Collider other)
    {

    }

    private void ClearInteractable(Collider other)
    {

    }

    private bool TryGetInteractable(Collider collider, out XRBaseInteractable interactable)
    {
        interactable = interactionManager.GetInteractableForCollider(collider);

        return false;
    }

    public override void GetValidTargets(List<IXRInteractable> validtargets)
    {
        throw new System.NotImplementedException();
    }

}
