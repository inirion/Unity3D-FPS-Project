using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemies : MonoBehaviour {
    GameObject[] _enemies;
	// Use this for initialization
	void Start () {
        SearchForEnemies();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SearchForEnemies()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(_enemies.Length > 0)
        {
            foreach (GameObject enemy in _enemies)
            {
                Debug.Log(enemy.name);
            }
        }
    }
}
