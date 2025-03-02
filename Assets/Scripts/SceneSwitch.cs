using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void switchToPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void switchToEnd()
    {
        SceneManager.LoadScene(2);
    }

    public void switchToTitle()
    {
        SceneManager.LoadScene(0);
    }
}
