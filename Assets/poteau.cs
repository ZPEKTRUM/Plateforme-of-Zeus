using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Poteau : MonoBehaviour
{
    [SerializeField] SpriteRenderer _renderer;
    [SerializeField] List<Sprite> _sprites;
    [SerializeField] int _playerImpact;

    [SerializeField] float _destroyWaitInSeconds;
    [SerializeField] UnityEvent _onImpact;
    [SerializeField] UnityEvent _onDestroy;
    [SerializeField] AudioClip clip;

    private void Start()
    {
        _renderer.sprite = _sprites[_playerImpact];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Player.IsPlayer(collision))
        {
            _playerImpact++;

            if (_playerImpact >= _sprites.Count)
            {
                Destroy(gameObject, _destroyWaitInSeconds);
                _onDestroy.Invoke();
            }
            else
            {
                _renderer.sprite = _sprites[_playerImpact];
                _onImpact.Invoke();
            }
        }
    }


}