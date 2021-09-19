using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Tower Component
    [SerializeField] private SpriteRenderer _towerPlace;
    [SerializeField] private SpriteRenderer _towerHead;

    // Tower Properties
    [SerializeField] private int _shootPower = 1;
    [SerializeField] private float _shootDistance = 1f;
    [SerializeField] private float _shootDelay = 5f;
    [SerializeField] private float _bulletSpeed = 1f;
    [SerializeField] private float _bulletSplashRadius = 0f;

    // save the position to be occupied while the tower is dragged
    public Vector2? PlacePosition { get; private set; }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlacePosition (Vector2? newPosition)
    {
        PlacePosition = newPosition;
    }

    // Added in "Drag n Drop"
    public void LockPlacement ()
    {
        transform.position = (Vector2) PlacePosition;
    }

    // change order in layer of on drag Tower
    public void ToggleOrderInLayer (bool toFront)
    {
        int orderInLayer = toFront ? 2 : 0;
        _towerPlace.sortingOrder = orderInLayer;
        _towerHead.sortingOrder = orderInLayer;
    }

    public Sprite GetTowerHeadIcon ()
    {
        return _towerHead.sprite;
    }
}
