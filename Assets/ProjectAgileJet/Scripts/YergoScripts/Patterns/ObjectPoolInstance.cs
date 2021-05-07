using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YergoScripts.Patterns
{
    public class ObjectPoolInstance : MonoBehaviour
    {
        IOnObjectPoolEvent _EventHandler;

        ObjectPoolAsset.ObjectPool _ObjectPool;

        public ObjectPoolAsset.ObjectPool objectPool => _ObjectPool;

        void Awake() => _EventHandler = GetComponentInChildren<IOnObjectPoolEvent>();

        void OnDisable() => Invoke("ReturnToPool", 0.1f);

        public void SetObjectPool(ObjectPoolAsset.ObjectPool objectPool) => _ObjectPool = objectPool;
        
        public void ResetInstance() => _EventHandler?.OnReset();

        public void ReturnToPool()
        {
            if(gameObject.activeSelf)
                gameObject.SetActive(false);

            transform.parent = _ObjectPool.parent;
            
            //_ObjectPool.Return(this);
        }

        public void ParentToPool() => transform.parent = _ObjectPool.parent;
    }
}