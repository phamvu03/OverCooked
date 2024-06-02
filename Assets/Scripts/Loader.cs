using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader 
{
   

    public enum Scence
    {
        MainMenuScence, 
        GameScence, 
        LoadingScence
    }

    private static Scence targetScence;

    public static void Load(Scence targetScence)
    {
        Loader.targetScence = targetScence;

        SceneManager.LoadScene(Scence.LoadingScence.ToString());

       
    }

    public static void LoaderCallBack()
    {
        SceneManager.LoadScene(targetScence.ToString());
    }
}
