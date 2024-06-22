using UnityEngine;

public class PutPan : MonoBehaviour
{
    public float cookingTime = 0f;
    private bool isCooking = false;

    public Transform carrot;
    public Transform potato;
    public Transform lobak;
    public Transform fire;

    public Transform carrotCooked;
    public Transform potatoCooked;
    public Transform lobakCooked;

    private gamePlay gamePlay;    // Start is called before the first frame update
    
    public static GameObject cookedCrop;
    public GameObject currentFire;
    void Start()
    {
        gamePlay = FindObjectOfType<gamePlay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            PanInstantiate();
        }

        if (Input.GetMouseButton(1))
        {
            PanciInstantiate();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            TransferToPlate();
        }

        if (isCooking)
        {
            cookingTime += Time.deltaTime;
            if (cookingTime > 3f && cookingTime <=5f)
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
            }
            if (cookingTime > 5f)
            {
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                isCooking = false;
            }
        }
       
    }
    void PanInstantiate()
    {
        if(currentFire == null)
        {
            currentFire = Instantiate(fire, new Vector2(-1.981f, 1.172f), fire.rotation).gameObject;
        }

        if (gamePlay.currentCrop != null)
        {
            string cropName = gamePlay.currentCrop.name;
            Destroy(gamePlay.currentCrop);
            gamePlay.currentCrop = null;
            gamePlay.cuttingBoard = "empty";

            if (cropName.Contains("carrot_cut"))
            {
                Transform newCarrotCook = Instantiate(carrot, new Vector2(-1.91f, 1.69f), carrot.rotation);
                Debug.Log("Carrot instantiated on pan");
                cookedCrop = newCarrotCook.gameObject;
                gamePlay.pan = "full";
            }
            else if (cropName.Contains("potato_cut"))
            {
                Transform newPotatoCook = Instantiate(potato, new Vector2(-1.953f, 1.65f), potato.rotation);
                Debug.Log("Potato instantiated on pan");
                cookedCrop = newPotatoCook.gameObject;
                gamePlay.pan = "full";
            }
            else if (cropName.Contains("lobak_cut"))
            {
                Transform newLobakCook  = Instantiate(lobak, new Vector2(-1.94f, 1.667f), lobak.rotation);
                Debug.Log("Lobak instantiated on pan");
                cookedCrop= newLobakCook.gameObject;
                gamePlay.pan = "full";  
            }

            cookingTime = 0f;
            isCooking = true;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);

        }

    }

    public void TransferToPlate()
    {
        if(cookedCrop != null)
        {
            string cropName = cookedCrop.name;
            Destroy(cookedCrop);
            cookedCrop = null;
            gamePlay.pan = "empty";

            if (currentFire != null)
            {
                Destroy(currentFire);
                currentFire = null;
            }

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

    void PanciInstantiate()
    {

    }
}
