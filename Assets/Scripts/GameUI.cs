using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    #region 成员
    public GameObject Logo;
    public GameObject ButtonStart;
    public GameObject ButtonGuide;
    public GameObject ButtonSettings;
    public GameObject GuideUI;
    public GameObject SettingsUI;
    public GameObject PauseUI;
    public GameObject OverUI;
    public GameObject ScoreText;
    public GameObject Score;
    public GameObject PauseButton;
    public GameObject ContinueButton;
    public GameObject StopButton;
    #endregion

    #region 方法
    public void UpdateUI(GameState state)
    {
        switch (state)
        {
            case GameState.Init:
                Logo.SetActive(true);
                ButtonStart.SetActive(true);
                ButtonGuide.SetActive(true);
                ButtonSettings.SetActive(true);
                GuideUI.SetActive(false);
                SettingsUI.SetActive(false);
                PauseUI.SetActive(false);
                OverUI.SetActive(false);
                ScoreText.SetActive(false);
                Score.SetActive(false);
                PauseButton.SetActive(false);
                ContinueButton.SetActive(false);
                StopButton.SetActive(false);
                break;

            case GameState.Guide:
                Logo.SetActive(false);
                ButtonStart.SetActive(false);
                ButtonGuide.SetActive(false);
                ButtonSettings.SetActive(false);
                GuideUI.SetActive(true);
                SettingsUI.SetActive(false);
                PauseUI.SetActive(false);
                OverUI.SetActive(false);
                ScoreText.SetActive(false);
                Score.SetActive(false);
                PauseButton.SetActive(false);
                ContinueButton.SetActive(false);
                StopButton.SetActive(false);
                break;

            case GameState.Settings:
                Logo.SetActive(false);
                ButtonStart.SetActive(false);
                ButtonGuide.SetActive(false);
                ButtonSettings.SetActive(false);
                GuideUI.SetActive(false);
                SettingsUI.SetActive(true);
                PauseUI.SetActive(false);
                OverUI.SetActive(false);
                ScoreText.SetActive(false);
                Score.SetActive(false);
                PauseButton.SetActive(false);
                ContinueButton.SetActive(false);
                StopButton.SetActive(false);
                break;

            case GameState.Ready:
                break;

            case GameState.Play:
                break;

            case GameState.Pause:
                break;

            case GameState.Over:
                break;
        }
    }


    #endregion


}
