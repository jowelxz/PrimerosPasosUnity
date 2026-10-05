using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    private float tiempo = 0f;

    public bool juegoActivo = true;

    void Update()
    {
        if (!juegoActivo)
            return;

        tiempo += Time.deltaTime;

        int minutos = Mathf.FloorToInt(tiempo / 60f);
        int segundos = Mathf.FloorToInt(tiempo % 60f);

        timerText.text = "+" + minutos.ToString("00") + ":" + segundos.ToString("00");
    }

    public void DetenerTimer()
    {
        juegoActivo = false;
    }
}