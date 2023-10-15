using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class DOText : MonoBehaviour
    {
        [SerializeField] private Text _text;

        private Sequence _sequence;

        private void Start()
        {
            _sequence = DOTween.Sequence();

            _sequence.Insert(4, _text.DOText("DOTween", 3));
            _sequence.Append(_text.DOText(" - настоящая магия", 5).SetRelative());
            _sequence.Append(_text.DOText("Пользуйтесь DOTween :)", 3,  true, ScrambleMode.All));

            _sequence.SetLoops(-1);
        }
    }
}