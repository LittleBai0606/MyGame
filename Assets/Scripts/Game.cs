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

        public event Action<GameState> onStateChanged;

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

        #region Player

        public GameUI gameUI = null;


        #endregion

        void Start()
        {
            onStateChanged += Game_onStateChanged;

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

        public void GotoStop()
        {
            this.gameState = GameState.Stop;
        }

        public void GotoOver()
        {
            this.gameState = GameState.Over;
        }

        private void Game_onStateChanged(GameState obj)
        {
            throw new NotImplementedException();
        }
    }
}
