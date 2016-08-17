using UnityEngine;
using System.Collections;

public class camerafixedrotation : MonoBehaviour
{

    Quaternion rotation;
    void Awake()
    {
        rotation = transform.rotation;
    }
    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
