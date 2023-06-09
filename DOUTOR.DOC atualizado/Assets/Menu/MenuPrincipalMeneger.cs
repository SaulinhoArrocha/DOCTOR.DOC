using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalMeneger : MonoBehaviour
{

    public LevelLoader levelLoader;

    [SerializeField] private string nomeDoLevelDeJogo;

    public void Jogar()
    {
        levelLoader.Transition(nomeDoLevelDeJogo);
    }
}
