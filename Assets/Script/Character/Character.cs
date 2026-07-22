using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       transform.Translate(Vector3.forward * Time.deltaTime * 5f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if(Input.GetAxis("Mouse X") < 0) 
            {
                transform.position=Vector3.Lerp(transform.position, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), .25f);
            }
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position=Vector3.Lerp(transform.position, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), .25f);
            }
        }
    }
}
