using UnityEngine;

public class RequiredItemsLevel2 : MonoBehaviour
{
    public GameObject setActive1;
    public GameObject setActive2;
    public AudioClip sound;
    private AudioSource playerAudio;
    int itemprice1;
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
        if (other.gameObject.CompareTag("Steak"))
        {
            setActive2.SetActive(true);
        }

    }
}
