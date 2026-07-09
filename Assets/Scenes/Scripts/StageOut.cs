using UnityEngine;
using UnityEngine.UI;
public class StageOut : MonoBehaviour
{
    //Score = 0,1,2....
    private int Score;
    //Text型(古いやり方)でテキスト表示
    public Text scoreText;
    //TextMeshProをコード上から取り扱う場合は、TextMeshProUGUI型が必要
    public TMPro.TextMeshProUGUI scoreTextTMP;
    public AudioManager audioManager;
    void OnTriggerEnter(Collider other)
    {
        audioManager.PlaySE();

        //Sccore = Score + 1;
        Score += 1;
        Debug.Log($"{Score}");
        scoreText.text = $"Score: {Score}";

        scoreTextTMP.text = $"{Score}";
        Debug.Log($"{other.name}がすり抜けました");
        Destroy(other.gameObject);
    }

}
