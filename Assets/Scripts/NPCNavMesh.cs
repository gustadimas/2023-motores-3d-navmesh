using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class NPCNavMesh: MonoBehaviour
{
    Transform player;
    NavMeshAgent Npc;
    void Start()
    {
        player = GameObject.Find("Player").transform;
        Npc = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Npc.SetDestination(player.position);
    }
}
