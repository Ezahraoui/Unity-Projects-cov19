using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControleurJoueur : MonoBehaviour
{

    public float vitesse;
    public Text countText;
    public Text winText;
    public Text loseText;
    private Rigidbody rb;
    private int count;
    private int count1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        count1 = 0;
        SetCountText();
        winText.text = "";
        loseText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mouvement * vitesse);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cible"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.SetActive(false);
            count1 = count1 + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            loseText.text = "";
            winText.text = "You Win!";
            
        }
        if (count1 >= 1 && count<8)
        {
            loseText.text = "You Lose!";
        }
    }
}
