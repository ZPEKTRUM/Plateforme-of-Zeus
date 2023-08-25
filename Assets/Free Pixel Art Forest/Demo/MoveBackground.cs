// Ce script permet de déplacer un élément de décor en boucle horizontalement
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{

    // La vitesse de déplacement du décor en unités par seconde
    public float backgroundSpeed;
    // La position x du décor
    private float backgroundPosition;
    // La limite gauche du déplacement du décor
    public float leftBound;
    // La limite droite du déplacement du décor
    public float rightBound;

    // Cette méthode est appelée une fois au démarrage du jeu
    void Start()
    {
        // On initialise la position x du décor avec sa valeur initiale
        backgroundPosition = transform.position.x;
    }

    // Cette méthode est appelée à chaque image affichée
    void Update()
    {
        // On met à jour la position x du décor en fonction de la vitesse et du temps écoulé
        backgroundPosition += backgroundSpeed * Time.deltaTime;
        // On applique la nouvelle position au transform du décor
        transform.position = new Vector3(backgroundPosition, transform.position.y, transform.position.z);

        // Si la position x du décor est inférieure à la limite gauche
        if (backgroundPosition <= leftBound)
        {
            // On affiche un message de débogage
            Debug.Log("hhhh");
            // On remet la position x du décor à la limite droite
            backgroundPosition = rightBound;
            // On applique la nouvelle position au transform du décor
            transform.position = new Vector3(backgroundPosition, transform.position.y, transform.position.z);
        }
    }
}