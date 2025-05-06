using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaludoUI : MonoBehaviour
{
    public TextMeshProUGUI saludoUsuario;
    public TMP_InputField inputNombre;
    string nombreUsuario;
    
    // Start is called before the first frame update
    void Start()
    {
        saludoUsuario.text = ""; 
    }

    public void Saludar()
    {
        saludoUsuario.text = "Hola " + inputNombre.text;
    }
}
