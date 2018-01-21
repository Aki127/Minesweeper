using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultController : MonoBehaviour {
    public int mines = 0;
    public Sprite _gameover;
    public Sprite _gameclear;
    private bool flg = true;
    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Result")
        {
            mines = GameDifficultTypeManager.Instance.GetMineNum();
            //爆弾の数を取得
            Debug.Log(mines);
        }
        if (mines == 999)
        {
            Debug.Log("ゲームオーバー");
            var img = GetComponent<Image>();
            img.sprite = (flg) ? _gameover : _gameclear;
            flg = !flg;
        }
        if (mines == 000)
        {
            Debug.Log("ゲームクリア！");
            var img = GetComponent<Image>();
            img.sprite = (flg) ? _gameclear: _gameover;
            flg = !flg;
            //実装してないMainPanelsCountrollerに追加する必要あり
        }
      
        
    }
}
