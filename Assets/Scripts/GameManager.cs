using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int point;

    public Image UIhealth;
    public Text UIPoint;
    public GameObject UIretry;

    public AudioClip audioHit;
    public AudioClip audioHeal;
    public AudioClip audioPoint;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        UIPoint.text = point.ToString() + " pt";
    }

    public void DecreaseHp()
    {
        audioSource.clip = audioHit;
        audioSource.Play();

        float currentHP = UIhealth.GetComponent<Image>().fillAmount;

        if(currentHP > 0.3f) //decrease HP
        {
            UIhealth.GetComponent<Image>().fillAmount -= 0.2f;
        }
        else //die
        {
            UIhealth.GetComponent<Image>().fillAmount -= 0.2f;
            Time.timeScale = 0; //∞‘¿” ≥ª Ω√∞£ ∏ÿ√„
            UIretry.SetActive(true);
        } 
    }

    public void GetHp()
    {
        audioSource.clip = audioHeal;
        audioSource.Play();

        UIhealth.GetComponent<Image>().fillAmount += 0.2f;
    }

    public void GetPoint()
    {
        audioSource.clip = audioPoint;
        audioSource.Play();

        point += 50;      
        PlayerPrefs.SetInt("savePoint", point);
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }
}
