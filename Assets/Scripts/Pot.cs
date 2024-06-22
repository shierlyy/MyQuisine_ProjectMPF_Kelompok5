using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    private List<GameObject> ingredients = new List<GameObject>();

    public void AddIngredient(GameObject ingredient)
    {
        // Add ingredient to the pot
        ingredients.Add(ingredient);
        // Optionally, you can destroy the ingredient or change its state
        Destroy(ingredient);
    }
}
