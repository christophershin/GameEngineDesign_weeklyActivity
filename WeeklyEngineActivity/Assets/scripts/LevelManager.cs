using System;
using Chapter.Singleton;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton {

    public class LevelManager : Singleton<LevelManager>
    {

        public EnemySpawner spawner;
        public EnemySpawner[] ProjectileSpawner;

        public bool gameEnded = false;
        public GameObject player;

        private void Start()
        {

            EnemyBase enemy = spawner.SpawnEnemy();
            enemy.attack();

            for (int i=0; i<ProjectileSpawner.Length; i++)
            {
                ProjectileSpawner[i].SpawnEnemy();
            }

            
        }



        public void NextScene()
        {
            SceneManager.LoadScene(1);
        }


    }


}


