using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 prevPlayerPos;
    private Vector3 posVector;
    public float scale = 3.0f;
    public float cameraSpeed = 1.0f;

    void Start()
    {

        prevPlayerPos = new Vector3(0, 0, -1);
    }

    void Update()
    {
        Vector3 currentPlayerPos = player.transform.position;
        Vector3 backVector = (prevPlayerPos - currentPlayerPos).normalized;
        posVector = (backVector == Vector3.zero) ? posVector : backVector;
        Vector3 targetPos = currentPlayerPos + scale * posVector;
        targetPos.y = targetPos.y + 0.5f;
        this.transform.position = Vector3.Lerp(
            this.transform.position,
            targetPos,
            cameraSpeed * Time.deltaTime
        );
        this.transform.LookAt(player.transform.position);
        prevPlayerPos = player.transform.position;
    }
}