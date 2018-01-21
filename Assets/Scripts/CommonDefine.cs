using System.Collections;
using UnityEngine;

namespace Mine{
    //<summary>
    // 定数とか列挙型を定義するクラス
    //</summary>
    public class CommonDefine
    {
        //<summary>
        //ゲームの難易度
        //</summary>
        public enum GameDifficultType
        {
            NONE,
            EASY,
            NORMAL,
            DIFFICULT,
            GAMEOVER,
            GAMECLEAR
        }
    }
}