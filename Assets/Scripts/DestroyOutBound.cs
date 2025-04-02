using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    private float topBound = 30f;
    private float downBound = -10f;

    private void Update()
    {
        if (transform.position.z >  topBound || transform.position.z < downBound) 
        {
            Destroy(gameObject);
        }
    }
}
