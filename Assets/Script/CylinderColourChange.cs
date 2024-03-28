using UnityEngine;

public class CylinderColourChange : MonoBehaviour

{
    public Material targetMaterial;  // Assign the material in the Unity Editor
    public Color initialEmissionColor = Color.magenta;  // Set the initial emission color
    public Color newEmissionColor = Color.white;  // Set the desired emission color
    public float raiseThreshold = 1.2f;



    void Start()
    {
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
    void Update()
    {
        if (transform.position.y > raiseThreshold)
        {
            ChangeEmissionColor(newEmissionColor);
        }
        if (transform.position.y < raiseThreshold)
        {
            ChangeEmissionColor(initialEmissionColor);
        }
    }


    void ChangeEmissionColor(Color newColor)
    {
        if (targetMaterial != null)
        {
            targetMaterial.SetColor("_EmissionColor", newColor);
            targetMaterial.EnableKeyword("_EMISSION");
        }
    }
}

