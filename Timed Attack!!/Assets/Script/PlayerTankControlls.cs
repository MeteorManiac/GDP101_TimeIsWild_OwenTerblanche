using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankControlls : MonoBehaviour
{
  [SerializeField] float turnSpeed = 1f;
  [SerializeField] float moveSpeed = 0.01f;
  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
      if  (Input.GetAxis("Horizontal") != 0)
      {
          transform.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal")) * turnSpeed);
      }

      if (Input.GetAxis("Vertical") != 0)
      {
          transform.Translate(new Vector3(0, Input.GetAxis("Vertical"), 0) * moveSpeed);
      }
  }
}
