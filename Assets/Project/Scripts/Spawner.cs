using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Points")]
    [SerializeField] private Transform spawnPoint1;
    [SerializeField] private Transform spawnPoint2;
    [SerializeField] private Transform spawnGroup;

    [Header("Object Prefabs")]
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private GameObject boosterPrefab;

    [Header("Object Spawn Time")]
    [Range(0.1f, 20f)] [SerializeField] private float coinSpawnTime=0.1f;
    [Range(0.1f, 20f)] [SerializeField] private float bombSpawnTime = 0.1f;
    [Range(0.1f, 20f)] [SerializeField] private float boosterSpawnTime = 0.1f;

    private void Start()
    {
        StartCoroutine(SpawnObj(coinPrefab, coinSpawnTime));
        StartCoroutine(SpawnObj(bombPrefab, bombSpawnTime));
        StartCoroutine(SpawnObj(boosterPrefab, boosterSpawnTime));
    }


    private IEnumerator SpawnObj(GameObject obj,float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);

            float randXPos = Random.Range(spawnPoint1.position.x,spawnPoint2.position.x);
            Vector3 newPos = new Vector3(randXPos, spawnPoint1.position.y,spawnPoint1.position.z);
            GameObject go = Instantiate(obj,newPos,Quaternion.identity,spawnGroup);
            Destroy(go, 10f);
        }
    }



}
