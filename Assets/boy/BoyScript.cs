using UnityEngine;

public class BoyScript : MonoBehaviour
{

   public Transform position;
   public float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
         Vector3 move = new Vector3(h, 0f, v);
         transform.Translate(move*speed*Time.deltaTime);
    }
}
