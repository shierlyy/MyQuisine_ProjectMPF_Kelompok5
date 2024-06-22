using UnityEngine;

public class CropManager : MonoBehaviour
{
    public GameObject carrotPrefab;
    public Transform cropParent;

    void Start()
    {
        // Example of instantiating a carrot at a specific position
        InstantiateCrop(carrotPrefab, new Vector3(0, 0, 0));
    }

    public void InstantiateCrop(GameObject cropPrefab, Vector3 position)
    {
        GameObject crop = Instantiate(cropPrefab, position, Quaternion.identity, cropParent);
        crop.SetActive(true); // Ensure the crop is active
    }
}
