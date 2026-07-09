using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Jobs;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float MoveSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        //‚P•bŠÔ‚É‰E‘¤‚É1f“®‚©‚µ‚½‚¢i‰E•ûŒü -> x‚Ì’l‚É+‚Ì’l‚ð‰ÁŽZj
        //‘ã“üæ(Vector3:(xx,y,z)
        this.transform.position = this.transform.position + new Vector3(MoveSpeed, 0, 0) * Time.deltaTime;
        if (this.transform.position.x > 5)
        {
            MoveSpeed = -1 * MoveSpeed;
        }
        if(this.transform.position.x < -5)
        {
            MoveSpeed = -1 * MoveSpeed;
        }
            }

}