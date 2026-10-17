using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject view1;
    public GameObject view2;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = view2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            this.transform.position = Vector3.Lerp(this.transform.position, view1.transform.position, 0.05f);
        }
        else
        {
            this.transform.position = Vector3.Lerp(this.transform.position, view2.transform.position, 0.05f);
            this.transform.LookAt(view1.transform);
        }
    }
}
