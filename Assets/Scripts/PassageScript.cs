using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageScript : MonoBehaviour
{

    [SerializeField] GameObject bola ;
    [SerializeField] GameObject player;
    [SerializeField] GameObject cenario;
    [SerializeField] GameObject canvas;


    public void mudaCena1()
    {
        DontDestroyOnLoad(bola);
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(cenario);
        DontDestroyOnLoad(canvas);
        DontDestroyOnLoad(gameObject);
    }

    public void mudaCena2()
    {
        Destroy(bola);
        Destroy(player);
        Destroy(cenario);
        DontDestroyOnLoad(canvas);
        canvas.SetActive(false);
        //Destroy(canvas);
        Destroy(gameObject);
    }
}
