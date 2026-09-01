using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    // Start is called before the first frame update
    void Start()
    {
        _barra.color = Color.cyan;
        _barra.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}