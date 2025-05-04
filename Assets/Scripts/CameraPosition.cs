using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    private bool FirstPerson = false;
    public GameObject player;
    private Vector3 offset = new Vector3 (0.11f, 4.26f, -5.76f);
    private Vector3 fps = new Vector3 (0f, 2.71f, 0.95f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
         if (Input.GetKeyDown(KeyCode.V)){
            FirstPerson = !FirstPerson;
        }

        if(FirstPerson){
        
        transform.position=player.transform.position + fps;
        }
        else{

        transform.position=player.transform.position + offset;
        
    }
}
}