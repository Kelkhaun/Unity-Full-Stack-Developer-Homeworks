using Atomic.Elements;
using Atomic.Entities;
using Game.Scripts.Gameplay.Entity.Common.TakeDamage;
using SampleGame;
using UnityEngine;

public sealed class TakeDamageSoundBehaviour : IEntityInit, IEntityDispose
{
    private AudioSource _audioSource;
    private PainSoundBehaviour.Level[] _damageLevels;
    private ReactiveInt _health;

    private int _oldHealth;
    private int _maxHealth;

    public void Init(in IEntity entity)
    {
        _audioSource = entity.GetAudioSource();
        _damageLevels = entity.GetTakeDamageSounds();
        _health = entity.GetCurrentHealth();
        _health.Observe(OnHealthChanged);
        _oldHealth = _health.Value;
        _maxHealth = entity.GetMaxHealth().Value;
    }

    public void Dispose(in IEntity entity)
    {
        _health.Unsubscribe(OnHealthChanged);
    }

    private void OnHealthChanged(int health)
    {
        if (_oldHealth > health)
        {
            for (int i = _damageLevels.Length - 1; i >= 0; i--)
            {
                PainSoundBehaviour.Level level = _damageLevels[i];
                if (level.percent >= health / _maxHealth)
                {
                    AudioClip damageSFX = level.RandomClip();
                    _audioSource.PlayOneShot(damageSFX);
                    return;
                }
            }
        }

        _oldHealth = health;
    }
}