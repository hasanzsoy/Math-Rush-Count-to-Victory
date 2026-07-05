using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    private void LateUpdate()
    {
        FollowPlayerPosition();
    }

    private void FollowPlayerPosition()
    {
        Vector3 newPosition = transform.position = playerTransform.position + offset;
        newPosition.x = 0;
        transform.position = newPosition;
    }
}
