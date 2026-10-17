using UnityEngine;

public class TankControl : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public GameObject bullet;
    public GameObject bulletSpawn;
    public float bulletSpeed;
    public float gunTurningSpeed;
    public GameObject gun;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float horizontal = Input.GetAxis("Mouse X") * gunTurningSpeed * Time.deltaTime;
            float vertical = Input.GetAxis("Mouse Y") * gunTurningSpeed * Time.deltaTime;

            gun.transform.Rotate(-vertical, 0, horizontal);

            if (Input.GetMouseButtonDown(0))
            {
                GameObject b = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.localRotation);
                b.GetComponent<Rigidbody>().AddForce(bulletSpawn.transform.forward * bulletSpeed);
                Destroy(b, 5f);
            }
        }
        else
        {
            float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            this.transform.Translate(0, 0, moveVertical);

            float moveHorizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
            this.transform.Rotate(0, moveHorizontal, 0);

            gun.transform.localRotation = Quaternion.Lerp(gun.transform.localRotation, Quaternion.identity, 0.1f);
        }
    }
}
