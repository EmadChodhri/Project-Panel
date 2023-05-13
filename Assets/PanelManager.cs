using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject[] panels;
    public Button[] buttons;

    void Start()
    {
       active();
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    public void active()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            buttons[0].onClick.AddListener(() => panels[0].SetActive(true));
            buttons[1].onClick.AddListener(() => panels[1].SetActive(true));
            buttons[2].onClick.AddListener(() => panels[2].SetActive(true));
            buttons[3].onClick.AddListener(() => panels[3].SetActive(true));
            panels[i].SetActive(false);
        }
    }
}