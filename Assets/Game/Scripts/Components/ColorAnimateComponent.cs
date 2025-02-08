using DG.Tweening;
using UnityEngine;

namespace Game.Scripts.Components
{
    public sealed class ColorAnimateComponent : MonoBehaviour
    {
        [SerializeField]
        private Color _color;

        [SerializeField]
        private AnimationCurve _curve;

        [SerializeField]
        private float _time;

        [SerializeField]
        private SpriteRenderer _target;

        private Tween _tween;

        public void PlayAnimation()
        {
            if (_tween != null && _tween.IsPlaying())
                return;

            _tween = _target.DOColor(_color, _time).SetEase(_curve);
        }
    }
}