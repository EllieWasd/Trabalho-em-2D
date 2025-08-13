using UnityEngine;

public class personagem : MonoBehaviour
{
    [SerializeField] private int vidas;
    [SerializeField] private int energia;
    [SerializeField] private int velocidade;

    public void setVidas(int vidas)
    {
        this.vidas = vidas;

    }

    public int getVidas()
    {
        return this.vidas;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;

    }

    public int getenergia()
    {
        return this.energia;
    }

    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;

    }

    public int getVelocidade()
    {
        return this.velocidade;
    }

    public float getEnergia()
    {
        throw new System.NotImplementedException();
    }
}