using UnityEngine;

public class MenuAnimationController : MonoBehaviour
{
    public Animator animator;

    public void PLayAnimation(string triggerName)
    {
        animator.SetTrigger(triggerName);
    }
}
