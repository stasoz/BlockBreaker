using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Chek : MonoBehaviour
{
    GameObject[] target;
    private void Update()
    {
        target = GameObject.FindGameObjectsWithTag("enemy");
        if (target.Length == 0)
        {
            GameManager.GameIsNotOver = false;
            LoadLevelManager.openLevel2 = true;
        }
        Debug.Log(LoadLevelManager.openLevel2);
        
    }
}
