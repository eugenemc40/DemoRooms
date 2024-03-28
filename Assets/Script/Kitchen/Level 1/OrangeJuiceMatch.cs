using UnityEngine;

public class OrangeJuiceMatch : MonoBehaviour
{


    public AudioClip sound;
    private AudioSource playerAudio;
    public GameObject setActive1;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OrangeJuice"))
        {
            setActive1.SetActive(true);
            playSound();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("OrangeJuice"))
        {

            setActive1.SetActive(false);

        }

    }


    private void playSound()
    {
        if (sound != null && playerAudio != null)
        {
            playerAudio.PlayOneShot(sound, 1.0f);
        }
    }
}
