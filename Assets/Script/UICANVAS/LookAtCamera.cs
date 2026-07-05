using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform target;

    public void LateUpdate()
    {
        transform.LookAt(target);
    }
}
