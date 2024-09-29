using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Home;
    public GameObject Category;
    public GameObject Authorization;
    public InputField login;
    public InputField password;

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void OpenMainMenu()
    {
        Category.SetActive(false);
        Home.SetActive(true);
        Menu.SetActive(false);
        Authorization.SetActive(false);
    }


    public void OpenMenu()
    {
        Category.SetActive(false);
        Home.SetActive(false);
        Menu.SetActive(true);
        Authorization.SetActive(false);

    }

    public void OpenCategory()
    {
        Category.SetActive(true);
        Home.SetActive(false);
        Menu.SetActive(false);
        Authorization.SetActive(false);

    }

    public void OpenAuthor()
    {
        Category.SetActive(false);
        Home.SetActive(false);
        Menu.SetActive(false);
        Authorization.SetActive(true);

    }


    public void RunGameByID(int i)
    {
        if (i >= 0 && i < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(i);

            //if (i == 0)
            //{
            //    OpenMenu();
            //}
        }
        else
        {
            Debug.LogError("ID scene not exist. Max count - " + SceneManager.sceneCountInBuildSettings);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Author()
    {
        string[,] user = new string[3, 2] {
            {"user1","123"},
            {"user2","123"},
            {"user3","123"}
        };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
                if (login.text == user[i, j] && password.text == user[i, j + 1])
                {

                    Category.SetActive(false);
                    Home.SetActive(false);
                    Menu.SetActive(true);
                    Authorization.SetActive(false);
                }
        }

        OpenMainMenu();
    }
}
