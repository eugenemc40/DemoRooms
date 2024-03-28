using UnityEngine;

public class Torch : MonoBehaviour
{
    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        light.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        light.SetActive(false);
    }
}
