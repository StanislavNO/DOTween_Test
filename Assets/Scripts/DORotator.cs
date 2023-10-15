using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts
{
    public class DORotator : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Vector3 _rotation;

        private void Start()
        {
            _rotation = new Vector3(0,-360,0);

            transform.DORotate(_rotation, _speed, RotateMode.WorldAxisAdd)
                .SetEase(Ease.Linear)
                .SetSpeedBased()
                .SetLoops(-1);
        }
    }
}