using UnityEngine;

namespace RPG.Control
{
    public class PatrolPath : MonoBehaviour
    {
        private const float waypointGizmoRadius = 0.3f;

        private void OnDrawGizmos()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                int j = GetNextIndex(i);
                Gizmos.color = Color.hotPink;
                Gizmos.DrawSphere(GetWaypoint(i), waypointGizmoRadius);

                Gizmos.DrawLine(GetWaypoint(i), GetWaypoint(j));
            }
        }

        private int GetNextIndex(int i)
        {
            if (i + 1 == transform.childCount)
            {
                return 0;
            }
            return i + 1;
        }

        private Vector3 GetWaypoint(int i)
        {
            return transform.GetChild(i).position;
        }
    }
}
