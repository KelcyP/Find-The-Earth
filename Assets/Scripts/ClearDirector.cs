using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    int savePoint;
    public Text finalPoint;
    
    void Start()
    {
        savePoint = PlayerPrefs.GetInt("savePoint", 0);
        PlayerPrefs.Save();
    }

    void Update()
    {
        finalPoint.text = savePoint.ToString() + " pt";
    }

    public void Restart()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("StartScene");
    }
}
