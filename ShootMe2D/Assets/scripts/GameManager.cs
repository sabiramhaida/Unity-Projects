using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{   public GameObject winText;
    public GameObject target;
    int score = 0;
    public Text ScoreText;
    bool win =false;
    // Start is called before the first frame update
    void Start()
    {
        //spawn();
	InvokeRepeating("spawn",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(win==true)
	{
	   CancelInvoke("spawn");
	}

	if(Input.GetMouseButtonDown(0))
	{
	   GetComponent<AudioSource>().Play();

	}

    }
    void spawn()
    {
    	float randomX=Random.Range(-7f,7f);
	float randomY=Random.Range(-3.5f,3.5f);

	Vector3 randomPosition = new Vector3(randomX,randomY,0);
	
	Instantiate(target, randomPosition,Quaternion.identity);
    }
    public void IncrementScore()
    {
	score++;
        print(score);
	ScoreText.text = score.ToString();
	if(score >= 10)
	{
	   win=true;
	   winText.SetActive(true);
	}
    }
}
