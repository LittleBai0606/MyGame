using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ButtonAnimation : MonoBehaviour {

        public Image LogoBallLeft;
        public Image LogoBallRight;

        private bool flag1 = true;
        private bool flag2 = false;
        private bool flag3 = false;
        private bool flag4 = false;

        void Awake()
        {
            LogoBallLeft.gameObject.SetActive(true);
            LogoBallRight.gameObject.SetActive(false);
        }

    

        void Update()
        {
            if (flag1)
            {
                LeftBallFromLeftToRight();
            }
            if (flag2 )
            {
                RightBallFromLeftToRight();
            }
            if (flag3)
            {
                RightBallFromRightToLeft();
            }
            if(flag4)
            {
                LeftBallFromRightToLeft();
            }

        }

        void LeftBallFromLeftToRight()
        {
            if (LogoBallLeft.transform.localPosition.x < -594.7f)
            {
                LogoBallLeft.gameObject.SetActive(true);
                LogoBallRight.gameObject.SetActive(false);
                iTween.MoveTo(LogoBallLeft.gameObject, iTween.Hash("position", new Vector3(-476.55f, 0.0f, 0.0f), "time", 1f, "easetype", "linear", "islocal", true));
                flag1 = false;
                flag2 = true;
            }
            

        }

        void RightBallFromLeftToRight()
        {
            if (LogoBallLeft.transform.localPosition.x > -476.65f)
            {
                LogoBallLeft.gameObject.SetActive(false);
                LogoBallRight.gameObject.SetActive(true);
                iTween.MoveTo(LogoBallRight.gameObject, iTween.Hash("position", new Vector3(594.8f, 0.0f, 0.0f), "time", 0.5f, "easetype", "linear", "islocal", true));
                flag2 = false;
                flag3 = true;
            }
            
        }

        void RightBallFromRightToLeft()
        {
            if (LogoBallRight.transform.localPosition.x > 594.7f)
            {
                LogoBallLeft.gameObject.SetActive(false);

                iTween.MoveTo(LogoBallRight.gameObject, iTween.Hash("position", new Vector3(476.55f, 0.0f, 0.0f), "time", 0.5f, "easetype", "linear", "islocal", true));
                flag3 = false;
                flag4 = true;
            }
            
        }

        void LeftBallFromRightToLeft()
        {
            if (LogoBallRight.transform.localPosition.x <476.65f )
            {
                LogoBallLeft.gameObject.SetActive(true);
                LogoBallRight.gameObject.SetActive(false);

                iTween.MoveTo(LogoBallLeft.gameObject, iTween.Hash("position", new Vector3(-594.8f, 0.0f, 0.0f), "time", 0.5f, "easetype", "linear", "islocal", true));
                flag4 = false;
                flag1 = true;
            }    
        }
    }
}
