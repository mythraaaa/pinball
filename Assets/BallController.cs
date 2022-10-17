using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //スコアを表示するテキスト
    private GameObject scoreText;

    //スコアの変数
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のScoreOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over!!";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "LargeStarTag")
        {
            score += 120;
        }
        if ( collision.gameObject.tag == "SmallStarTag")
        {
            score += 60;
        }
        if ( collision.gameObject.tag == "LargeCloudTag")
        {
            score += 100;
        }
        if ( collision.gameObject.tag == "SmallCloudTag")
        {
            score += 50;
        }
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
}

