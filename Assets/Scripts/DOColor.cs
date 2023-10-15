using UnityEngine;
using DG.Tweening;

namespace Assets.Scripts
{
    public class DOColor : MonoBehaviour
    {
        [SerializeField] private Material material;
        [SerializeField] Color _startColor;

        private void Awake()
        {
            material.color = _startColor;
        }

        private void Start()
        {
            material.DOColor(Color.white, 2)
                .SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}