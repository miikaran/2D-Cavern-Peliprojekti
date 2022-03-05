using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerItem : MonoBehaviour
{
    static private float currentTime = 0f;

    [SerializeField] Text countDownText;
    [SerializeField] Text GameOverText;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            currentTime += 5;
            countDownText.text = currentTime.ToString("0.0");
            Destroy(gameObject);

        }

    }


}