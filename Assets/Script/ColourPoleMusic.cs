using UnityEngine;


public class ColourPoleMusic : MonoBehaviour
{
    public GameObject pole;
    public AudioClip sound;
    private AudioSource playerAudio;
    public MeshRenderer meshRenderer;

    public new Light light;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        playerAudio.PlayOneShot(sound, 1.0f);
        meshRenderer.material.color = Random.ColorHSV();
        light.enabled = true;
    }


    private void OnTriggerExit(Collider other)
    {
        light.enabled = false;
    }


    public void LightOn()
    {
        light.enabled = true;
    }

    public void LightOff()
    {
        light.enabled = false;
    }
}
