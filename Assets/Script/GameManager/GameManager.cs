using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject SupCharacter;
    public GameObject Destination;
    public GameObject PointOfOrigin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Instantiate(SupCharacter, PointOfOrigin.transform.position, Quaternion.identity);
        }

    }
}
