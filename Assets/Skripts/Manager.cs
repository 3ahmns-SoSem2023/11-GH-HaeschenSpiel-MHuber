using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int round = 0;
    public int RotScore;
    public int GrauScore;
    public int BlauScore;
    public int GelbScore;
    public Button ButtonRot;
    public Button ButtonBlau;
    public Button ButtonGelb;
    public Button ButtonGrau;
    public Text ScoreRot;
    public Text ScoreGelb;
    public Text ScoreGrau;
    public Text ScoreBlau;
    public Text countTextRot;
    public Text countTextGelb;
    public Text countTextGrau;
    public Text countTextBlau;
    private int countRot;
    private int countGelb;
    private int countBlau;
    private int countGrau;

    [SerializeField] private Image PlayerRot, PlayerBlau, PlayerGelb, PlayerGrau;

    public void ButtonRotClick()
    {
        PlayerRot.GetComponent<Image>().color = Color.red;
        PlayerBlau.color = Color.blue;
        PlayerGelb.color = Color.yellow;
        PlayerGrau.color = Color.grey;

        int rnd = Random.Range(0, 4);
        if (rnd == 0)
        {
            ButtonRot.image.color = Color.red;
            countRot++;
            countTextRot.text = countRot.ToString();
            RotScore++;
        }

        if (rnd == 1)
        {
            ButtonRot.image.color = Color.grey;
        }

        if (rnd == 2)
        {
            ButtonRot.image.color = Color.blue;
        }

        if (rnd == 3)
        {
            ButtonRot.image.color = Color.yellow;
        }
    }
    public void ButtonBlauClick()
    {
        int rnd = Random.Range(0, 4);
        if (rnd == 0)
        {
            ButtonBlau.image.color = Color.blue;
            countBlau++;
            countTextBlau.text = countBlau.ToString();
        }

        if (rnd == 1)
        {
            ButtonBlau.image.color = Color.grey;
        }

        if (rnd == 2)
        {
            ButtonBlau.image.color = Color.red;
        }

        if (rnd == 3)
        {
            ButtonBlau.image.color = Color.yellow;
        }

    }
    public void ButtonGelbClick()
    {
        int rnd = Random.Range(0, 4);
        if (rnd == 0)
        {
            ButtonGelb.image.color = Color.yellow;
            countGelb++;
            countTextGelb.text = countGelb.ToString();

        }

        if (rnd == 1)
        {
            ButtonGelb.image.color = Color.red;
        }

        if (rnd == 2)
        {
            ButtonGelb.image.color = Color.blue;
        }

        if (rnd == 3)
        {
            ButtonGelb.image.color = Color.grey;
        }
    }
    public void ButtonGrauClick()
    {
        int rnd = Random.Range(0, 4);
        if (rnd == 0)
        {
            ButtonGrau.image.color = Color.grey;
            countGrau++;
            countTextGrau.text = countGrau.ToString();
        }

        if (rnd == 1)
        {
            ButtonGrau.image.color = Color.red;
        }

        if (rnd == 2)
        {
            ButtonGrau.image.color = Color.blue;
        }

        if (rnd == 3)
        {
            ButtonGrau.image.color = Color.yellow;
        }
    }
    void Start()
    {

    }

    void Update()
    {

    }
}

