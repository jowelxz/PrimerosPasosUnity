using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _puntosVida = 100;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
        _puntosVida -= daño;
    }
}