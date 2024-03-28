using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopNextLevel : MonoBehaviour
{
    public GameObject update1;
    public GameObject update2;
    public int level;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trolly") && update1.activeSelf)
        {
            levelChange(level);
        }
    }

    public void levelChange(int level)
    {
        SceneManager.LoadScene(level);
    }

}
