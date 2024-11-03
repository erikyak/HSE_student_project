using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ResourceBank resourceBank;

    private void Awake()
    {
        resourceBank.ChangeResource(GameResource.Humans, 10);
        resourceBank.ChangeResource(GameResource.Food, 5);
        resourceBank.ChangeResource(GameResource.Wood, 5);
        resourceBank.ChangeResource(GameResource.Stone, 0);
        resourceBank.ChangeResource(GameResource.Gold, 0);
        resourceBank.ChangeResource(GameResource.HumansProdLvl, 0);
        resourceBank.ChangeResource(GameResource.FoodProdLvl, 0);
        resourceBank.ChangeResource(GameResource.WoodProdLvl, 0);
        resourceBank.ChangeResource(GameResource.StoneProdLvl, 0);
        resourceBank.ChangeResource(GameResource.GoldProdLvl, 0);
    }
}