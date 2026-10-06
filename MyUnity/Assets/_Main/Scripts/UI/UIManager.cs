using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;

    public void SumarFillAmount(float Mamount = 0.1f)
    {
        _barra.fillAmount += Mamount;
    }

    public void RestarFillAmount(float Ramont = 0.1f)
    {
        _barra.fillAmount -= Ramont;
    }

    public void SetFillAmount(float amount)
    {
        _barra.fillAmount = Mathf.Clamp01(amount);
    }

    public void ColorBarra(Color color)
    {
        _barra.color = color;
    }
}