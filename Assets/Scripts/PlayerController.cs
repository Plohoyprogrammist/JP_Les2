using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horInput;
    public float speed = 10.0f;
    public float xRange = 10f;

    private void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
    }
}