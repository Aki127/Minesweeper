using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mine;

namespace Mine
{
    public class MineCount : MonoBehaviour
    {

        public Text text;
        public int mines = 0;

        // Use this for initialization
        void Start()
        {
            if (SceneManager.GetActiveScene().name == "Game")
            {
                mines = GameDifficultTypeManager.Instance.GetMineNum();
                //爆弾の数を取得
                Debug.Log(mines);
            }
        }

        // Update is called once per frame
        void Update()
        {
            //if (SceneManager.GetActiveScene().name == "Game")
            //{
            mines = GameDifficultTypeManager.Instance.GetMineNum();
            string minesText = (mines).ToString();
            text.text = minesText;
           //Debug.Log("ローディング済" + mines);

        }
    }
}
//}
