using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    // 跳3
    public void 跳轉至3()
    {
        SceneManager.LoadScene("00_003");
    }

    // 跳4
    public void 跳轉至4()
    {
        SceneManager.LoadScene("00_004");
    }

    // 跳5
    public void 跳轉至5()
    {
        SceneManager.LoadScene("00_005");
    }

    // 跳2
    public void 跳轉至2()
    {
        SceneManager.LoadScene("00_002");
    }

    // 跳1
    public void 跳轉至1()
    {
        SceneManager.LoadScene("00_001");
    }
}
