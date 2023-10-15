using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts
{
    public class DOOrganizer : MonoBehaviour
    {
        [SerializeField][Range(0, 10)] private float _path;
        [SerializeField] private float _speed;

        private float _startPositionZ;
        private Vector3 _startScale;

        private Sequence _sequence;

        void Start()
        {
            _startPositionZ = transform.position.z;
            _startScale = transform.localScale;

            _sequence = DOTween.Sequence();

            _sequence.Append(transform.DOMoveZ(transform.position.z + _path, _speed));

            _sequence.Insert(0, transform.DORotate(new Vector3(0, -360, 0), _speed, RotateMode.WorldAxisAdd));

            _sequence.Insert(0, transform.DOScale(2, _speed));

            _sequence.Append(transform.DOMoveZ(_startPositionZ, _speed));

            _sequence.Insert(_speed, transform.DORotate(new Vector3(0, -360, 0), _speed, RotateMode.WorldAxisAdd));

            _sequence.Insert(_speed, transform.DOScale(_startScale, _speed));

            _sequence.SetLoops(-1)
                .SetEase(Ease.Linear)
                .SetSpeedBased();
        }
    }
}