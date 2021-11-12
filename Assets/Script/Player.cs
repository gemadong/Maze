using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text text = null;
    private float Speed = 3f;
    private float rotSpeed = 100f;
    public float second = 30f;
    [SerializeField] private Text timeText = null;
    [SerializeField] private Slider slider = null;
    public int coin = 0;



    private void Update()
    {
        NORMAL();
        times();
        timeText.text = string.Format("{0:D2}",(int)second % 60);
        text.text = "SCORE : " + coin.ToString();
        slider.value = second / 30f;
    }
    
    public void NORMAL()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position =
                transform.position +
                (transform.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position =
                transform.position +
                (transform.forward * -Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -rotSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        }
    }
   
   
    public void CoinPP()
    {
        coin+=10;
    }

    public void TimePP()
    {
        second += 10f;
    }
    private void times()
    {
        second -= Time.deltaTime;
        if (second <=0) SceneManager.LoadScene(2);
    }
}
