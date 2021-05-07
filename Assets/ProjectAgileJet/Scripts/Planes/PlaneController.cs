using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.Planes
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlaneController : MonoBehaviour
    {        
        [Header("Thrust")]
        [SerializeField]
        float _ThrustForce = 10;

        [Header("Rotation")]
        [SerializeField]
        float _RollTorque = 0;
        [SerializeField]
        float _PitchTorque = 0;
        [SerializeField]
        float _YawTorque = 0;

        Rigidbody _Rigidbody;

        Vector3 _PlaneForward;

        public float thrustValue { get; set; } = 1;

        public float rollInput { get; set; } = 0;
        public float pitchInput { get; set; } = 0;
        public float yawInput { get; set; } = 0;

        public bool canThurst { get; set; } = true;
        
        void Awake()
        {
            _Rigidbody = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            FlapControl();

            Thrust();
        }

        void Thrust()
        {
            if(canThurst)
                _Rigidbody.AddForce(transform.forward * thrustValue * _ThrustForce);
        }

        void FlapControl()
        {
            _Rigidbody.AddRelativeTorque(new Vector3(pitchInput * _PitchTorque, yawInput * _YawTorque, rollInput * _RollTorque) * Time.fixedDeltaTime);
        }

        float CalculateSurfaceArea(Vector3 size) => (2 * size.y * size.x) + (2 * size.z * size.y) + (2 * size.x * size.z);
    }
}