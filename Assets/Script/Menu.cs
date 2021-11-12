using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void clossmenu()
    {
        this.gameObject.SetActive(false);
    }
    public void openmenu()
    {
        this.gameObject.SetActive(true);
    }
}
