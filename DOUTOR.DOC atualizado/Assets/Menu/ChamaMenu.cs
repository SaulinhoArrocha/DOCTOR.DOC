using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamaMenu : MonoBehaviour
{
    public LevelLoader LevelLoader;



    public void CenaMenu()
    {
        LevelLoader.Transition("Amenu");
    }
}
