using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;
    public spawnerBlock block_Spawner;
    [HideInInspector]
    public Block CurrentBlock;

    public CameraFollow cameraFollow;

    private int moveCount = 0;

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

    void DetectarInput() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            CurrentBlock.dropBlock();
        }
    }

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
        moveCount++;

        if(moveCount == 2)
        {
            moveCount = 0;
            //cameraFollow.targetPos.y += 1f;
        }
    }

    public void Reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
