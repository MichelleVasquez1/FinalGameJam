using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;
using UnityEngine.SceneManagement;


public class finalLevel : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D charBody;
    private Vector2 velocity;
    private Vector2 inputMovement;
    // Start is called before the first frame update
    private int canCounter = 0;
    public TMP_Text counterText;
    
    public static int currentScore=0;

    void Start()
    {
        velocity = new Vector2(speed, speed);
        charBody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate(){
        Vector2 delta = inputMovement * velocity * Time.deltaTime;
        Vector2 newPosition = charBody.position + delta;
        charBody.MovePosition(newPosition);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Can") && collision.gameObject.activeSelf == true){
            collision.gameObject.SetActive(false);
            canCounter +=2;
            counterText.text = "Cans: " + canCounter;
        }
        else if(collision.CompareTag("Enemy")){ //&& collision.gameObject.activeSelf == true){
            collision.gameObject.SetActive(false);
            canCounter -= 1; 
            counterText.text = "Cans: " + canCounter;
        }
    }
    
    
}
