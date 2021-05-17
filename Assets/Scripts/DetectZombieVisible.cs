using UnityEngine;
using UnityEngine.AI;

public class DetectZombieVisible : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    NavMeshAgent agent;
    public static bool IsVisibleToCamera(Transform transform)
    {
        Vector3 vis = Camera.main.WorldToViewportPoint(transform.position);
        return (vis.x >= 0 && vis.y >= 0) && (vis.x <= 1 && vis.y <= 1) && vis.z >= 0;
    }

    private void Update()
    {
        if (IsVisibleToCamera(transform))
        {
            animator.SetTrigger("Freeze");
            print("Freeze");
            agent.isStopped = true;
        }
        else
        {
            animator.SetTrigger("UnFreeze");
            print("UnFreeze");
            agent.isStopped = false;
        }
    }

    //private void OnBecameVisible()
    //{
    //    animator.SetTrigger("Freeze");
    //    print("Freeze");
    //    agent.isStopped = true;
    //}

    //private void OnBecameInvisible()
    //{
    //    animator.SetTrigger("UnFreeze");
    //    print("UnFreeze");
    //    agent.isStopped = false;
    //}
}
