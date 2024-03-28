using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void levelChange(int level)
    {
        SceneManager.LoadScene(level);
    }

}
