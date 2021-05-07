using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.WeaponSystem
{
    public class Missile : Weapon
    {
        [SerializeField]
        float _Speed;
        [SerializeField]
        float _DetectRadius;
        [SerializeField]
        float _RotateSpeed;
        bool _IsHit = false;

        public System.Action onHitEvent { get; set; }

        protected override void OnFixedUpdate(TargetContext targetContext, DamageContext damageContext)
        {
            _IsHit = Vector3.Distance(transform.position, targetContext.target.position + targetContext.offset) <= _DetectRadius;

            if(_IsHit)
                Deactivate();

            else
            {
                transform.position += transform.forward * _Speed * Time.fixedDeltaTime;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(targetContext.target.position - transform.position), 
                    _RotateSpeed * Time.fixedDeltaTime);
            }
        }

        protected override void OnDeactivate()
        {
            gameObject.SetActive(false);

            onHitEvent?.Invoke();
        }
    }
}