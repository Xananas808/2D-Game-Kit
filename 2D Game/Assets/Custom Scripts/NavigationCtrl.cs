using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationCtrl : MonoBehaviour
{
    public GameObject ButtonParent;
    public GameObject LvlParent;
    // Start is called before the first frame update
    public void DisplayMenuButton()
    {
        ButtonParent.SetActive(true);
        LvlParent.SetActive(false);
    }

    // Update is called once per frame
    public void DisplayLvlButton()
    {
        ButtonParent.SetActive(false);
        LvlParent.SetActive(true);

    }
}
