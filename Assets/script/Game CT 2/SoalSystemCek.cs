using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalSystemCek : MonoBehaviour
{
    public InputField InputJawaban;
    public string Jawaban;
    public GameObject WinKondisi;
    public GameObject LossKondisi;
    // Start is called before the first frame update
    public void CekJawaban()
    {
        string inputJawaban = InputJawaban.text;

        if(inputJawaban == Jawaban)
        {
            Debug.Log("Jawaban Benar");
            WinKondisi.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Jawan Salah");
            LossKondisi.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
