using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] public UIManager _uiManager;

    private int _restaurarVida = 10;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;

    }
    public void RestaurarVida(int heal)
    {
        _puntosVida = _puntosVida + _restaurarVida;

    }

    private void Update()
    {
        // Vida del jugador es >= 80, Color = Verde
        if (_puntosVida >= 80)
        {
           _uiManager.ColorBarra(Color.green);
        }

        // Vida del jugador es < 40 > 80, Color = Naranja
        if (_puntosVida < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }

        // Vida del jugador es < 40, Color = Rojo
        if (_puntosVida <= 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
    }
}