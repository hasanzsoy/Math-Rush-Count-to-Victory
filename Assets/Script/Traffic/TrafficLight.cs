using Unity.VisualScripting;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Renderer redLight;
    public Renderer yellowLight;
    public Renderer greenLight;


    private void Start()
    {
        Red();
        Yellow();
        Green();

    }
    public void Red()
    {
        redLight.material.color = Color.red;
        yellowLight.material.color = Color.black;
        greenLight.material.color = Color.black;
    }
    public void Yellow()
    {
        redLight.material.color = Color.black;
        yellowLight.material.color = Color.yellow;
        greenLight.material.color = Color.black;
    }
    public void Green()
    {
        redLight.material.color = Color.black;
        yellowLight.material.color = Color.black;
        greenLight.material.color = Color.green;
    }


}