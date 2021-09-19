using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 1;
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private SpriteRenderer _healthBar;
    [SerializeField] private SpriteRenderer _healthFill;


    private int _currentHealth;


    // Called once everytime game object enabled
    private void OnEnable ()
    {
        _currentHealth = _maxHealth;
        _healthFill.size = _healthBar.size;
    }
}
