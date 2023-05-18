using UnityEngine;

//movimentação obstaculo
public class Obstacle : MonoBehaviour
{
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }
//destruir objeto fora da camera
    private void Update()
    {
        transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
