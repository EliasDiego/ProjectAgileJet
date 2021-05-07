using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.WeaponSystem
{
    public class Weapon : MonoBehaviour
    {
        bool _IsActive = false;

        TargetContext _TargetContext;

        DamageContext _DamageContext;

        void FixedUpdate()
        {
            if(_IsActive)
                OnFixedUpdate(_TargetContext, _DamageContext);
        }

        public void Activate(TargetContext targetContext, DamageContext damageContext)
        {
            _IsActive = true;
            
            _TargetContext = targetContext;

            _DamageContext = damageContext;

            OnActivate();
        }

        public void Deactivate()
        {
            _IsActive = false;

            OnDeactivate();
        }

        protected virtual void OnDeactivate(){}

        protected virtual void OnActivate(){}

        protected virtual void OnFixedUpdate(TargetContext targetContext, DamageContext damageContext){}
    }
}