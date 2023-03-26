using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DragAndDrop : MonoBehaviour
{
    public GameObject Buah1, Buah2, Buah3, Buah4, Buah1Black, Buah2Black, Buah3Black, Buah4Black;
    Vector2 PosBuah1, PosBuah2, PosBuah3, PosBuah4;

    public bool Buah1_cek, Buah2_cek, Buah3_cek, Buah4_cek;

    public GameObject Menang;
    public GameObject Kalah;
    public GameObject StartGame;
    public AudioClip correct;
    public AudioClip incorrect;
    public AudioClip buttondrop;
    public AudioSource source;

    [Header("System Darah")]
    [SerializeField] private float Damage;
    [SerializeField] private GameObject GameOver;
    public float CurrentNyawa { get; private set; }
    public void Start()
    {
        Buah1_cek = false;
        Buah2_cek = false;
        Buah3_cek = false;
        Buah4_cek = false;

        PosBuah1 = Buah1.transform.position;
        PosBuah2 = Buah2.transform.position;
        PosBuah3 = Buah3.transform.position;
        PosBuah4 = Buah4.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(Buah1_cek && Buah2_cek && Buah3_cek && Buah4_cek)
        {
            Debug.Log("You Win");
            Menang.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Startgame()
    {
        StartGame.SetActive(true);

    }

    public void DragBuah1()
    {
        Buah1.transform.position = Input.mousePosition;
    }

    public void DragBuah2()
    {
        Buah2.transform.position = Input.mousePosition;
    }
    public void DragBuah3()
    {
        Buah3.transform.position = Input.mousePosition;
    }
    public void DragBuah4()
    {
        Buah4.transform.position = Input.mousePosition;
    }

    public void DropBuah1()
    {
        float Distance = Vector3.Distance(Buah1.transform.position, Buah1Black.transform.position);
        Debug.Log(Distance);
        if (Distance < 50)
        {
            Buah1.transform.position = Buah1Black.transform.position;
            Buah1_cek = true;
/*            source.clip = buttondrop;
            source.Play();*/
        }
        else
        {
            Buah1.transform.position = PosBuah1;
            gameObject.GetComponent<Nyawa>().NyawaBerkurang(1);
            
        }
    }
    public void DropBuah2()
    {
        float Distance = Vector3.Distance(Buah2.transform.position, Buah2Black.transform.position);
        if (Distance < 50)
        {
            Buah2.transform.position = Buah2Black.transform.position;
            Buah2_cek = true;
/*            source.clip = buttondrop;
            source.Play();*/
        }
        else
        {
            Buah2.transform.position = PosBuah2;
            gameObject.GetComponent<Nyawa>().NyawaBerkurang(1);
        }
    }
    public void DropBuah3()
    {
        float Distance = Vector3.Distance(Buah3.transform.position, Buah3Black.transform.position);
        if (Distance < 50)
        {
            Buah3.transform.position = Buah3Black.transform.position;
            Buah3_cek = true;
/*            source.clip = buttondrop;
            source.Play();*/
        }
        else
        {
            Buah3.transform.position = PosBuah3;
            gameObject.GetComponent<Nyawa>().NyawaBerkurang(1);
        }
    }
    public void DropBuah4()
    {
        float Distance = Vector3.Distance(Buah4.transform.position, Buah4Black.transform.position);
        if (Distance < 50)
        {
            Buah4.transform.position = Buah4Black.transform.position;
            Buah4_cek = true;
/*            source.clip = buttondrop;
            source.Play();*/
        }
        else
        {
            Buah4.transform.position = PosBuah4;
            gameObject.GetComponent<Nyawa>().NyawaBerkurang(1);
        }
    }
}
