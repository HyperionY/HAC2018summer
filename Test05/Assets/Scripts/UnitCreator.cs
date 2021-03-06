﻿using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCreator : MonoBehaviour {
    
    [SerializeField]
    Transform[] parent = new Transform[2];
    
    [SerializeField]
    GameObject[] unit;

    [SerializeField]
    GameObject[] enemyUnit;

    [SerializeField]
    Transform[] playerSpawn = new Transform[5];

    [SerializeField]
    Transform[] enemySpawn = new Transform[5];

    private void Start()
    {
    }

    public void CreateUnit(int type, int[] colors)
    {
        int spawnPoint = Random.Range(0,playerSpawn.Length);
        GameObject newUnit = Instantiate(unit[type], playerSpawn[spawnPoint].position, Quaternion.identity);
        newUnit.GetComponent<PlayerUnit>().SetColors(colors);
        newUnit.transform.SetParent(parent[0]);
        newUnit.GetComponent<MeshRenderer>().sortingOrder = spawnPoint;
    }

    public void CreateEnemyUnit(int i)
    {
        int enemySpawnPoint = Random.Range(0, enemySpawn.Length);
        GameObject newUnit = Instantiate(enemyUnit[i], enemySpawn[enemySpawnPoint].position, Quaternion.identity);
        newUnit.transform.SetParent(parent[1]);
        newUnit.GetComponent<MeshRenderer>().sortingOrder = enemySpawnPoint;
    }
}
