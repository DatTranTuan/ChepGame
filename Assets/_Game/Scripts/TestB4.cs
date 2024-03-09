using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestB4 : MonoBehaviour
{
    //[SerializeField] private GameObject b4Prefab;

    //public void Invoke()
    //{
    //    StopAllCoroutines();
    //}

    //public void Shoot()
    //{
    //    GameObject myGo = Instantiate(b4Prefab);
    //    myGo.transform.position = new Vector3(-5, -10);
    //}

    [SerializeField] private Transform startPoint, endPoint;
    [SerializeField] private float speed;

    Vector3 pawn;

    private void Start()
    {
        transform.position = startPoint.position;
        pawn = endPoint.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pawn, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, startPoint.position) < 0.1f)
        {
            pawn = endPoint.position;
        }else if (Vector2.Distance(transform.position, endPoint.position) < 0.1f)
        {
            pawn = startPoint.position;
        }
    }
}
