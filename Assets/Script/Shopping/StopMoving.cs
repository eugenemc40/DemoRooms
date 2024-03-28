using UnityEngine;

public class StopMoving : MonoBehaviour
{
    private GameObject grabbedObject = null;
    private Transform previousParent = null;

    void Update()
    {
        if (grabbedObject != null)
        {

            grabbedObject.transform.position = transform.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (grabbedObject == null && other.CompareTag("Grabbable"))
        {

            grabbedObject = other.gameObject;
            previousParent = grabbedObject.transform.parent;
            grabbedObject.transform.SetParent(transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (grabbedObject != null && other.gameObject == grabbedObject)
        {

            grabbedObject.transform.SetParent(previousParent);
            grabbedObject = null;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (grabbedObject != null && other.CompareTag("Trolly"))
        {

            grabbedObject.transform.SetParent(other.transform);
        }
    }

}
