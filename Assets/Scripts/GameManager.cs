using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startMenu;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] GameObject finishWindow;
    [SerializeField] CoinManager coinManager;
    private void Start()
    {
        levelText.text = SceneManager.GetActiveScene().name;
    }

    public void Play()
    {
        startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
    }

    public void ShowFinishWindow()
    {
        finishWindow.SetActive(true);
    }


    public void NextLevel()
    {

        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            coinManager.SaveToProgress();
            SceneManager.LoadScene(next);
        }
    }
}
