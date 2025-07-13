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
                Gizmos.color = Color.hotPink;
                Gizmos.DrawSphere(transform.GetChild(i).transform.position, waypointGizmoRadius);
            }
        }
    }
}
