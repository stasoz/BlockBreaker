using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool GameIsNotOver=true;
    public GameObject[] GButtons;

    private void Start()
    {
        foreach(GameObject i in GButtons)
        {
            i.SetActive(false);
        }
    }
    private void Update()
    {
        EndGame();
    }
    void EndGame()
    {
        if(!GameIsNotOver)
        {
            foreach (GameObject i in GButtons)
            {
                i.SetActive(true);
            }
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameIsNotOver = true;
    }
    public void GoToMenu()
    {
        Application.LoadLevel(0);
        GameIsNotOver = true;
    }
}
