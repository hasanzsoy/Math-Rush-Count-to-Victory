using DG.Tweening;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    //private void OnMouseEnter()
    //{
    //    GetComponent<MeshRenderer>().material.color = Color.red;
    //}
    //private void OnMouseExit()
    //{
    //    GetComponent<MeshRenderer>().material.color = Color.white;
    //}
   // private void OnMouseDown()
    //{
        //transform.DOScale(Vector3.one * 2, 0.5f).SetEase(Ease.OutBounce).OnComplete(() => 
        //{
        //    transform.DOScale(new Vector3(5, 1, 5), 0.5f).SetEase(Ease.OutBounce);
        //});

        //bunu incele
    //}

   //private void OnMouseDrag()
   //{
   //    Debug.Log("OnMouseDrag--mouse süreklerken");
   //}
   //
   //private void OnMouseUp()
   //{
   //    Debug.Log("OnMouseUp--mouse obje üzerinden kaldırıldı");
   //}
   //
   //private void OnMouseOver()
   //{
   //    Debug.Log("OnMouseOver--MOUSE ÜZERİNDE");
   //}
   //
    //objeyi hareket ettirmek için

    private Vector3 mouseOffset;
    private Vector3 objectZDepth;

    private void OnMouseDown()
    {
        objectZDepth = Camera.main.WorldToScreenPoint(transform.position);
        mouseOffset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectZDepth.z));

        GetComponent<Renderer>().material.DOColor(Color.red, 0.5f);
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectZDepth.z);
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition) + mouseOffset;
        transform.position = worldMousePosition;
    }

    private void OnMouseUp()
    {
        GetComponent<Renderer>().material.DOColor(Color.white, 0.5f);

    }




}
