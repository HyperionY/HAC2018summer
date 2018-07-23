﻿using System.Collections;
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
    Transform playerSpawn;

    [SerializeField]
    Transform enemySpawn;

    private void Start()
    {
        
    }

    public void CreateUnit(int type, string[] colors)
    {
        GameObject newUnit = Instantiate(unit[type], playerSpawn.position, Quaternion.identity);
        newUnit.GetComponent<PlayerUnit>().SetColors(colors);
        newUnit.transform.SetParent(parent[0]);
    }

    public void CreateEnemyUnit(int i)
    {
        GameObject newUnit = Instantiate(enemyUnit[i], enemySpawn.position, Quaternion.identity);
        newUnit.transform.SetParent(parent[1]);
    }
}
