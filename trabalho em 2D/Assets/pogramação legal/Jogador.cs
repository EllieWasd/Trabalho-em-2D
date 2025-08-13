using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Jogador : personagem
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //esquerda
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.D)) //Direita
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.S)) //Cima
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);

        }

        if (Input.GetKey(KeyCode.W)) //Baixo    
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);

        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        
        if (other.gameObject.tag == "Inimigo")
        {
                                                   
                                                   
            int vidas = getVidas() - 1;
            setVidas(vidas); 
        }
    }
    


}
