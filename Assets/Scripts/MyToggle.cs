using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class MyToggle : MonoBehaviour
    {

        public GameObject SwitchisOn;
        public GameObject SwitchisOff;

        public Slider Volume;

        private Toggle toggle;

        
        void Update()
        {
            toggle = GetComponent<Toggle>();
            OnValueChange(toggle.isOn);
            
        }

        public void OnValueChange(bool isOn)
        {
            if (Volume.value == 0)
            {
                SwitchisOn.SetActive(true);
                SwitchisOff.SetActive(false);
            }
            else
            {
                SwitchisOn.SetActive(isOn);
                SwitchisOff.SetActive(!isOn);
            }
        }
    }
}
