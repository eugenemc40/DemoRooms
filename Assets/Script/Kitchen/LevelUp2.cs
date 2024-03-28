using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelUp2 : MonoBehaviour
{
    public GameObject update1;
    public GameObject update2;
    public GameObject update3;
    public GameObject update4;
    public GameObject update5;
    public GameObject toActivate;
    public GameObject toDeactivate;
    public int level;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        toUpdate();
    }
    public void toUpdate()
    {
        if (update1.activeSelf && update2.activeSelf && update3.activeSelf && update4.activeSelf && update5.activeSelf)
        {
            toActivate.SetActive(true);
            toDeactivate.SetActive(false);
            levelChange(level);

        }
    }

    public void levelChange(int level)
    {
        SceneManager.LoadScene(level);
    }
}
