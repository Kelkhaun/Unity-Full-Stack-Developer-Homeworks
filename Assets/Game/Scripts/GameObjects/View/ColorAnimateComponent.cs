using DG.Tweening;
using Game.Scripts.GameObjects.Core;
using UnityEngine;

namespace Game.Scripts.GameObjects.View
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

        [SerializeField]
        private HealthComponent _healthComponent;

        private Tween _tween;

        private void OnEnable()
        {
            _healthComponent.OnHealthChanged += OnHealthChanged;
        }

        private void OnDisable()
        {
            _healthComponent.OnHealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            if (_tween != null && _tween.active && _tween.IsPlaying())
                return;

            _tween = _target.DOColor(_color, _time).SetEase(_curve);
        }
    }
}