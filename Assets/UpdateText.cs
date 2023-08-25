using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Reflection.Emit;

public class UpdateText : MonoBehaviour
{
    //récupération de la variable

    [SerializeField]
    private Intvariable _beersCollected;

    void Awake()
    {

        _label = GetComponent<TextMeshProUGUI>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _label.text = _beersCollected.m_value.ToString();  
    }

    //récupération du champs texte

    private TextMeshProUGUI _label;
}
