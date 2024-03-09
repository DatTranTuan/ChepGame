using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] public Button levelButton;
    [SerializeField] public Text textLevelButton;
    // Start is called before the first frame update

    public void SetData(int id)
    {
        textLevelButton.text = $"Level {id}";
        levelButton.onClick.AddListener(() =>
        {
           LoadResourceLevel(id);
            //if (isLoadSuccess)
            //{
            //    LevelManager.Instance.DestroyLevelManager();
            //    GameObject player = GameObject.Find("Player");
            //    if (player != null && spawnPosition != null)
            //    {
            //        player.transform.position = spawnPosition.position;
            //    }
            //}
        });
    }
    private void LoadResourceLevel(int levelId)
    {
        GameObject levelPrefab = Resources.Load<GameObject>($"Level{levelId}");
        if (levelPrefab != null)
        {
           Instantiate(levelPrefab);
        }

    }
}
