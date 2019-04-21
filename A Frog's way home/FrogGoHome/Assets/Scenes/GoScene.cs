//  Only using load menu and Scene 1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoScene : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void loadHome()
    {
        SceneManager.LoadScene("Welcome");
    }

    
}
