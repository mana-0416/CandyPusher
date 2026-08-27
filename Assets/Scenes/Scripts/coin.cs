using UnityEngine;

public class Coin : MonoBehaviour
{
    // コインの種類
    // 0 = 銅
    // 1 = 銀
    // 2 = 金
    public int coinType;

    // コインの得点
    public int score;

    // 合成したときに作るコイン
    public GameObject nextCoinPrefab;

    // 合成中かどうか
    private bool isMerging = false;


    // コイン同士がぶつかったとき
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("コインが何かにぶつかりました");
        // ぶつかった相手からCoinを探す
        Coin otherCoin = collision.gameObject.GetComponent<Coin>();

        // 相手がコインではなかったら何もしない
        if (otherCoin == null)
        {
            return;
        }

        // すでに合成中なら何もしない
        if (isMerging == true || otherCoin.isMerging == true)
        {
            return;
        }

        // 同じ種類なら合成する
        if (coinType == otherCoin.coinType)
        {
            // 金コインなら合成しない
            if (coinType == 2)
            {
                return;
            }

            // 合成する
            Merge(otherCoin);
        }
    }


    // 合成処理
    private void Merge(Coin otherCoin)
    {
        // 合成中にする
        isMerging = true;
        otherCoin.isMerging = true;

        // 2つのコインの真ん中を計算
        Vector3 mergePosition =
            (transform.position + otherCoin.transform.position) / 2;

        // 次のコインを作る
        Instantiate(
            nextCoinPrefab,
            mergePosition,
            Quaternion.identity
        );

        // 元のコインを消す
        Destroy(gameObject);
        Destroy(otherCoin.gameObject);
    }
}