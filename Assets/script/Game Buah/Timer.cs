using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TextTime;
    public float Waktu;
    public bool GameAktif;
    public GameObject PanelKalah;
    public GameObject PanelMenang;
    public GameObject Spawn;

    float S;

    // Start is called before the first frame update
    void Start()
    {
        GameAktif = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameAktif)
        {
            S += Time.deltaTime;
            if (S >= 1)
            {
                Waktu--;
                S = 0;
            }

            if (GameAktif && Waktu <= 0)
            {
                GameAktif = false;
                Spawn.SetActive(false);
                PanelKalah.SetActive(true);
            }
        }
        SetWaktu();
    }

    void SetWaktu()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTime.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    public void GameDimulai()
    {
        GameAktif = true;
    }

    public void GameSelesai()
    {
        GameAktif = false;
    }

}
