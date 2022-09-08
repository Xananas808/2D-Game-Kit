using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvlButton : MonoBehaviour
{
    public int lvlID;
    public void Play() { SceneManager.LoadScene(lvlID); }

}