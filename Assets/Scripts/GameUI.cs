using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{

    public GameObject Logo;
    public GameObject ButtonStart;
    public GameObject ButtonGuide;
    public GameObject ButtonSettings;

    public void UpdateUI(GameState state)
    {
        switch (state)
        {
                case GameState.Init:
                    break;

                case GameState.Guide:
                    Logo.SetActive(false);
                    ButtonStart.SetActive(false);
                    ButtonGuide.SetActive(false);
                    ButtonSettings.SetActive(false);
                    break;
            
                case GameState.Settings:
                    break;

                case GameState.Ready:
                    break;

                case GameState.Play:
                    break;

                case GameState.Pause:
                    break;

                case GameState.Stop:
                    break;

                case GameState.Over:
                    break;
        }
    }

}
