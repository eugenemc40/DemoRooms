using UnityEngine;

public class RequiredItems : MonoBehaviour
{
    public GameObject setActive1;
    public AudioClip sound;
    private AudioSource playerAudio;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            setActive1.SetActive(true);
        }
    }
}
