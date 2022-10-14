using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Gamekit2D
{
    public class StartUI : MonoBehaviour
    {

        public void Quit()
        {
            EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
