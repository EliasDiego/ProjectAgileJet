using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.WeaponSystem
{
    public struct DamageContext
    {
        public float damage { get; set; }
        
        public bool isExplosive { get; set; }

        public float explosionRadius { get; set; }
        public float explosionForce { get; set; }

        public static implicit operator DamageContext(float damage) => new DamageContext() { damage = damage };
    }
}