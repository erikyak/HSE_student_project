using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class ResourceVisual : MonoBehaviour
{
    public GameResource gameResource;
    public TextMeshProUGUI resourceText;
    [SerializeField] private ResourceBank resourceBank;

    private void Start()
    {
        ObservableInt resource = resourceBank.GetResource(gameResource);
        resource.OnValueChanged += UpdateText;
        UpdateText(resource.Value);
    }

    private void UpdateText(int value)
    {
        resourceText.text = value.ToString();
    }
}
