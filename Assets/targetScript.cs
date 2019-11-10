using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetScript : MonoBehaviour
{
    public GameObject player;
    public static int targetsDestroyed = 0;
    public Text scoreText;
    public Text JumpScore;
    public GameObject targetScore;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreText.text = "";

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            targetsDestroyed += 1;
            scoreText.text = "Targets destroyed: " + targetsDestroyed;
            this.gameObject.SetActive(false);
        }
    }
}
