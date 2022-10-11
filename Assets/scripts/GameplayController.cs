using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;
    public spawnerBlock block_Spawner;
    [HideInInspector]
    public Block CurrentBlock;

    public CameraFollow cameraFollow;
    public GameObject panelPause;

    

    void Awake() 
    {
        if(instance == null)
            instance = this;
    }

    void Start()
    {
        block_Spawner.spawnBlock();
    }

    void Update()
    {
        DetectarInput();
    }

    //detecta el teclado
    void DetectarInput() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            CurrentBlock.dropBlock();
        }
    }

    //aparecer un nuevo bloque
    public void SpawnNewBlock()
    {
        Invoke("newBlock", 1f);
    }

    void newBlock()
    {
        block_Spawner.spawnBlock();
    }

    public void moveCamera()
    {
        cameraFollow.targetPos.y += 2.5f;
    }

    public void Reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        
        Time.timeScale = 1f;
    }

    //sale del juego
    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //reanuda el juego 
    public void Continue()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Pause()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
    }
}
