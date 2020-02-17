using UnityEngine;

/*
 *      FLOWER
 *      - Class for creating flowers
 */
public enum FlowerType { RED, ORANGE, REDORANGE}

public class Flower
{
    private FlowerType _flowerType;
    private int _timeToGrowInMinutes = 5;

    private bool _isWatered = false;
    private int _timeFlowerIsWateredInMinutes = 2;

    private bool _canBeGrossPollunated = false;

    private GameObject _flowerPrefab;
    private readonly int _positionInField;

    public Flower(FlowerType flowerType, int timeToGrowInMinutes, int timeFlowerIsWateredInMinutes, 
        bool canBeGrossPollunated, GameObject flowerPrefab, int positionInField)
    {
        _flowerType = flowerType;
        _timeToGrowInMinutes = timeToGrowInMinutes;
        _timeFlowerIsWateredInMinutes = timeFlowerIsWateredInMinutes;
        _canBeGrossPollunated = canBeGrossPollunated;
        FlowerPrefab = flowerPrefab;
        _positionInField = positionInField;
    }

    public bool IsWatered { get => _isWatered; set => _isWatered = value; }
    public GameObject FlowerPrefab { get => _flowerPrefab; set => _flowerPrefab = value; }
    public int PositionInField => _positionInField;
}
