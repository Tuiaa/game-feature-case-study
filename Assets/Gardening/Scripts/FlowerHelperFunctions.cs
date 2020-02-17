using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FlowerHelperFunctions
{
    public static Vector3 GetSpawnPosition(Flower flower, List<GardeningManager.FlowerFieldPosition> spawnPositions)
    {
        Vector3 flowerSpawnPosition = spawnPositions[flower.PositionInField].spawnTransform.position;
        return flowerSpawnPosition;
    }

    public static void SpawnFlower(Flower flowerToSpawn, Vector3 positionToSpawn, Transform flowerParent)
    {
        GameObject flower = GameObject.Instantiate(flowerToSpawn.FlowerPrefab);
        flower.transform.SetParent(flowerParent);
        flower.transform.position = positionToSpawn;
    }
}
