using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerBlock : MonoBehaviour
{
    public static spawnerBlock instance;
    public GameObject prefabsBlock;
    public GameObject crane;

    private void Awake() {
        if (instance == null){
            instance = this;
        }
    }
    public void spawnBlock(){
        AudioManager.instance.PlaySound("spawn");
        GameObject newBlock = Instantiate(prefabsBlock);

        Vector3 vecto = crane.transform.position;
        vecto.y -= 2.9f;

        newBlock.transform.position = vecto;

    }
}
