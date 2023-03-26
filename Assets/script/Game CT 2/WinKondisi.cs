using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinKondisi : MonoBehaviour
{
    [SerializeField] private Movement Data;
    public GameObject Winkondisi;
    public GameObject[] bintang;
    public int Point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("TES!!!!");
            StartCoroutine(Playerwin());
            Debug.Log(Data.Point);
        }
    }

    public void TakePoint(int _points)
    {
        Point = Point + _points;
    }

    private IEnumerator Playerwin()
    {
        Data.enabled = false;
        Debug.Log("You Win");
        Point = Data.Point;
        yield return new WaitForSeconds(0.5f);
        Winkondisi.SetActive(true);
        if (Point == 1) {
            yield return new WaitForSeconds(0.5f);
            bintang[0].SetActive(true);
        }
        else if (Point == 2){
            yield return new WaitForSeconds(0.5f);
            bintang[0].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bintang[1].SetActive(true);
        }
        else if (Point == 3)
        {
            yield return new WaitForSeconds(0.5f);
            bintang[0].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bintang[1].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            bintang[2].SetActive(true);
        }

    }
}
