using UnityEngine;

public class AppleMove : MonoBehaviour
{
    private GameObject grabbedObject = null;
    private Rigidbody grabbedRigidbody = null;
    private Transform previousParent = null;

    void Update()
    {
        if (grabbedObject != null)
        {
            // Move the grabbed object along with the controller
            grabbedObject.transform.position = transform.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (grabbedObject == null && other.CompareTag("Apple"))
        {
            // Pick up the object
            grabbedObject = other.gameObject;
            grabbedRigidbody = grabbedObject.GetComponent<Rigidbody>();
            if (grabbedRigidbody != null)
            {
                grabbedRigidbody.isKinematic = true; // Freeze the object's movement
            }
            previousParent = grabbedObject.transform.parent;
            grabbedObject.transform.SetParent(transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (grabbedObject != null && other.gameObject == grabbedObject)
        {
            // Release the object
            if (grabbedRigidbody != null)
            {
                grabbedRigidbody.isKinematic = false; // Unfreeze the object's movement
            }
            grabbedObject.transform.SetParent(previousParent);
            grabbedObject = null;
        }
    }
}
