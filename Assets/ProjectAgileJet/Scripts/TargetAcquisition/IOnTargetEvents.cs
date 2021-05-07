using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.TargetAcquisitionSystem
{
    public interface IOnTargetEvents
    {
        void OnLockOn();
        void OnLockOff();
    }
}