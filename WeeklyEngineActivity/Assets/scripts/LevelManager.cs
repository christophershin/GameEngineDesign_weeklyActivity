using Chapter.Singleton;
using UnityEngine;

namespace Chapter.Singleton {

    public class LevelManager : Singleton<LevelManager>
    {

        public EnemySpawner spawner;


        private void Start()
        {

            EnemyBase enemy = spawner.SpawnEnemy();
            enemy.attack();
        }


    }


}


