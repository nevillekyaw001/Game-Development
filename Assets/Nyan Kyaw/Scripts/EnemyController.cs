using UnityEngine;
using UnityEngine.AI;

namespace NyanKyaw
{
    public class EnemyController : MonoBehaviour
    {
        public GameObject player;
        private NavMeshAgent navMeshAgent;

        void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            MoveEnemy();
        }

        public void MoveEnemy()
        {
            navMeshAgent.SetDestination(player.transform.position);
        }
    }
}
