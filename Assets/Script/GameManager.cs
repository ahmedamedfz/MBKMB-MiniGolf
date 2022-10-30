using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] PlayerController player;
    [SerializeField] Hole hole;

    private void Start()
    {
        gameOverPanel.SetActive(false);    
    }

    // Update is called once per frame
    private void Update()
    {
        if(hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Finished! Shoot Count : "+player.ShootCount;
        }
    }
    public void BackToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }
    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }
    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}
