using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProductionBuilding : MonoBehaviour
{
    public GameResource producedResource;
    public GameResource productionLevel;
    public float baseProductionTime = 5f;
    public Slider productionSlider;
    [SerializeField] private ResourceBank resourceBank;
    [SerializeField] private int amountToUpgrade = 0;
    private bool isProducing;

    private void Start()
    {
        productionSlider.value = 0;
    }

    public void StartProduction()
    {
        if (!isProducing && resourceBank.GetResource(productionLevel).Value >= amountToUpgrade)
        {
            productionSlider.maxValue = CalculateProductionTime();
            resourceBank.ChangeResource(productionLevel, -amountToUpgrade);
            StartCoroutine(ProduceResource());
        }
    }
    private float CalculateProductionTime()
    {
        int level = resourceBank.GetResource(productionLevel).Value;
        return baseProductionTime * (1 - level / 100f);
    }
    private IEnumerator ProduceResource()
    {
        isProducing = true;
        productionSlider.gameObject.SetActive(true);
        
        float productionTime = CalculateProductionTime();
        float timePassed = 0;
        while (timePassed < productionTime)
        {
            timePassed += Time.deltaTime;
            productionSlider.value = timePassed ;
            yield return null;
        }

        resourceBank.ChangeResource(producedResource, 1);
        isProducing = false;
        productionSlider.gameObject.SetActive(false);
    }
}