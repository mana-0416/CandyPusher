using UnityEngine;

public class Coin : MonoBehaviour
{
    public enum CoinType
    {
        Normal,     // 通常コイン
        Silver,     // 銀コイン
        Gold,       // 金コイン
        Danger,     // 危険コイン
        Recovery    // 回復コイン
    }

    [Header("コイン設定")]
    [SerializeField] private CoinType coinType;

    [SerializeField] private int score = 1;

    [Header("特殊効果")]
    [SerializeField] private int dangerValue = 0;

    public CoinType Type => coinType;
    public int Score => score;
    public int DangerValue => dangerValue;

    // 合成可能か
    public bool CanMerge()
    {
        return coinType == CoinType.Normal ||
               coinType == CoinType.Silver ||
               coinType == CoinType.Gold;
    }

    // 次のコインの種類を取得
    public CoinType GetNextCoinType()
    {
        switch (coinType)
        {
            case CoinType.Normal:
                return CoinType.Silver;

            case CoinType.Silver:
                return CoinType.Gold;

            default:
                return coinType;
        }
    }
}