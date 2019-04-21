using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTo2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void GoScene2()
    {
        Debug.Log("ok");
        SceneManager.LoadScene("Scene2");
    }
}
