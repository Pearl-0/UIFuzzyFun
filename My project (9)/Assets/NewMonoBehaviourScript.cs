using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{



    public void Open()
    {
        SceneManager.LoadScene("newnaming");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("newnaming");
    }

    public void Open2()
    {
        SceneManager.LoadScene("customization page");
    }

    public void Open2Home()
    {
        SceneManager.LoadScene("homeTemp");
    }

    public void OpenPopUp()
    {
        SceneManager.LoadScene("miniGame1");
    }

}
