using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    public Dictionary<GameResource, ObservableInt> resources = new Dictionary<GameResource, ObservableInt>();
    
    public void ChangeResource(GameResource resource, int value)
    {
        if (resources.TryGetValue(resource, out var resource1))
        {
            resource1.Value += value;
        }
        else
        {
            resources[resource] = new ObservableInt(value);
        }
    }

    public ObservableInt GetResource(GameResource resource)
    {
        return resources.ContainsKey(resource) ? resources[resource] : new ObservableInt();
    }

}
