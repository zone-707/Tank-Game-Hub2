using UnityEngine;

public class CrateControl : MonoBehaviour
{
    public GameObject crackedCrate;
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(crackedCrate, this.transform.position, this.transform.localRotation);
            GameObject vfx = Instantiate(explosion, this.transform.position, this.transform.localRotation);

            Destroy(vfx, 3);

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
