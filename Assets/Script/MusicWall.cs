using UnityEngine;
public class MusicWall : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource playerAudio;
    public MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            playSound();
            meshRenderer.material.color = Random.ColorHSV();
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

