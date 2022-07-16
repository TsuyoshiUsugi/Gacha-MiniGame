using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ガチャのマネージャーコンポーネント
/// ガチャのシーンになった時上からガチャを生成する
/// leverオブジェクトがクリックされるとガチャがまわる
/// 排出されるガチャはガチャ下部のバー(UnderBarオブジェクト)に当たっているものからランダムで選ばれる
/// </summary>
public class GachaManager : MonoBehaviour
{
    /// <summary>生成するガチャのオブジェクト</summary>
    [SerializeField] GameObject _gachaBallObj;

    /// <summary>最初に生成するガチャの数</summary>
    [SerializeField] int _gachaBallLimit = 10;

    /// <summary>最初に生成するガチャの位置</summary>
    [SerializeField] Vector2 InstantiatePoint;

    /// <summary>レバーが回されたらtrueになる</summary>
    [SerializeField] bool _leverClicked;

    /// <summary>leverオブジェクトが使用するプロパティ</summary>
    public bool Lever { get => _leverClicked; set => _leverClicked = value; }

    /// <summary>出せるオブジェクトのリスト
    /// UnderBarオブジェクトが読みこんだものをいれる</summary>
    [SerializeField] List<GameObject> _waitToPullOut;

    /// <summary>leverオブジェクトが使用するプロパティ</summary>
    public void PullOutObj(GameObject ball) { _waitToPullOut.Add(ball); }

    void Start()
    {
        //シーンに入ったタイミングでガチャ玉を設定数生成する
        for (int ballNumber = 0; ballNumber < _gachaBallLimit; ballNumber++)
        {
            InstantiateGacha();
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayGacha();
    }

    /// <summary>
    /// ガチャ玉を生成するメソッド
    /// </summary>
    void InstantiateGacha()
    {
        Instantiate(_gachaBallObj, InstantiatePoint, Quaternion.identity);
    }

    /// <summary>
    /// _leverが回されたときのメソッド
    /// _waitToPullOutのリストからランダムで排出する
    /// </summary>
    void PlayGacha()
    {
        //レバーが回されたら
        if (_leverClicked == true)
        {
            int Atari = Random.Range(0, _waitToPullOut.Count);

            //ここから排出したものの表示、演出
            Debug.Log(_waitToPullOut[Atari].GetComponent<Ball1>().TestString);
            Destroy(_waitToPullOut[Atari]);

            //リストから排出されたものを消す
            _waitToPullOut.RemoveAt(Atari);
        }
        _leverClicked = false;
    }


}
