using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


    //List<int> myList = new List<int> { 1, 2, 3, 4, -1, 6, 7, 8, 9, 10 };

    //private void Start()
    //{

    //    for (int i = 0; i < myList.Count; i++)
    //    {
    //        Debug.Log(myList[i]);
    //        if (myList[i] == -1)
    //        {
    //            myList.RemoveAt(i);
    //            i--;
    //        }
    //    }
    // Cách 2 Hữu dụng
    //List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //for (int i = myList.Count - 1; i >= 0; i--)
    //{
    //    if (myList[i] == -1)
    //    {
    //        myList.RemoveAt(i);
    //    }
    //}
    //}

    [SerializeField] Text coinText;

    public static UIManager instance;

    //public static UIManager Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = FindObjectOfType<UIManager>();
    //        }

    //        return instance;
    //    }
    //}

    private void Awake()
    {
        instance = this;
    }


    public void SetCoin(int coin)
    {
        coinText.text = coin.ToString();
    }
}
