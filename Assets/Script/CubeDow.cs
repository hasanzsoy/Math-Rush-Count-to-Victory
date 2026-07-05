using UnityEngine;
using DG.Tweening;
public class CubeDow : MonoBehaviour
{
    //DOTWEEN KÜTÜPHANESİ İÇİN KOD ÖRNEKLERİ

    //oncomplete içinde fonksiyon çağırmayı araştır

    
    private void Start()
    {
        //transform.DOMove(new Vector3(3, 2, 0), 1f);
        //transform.DOMoveX(2, 1f);
        //transform.DOMoveZ(4, 2f);
        //transform.DORotate(new Vector3(0, 180, 0), 2f);
        //transform.DOScale(2f,2f);
        //transform.DOMoveY(3f, 1).SetLoops(-1, LoopType.Yoyo);
        //transform.DOMoveY(3f, 1).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutBack);
        //transform.DORotate(new Vector3(0, 360, 0), 2f,RotateMode.FastBeyond360).SetLoops(-1);
        //transform.DORotate(new Vector3(0, 360, 0), 2f,RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);



        //transform.DOMoveZ(5, 1.5f).OnComplete(() =>
        //{
        //    transform.DOMoveY(3, 1).OnComplete(() =>
        //    {
        //        transform.DOScale(3, 1).OnComplete(() =>
        //        {
        //            transform.DOMoveZ(1, 1f).OnComplete(() =>
        //            {
        //                transform.DOScale(1, 4f).OnComplete(() =>
        //                {
        //                    GetComponent<Renderer>().material.color = Color.blue;
        //                });
        //            });
        //        });
        //    });
        //});



        //GetComponent<Renderer>().material.DOFade(0, 2f);

        //transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.5f, 2, 1);

        
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveX(5, 1));
        sequence.Append(transform.DOScale(5, 1));
        sequence.Append(transform.DORotate(new Vector3(0, 180, 0), 1));//append sırayla yapıyor

        //APPEND İLE BİR ÖDEV YAP TRAFİK IŞIKLARI GİBİ YOLDAN SIRAYLA GEÇEN BİR SİSTEM KODLA

        sequence.Join(transform.DOMoveX(5, 1));
        sequence.Join(transform.DOScale(5, 1));//join aynı anda yapıyor


    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) 
        //{
        //    transform.DOMove(new Vector3(3, 2, 0), 1f);
        //}

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    transform.DOJump(new Vector3(0, 2, 2),1.5f,1,0.5f);
        //}
    }

}

