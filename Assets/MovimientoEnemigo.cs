using UnityEngine;
using UnityEngine.AI;

public class MovimientoEnemigo : MonoBehaviour
{

    public Transform player;

    public float distanciaPlayer = 5f;
    private NavMeshAgent _navMesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _navMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.position) > distanciaPlayer)
        {
            _navMesh.SetDestination(player.position);
        }
        
    }
}
