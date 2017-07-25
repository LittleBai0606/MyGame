using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Game : MonoBehaviour
    {

        private static Game m_Instance = null;

        public static Game Instance
        {
            get { return m_Instance; }
        }

        void Awake()
        {
            m_Instance = this;
        }

        #region 事件
        public event Action<GameState> onStateChanged;
        #endregion

        #region 变量

        GameState m_State  = GameState.Init;

        public GameState gameState
        {
            get { return m_State; }

            private set
            {
                m_State = value;
                if (onStateChanged != null)
                    onStateChanged(m_State);
            }
        }

        #endregion

        #region 演员
        public GameUI gameUI = null;

        public Ball ball = null;


        #endregion

        void Start()
        {
            //监听
            onStateChanged += Game_onStateChanged;
            //初始进入Init
            GotoInit();
        }

        public void GotoInit()
        {
            this.gameState = GameState.Init;
        }

        public void GotoGuide()
        {
            this.gameState = GameState.Guide;
        }

        public void GotoSettings()
        {
            this.gameState = GameState.Settings;
        }

        public void GotoReady()
        {
            this.gameState = GameState.Ready;
        }

        public void GotoPlay()
        {
            this.gameState = GameState.Play;
        }

        public void GotoPause()
        {
            this.gameState = GameState.Pause;
        }

        public void GotoOver()
        {
            this.gameState = GameState.Over;
        }

        private void Game_onStateChanged(GameState state)
        {   
            switch (state)
            {
                case GameState.Init:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = false;
                    break;

                case GameState.Guide:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = false;
                    break;

                case GameState.Settings:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = false;
                    break;

                case GameState.Ready:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = false;
                    break;

                case GameState.Play:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = true;
                    break;

                case GameState.Pause:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = false;
                    break;

                case GameState.Over:
                    gameUI.UpdateUI(state);
                    ball.IsVisible = false;
                    break;
            }
            
        }
    }
}
