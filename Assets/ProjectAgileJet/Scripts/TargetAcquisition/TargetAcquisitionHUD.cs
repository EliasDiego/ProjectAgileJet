using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace ProjectAgileJet.TargetAcquisitionSystem
{
    public class TargetAcquisitionHUD : MonoBehaviour
    {
        [SerializeField]
        RectTransform _BoxImage;
        [SerializeField]
        RectTransform _LockOnImage;
        [SerializeField]
        RectTransform _UpLeftImage;
        [SerializeField]
        RectTransform _UpRightImage;
        [SerializeField]
        RectTransform _DownLeftImage;
        [SerializeField]
        RectTransform _DownRightImage;
        

        public Targetable lockOn { get; set; }

        public TargetAcquirer targetAcquirer { get; set; }

        void Start() 
        {
        }

        void Update()
        {
            Camera camera = Camera.main;
            
            Vector2 size;

            Vector3 rotation;

            if(lockOn != null)
            {
                _LockOnImage.gameObject.SetActive(true);
                _LockOnImage.position = lockOn.screenBounds.center;
            }

            else
                _LockOnImage.gameObject.SetActive(false);

            if(targetAcquirer)
            {
                _UpLeftImage.position = camera.WorldToScreenPoint(targetAcquirer.transform.position + targetAcquirer.upLeft * 100);
                _UpRightImage.position = camera.WorldToScreenPoint(targetAcquirer.transform.position + targetAcquirer.upRight * 100);
                _DownLeftImage.position = camera.WorldToScreenPoint(targetAcquirer.transform.position + targetAcquirer.downLeft * 100);
                _DownRightImage.position = camera.WorldToScreenPoint(targetAcquirer.transform.position + targetAcquirer.downRight * 100);

                size.x = Vector3.Distance(_UpLeftImage.position, _DownRightImage.position);
                size.y = Vector3.Distance(_UpLeftImage.position, _DownLeftImage.position);

                //Quaternion.
                rotation = (Camera.main.transform.rotation * targetAcquirer.transform.rotation).eulerAngles;
                // tempRot = rotation.x;
                // rotation.x = rotation.y;
                // rotation.y = tempRot;

                //_BoxImage.sizeDelta = size;
                _BoxImage.position = camera.WorldToScreenPoint(targetAcquirer.transform.position + targetAcquirer.transform.forward * 100);
                _BoxImage.rotation = Quaternion.Euler(rotation);
            }
        }
    }
}