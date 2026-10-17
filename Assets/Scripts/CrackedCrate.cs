using UnityEngine;

public class CrackedCrate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider[] cols = Physics.OverlapSphere(this.transform.position, 2);

        foreach (Collider c in cols)
        {
            Rigidbody rd = c.GetComponent<Rigidbody>();
             
            if (rd)
            {
                rd.AddExplosionForce(Random.Range(5, 10), this.transform.position, Random.Range(5, 10), 1, ForceMode.Impulse);
            }
        }

        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
