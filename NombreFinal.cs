using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NombreFinal : MonoBehaviour
{
    [SerializeField] public string Nombre;
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        Nombre = NombrePersonaje.Instance.nombreTotal;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = Nombre.ToString();
    }
}
