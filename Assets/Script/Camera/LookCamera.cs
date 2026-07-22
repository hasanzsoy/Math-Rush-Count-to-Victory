using UnityEngine;

public class LookCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 target_offset;

    private void Start()
    {
        target_offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + target_offset, .125f);
    }
}
