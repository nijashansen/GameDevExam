using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class offsetGrab : XRGrabInteractable
{

    private Vector3 interactorPos = Vector3.zero;
    private Quaternion interactionRotation = Quaternion.identity;

    protected override void OnSelectEnter(XRBaseInteractor interactor)
    {
        base.OnSelectEnter(interactor);
        StoreInteractor(interactor);
        MatchAttachmentPoint(interactor);
    }

    private void StoreInteractor(XRBaseInteractor interactor)
    {
        interactorPos = interactor.attachTransform.localPosition;
        interactionRotation = interactor.attachTransform.localRotation;
    }

    private void MatchAttachmentPoint(XRBaseInteractor interactor)
    {
        bool hasAttached = attachTransform != null;
        interactor.attachTransform.position = hasAttached ? attachTransform.position : transform.position;
        interactor.attachTransform.rotation = hasAttached ? attachTransform.rotation : transform.rotation;
    }

    protected override void OnSelectExit(XRBaseInteractor interactor)
    {
        base.OnSelectExit(interactor);
        ResetAttachmentPoint(interactor);
        ClearInteractor(interactor);
    }

    private void ResetAttachmentPoint(XRBaseInteractor interactor)
    {
        interactor.attachTransform.localPosition = interactorPos;
        interactor.attachTransform.localRotation = interactionRotation;
    }

    private void ClearInteractor(XRBaseInteractor interactor)
    {
        interactorPos = Vector3.zero;
        interactionRotation = Quaternion.identity;
    }


}
