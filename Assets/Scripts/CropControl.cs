using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CropControl : MonoBehaviour
{

    public Transform carrotObj;
    public Transform tomatoObj;
    public Transform lettuceObj;
    public Transform potatoObj;
    public Transform lobakObj;

    public gamePlay gamePlay;

    void OnMouseDown()
    {
            if (gameObject.name == "Carrot")
            {
                if (gamePlay.cuttingBoard == "empty")
                {
                    Transform newCarrot = Instantiate(carrotObj, new Vector2(-7.53f, 1.39f), carrotObj.rotation);
                    gamePlay.currentCrop = newCarrot.gameObject;
                    gamePlay.cuttingBoard = "full";  
                }
            }

            else if (gameObject.name == "Lettuce")
            {
                if (gamePlay.cuttingBoard == "empty")
                {
                    Transform newLettuce = Instantiate(lettuceObj, new Vector2(-7.498f, 1.41f), lettuceObj.rotation);
                    gamePlay.currentCrop = newLettuce.gameObject;
                    gamePlay.cuttingBoard = "full";  
                }
            }

            else if (gameObject.name == "Tomato")
            {
                if (gamePlay.cuttingBoard == "empty")
                {
                    Transform newTomato = Instantiate(tomatoObj, new Vector2(-7.53f, 1.421f), tomatoObj.rotation);
                    gamePlay.currentCrop = newTomato.gameObject;
                    gamePlay.cuttingBoard = "full";  
                }
            }

            else if (gameObject.name == "Potato")
            {
                if (gamePlay.cuttingBoard == "empty")
                {
                    Transform newPotato = Instantiate(potatoObj, new Vector2(-7.49f, 1.45f), potatoObj.rotation);
                    gamePlay.currentCrop = newPotato.gameObject;
                    gamePlay.cuttingBoard = "full";
                }
            }

            else if (gameObject.name == "Lobak")
            {
                if (gamePlay.cuttingBoard == "empty")
                {
                    Transform newLobak = Instantiate(lobakObj, new Vector2(-7.514f, 1.39f), lobakObj.rotation);
                    gamePlay.currentCrop = newLobak.gameObject;
                    gamePlay.cuttingBoard = "full";
                    
                }
            }

            
        }
}
