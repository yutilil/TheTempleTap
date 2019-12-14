using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MokugyoManager : MonoBehaviour
{
    // オブジェクト参照
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 木魚をタップしたときに呼び出される
    /// </summary>
    public void TapMokugyo()
    {
//
        // デバッグ
        Debug.Log(message: "Mokugyo++");
//
        gameManager.GetComponent<GameManager>().CreateNewOrb();
    }
}
