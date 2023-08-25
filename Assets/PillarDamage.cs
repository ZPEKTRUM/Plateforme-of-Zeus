using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarDamage : MonoBehaviour
{
    [SerializeField]
    private Sprite[] _sprites;

    [SerializeField]
    private int _healthPoint = 5;

    [SerializeField] SpriteRenderer _renderer;

    private int nbDamage = 0;
    private int _nbDamage;
    private void Start()
    {
        ChangeSprites();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody == null) return;

        if (collision.rigidbody.CompareTag("Player"))
        {
            
            _nbDamage++;
        }

        if (_nbDamage >= _healthPoint)
        {

            Destroy(gameObject);
        }
        else
        {
            ChangeSprites();
        }
    }

    private void ChangeSprites()
    {

        _renderer.sprite = _sprites[_nbDamage];

    }


}
