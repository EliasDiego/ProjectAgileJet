using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace YergoScripts.Patterns
{
    [CreateAssetMenu(menuName = "YergoScripts/Patterns/ObjectPool", fileName = "New Object Pool")]
    public class ObjectPoolAsset : ScriptableObject // V1, To Further Test & Optimize
    {
        [SerializeField]
        ObjectPool[] _ObjectPools;

        Transform _ObjectPoolsParent;

        [Serializable]
        public class ObjectPool
        {
            [SerializeField]
            string _Id;
            [SerializeField]
            GameObject _Prefab;
            [SerializeField]
            int _Count;
            [SerializeField]
            bool _IsExpandable;
            
            Transform _Parent;

            bool _IsInstantiated = false;

            Queue<ObjectPoolInstance> _ActivePool = new Queue<ObjectPoolInstance>();
            Stack<ObjectPoolInstance> _InactivePool = new Stack<ObjectPoolInstance>();

            public Transform parent => _Parent;
            
            public string id => _Id;

            public bool isInstantiated => _IsInstantiated;

            ObjectPoolInstance InstantiatePrefab()
            {
                GameObject gameObject = GameObject.Instantiate(_Prefab, _Parent);
                ObjectPoolInstance instance;

                gameObject.transform.SetParent(_Parent);
                gameObject.SetActive(false);

                instance = gameObject.AddComponent<ObjectPoolInstance>();
                instance.SetObjectPool(this);

                return instance;
            }

            public void Instantiate()
            {   
                ObjectPoolInstance instance;
                
                _Parent = new GameObject(_Id + " Pool").transform;

                _IsInstantiated = true;
                    
                for(int i = 0; i < _Count; i++)
                {
                    instance = InstantiatePrefab();

                    _InactivePool.Push(instance);
                }
            }

            public void Destroy() 
            {
                foreach(ObjectPoolInstance instance in _ActivePool)
                    GameObject.Destroy(instance.gameObject);

                if(_Parent)
                    GameObject.Destroy(_Parent.gameObject);

                _IsInstantiated = false;

                _ActivePool.Clear();
                _InactivePool.Clear();
            }

            public GameObject GetObject(bool getFromActivePoolIfEmpty = false)
            {
                ObjectPoolInstance instance = null;

                if(_InactivePool.Count <= 0)
                {
                    if(_IsExpandable)
                        instance = InstantiatePrefab();

                    else if(getFromActivePoolIfEmpty)
                        instance = _ActivePool.Dequeue();
                }

                else
                    instance = _InactivePool.Pop();

                instance.ResetInstance();
                instance.transform.SetParent(null);
                instance.gameObject.SetActive(true);

                _ActivePool.Enqueue(instance);

                return instance.gameObject;
            }

            public GameObject[] GetObjects(int count, bool getFromActivePoolIfEmpty = false)
            {
                List<ObjectPoolInstance> instanceList = new List<ObjectPoolInstance>();

                ObjectPoolInstance instance = null;

                for(int i = 0; i < count; i++)
                {
                    if(_InactivePool.Count <= 0)
                    {
                        if(_IsExpandable)
                            instance = InstantiatePrefab();

                        else if(getFromActivePoolIfEmpty)
                            instance = _ActivePool.Dequeue();
                    }

                    else
                        instance = _InactivePool.Pop();

                    instanceList.Add(instance);
                        
                    instance.ResetInstance();
                    instance.transform.SetParent(null);
                    instance.gameObject.SetActive(true);
                }

                for(int i = 0; i < instanceList.Count; i++)
                    _ActivePool.Enqueue(instanceList[i]);

                return instanceList.Select(i => i.gameObject).ToArray();
            }

            async public void Return(ObjectPoolInstance instance)
            {
                if(instance.objectPool == this)
                {
                    _ActivePool = new Queue<ObjectPoolInstance>(_ActivePool.Where(i => i != instance));

                    _InactivePool.Push(instance);
                    
                    await System.Threading.Tasks.Task.Delay(1);

                    Debug.Log(instance != null);
                    
                    instance.ParentToPool();
                }
            }
        }

        void OnEnable() => Destroy();    

        public void Instantiate()
        {
            _ObjectPoolsParent = new GameObject(name).transform;

            foreach(ObjectPool objectPool in _ObjectPools)
            {
                if(!objectPool.isInstantiated)
                {
                    objectPool.Instantiate();

                    objectPool.parent.SetParent(_ObjectPoolsParent);
                }

                else
                    Debug.LogWarning("ObjectPoolWarning: " + objectPool.id + " Pool is already instantiated!");
            }
        }

        public void Instatiate(string id)
        {
            _ObjectPoolsParent = new GameObject(name).transform;

            ObjectPool objectPool = _ObjectPools.First(o => o.id == id);

            if(objectPool != null && !objectPool.isInstantiated)
                objectPool.Instantiate();
        }

        public void Destroy()
        {
            if(_ObjectPools != null)
            {
                foreach(ObjectPool objectPool in _ObjectPools)
                    objectPool.Destroy();
            }

            if(_ObjectPoolsParent)
                GameObject.Destroy(_ObjectPoolsParent.gameObject);
        }

        public void Destroy(string id)
        {
            _ObjectPools.First(o => o.id == id)?.Destroy();
        }

        public GameObject GetObject(string id, bool getFromActivePoolIfEmpty = false) 
        {
            ObjectPool objectPool = null;

            try
            {
                objectPool = _ObjectPools.First(pool => pool.id == id);
            }

            catch (Exception e)
            {
                Debug.LogError("GetObjectError: Object Pool ID " + '\"' + id + '\"' + " not found!\n" + e);
            }

            return objectPool == null ? null : objectPool.GetObject(getFromActivePoolIfEmpty);
        }

        public GameObject[] GetObjects(string id, int count, bool getFromActivePoolIfEmpty = false)
        {
            ObjectPool objectPool = null;

            try
            {
                objectPool = _ObjectPools.First(pool => pool.id == id);
            }

            catch (Exception e)
            {
                Debug.LogError("GetObjectsError: Object Pool ID " + '\"' + id + '\"' + " not found!\n" + e);
            }

            return objectPool == null ? null : objectPool.GetObjects(count, getFromActivePoolIfEmpty);
        }
    }
}