using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace Assets.Scripts
{
    public class DOScaler : MonoBehaviour
    {
        [SerializeField] private float _scale = 5f;
        [SerializeField] private float _speed;

        private void Start()
        {
            transform.DOScale(_scale, _speed)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}