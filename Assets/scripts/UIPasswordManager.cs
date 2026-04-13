using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIPasswordManager : MonoBehaviour
{
    public GameObject txt_contraseñaResultado;
    public TextMeshProUGUI txt_contraseñaResultadoTexto;
    public TMP_InputField input_Password;

    // Start is called before the first frame update
    void Start()
    {
        txt_contraseñaResultado.SetActive(false);
    }
    public void ValidatePassword(){
         txt_contraseñaResultado.SetActive(true);
         txt_contraseñaResultadoTexto.text = input_Password.text;
    }
}