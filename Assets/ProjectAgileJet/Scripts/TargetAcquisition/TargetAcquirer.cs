using System.Linq;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace ProjectAgileJet.TargetAcquisitionSystem
{
    public class TargetAcquirer : MonoBehaviour
    {
        [SerializeField]
        Vector2 _Angle;

        float _ClosestDistance;

        Targetable[] _TargetablesInSight;

        public Targetable[] targetablesInSight => _TargetablesInSight;

        public Targetable closestTargetable => _TargetablesInSight?.OrderBy(t => Vector2.Distance(transform.position, t.transform.position)).Min();

        public Vector3 upRight => transform.rotation * Quaternion.Euler(-_Angle.y, _Angle.x, 0) * Vector3.forward;
        public Vector3 upLeft => transform.rotation * Quaternion.Euler(-_Angle.y, -_Angle.x, 0) * Vector3.forward;
        public Vector3 downRight => transform.rotation * Quaternion.Euler(_Angle.y, _Angle.x, 0) * Vector3.forward;
        public Vector3 downLeft => transform.rotation * Quaternion.Euler(_Angle.y, -_Angle.x, 0) * Vector3.forward;

        [CustomEditor(typeof(TargetAcquirer))]
        class TargetAcquirerEditor : Editor
        {
            bool _isFoldOut = false;

            TargetAcquirer _TargetAcquirer;

            static float _Distance = 100;

            public override void OnInspectorGUI()
            {
                base.OnInspectorGUI();

                if(!_TargetAcquirer)
                    _TargetAcquirer = target as TargetAcquirer;

                EditorGUILayout.Space();
                EditorGUILayout.LabelField("Debug", EditorStyles.boldLabel);

                _Distance = EditorGUILayout.FloatField("Distance", _Distance);
                
                _isFoldOut = EditorGUILayout.BeginFoldoutHeaderGroup(_isFoldOut, "Targetables In Sight");

                if(_isFoldOut)
                {
                    foreach(Targetable t in _TargetAcquirer.targetablesInSight)
                        EditorGUILayout.LabelField(t.name);
                }

                EditorGUILayout.EndFoldoutHeaderGroup();

                SceneView.RepaintAll();
            }

            [DrawGizmo(GizmoType.Selected | GizmoType.Active | GizmoType.NonSelected)]
            static void OnDrawGizmos(TargetAcquirer targetAcquirer, GizmoType gizmoType)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(targetAcquirer.transform.position, targetAcquirer.transform.position + targetAcquirer.upRight * _Distance);
                Gizmos.color = Color.red;
                Gizmos.DrawLine(targetAcquirer.transform.position, targetAcquirer.transform.position + targetAcquirer.upLeft * _Distance);
                Gizmos.color = Color.white;
                Gizmos.DrawLine(targetAcquirer.transform.position, targetAcquirer.transform.position + targetAcquirer.downRight * _Distance);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(targetAcquirer.transform.position, targetAcquirer.transform.position + targetAcquirer.downLeft * _Distance);
                
                Gizmos.color = Color.gray;
                Gizmos.DrawLine(targetAcquirer.transform.position + targetAcquirer.upLeft * _Distance, targetAcquirer.transform.position + targetAcquirer.upRight * _Distance);
                Gizmos.DrawLine(targetAcquirer.transform.position + targetAcquirer.upLeft * _Distance, targetAcquirer.transform.position + targetAcquirer.downLeft * _Distance);
                Gizmos.DrawLine(targetAcquirer.transform.position + targetAcquirer.downLeft * _Distance, targetAcquirer.transform.position + targetAcquirer.downRight * _Distance);
                Gizmos.DrawLine(targetAcquirer.transform.position + targetAcquirer.upRight * _Distance, targetAcquirer.transform.position + targetAcquirer.downRight * _Distance);
            }
        }

        void Update()
        {
            _TargetablesInSight = Targetable.targetableList.Where(t => 
            {
                Vector3 angleDifference = (transform.rotation * Quaternion.Inverse(Quaternion.LookRotation(t.transform.position - transform.position, transform.up))).eulerAngles;
                
                angleDifference = WrapRotation(angleDifference);

                return _Angle.y >= Mathf.Abs(angleDifference.x) && _Angle.x >= Mathf.Abs(angleDifference.y);
            }).ToArray();
        }

        Vector3 WrapRotation(Vector3 angle)
        {
            if(Mathf.Abs(angle.x) > 180)
                angle.x = Mathf.Abs(angle.x) + -360;
                
            if(Mathf.Abs(angle.y) > 180)
                angle.y = Mathf.Abs(angle.y) + -360;
                
            if(Mathf.Abs(angle.z) > 180)
                angle.z = Mathf.Abs(angle.z) + -360;

            return angle;
        }
    }
}