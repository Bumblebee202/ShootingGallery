using UnityEngine;

public class ShootingGallery : MonoBehaviour
{
    float _currentTime;
    [SerializeField] int _minShowCount;
    [SerializeField] int _maxShowCount;
    [SerializeField] float _showDelay;
    [SerializeField] TargetsGroup[] _targetsGroups;

    void Start() => _currentTime = 0f;

    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _showDelay)
        {
            int spawnCount = Random.Range(_minShowCount, _maxShowCount);
            int index;

            for (int i = 0; i < spawnCount; i++)
            {
                index = Random.Range(0, _targetsGroups.Length);
                TargetsGroup targetsGroup = _targetsGroups[index];
                targetsGroup.ShowRandomTarget();
            }

            _currentTime = 0;
        }
    }
}
