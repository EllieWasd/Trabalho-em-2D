using System;
using TMPro;
using UnityEngine;

public class TextoRandomizado : MonoBehaviour
{
    public string novoTexto;
    public TextMeshProUGUI UITexto;

    public int numero; 
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        UITexto.text = novoTexto + " " + numero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
