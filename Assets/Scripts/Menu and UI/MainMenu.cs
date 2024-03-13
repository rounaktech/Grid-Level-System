using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenuCanvas, levelSelectionCanvas, gameCanvas;
    public void StartButton()
    {
        levelSelectionCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
        SoundManager.Instance.StartSound();
    }

    public void BackButton()
    {
        mainMenuCanvas.SetActive(true);
        levelSelectionCanvas.SetActive(false);
        SoundManager.Instance.BackSound();
    }

    public void LoadLevel(int levelNum)
    {
        LevelSelection.CurrLevel = levelNum;
        gameCanvas.SetActive(true);
        levelSelectionCanvas.SetActive(false);
        SoundManager.Instance.LevelOpenSound();
    }

    public void BackToMenu()
    {
        levelSelectionCanvas.SetActive(true);
        gameCanvas.SetActive(false);
    }
}
