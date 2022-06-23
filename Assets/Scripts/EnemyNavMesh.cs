using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;
    public Animator animator;
    public float range;
   private void Awake()
   {
       navMeshAgent = GetComponent<NavMeshAgent>();

   }
   private void Update()
   {
       navMeshAgent.destination = movePositionTransform.position;
        if (Vector3.Distance(movePositionTransform.position, gameObject.transform.position) < range)
        {
            animator.SetBool("InRange", true);
        }
        else
        {
            animator.SetBool("InRange", false);
        }
    }
}
