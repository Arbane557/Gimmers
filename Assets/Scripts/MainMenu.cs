using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject option;
    bool isPause;
    [SerializeField]
    private GameObject pauseButton;
    [SerializeField]
    private Texture2D[] pauseSprite;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();

        if (isPause) Time.timeScale = 0;
        else Time.timeScale = 1;
    }
    public void ReturnToTitle()
    {
        SceneManager.LoadScene(0);
    }
    public void Pause()
    {
        if (!isPause) { pauseButton.GetComponent<RawImage>().texture = pauseSprite[0]; isPause = true; option.SetActive(true); } else { pauseButton.GetComponent<RawImage>().texture = pauseSprite[1]; isPause = false; option.SetActive(false); }
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame() 
    {
        Application.Quit();
    }

}
