using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public static int eggs;
    public static bool flg = true;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
               // Destroy(hit.transform.gameObject);
               if (hit.collider.tag == "eggs")
                {
                    hit.collider.gameObject.SetActive(false);
                    eggs++;
                    flg = true;
                }
            }
        }

    }

}
