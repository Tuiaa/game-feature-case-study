using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FlowerHelperFunctions
{
    public static Vector3 GetSpawnPosition(Flower flower, List<GameObject> availableFields)
    {
        Vector3 flowerSpawnPosition = availableFields[flower.PositionInField-1].transform.position;
       
        return flowerSpawnPosition;
    }

    public static void SpawnFlowerAndRemoveSeed(Flower flowerToSpawn, Vector3 positionToSpawn, Transform flowerParent)
    {
        GameObject flower = GameObject.Instantiate(flowerToSpawn.FlowerPrefab);
        flower.transform.SetParent(flowerParent);
        flower.transform.position = positionToSpawn;
    }

    public static void SpawnSeed()
    {

    }
}
