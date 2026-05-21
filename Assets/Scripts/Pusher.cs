using UnityEngine;

public class Pusher : MonoBehaviour
{
    public float spead = 1f;
    public float movePower = 5f;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.position;
        Debug.Log("ゲームが開始したよ");
    }

    // Update is called once per frame
    public Rigidbody rb;
    void Update()
    {
        //z軸の往復移動を行う
        float z = Mathf.Sin(Time.time * spead) * movePower;

        //自身のローカル座標の位置情報に z(sin波の変動値)を加算して返す
        rb.linearVelocity = new Vector3(0, 0, z);
    }
}
