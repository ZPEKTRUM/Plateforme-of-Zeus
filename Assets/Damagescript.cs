using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si la collision est avec le joueur
        if (Player.IsPlayer(collision))
        {
            // Inflige des dégâts au joueur
            collision.rigidbody.GetComponent<Health>().TakeDamage(damage);

            // Détruit le GameObject
            Destroy(collision.rigidbody.gameObject);

            // Crée un GameObject
            GameObject Trapscie = new GameObject();

            // Attache le script DamageScript au GameObject
            Trapscie.AddComponent<DamageScript>();

            // Définit la propriété damage
            Trapscie.GetComponent<DamageScript>().damage = 10;
        }
    }

}