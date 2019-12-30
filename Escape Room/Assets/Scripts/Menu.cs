using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject main;
    public GameObject options;
    // Start is called before the first frame update
    public void Start()
    {
        main.SetActive(true);
        options.SetActive(false);
    }
   public void HideMenu()
    {
        main.SetActive(false);
        options.SetActive(true);
    }
    public void ShowMenu()
    {
        main.SetActive(true);
        options.SetActive(false);
    }
}
