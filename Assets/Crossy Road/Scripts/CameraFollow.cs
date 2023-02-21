using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speed = 0.25f;
    public bool autoMove = true;
    public GameObject player = null;
    public Vector3 offset = new Vector3(3, 6, -3);

    Vector3 depth = Vector3.zero;
    Vector3 pos = Vector3.zero;

    private void Update()
    {
        if (!Manager.instance.CanPlay()) { return; }

        if (autoMove)
        {
            depth = gameObject.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            pos = Vector3.Lerp(gameObject.transform.position, player.transform.position + offset, Time.deltaTime);
            gameObject.transform.position = new Vector3(pos.x, offset.y, depth.z);
        }
        else
        {
            pos = Vector3.Lerp(gameObject.transform.position, player.transform.position + offset, Time.deltaTime);
            gameObject.transform.position = new Vector3(pos.x, offset.y, pos.z);
        }
    }
}
