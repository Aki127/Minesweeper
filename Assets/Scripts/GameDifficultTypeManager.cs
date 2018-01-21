using System.Collections;
using System.Collections.Generic;
using Mine;
using UnityEngine;

public class GameDifficultTypeManager : SingletonMonoBehaviour<GameDifficultTypeManager>
{                                       
    [SerializeField]
    private CommonDefine.GameDifficultType _gameDifficultType;

    public CommonDefine.GameDifficultType GameDifficultType
    {
        get { return _gameDifficultType; }
    }
    //初回起動していない、こいつが原因？
    void Awake()
    {
        //このスクリプトがアタッチされているオブジェクトはシーン遷移時も生き残る
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetGameDifficultType(CommonDefine.GameDifficultType gameDifficultType)
    {
        _gameDifficultType = gameDifficultType;
    }

    public int GetMineNum()
    {
        switch (_gameDifficultType)
        {
            case CommonDefine.GameDifficultType.NONE:

                return 0;
            case CommonDefine.GameDifficultType.EASY:

                return 10;
            case CommonDefine.GameDifficultType.NORMAL:

                return 40;  
            case CommonDefine.GameDifficultType.DIFFICULT:

                return 99;
            case CommonDefine.GameDifficultType.GAMEOVER:

                return 999;

            case CommonDefine.GameDifficultType.GAMECLEAR:

                return 000;
            default:
                return 0;
        }
    }
}