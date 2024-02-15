using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject screenWinner;
    [SerializeField] private GameObject screenLoser;
    [SerializeField] private GameObject infoUI;
    [SerializeField] private TextMeshProUGUI textPoints;

    private AudioSource sound;
    [SerializeField] private AudioClip soundWinner;
    [SerializeField] private AudioClip soundLoser;

    private int points = 0;

    private bool isGameOver;
    private bool isWinner;

    int currentIndexScene;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    
    private void Awake()
    {
        if (instance == null)       
        {
            instance = this;
        }
        else                        
        {
            Destroy(gameObject);
        }
        sound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        textPoints.text = "Points: " + points.ToString();
    }


    public void GameOver(bool result)
    {
        isWinner = result;
        isGameOver = true;

        infoUI.SetActive(false);

        Sound();

        if (isWinner)
        {
            StartCoroutine(WaitScreenWinner());    
        }
        else
        {
            StartCoroutine(WaitScreenGameOver());    
        }
    }

    IEnumerator WaitScreenGameOver()
    {
        yield return new WaitForSeconds(0.3f);
        screenLoser.SetActive(true);
    }

    IEnumerator WaitScreenWinner()
    {
        yield return new WaitForSeconds(0.3f);
        screenWinner.SetActive(true);
    }

    private void Sound()
    {
        if (isWinner)
        {
            sound.PlayOneShot(soundWinner);
        }
        else
        {
            sound.PlayOneShot(soundLoser);
        }
    }

    
    #region Buttons actions
    public void ClickButtonRestart()
    {
        SceneManager.LoadScene(currentIndexScene);
    }

    public void ClickButtonMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ClickButtonInstructions()
    {
        SceneManager.LoadScene(2);
    }

    public void ClickButtonExit()
    {
        Application.Quit();
    }

    #endregion


    #region Getters and setters
    public int GetCurrentIndexScene() { return currentIndexScene; }

    public void AddPoint()
    {
        points = points + 1;
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    #endregion
}

