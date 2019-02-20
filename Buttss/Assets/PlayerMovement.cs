using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{


    // public GameObject effect;
    public float speed = 5f;
    private Rigidbody rb;
    public int count = 0;
    public DoorScript door;
    //public Text countText;
    void Start()
    {
        //   rb = GetComponent<Rigidbody>();
        // countText.text = "Count: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float turning = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        turning *= Time.deltaTime;

        //transform.Translate(turning, 0, translation);

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, (speed * Input.GetAxis("Vertical") * Time.deltaTime));
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            //other.gameObject.SetActive(false);
            count = count + 1;
           // door.counter();
          if (count == 2)
            {
               SceneManager.LoadScene("Menu");

            }
            //    if (counter >= 1)
            // {
            //    other.GetComponent<Animation>().Play("OpenDoor");
            //Instantiate(effect, transform.position, transform.rotation);
            // countText.text = "Count: " + count.ToString();
            //}
        }
    }
}
/*   if (Input.GetKey(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(Vector3.up * 20);
           if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(Vector3.forward * speed); // * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow))
                   transform.Translate(-Vector3.forward * speed); // * Time.deltaTime);

         if (Input.GetKey(KeyCode.LeftArrow))
         transform.Rotate(Vector3.up, -speed * speed); //* Time.deltaTime);

          if (Input.GetKey(KeyCode.RightArrow))
         transform.Rotate(Vector3.up, speed * speed);  //* Time.deltaTime);
          
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
*/
    
