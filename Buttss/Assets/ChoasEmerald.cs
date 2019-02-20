using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoasEmerald : MonoBehaviour
{
    public GameObject effect;

    void Update()
    {
        transform.Rotate(new Vector3(15, 15, 0) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(effect, transform.position, transform.rotation);


        }
    }
}