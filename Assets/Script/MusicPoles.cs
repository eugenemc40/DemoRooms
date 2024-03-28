using UnityEngine;
public class MusicPoles : MonoBehaviour
{
    public GameObject pole;
    public AudioClip sound;
    private AudioSource playerAudio;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {

            playerAudio.PlayOneShot(sound, 1.0f);
            meshRenderer.material.color = Random.ColorHSV();


        }
    }

}

