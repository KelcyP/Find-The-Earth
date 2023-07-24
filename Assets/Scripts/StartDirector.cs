using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour
{
    public GameObject UIhelp;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ShowUI()
    {
        UIhelp.SetActive(true);
    }

    public void CloseUI()
    {
        UIhelp.SetActive(false);
    }
}
