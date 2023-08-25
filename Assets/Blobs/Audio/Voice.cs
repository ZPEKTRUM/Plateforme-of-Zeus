using Unity.VisualScripting;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    [SerializeField] AudioClip clip;

    // R�f�rence � l'AudioSource
    public AudioSource audioSource;

    // Nom du bouton input
    public string inputName = "Fire1";

    public AudioClip Clip { get => clip; set => clip = value; }

    // M�thode appel�e � chaque frame
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