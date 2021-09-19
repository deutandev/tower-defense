using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Transform _towerUIParent;
    [SerializeField] private GameObject _towerUIPrefab;
    [SerializeField] private Tower[] _towerPrefabs;

    // Added in "drag n Drop"
    private List<Tower> _spawnedTowers = new List<Tower> ();

    // Singleton function
    private static LevelManager _instance = null;
    public static LevelManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<LevelManager> ();
            }

            return _instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InstantiateAllTowerUI ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Show all available Tower in Tower Selection UI
    private void InstantiateAllTowerUI ()
    {
        foreach (Tower tower in _towerPrefabs)
        {
            GameObject newTowerUIObj = Instantiate (_towerUIPrefab.gameObject, _towerUIParent);
            TowerUI newTowerUI = newTowerUIObj.GetComponent<TowerUI> ();

            newTowerUI.SetTowerPrefab (tower);
            newTowerUI.transform.name = tower.name;
        }
    }

    // Registering spawned Tower to be controlled by LevelManager
    public void RegisterSpawnedTower (Tower tower)

    {
        _spawnedTowers.Add (tower);
    }
}
