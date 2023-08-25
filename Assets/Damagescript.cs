using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si la collision est avec le joueur
        if (Player.IsPlayer(collision))
        {
            // Inflige des d�g�ts au joueur
            collision.rigidbody.GetComponent<Health>().TakeDamage(damage);

            // D�truit le GameObject
            Destroy(collision.rigidbody.gameObject);

            // Cr�e un GameObject
            GameObject Trapscie = new GameObject();

            // Attache le script DamageScript au GameObject
            Trapscie.AddComponent<DamageScript>();

            // D�finit la propri�t� damage
            Trapscie.GetComponent<DamageScript>().damage = 10;
        }
    }

}