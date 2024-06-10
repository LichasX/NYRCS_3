using UnityEngine;
using UnityEngine.EventSystems;

public class EnsureSingleEventSystem : MonoBehaviour
{
    void Awake()
    {
        // Find all EventSystems in the scene
        EventSystem[] eventSystems = FindObjectsOfType<EventSystem>();

        // If there are multiple EventSystems, destroy all but one
        if (eventSystems.Length > 1)
        {
            Debug.LogWarning("Multiple EventSystems found! Ensuring only one remains.");

            for (int i = 1; i < eventSystems.Length; i++)
            {
                Destroy(eventSystems[i].gameObject);
            }
        }
    }
}