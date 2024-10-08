﻿using MyBox;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace SquareDino.TestTask.Movement
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class WaypointsMovement : MonoBehaviour
    {
        public event UnityAction Moved;

        public event UnityAction Came;

        private const float CloseRange = 0.1f;

        [SerializeField] [AutoProperty] private NavMeshAgent _navMeshAgent;

        public void MoveTo(Waypoint waypoint)
        {
            _navMeshAgent.SetDestination(waypoint.Position);
            Moved?.Invoke();
        }

        private void Update()
        {
            if (_navMeshAgent.remainingDistance <= CloseRange)
                Came?.Invoke();
        }
    }
}