using System;
using System.Collections;
using System.Threading.Tasks;
using Chapter.Singleton;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton {

    public class LevelManager : Singleton<LevelManager>
    {

        public EnemySpawner spawner;
        public EnemySpawner[] ProjectileSpawner;


        [HideInInspector]
        public bool gameEnded = false;
        public bool gameWin = false;


        public GameObject player;
        public GameObject respawnPlatform;


        //UI
        [SerializeField]
        private TextMeshProUGUI conditionText;


        private void Start()
        {

            EnemyBase enemy = spawner.SpawnEnemy();
            enemy.attack();

            for (int i=0; i<ProjectileSpawner.Length; i++)
            {
                ProjectileSpawner[i].SpawnEnemy();
            }

            
        }

        private void Update()
        {
            if (gameEnded)
            {
                StartCoroutine(GameEnded());

            }else if (gameWin)
            {
                conditionText.text = "YOU WIN!!";

            }
            
        }



        public void NextScene()
        {
            SceneManager.LoadScene(1);
        }



        private IEnumerator GameEnded()
        {

            conditionText.text = "YOU DIED";


            yield return new WaitForSeconds(1);
            player.transform.position = respawnPlatform.transform.position + new Vector3(0, 1, 0) ;
            gameEnded = false;
            player.GetComponent<PlayerController>().Move(true);
            player.GetComponent<PlayerController>().SetPlayerHealth(100);
            conditionText.text = " ";

        }






    }


}


