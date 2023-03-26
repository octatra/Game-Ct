using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float cameraSpeed;
    [SerializeField] private float distanceAhead;
    private float lookAhead;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Player.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.position.x + lookAhead, transform.position.y, transform.position.z);

        lookAhead = Mathf.Lerp(lookAhead, (distanceAhead * Player.position.x), Time.deltaTime * cameraSpeed);
    }
}
