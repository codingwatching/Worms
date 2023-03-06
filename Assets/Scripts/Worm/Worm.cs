using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Worm : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private CapsuleCollider2D _collider;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _jumpSpeed = 5f;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _wormSprite;
    [SerializeField] private WormInformationView _wormInformationView;
    [SerializeField] private WormInput _input;
    [SerializeField] private Throwing _throwing;

    private int _health;
    private FollowingCamera _followingCamera;

    public CapsuleCollider2D Collider2D => _collider;
    public Throwing Throwing => _throwing;
    public WormInput WormInput => _input;

    public event UnityAction<int> HealthChanged;
    public event UnityAction<Worm> Died;
    public event UnityAction<Bomb> Shot;
    public event UnityAction<Worm> DamageTook;

    private void OnEnable()
    {
        _throwing.Shot += OnShot;
    }

    private void OnDisable()
    {
        _throwing.Shot -= OnShot;
    }

    private void Start()
    {
        _health = _maxHealth;
    }

    public void Init(Color color, string name)
    {
        _wormInformationView.Init(color, name);
        gameObject.name = name;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.SetBool("Grounded", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _animator.SetBool("Grounded", false);
    }

    public void TryMove(float horizontal)
    {
        if (horizontal != 0)
        {
            _wormSprite.localScale = new Vector3(-horizontal, 1f, 1f);
            Vector2 velocity = _rigidbody.velocity;
            velocity.x = horizontal * _speed;
            _rigidbody.velocity = velocity;
            _animator.SetBool("Walk", true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }

    public void Jump()
    {
        _rigidbody.velocity += new Vector2(0, _jumpSpeed);
        _animator.SetBool("Grounded", false);
    }

    public void AddExplosionForce(float explosionForce, Transform transform, float explosionUpwardsModifier)
    {
        _rigidbody.AddExplosionForce(explosionForce, transform.position, explosionUpwardsModifier);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        DamageTook?.Invoke(this);
        HealthChanged?.Invoke(_health);

        if (_health <= 0)
            Die();
    }

    public void Die()
    {
        Died?.Invoke(this);
        Destroy(gameObject);
    }

    private void OnShot(Bomb bomb)
    {
        Shot?.Invoke(bomb);
    }
}
