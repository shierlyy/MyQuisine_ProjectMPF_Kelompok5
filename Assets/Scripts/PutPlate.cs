using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutPlate : MonoBehaviour
{
    public Transform carrot;
    public Transform tomato;
    public Transform lettuce;
    public Transform potato;
    public Transform lobak;

    public Transform fire;

    public Transform carrotCooked;
    public Transform potatoCooked;
    public Transform lobakCooked;

    private gamePlay gamePlay;
    private PutPan PutPan;

    // Start is called before the first frame update
    void Start()
    {
        gamePlay = FindObjectOfType<gamePlay>();
        PutPan = gamePlay.GetComponent<PutPan>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            InstantiatePanToPlate();
        }
    }

    void Instantiate()
    {
        if (gamePlay.currentCrop != null)
        {
            string cropName = gamePlay.currentCrop.name;
            Destroy(gamePlay.currentCrop);
            gamePlay.currentCrop = null;
            gamePlay.cuttingBoard = "empty";

            if (cropName.Contains("carrot_cut")){
                Instantiate(carrot, new Vector2(5.44f, -1.856f), carrot.rotation);
                Debug.Log("Carrot instantiated on plate");
            }
            else if (cropName.Contains("lettuce_cut"))
            {
                Instantiate(lettuce, new Vector2(5.24f, -2.42f), lettuce.rotation);
                Debug.Log("Lettuce instantiated on plate");
            }
            else if (cropName.Contains("tomato_cut"))
            {
                Instantiate(tomato, new Vector2(5.82f, -2.67f), tomato.rotation);
                Debug.Log("Tomato instantiated on plate");
            }
            else if (cropName.Contains("potato_cut"))
            {
                Instantiate(potato, new Vector2(5.46f, -2.12f), potato.rotation);
                Debug.Log("Potato instantiated on plate");
            }
            else if (cropName.Contains("lobak_cut"))
            {
                Instantiate(lobak, new Vector2(5.56f, -2.05f), lobak.rotation);
                Debug.Log("Lobak instantiated on plate");
            }
        }
    }

    void InstantiatePanToPlate()
    {
        if (PutPan.cookedCrop != null)
        {
            string cropName = PutPan.cookedCrop.name;
            Destroy(PutPan.cookedCrop);
            PutPan.cookedCrop = null;
            gamePlay.pan = "empty";

            if (cropName.Contains("carrot_cooked"))
            {
                Instantiate(carrotCooked, new Vector2(5.44f, -1.856f), carrotCooked.rotation);
            }
            else if (cropName.Contains("potato_cook"))
            {
                Instantiate(potatoCooked, new Vector2(5.46f, -2.12f), potatoCooked.rotation);
            }
            else if (cropName.Contains("lobak_cook"))
            {
                Instantiate(lobakCooked, new Vector2(5.56f, -2.05f), lobakCooked.rotation);
            }
        }
    }
}
