using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField inputField;
    public string playerName;

    public void StartNew()
    {
        playerName = inputField.text;
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //MainManager.Instance.SaveColor();
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

}
