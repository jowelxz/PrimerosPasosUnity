using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static Vector3 posicionMario;
    private static bool hayPosicionGuardada = false;

    private static int vidaMario;
    private static bool hayVidaGuardada = false;

    private static float tiempoGuardado;
    private static bool hayTiempoGuardado = false;
    

    public Timer timer;
    void Start()
    {
        RestaurarPosicionMario();
    }

    public void CargarEscena(int scene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

    public void PausarElJuego()
    {
        Time.timeScale = 0;
    }

    public void ReanudarElJuego()
    {
        Time.timeScale = 1;
    }

    public void PausarMusica()
    {
        if (MusicManager.instancia != null)
        {
            MusicManager.instancia.PausarMusica();
        }
    }

    public void ReanudarMusica()
    {
        if (MusicManager.instancia != null)
        {
            MusicManager.instancia.ReanudarMusica();
        }
    }

    public void ReiniciarMusica()
    {
        if (MusicManager.instancia != null)
        {
            MusicManager.instancia.ReiniciarMusica();
        }
    }

    public void AlternarMute()
    {
        if (MusicManager.instancia != null)
        {
            MusicManager.instancia.AlternarMute();
        }
    }

    public void CargarEscenaYReanudarMusica(int scene)
    {
        Time.timeScale = 1f;

        if (MusicManager.instancia != null)
        {
            MusicManager.instancia.ReanudarMusica();
        }

        SceneManager.LoadScene(scene);
    }

    public void ReiniciarPartida()
    {
        Time.timeScale = 1f;

        hayPosicionGuardada = false;
        hayVidaGuardada = false;
        hayTiempoGuardado = false;

        tiempoGuardado = 0f;
        vidaMario = 100;

        if (MusicManager.instancia != null)
        {
            MusicManager.instancia.ReiniciarMusica();
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IrAlLobby(int scene)
{
    GameObject mario = GameObject.Find("Marito");

        if (mario != null)
        {
            posicionMario = mario.transform.position;
            hayPosicionGuardada = true;

            PlayerStats stats = mario.GetComponent<PlayerStats>();

            if (stats != null)
            {
                vidaMario = stats._puntosVidaActuales;
                hayVidaGuardada = true;
            }
        }

        if (timer != null)
        {
            tiempoGuardado = timer.ObtenerTiempo();
            hayTiempoGuardado = true;
        }

        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }

    public void RestaurarPosicionMario()
    {
        if (hayPosicionGuardada)
        {
            GameObject mario = GameObject.Find("Marito");

            if (mario != null)
            {
                mario.transform.position = posicionMario;

                PlayerStats stats = mario.GetComponent<PlayerStats>();

                if (stats != null && hayVidaGuardada)
                {
                    stats._puntosVidaActuales = vidaMario;

                    if (stats._uiManager != null)
                    {
                        stats._uiManager.SetFillAmount(stats._puntosVidaActuales / 100f);
                    }
                }
            }
        }

        if (timer != null && hayTiempoGuardado)
        {
            timer.RestaurarTiempo(tiempoGuardado);
        }
    }
}