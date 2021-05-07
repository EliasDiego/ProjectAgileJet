using UnityEngine;

using ProjectAgileJet.Input;
using ProjectAgileJet.TargetAcquisitionSystem;
using ProjectAgileJet.WeaponSystem;

using YergoScripts.Patterns;

namespace ProjectAgileJet.Planes
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        InputHandler _InputHandler;
        [SerializeField]
        CameraHandler _CameraHandler;
        [SerializeField]
        ObjectPoolAsset _WeaponPool;
        [SerializeField]
        ObjectPoolAsset _ExplosionPool;
        [SerializeField]
        TargetAcquisitionHUD _Hud;
        [SerializeField]
        Transform _MissileSpawnPoint;
        
        [Header("FAD Mode")]
        [SerializeField]
        float _MaxDegreesDelta;
        
        Vector3 _CameraOriginalRotation = Vector3.zero;
        Vector3 _CameraRotation = Vector3.zero;
        
        Vector3 _FlapInput;
        
        Rigidbody _Rigidbody;

        PlaneController _PlaneController;

        TargetAcquirer _TargetAcquirer;

        bool _IsFadMode = false;
        bool _CanBoost = true;
        bool _CanControlFlaps = true;
        
        void Awake()
        {
            _Rigidbody = GetComponent<Rigidbody>();

            _PlaneController = GetComponent<PlaneController>();

            _TargetAcquirer = GetComponent<TargetAcquirer>();

            _Hud.targetAcquirer = _TargetAcquirer;
            
            _WeaponPool.Instantiate();
            _ExplosionPool.Instantiate();
        }

        void Start()
        {
            _InputHandler.Enable("Game");

            _InputHandler.AddPerformedListener("Game", "Pitch", context => _FlapInput.x = context.ReadValue<float>());
            _InputHandler.AddCanceledListener("Game", "Pitch", context => _FlapInput.x = 0);
            
            _InputHandler.AddPerformedListener("Game", "Yaw", context => _FlapInput.y = context.ReadValue<float>());
            _InputHandler.AddCanceledListener("Game", "Yaw", context => _FlapInput.y = 0);

            _InputHandler.AddPerformedListener("Game", "Roll", context => _FlapInput.z = -context.ReadValue<float>());
            _InputHandler.AddCanceledListener("Game", "Roll", context => _FlapInput.z = 0);

            _InputHandler.AddPerformedListener("Game", "Boost", context =>
            {
                if(_CanBoost)
                {
                    _CameraHandler.ActivateVCam(CameraHandler.VCam.Boost);

                     _PlaneController.thrustValue = 1.5f;
                }
            });

            _InputHandler.AddCanceledListener("Game", "Boost", context =>
            {
                _CameraHandler.ActivateVCam(CameraHandler.VCam.Default);

                _PlaneController.thrustValue = 1;
            });

            _InputHandler.AddStartedListener("Game", "FadMode", context => 
            {
                _CanBoost = false;

                _IsFadMode = true;

                _PlaneController.thrustValue = 1;
                
                _CameraOriginalRotation = _CameraHandler.transform.eulerAngles;
                
                _CameraOriginalRotation.z = 0;

                _CameraRotation = Vector3.zero;

                Cursor.lockState = CursorLockMode.Locked;

                _CameraHandler.transform.localEulerAngles = Vector3.zero;
                _CameraHandler.ActivateVCam(CameraHandler.VCam.FadMode);
            });

            _InputHandler.AddCanceledListener("Game", "FadMode", context => 
            {
                _CanBoost = true;

                _IsFadMode = false;
                
                _CameraHandler.transform.localRotation = Quaternion.identity;
                
                Cursor.lockState = CursorLockMode.None;

                _CameraHandler.ActivateVCam(CameraHandler.VCam.Default);
            });
        
            _InputHandler.AddPerformedListener("Game", "FadLook", context => 
            {
                Vector2 contextValue = context.ReadValue<Vector2>();

                _CameraRotation.x += -contextValue.y;
                _CameraRotation.y += contextValue.x;
            });

            //_InputHandler.AddCanceledListener("Game", "FadLook", context => _CameraRotation = Vector2.zero);

            _InputHandler.AddStartedListener("Game", "Fire", context => 
            {
                Targetable target = _TargetAcquirer.closestTargetable;
                GameObject missileGameObject;

                if(target)
                {
                    missileGameObject = _WeaponPool.GetObject("missile");

                    if(missileGameObject && missileGameObject.TryGetComponent<Missile>(out Missile missile))
                    {
                        missile.Activate(target.transform, 0);

                        missileGameObject.transform.position = _MissileSpawnPoint.position;
                        missileGameObject.transform.rotation = _MissileSpawnPoint.rotation;

                        missile.onHitEvent += () => 
                        {
                            Transform explosion = _ExplosionPool.GetObject("explosion")?.transform;

                            if(explosion)
                                explosion.position = missile.transform.position;
                        };
                    }
                }
            });
        }

        void Update()
        {
            FlapControl();

            CameraControl();

            HeadsUpDisplay();
        }

        void HeadsUpDisplay()
        {
            _Hud.lockOn = _TargetAcquirer.closestTargetable;
        }

        void FlapControl()
        {
            _PlaneController.pitchInput = _FlapInput.x;
            _PlaneController.yawInput = _FlapInput.y;
            _PlaneController.rollInput = _FlapInput.z;
        }

        void CameraControl()
        {
            if(_IsFadMode)
            {
                _CameraHandler.transform.rotation = Quaternion.Slerp(_CameraHandler.transform.rotation, 
                    Quaternion.Euler(_CameraOriginalRotation + _CameraRotation), 100 * Time.deltaTime);
            }
        }
    }
}