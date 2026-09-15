using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    public int _puntosVidaActuales;

    [SerializeField] private UIManager _uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_puntosVidaActuales < 100)
            {
                Debug.Log("El jugador ha recibido vida");
                _playerStats.RestaurarVida(10);
                _uiManager.SumarFillAmount();
            }
        }

        Destroy(this.gameObject);
        
    }
}