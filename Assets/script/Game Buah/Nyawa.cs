using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nyawa : MonoBehaviour
{
    [SerializeField] private float nyawaAwal;
    [SerializeField] private GameObject GameOver;

    [Header("Nyawa Awal")]
    [SerializeField] private float iFrameDuration;
    [SerializeField] private int number;

    public float CurrentNyawa { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        CurrentNyawa = nyawaAwal;

    }


    public void NyawaBerkurang(float Hit)
    {
        CurrentNyawa = Mathf.Clamp(CurrentNyawa - Hit, 0, nyawaAwal);

        if(CurrentNyawa == 0)
        {
            GameOver.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BBusuk")
        {
            NyawaBerkurang(1);
        }
    }
}
