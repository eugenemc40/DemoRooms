using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopNextLevel2 : MonoBehaviour
{
    public GameObject update1;
    public GameObject update2;
    public GameObject update3;
    public int level;


    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Trolly") && update1.activeSelf && update2.activeSelf && update3.activeSelf)
        {
            levelChange(level);
        }
    }

    public void levelChange(int level)
    {
        SceneManager.LoadScene(level);
    }
}
