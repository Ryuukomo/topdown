using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    Rigidbody2D rigi;
   public int velocidade = 5;
    public float horizon;
   public float verti;

    void Start()
    {
      rigi = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessaInputs();
    }

    private void FixedUpdate()
    {
        MovePers();
    }

    void ProcessaInputs() 
    { 
        horizon = Input.GetAxisRaw("Horizontal");
        verti = Input.GetAxisRaw("Vertical");
    
    }
    void MovePers()
    {
        rigi.linearVelocity = new Vector2(horizon, verti) * velocidade;
    }

}
