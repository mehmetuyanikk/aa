using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{

    public void AnaMenuOnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void CikisOnClick()
    {
        Application.Quit();
    }

}
