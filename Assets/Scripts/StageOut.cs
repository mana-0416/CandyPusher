using UnityEngine;

public class StageOut : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name}‚ª‚·‚è”²‚¯‚Ü‚µ‚½");
        Destroy(other.gameObject);
    }

}
