using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private int cantidadDaño = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerStats.RestarVida(cantidadDaño);

            if (_playerStats._uiManager != null)
            {
                _playerStats._uiManager.SetFillAmount(
                    _playerStats._puntosVidaActuales / 100f
                );
            }
        }
    }
}