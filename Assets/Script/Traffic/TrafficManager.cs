using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class TrafficManager : MonoBehaviour
{
    public TrafficLight trafficLight;

    [Header("Acil Durum Araçları")]
    public Transform ambulance;
    public Transform fireTruck;
    public Transform police;
    public Transform gendermerie;

    [Header("Sivil Araçlar")]
    public Transform civilCar1;
    public Transform civilCar2;
    public Transform civilCar3;

    private void Start()
    {
        DG.Tweening.Sequence sequence = DOTween.Sequence();

        sequence.Append(ambulance.DOMoveX(27f, 5f).SetEase(Ease.Linear));
       

        sequence.Append(fireTruck.DOMoveX(27f, 5f).SetEase(Ease.Linear));
        

        sequence.Append(police.DOMoveX(27f,5f).SetEase(Ease.Linear));
        

        sequence.Append(gendermerie.DOMoveX(27f, 5f).SetEase(Ease.Linear));

        sequence.AppendCallback(StartCivilCars);

        sequence.AppendInterval(5);

        sequence.AppendCallback(() =>
        {
            Debug.Log("Trafik Tamamlandı");
        });
    }

    void StartCivilCars()
    {
        DG.Tweening.Sequence civilSequence = DOTween.Sequence();

        civilSequence.Join(civilCar1.DOMoveZ(38f, 3f));
        civilSequence.Join(civilCar2.DOMoveZ(38f, 4f));
        civilSequence.Join(civilCar3.DOMoveZ(38f, 5f));
    }
}
