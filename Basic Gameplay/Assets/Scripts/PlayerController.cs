using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float horizontalInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("horizontal");
    }
}
