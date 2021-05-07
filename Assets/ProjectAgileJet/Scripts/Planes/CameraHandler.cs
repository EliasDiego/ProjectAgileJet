using UnityEngine;

using Cinemachine;

namespace ProjectAgileJet.Planes
{
    public class CameraHandler : MonoBehaviour
    {
        [Header("Virtual Cameras")]
        [SerializeField]
        CinemachineVirtualCamera _FadModeVCam;
        [SerializeField]
        CinemachineVirtualCamera _BoostVCam;
        [SerializeField]
        CinemachineVirtualCamera _DefaultVCam;

        public enum VCam
        {
            FadMode, Boost, Default
        }

        public void ActivateVCam(VCam vCam)
        {
            switch(vCam)
            {
                case VCam.Default:
                    _FadModeVCam.gameObject.SetActive(false);
                    _BoostVCam.gameObject.SetActive(false);
                    _DefaultVCam.gameObject.SetActive(true);
                    break;
                    
                case VCam.Boost:
                    _FadModeVCam.gameObject.SetActive(false);
                    _BoostVCam.gameObject.SetActive(true);
                    _DefaultVCam.gameObject.SetActive(false);
                    break;
                    
                case VCam.FadMode:
                    _FadModeVCam.gameObject.SetActive(true);
                    _BoostVCam.gameObject.SetActive(false);
                    _DefaultVCam.gameObject.SetActive(false);
                    break;
            }
        }
    }
}