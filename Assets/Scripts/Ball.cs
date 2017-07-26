using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Ball : MonoBehaviour {

        private bool isMouseDown = false;

        private Vector3 lastMousePosition = Vector3.zero;

        public event Action onDead;

        internal Vector3 DefaultPosition;

        void Awake()
        {
            DefaultPosition = this.transform.position;

            onDead += Ball_onDead;
        }

    

        public bool IsVisible
        {
            get { return gameObject.activeInHierarchy; }
            set { gameObject.SetActive(value);}
        }

        public void Die()
        {
            gameObject.SetActive(false);
        }

        public void Reset()
        {
            Rigidbody2D ball = GetComponent<Rigidbody2D>();
            this.transform.position = DefaultPosition;
            this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
            IsVisible = true;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                isMouseDown = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                isMouseDown = false;
                lastMousePosition = Vector3.zero;
            }
            if (isMouseDown)
            {
            
                if (lastMousePosition != Vector3.zero)
                {
                    Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                    this.transform.position += offset;
                }
                lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            }
        }

        public void OnCollisionEnter2D(Collision2D collission)
        {
            //if(Game.Instance.gameState != GameState.Play || Game.Instance.gameState != GameState.Continue) {return; }
            string tag = collission.transform.tag;
            Debug.Log("碰到" + tag + "了");
            if(onDead != null)
                onDead();
        }

        private void Ball_onDead()
        {
            Die();
        }

    }
}
