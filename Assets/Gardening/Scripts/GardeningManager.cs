using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardeningManager : MonoBehaviour
{
    //[SerializeField] private List<GameObject> _flowerGameObjects;
    [SerializeField] private GameObject _redFlower;
    [SerializeField] private GameObject _orangeFlower;
    [SerializeField] private GameObject _redOrangeFlower;
    private List<Flower> _flowers = new List<Flower>();

    [SerializeField] List<FlowerFieldPosition> _flowerFieldPositions;

    void Start()
    {
        Flower flower = new Flower(FlowerType.RED, 5, 2, true, _redFlower, 1);
        Flower flower2 = new Flower(FlowerType.ORANGE, 5, 2, true, _orangeFlower, 2);
        Flower flower3 = new Flower(FlowerType.REDORANGE, 5, 2, false, _redOrangeFlower, 6);
        _flowers.Add(flower);
        _flowers.Add(flower2);
        _flowers.Add(flower3);

        foreach(Flower flowerInList in _flowers)
        {
            Vector3 flowerSpawnPosition = FlowerHelperFunctions.GetSpawnPosition(flowerInList, _flowerFieldPositions);
            FlowerHelperFunctions.SpawnFlower(flowerInList, flowerSpawnPosition, gameObject.transform);
        }
    }


    void Update()
    {
        
    }

    [System.Serializable]
    public struct FlowerFieldPosition
    {
        public int id;
        public Transform spawnTransform;
    }
}
