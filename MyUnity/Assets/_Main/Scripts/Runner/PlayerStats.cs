using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public int _puntosVidaActuales = 100;
    [SerializeField] private int _puntosVidaMaximo = 100;

    [SerializeField] public UIManager _uiManager;

    private int _restaurarVida = 10;

    public void RestarVida(int daño)
    {
        _puntosVidaActuales = _puntosVidaActuales - daño;

    }
    public void RestaurarVida(int heal)
    {
        _puntosVidaActuales = _puntosVidaActuales + _restaurarVida;

    }

    private void Update()
    {
        // Vida del jugador es >= 80, Color = Verde
        if (_puntosVidaActuales >= 80)
        {
           _uiManager.ColorBarra(Color.green);

        }

        // Vida del jugador es < 40 > 80, Color = Naranja
        if (40 <= _puntosVidaActuales && _puntosVidaActuales < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
            
        }

        // Vida del jugador es < 40, Color = Rojo
        if (_puntosVidaActuales <= 40)
        {
            _uiManager.ColorBarra(Color.red);
            
        }

        if (_puntosVidaActuales > 100)
        {
            _puntosVidaActuales = 100;
        }

        if (_puntosVidaActuales <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}