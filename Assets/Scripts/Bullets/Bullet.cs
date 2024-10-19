using System;
using UnityEngine;

namespace Bullets
{
    public sealed class Bullet : MonoBehaviour
    {
        public event Action<Bullet> OnCollisionEntered;

        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        private bool _isPlayer;
        private int _damage;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            collision.gameObject.DealDamage(_damage, _isPlayer);
            OnCollisionEntered?.Invoke(this);
        }

        public void Construct(Vector2 position, Color color, int layer, int damage, bool isPlayer,
            Vector2 velocity)
        {
            _rigidbody2D.velocity = velocity;
            _spriteRenderer.color = color;
            gameObject.layer = layer;
            _damage = damage;
            _isPlayer = isPlayer;
            transform.position = position;
        }
    }
}