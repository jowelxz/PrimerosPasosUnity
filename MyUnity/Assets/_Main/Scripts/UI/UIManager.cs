using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    

    public void SumarFillAmount (float Mamount = 0.1f)
    {
        _barra.fillAmount += Mamount;
    }
    public void RestarFillAmount (float Ramount = 0.1f)
    {
        _barra.fillAmount -= Ramount;
    }
    public void ColorBarra(Color color)
    {
        _barra.color = color;
    }
}