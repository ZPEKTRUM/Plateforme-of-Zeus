using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] ParticleSystem movementParticle;
    [Range(0, 10)]
    [SerializeField] int occurfAfterVelocity;

    [Range(0, 0.2f)]
    [SerializeField] float dustFormationPeriod;

    [SerializeField] Rigidbody2D playerRb;

    float counter;

    private void Update()
    {
        counter += Time.deltaTime;
        if (Mathf.Abs(playerRb.velocity.x) > occurfAfterVelocity)

        {
            if (counter > dustFormationPeriod)

            {
                movementParticle.Play();
                counter = 0;
            }
        }
    }

}