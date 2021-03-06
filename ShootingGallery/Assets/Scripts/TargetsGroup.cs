using UnityEngine;

public class TargetsGroup : MonoBehaviour
{
    Target[] _targets;

    void Start() => _targets = GetComponentsInChildren<Target>();

    public void ShowRandomTarget()
    {
        int index = Random.Range(0, _targets.Length);
        Target target = _targets[index];
        target.Show();
    }
}
