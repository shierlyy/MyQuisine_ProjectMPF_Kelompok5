using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class chopping : MonoBehaviour
{
    public Transform carrot_cutObj;
    public Transform tomato_cutObj;
    public Transform lettuce_cutObj;
    public Transform potato_cutObj;
    public Transform lobak_cutObj;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate();
        }
    }

    void Instantiate()
    {
        if(gameObject.name == "carrot_move")
        {
            Instantiate(carrot_cutObj, new Vector2(-7.53f, 1.39f), carrot_cutObj.rotation);
            Destroy(this.gameObject);
        }
       

    }
}
