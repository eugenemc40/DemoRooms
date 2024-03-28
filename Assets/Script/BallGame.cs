using UnityEngine;
public class BallGame : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource playerAudio;
    public MeshRenderer meshRenderer;
    public Color initialEmissionColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bat"))
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
