using UnityEngine;
using UnityEngine.AI;

public class Sup_Character : MonoBehaviour
{
    GameObject target;
    NavMeshAgent _Navmesh;

    void Start()
    {
        _Navmesh = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("GameManager")
            .GetComponent<GameManager>().Destination;
    }

    void LateUpdate()
    {
        _Navmesh.SetDestination(target.transform.position);
    }
}