using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerBlock : MonoBehaviour
{
    public GameObject prefabsBlock;
    public GameObject crane;
    void Start()
    {
        spawnBlock();
    }

    public void spawnBlock(){
        GameObject newBlock = Instantiate(prefabsBlock);

        Vector3 vecto = crane.transform.position;
        vecto.y -= 2.9f;

        newBlock.transform.position = vecto;

    }
}
