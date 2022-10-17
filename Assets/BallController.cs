using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�X�R�A�̕ϐ�
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������ScoreOverText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
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

