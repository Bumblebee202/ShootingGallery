using UnityEngine;

public class Target : MonoBehaviour
{
    Animator _animator;

    void Start() => _animator = GetComponentInParent<Animator>();

    public void Hit() => _animator.SetTrigger("Hit");

    public void Show() => _animator.SetTrigger("Show");
}
