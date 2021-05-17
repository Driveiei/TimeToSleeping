using UnityEngine;
using UnityEngine.AI;

public class DetectZombieVisible : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    NavMeshAgent agent;

    private void Update()
    {
        if (GetComponent<Renderer>().isVisible)
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
