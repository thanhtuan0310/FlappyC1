using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
     void OnEnable()
    {
        StartCoroutine(AnimateText());    
    }

    IEnumerator AnimateText()
    {
        scoreText.text = "0";
        int score = 0;

        yield return new WaitForSeconds(.7f);

        while (score < PlayerController.score)
        {
            score++;
            scoreText.text = score.ToString();

            yield return new WaitForSeconds(.05f);
        }
    }
}
