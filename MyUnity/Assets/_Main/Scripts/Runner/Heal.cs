using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private int cantidadVida = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerStats.RestaurarVida(cantidadVida);

            if (_playerStats._uiManager != null)
            {
                _playerStats._uiManager.SetFillAmount(
                    _playerStats._puntosVidaActuales / 100f
                );
            }

            Destroy(gameObject);
        }
    }
}