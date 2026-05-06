using UnityEngine;

public class GreenPrince : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print("I am Green Prince Silksong from hit game Hollow Knight Silksong!");
            print("I miss my husband Hornet, I miss him a lot. I'll be back.");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Get & store ref for rigidbody to use in 2D Physics
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
