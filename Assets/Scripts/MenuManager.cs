using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public void LoadSelectLevelScene()
    {
        Application.LoadLevel(1);
    }
    public void LoadExit()
    {
        Application.Quit();
    }
}
