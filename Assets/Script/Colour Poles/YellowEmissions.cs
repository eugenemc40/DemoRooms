using UnityEngine;

public class YellowEmissions : MonoBehaviour
{
    public Material targetMaterial;  // Assign the material in the Unity Editor
    public Color initialEmissionColor = Color.white;  // Set the initial emission color
    public Color newEmissionColor = Color.yellow;  // Set the desired emission color
    public AudioClip sound;
    private AudioSource playerAudio;



    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

        if (targetMaterial == null)
        {
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                targetMaterial = renderer.material;
            }
        }

        if (targetMaterial != null)
        {
            // Set the initial emission color
            targetMaterial.SetColor("_EmissionColor", initialEmissionColor);
            targetMaterial.EnableKeyword("_EMISSION");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bat"))
        {
            ChangeEmissionColor(newEmissionColor);
            playSound();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Example: Revert emission color on release
        ChangeEmissionColor(initialEmissionColor);
    }


    void ChangeEmissionColor(Color newColor)
    {
        if (targetMaterial != null)
        {
            targetMaterial.SetColor("_EmissionColor", newColor);
            targetMaterial.EnableKeyword("_EMISSION");
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
