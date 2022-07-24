using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1Controller : MonoBehaviour
{
    [SerializeField] InputField input;
    
    public void addCharacter(string value)
    {
        input.text += value;
    }
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
