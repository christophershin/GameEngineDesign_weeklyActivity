using Chapter.Singleton;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton {

    public class LevelManager : Singleton<LevelManager>
    {

        public EnemySpawner spawner;

        public bool gameEnded = false;
        public GameObject player;

        private void Start()
        {

            EnemyBase enemy = spawner.SpawnEnemy();
            enemy.attack();
        }



        public void NextScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }


}


