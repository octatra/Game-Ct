using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarNyawa : MonoBehaviour
{
    [SerializeField] private Nyawa NyawaPlayer;
    [SerializeField] private Image totalNyawa;
    [SerializeField] private Image CurrentNyawa;
    // Start is called before the first frame update
    void Start()
    {
        totalNyawa.fillAmount = NyawaPlayer.CurrentNyawa / 4;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentNyawa.fillAmount = NyawaPlayer.CurrentNyawa / 4;
    }
}
