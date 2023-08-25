using Unity.VisualScripting;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    [SerializeField] AudioClip clip;

    // Référence à l'AudioSource
    public AudioSource audioSource;

    // Nom du bouton input
    public string inputName = "Fire1";

    public AudioClip Clip { get => clip; set => clip = value; }

    // Méthode appelée à chaque frame
    void Update()
    {
        // Si le joueur appuie sur le bouton input
        if (Input.GetButtonDown(inputName))
        {
            // Jouer le son
            //audioSource.Play();
        }
    }
}