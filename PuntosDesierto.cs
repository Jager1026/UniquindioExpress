using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosDesierto : MonoBehaviour
{
    
    [SerializeField] public float PuntosActuales;
    public float PuntosFinales;
    public TextMeshProUGUI textMesh;
    
    // Start is called before the first frame update
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PuntosActuales = ControladorPuntosTotales.Instance.cantidadPuntosTotales;
    }

    // Update is called once per frame
    void Update()
    {
         if (LevelManagerDesert.Instance.start == true && LevelManagerDesert.Instance.finish == true)
         {
             PuntosFinales = PuntosActuales + 200;
             textMesh.text = PuntosFinales.ToString();
         }
         else
        {
            textMesh.text = PuntosActuales.ToString();
        }
    }
}
