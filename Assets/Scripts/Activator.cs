using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField]
    GameObject GO;
    [SerializeField]
    bool isActive;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GO.SetActive(isActive);
            gameObject.SetActive(false);
        }
    }
}
