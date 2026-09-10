using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))

        Debug.Log("El jugador ha recibido vida");
        _playerStats.RestaurarVida(10);
        _uiManager.SumarFillAmount(0.1f);

        Destroy(this.gameObject);
    }
}