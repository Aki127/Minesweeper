using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Mine
{

    public class MinePanelsCountroller : MonoBehaviour
    {
        public Sprite _mine;
        public Sprite _off;
        private bool flg = true;

        // Use this for initialization
        public void SafeOpen()
        {
            Debug.Log("セーフ！");
            //パネルの無効化
            gameObject.SetActive(false);

        }
        public void MineOpen()
        {
            Debug.Log("地雷だ！");
            var img = GetComponent<Image>();
            img.sprite = (flg) ? _mine : _off;
            flg = !flg;
            //Invoke("DelayMethod", 3.5f);
            GameDifficultTypeManager.Instance.SetGameDifficultType(CommonDefine.GameDifficultType.GAMEOVER);
            SceneManager.LoadScene("Result");

        }
    }
}
