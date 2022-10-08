using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerBlock : MonoBehaviour
{
    public GameObject prefabsBlock;
    public GameObject crane;
    public GameObject gameObjectPosition;
    void Start()
    {
        spawnBlock();
    }

    public void spawnBlock(){
        SoundManager.instance.PlaySound("spawn");
        GameObject newBlock = Instantiate(prefabsBlock);

        Vector3 vecto = crane.transform.position;
        vecto.y -= 2.9f;

        newBlock.transform.position = vecto;
        this.gameObjectPosition.transform.position = new Vector3(this.gameObjectPosition.transform.position.x,
        this.gameObjectPosition.transform.position.y+1,this.gameObjectPosition.transform.position.z);

    }
}
