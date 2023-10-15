using DG.Tweening;
using UnityEngine;

public class DOMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _path;

    private void Start()
    {
        transform.DOMoveZ(_path, _speed)
            .SetEase(Ease.Linear)
            .SetSpeedBased()
            .SetLoops(-1, LoopType.Yoyo);
    }
}
