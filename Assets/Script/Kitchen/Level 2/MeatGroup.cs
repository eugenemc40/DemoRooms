using UnityEngine;

public class MeatGroup : MonoBehaviour
{
    public GameObject setActive1;
    public AudioClip sound;
    private AudioSource playerAudio;
    public string[] requiredTags;
    private int requiredObjectCount = 3;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (IsMatchingObject(other.gameObject))
        {
            requiredObjectCount--;

            if (requiredObjectCount == 0)
            {
                TriggeredAction();
            }
        }
    }

    private bool IsMatchingObject(GameObject obj)
    {
        foreach (string requiredTag in requiredTags)
        {
            if (obj.CompareTag(requiredTag))
            {
                return true;
            }
        }

        return false;
    }

    private void TriggeredAction()
    {
        setActive1.SetActive(true);
        playerAudio = GetComponent<AudioSource>();
        playSound();
    }

    private void playSound()
    {
        if (sound != null && playerAudio != null)
        {
            playerAudio.PlayOneShot(sound, 1.0f);
        }
    }
}
