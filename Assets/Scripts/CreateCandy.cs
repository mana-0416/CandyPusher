using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class crea : MonoBehaviour
{

    //スペースが押されたら、CandyPrefabを生成する
    //1,スペースが押された時の判定
    //2,CandyPrefabを生成する

    //生成したいオブジェクトを変数として定義
    [SerializeField]
    private GameObject candyPrefab;

    //スペースが押された時の判定

    void Update()
    {
        //もしも接続状態のキーボードのスペースキーが押されたら
        // Keyboard => キーボードに関する処理を呼び出す
        // current => 現在接続状態のキーボードを取得する
        // spaceKey => スペースキーの情報を取得する
        // wasPressedThisHrame => 押された瞬間かどうかの判定
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("スペースが押された");
            //Instantiate => オブジェクトを実体化する関数
            // Instantiate(生成したいオブジェクト)
            GameObject InstantiatedCandy = Instantiate(candyPrefab);
            InstantiatedCandy.transform.position = this.transform.position;
        }
    
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   
    
    }

