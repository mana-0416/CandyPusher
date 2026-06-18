using UnityEngine;
using UnityEngine.UI;
public class StageOut : MonoBehaviour
{
    //Score = 0,1,2....
    private int Score;
    public Text scoreText;
    void OnTriggerEnter(Collider other)
    {
        //Sccore = Score + 1;
        Score += 1;
        Debug.Log($"{Score}");
        scoreText.text = $"Score: {Score}";
        Debug.Log($"{other.name}‚ª‚·‚è”²‚¯‚Ü‚µ‚½");
        Destroy(other.gameObject);
    }

}
