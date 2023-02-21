using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public new GameObject light = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "train")
        {
            light.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "train")
        {
            light.SetActive(false);
        }
    }
}
