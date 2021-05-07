using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMatrixTest : MonoBehaviour
{
    [SerializeField]
    Transform _Target;
    [SerializeField]
    Camera _Camera;
    [SerializeField]
    Vector3 _Center;
    [SerializeField]
    Vector2 _Size;
    [SerializeField]
    float _Left;
    [SerializeField]
    float _Right;
    [SerializeField]
    float _Top;
    [SerializeField]
    float _Bottom;
    [SerializeField]
    float _FOV;
    [SerializeField]
    float _ZNear;
    [SerializeField]
    float _ZFar;
    
    Matrix4x4 _ProjectMatrix;

    // Update is called once per frame
    void OnDrawGizmos()
    {
        if(_Target && _Camera)
        {
            //Matrix4x4 projectionMatrix = Matrix4x4.Frustum(_Left, _Right, _Bottom, _Top, _ZNear, _ZFar);
            Matrix4x4 projectionMatrix = Matrix4x4.Perspective(_FOV, _Size.x / _Size.y, _ZNear, _ZFar);
            Vector4 v = (projectionMatrix * transform.worldToLocalMatrix) * new Vector4(_Target.position.x, _Target.position.y, _Target.position.z, 1);
            Vector4 v2 = v / -v.w;

            if(Mathf.Abs(v2.x) < 1 && Mathf.Abs(v2.y) < 1 && v.z < 0)
            {
                Gizmos.DrawLine(transform.position, _Target.position);

                Debug.Log(v.z + " && " + Vector3.Distance(transform.position, _Target.position));
            }

            // Test

            // Gizmos.color = Color.green;
            // Gizmos.DrawLine(transform.position, (Vector3)(projectionMatrix * transform.localToWorldMatrix * new Vector3(1, 1, -1)));
            // Gizmos.color = Color.red;
            // Gizmos.DrawLine(transform.position, transform.position + (Vector3)(projectionMatrix  * new Vector3(-1, 1, -1)));
            // Gizmos.color = Color.white;
            // Gizmos.DrawLine(transform.position, transform.position + (Vector3)(projectionMatrix  * new Vector3(1, -1, -1)));
            // Gizmos.color = Color.blue;
            // Gizmos.DrawLine(transform.position, transform.position + (Vector3)(projectionMatrix  * new Vector3(-1, -1, -1)));

            Gizmos.matrix = transform.localToWorldMatrix;

            Gizmos.DrawFrustum(_Center, _FOV, _ZFar, _ZNear, _Size.x / _Size.y);
        }
    }
}
