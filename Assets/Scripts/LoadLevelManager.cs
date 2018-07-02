using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelManager : MonoBehaviour {

    public static bool 
        openLevel2=false,
        openLevel3=false,
        openLevel4=false,
        openLevel5=false,
        openLevel6=false,
        openLevel7=false,
        openLevel8=false,
        openLevel9=false;
	public void Level1()
    {
        Application.LoadLevel(2);
    }
    public void Level2()
    {
        if (openLevel2)
        {
            Application.LoadLevel(3);
        }
    }
    public void Level3()
    {
        Application.LoadLevel(4);
    }
    public void Level4()
    {
        Application.LoadLevel(5);
    }
    public void Level5()
    {
        Application.LoadLevel(6);
    }
    public void Level6()
    {
        Application.LoadLevel(7);
    }
    public void Level7()
    {
        Application.LoadLevel(8);
    }
    public void Level8()
    {
        Application.LoadLevel(9);
    }
    public void Level9()
    {
        Application.LoadLevel(10);
    }
    public void Level10()
    {
        Application.LoadLevel(11);
    }
}
