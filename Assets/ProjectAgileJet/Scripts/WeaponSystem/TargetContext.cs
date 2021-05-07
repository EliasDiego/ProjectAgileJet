using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.WeaponSystem
{
    public struct TargetContext 
    {
        public Transform target { get; set; }

        public Vector3 offset { get; set; }

        public static TargetContext Set(Transform target, Vector3 offset) => new TargetContext { target = target, offset = offset};

        public static implicit operator TargetContext(Transform target) => new TargetContext() { target = target };
    }
}