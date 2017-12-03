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

    void Awake()
    {
        //このスクリプトがアタッチされているオブジェクトはシーン遷移時も生き残る
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetGameDifficultType(CommonDefine.GameDifficultType gameDifficultType)
    {
        _gameDifficultType = gameDifficultType;
    }
}