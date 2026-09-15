using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;

    [SerializeField] public UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("El jugador ha recibido daño");
            _playerStats.RestarVida(10);
            _uiManager.RestarFillAmount(0.1f);
        }
    }
}