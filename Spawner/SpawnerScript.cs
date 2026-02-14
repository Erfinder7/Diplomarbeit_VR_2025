using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objSpawner : MonoBehaviour
{
    public GameObject obj;
    int randNum;
    public Transform spawnDest1;
    public bool spawningbool = true;
    public float spawnTime;

    void Start()
    {
        StartCoroutine(spawning());
    }
        IEnumerator spawning()
    {
    while(spawningbool == true)
        {
            yield return new WaitForSeconds(spawnTime);

            randNum = Random.Range(0, 1);

            if(randNum == 0)
            {
                GameObject spawnedObject = Instantiate(obj, spawnDest1.position, spawnDest1.rotation);
                Destroy(spawnedObject, 3.5f);
            }
        }   
    }
}