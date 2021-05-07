using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.WeaponSystem
{
    public class Explosion : MonoBehaviour
    {
        [SerializeField]
        float _TimeTillDisable = 0;

        void OnEnable() => Invoke("Disable", _TimeTillDisable);

        void Disable() => gameObject.SetActive(false);
    }
}