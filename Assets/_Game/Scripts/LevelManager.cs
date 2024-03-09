using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private LevelData levelData;
    [SerializeField] private LevelButton levelPrefab;
    [SerializeField] private Transform levelItemParent;

    public static LevelManager Instance;

    private void Awake()
    {
        Instance= this;
    }

    private void Start()
    {
        SpawnLevelItem();
    }

    private void SpawnLevelItem()
    {
        for (int i = 0; i < levelData.itemsLevels.Count; i++)
        {
            LevelButton levelButton = Instantiate(levelPrefab, levelItemParent);
            levelButton.SetData(levelData.itemsLevels[i].id);
        }
    }

    public void DestroyLevelManager()
    {
        Destroy(gameObject);
    }
}
