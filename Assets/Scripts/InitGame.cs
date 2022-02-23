using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class InitGame : MonoBehaviour
{

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        PlayerPrefs.DeleteAll();
    }
}
