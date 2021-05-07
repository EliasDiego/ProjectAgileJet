using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectAgileJet.TargetAcquisitionSystem
{
    public class Targetable : MonoBehaviour
    {
        MeshRenderer[] _MeshRenderers;

        public Bounds screenBounds 
        {
            get
            {
                Camera c = Camera.main;

                Bounds b = new Bounds((Vector2)c.WorldToScreenPoint(transform.position), Vector3.zero);

                foreach(MeshRenderer m in _MeshRenderers)
                {
                    b.Encapsulate((Vector2)c.WorldToScreenPoint(m.bounds.min));
                    b.Encapsulate((Vector2)c.WorldToScreenPoint(m.bounds.min + Vector3.right * m.bounds.size.x));
                    b.Encapsulate((Vector2)c.WorldToScreenPoint(m.bounds.min + (Vector3)((Vector2)m.bounds.size)));
                    b.Encapsulate((Vector2)c.WorldToScreenPoint(m.bounds.max));
                    b.Encapsulate((Vector2)c.WorldToScreenPoint(m.bounds.max + Vector3.right * -m.bounds.size.x));
                    b.Encapsulate((Vector2)c.WorldToScreenPoint(m.bounds.max + -(Vector3)((Vector2)m.bounds.size)));
                }
                
                return b;
            } 
        }

        public static List<Targetable> targetableList = new List<Targetable>();
        
        void Awake()
        {
            _MeshRenderers = GetComponentsInChildren<MeshRenderer>();
            
            if(!targetableList.Contains(this))
                targetableList.Add(this);    
        }   

        void OnDestroy() 
        {
            if(targetableList.Contains(this))
                targetableList.Remove(this);   
        }

        void OnDisable() 
        {
            if(targetableList.Contains(this))
                targetableList.Remove(this);   
        }

        void OnDrawGizmos() 
        {
            if(!Application.isPlaying)
                return;

            Camera c = Camera.main;

            Bounds b = new Bounds((Vector2)c.WorldToScreenPoint(transform.position), Vector3.zero);
    
            foreach(MeshRenderer m in _MeshRenderers)
            {

                Gizmos.DrawSphere(m.bounds.min, 0.1f);
                Gizmos.DrawSphere(m.bounds.max, 0.1f);

                Gizmos.color = Color.red;

                Gizmos.DrawSphere(m.bounds.min + Vector3.right * m.bounds.size.x, 0.1f);
                Gizmos.DrawSphere(m.bounds.max + Vector3.right * -m.bounds.size.x, 0.1f);
                
                Gizmos.color = Color.blue;

                Gizmos.DrawSphere(m.bounds.min + Vector3.up * m.bounds.size.x, 0.1f);
                Gizmos.DrawSphere(m.bounds.max + Vector3.up * -m.bounds.size.x, 0.1f);
                
                Gizmos.color = Color.green;

                Gizmos.DrawSphere(m.bounds.min + (Vector3)((Vector2)m.bounds.size), 0.1f);
                Gizmos.DrawSphere(m.bounds.max + -(Vector3)((Vector2)m.bounds.size), 0.1f);
            }
        }
    }
}