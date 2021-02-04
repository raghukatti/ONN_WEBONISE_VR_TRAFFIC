using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_CharacterMove : MonoBehaviour
{
    public float speed;// = 0.05f;
    float speedz = 0.08f;
    float gravity = 10f;
    public Camera MainCam;
    CharacterController charac;
   // Vector3 eulerAngles = transform.rotation.eulerAngles;
    bool WalkReady;
    // Start is called before the first frame update
    //public GameObject Horse;
    Vector3 forward;
    public GameObject AManager;
    AudioManager audiomanager;
    bool collided;
    void Start()
    {
        WalkReady = false;
        charac = GetComponent<CharacterController>();
        audiomanager = AManager.GetComponent<AudioManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        CheckWalkDirection();
    }
    void Movement()
    {
     
       

        if (WalkReady)
        {
           forward =  MainCam.transform.TransformDirection(Vector3.forward);
            charac.Move(forward * speed);
           // Debug.Log(forward.z);
          //  Horse.transform.position = new Vector3(Horse.transform.position.x, Horse.transform.position.y, Horse.transform.position.z+speedz);
        }
        if (MainCam.transform.rotation.eulerAngles.x >= 3f && MainCam.transform.rotation.eulerAngles.x<=20f)
        {
            WalkReady = true;
        }
        else
        {
            WalkReady = false;
        }
              
    }
  void CheckWalkDirection()
    {
       
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (WalkReady && forward.z < 0f && other.tag=="fColliderR")
        {

            audiomanager.PlayAudio(0, 1f, 1f);
            
        }
        if (WalkReady && forward.z > 0f && other.tag == "fColliderL")
        {

            audiomanager.PlayAudio(0, 1f, 1f);

        }
        if (WalkReady && other.tag == "rCollider")
        {

            audiomanager.PlayAudio(1, 1f, 1f);

        }
        if (other.tag == "1_Badge")
        {
           // other.GetComponent<Animator>().Play();
        }
    }
}
