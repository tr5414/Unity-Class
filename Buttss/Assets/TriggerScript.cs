using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    //This is Main Camera in the Scene
    Camera m_MainCamera;
    //This is the second Camera and is assigned in inspector
    //public Camera m_CameraTwo;
    public Camera  m_R1Cam;
    //public Camera m_CameraThree;
    public Camera  m_R2Cam;


    void Start()
    {
        //This gets the Main Camera from the Scene
        m_MainCamera = Camera.main;
        //This enables Main Camera
        m_MainCamera.enabled = true;
        //Use this to disable secondary Camera
        m_R1Cam.enabled = false;
        //Use this to disable third camera 
        m_R2Cam.enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
        //Press the L Button to switch cameras
        if (other.tag == "Player")
        {
            m_R1Cam.enabled = false;

            m_MainCamera.enabled = false;

            m_R2Cam.enabled = true;
        }
    }
        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                m_R1Cam.enabled = false;

                m_MainCamera.enabled = true;

                m_R2Cam.enabled = false;
            }
        }
        //Check that the Main Camera is enabled in the Scene, then switch to the other Camera on a key press
        /* if (m_MainCamera.enabled && !m_R2Cam.enabled)
         {
             //Enable the second Camera
             m_R1Cam.enabled = true;

             //The Main first Camera is disabled
             m_MainCamera.enabled = false;

             m_R2Cam.enabled = false;

         }
         else if (m_CameraTwo.enabled && !m_MainCamera.enabled)
         {
             m_R1Cam.enabled = false;

             m_MainCamera.enabled = false;

             m_R2Cam.enabled = true;
         }
         //Otherwise, if the Main Camera is not enabled, switch back to the Main Camera on a key press
         else if (m_CameraThree.enabled && !m_R1Cam.enabled)
         {
             //Disable the second camera
             m_R1Cam.enabled = false;

             m_R2Cam.enabled = false;

             //Enable the Main Camera
             m_MainCamera.enabled = true;
         }
     }
 */

    
}