using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private GameObject scoreText;
    private int score_num = 0;

    void OnCollisionEnter(Collision other)
    {
        scoreText = GameObject.Find("ScorerText");

        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score_num += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score_num += 30;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score_num += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score_num += 40;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        scoreText.GetComponent<Text>().text = score_num.ToString();
    }
}
