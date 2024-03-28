using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public MeshRenderer meshRenderer;


    void ChangeColour()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
