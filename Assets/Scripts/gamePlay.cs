using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePlay : MonoBehaviour
{

    public static string table = "empty";
    public static string cuttingBoard = "empty";
    public static string pan = "empty";

    public static int coin = 0;

    public static string isTrashCicked = "n";

    public GameObject currentCrop;

    public Transform carrot_cutObj;
    public Transform tomato_cutObj;
    public Transform lettuce_cutObj;
    public Transform potato_cutObj;
    public Transform lobak_cutObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate();
        }

    }

    void Instantiate()
    {
        if (currentCrop != null)
        {
            Vector2 position = currentCrop.transform.position;
            Quaternion rotation = currentCrop.transform.rotation;
            string cropName = currentCrop.name;

            Destroy(currentCrop);
            cuttingBoard = "full";
            currentCrop = null;

            if (cropName.Contains("carrot_move"))
            {
                Transform newCarrotCut = Instantiate(carrot_cutObj, position, rotation);
                Debug.Log("Carrot cut object instantiated");
                currentCrop = newCarrotCut.gameObject;
            }
            else if (cropName.Contains("lettuce_move"))
            {
                Transform newLettuceCut = Instantiate(lettuce_cutObj, position, rotation);
                Debug.Log("Lettuce cut object instantiated");
                currentCrop = newLettuceCut.gameObject;
            }
            else if (cropName.Contains("tomato_move"))
            {
                Transform newTomatoCut = Instantiate(tomato_cutObj, position, rotation);
                Debug.Log("Tomato cut object instantiated");
                currentCrop = newTomatoCut.gameObject;
            }
            else if (cropName.Contains("potato_move"))
            {
                Transform newPotatoCut = Instantiate(potato_cutObj, position, rotation);
                Debug.Log("Potato cut object instantiated");
                currentCrop = newPotatoCut.gameObject;
            }
            else if (cropName.Contains("lobak_move"))
            {
                Transform newLobakCut = Instantiate(lobak_cutObj, position, rotation);
                Debug.Log("Lobak cut object instantiated");
                currentCrop = newLobakCut.gameObject;
            }
        }

    }

}
