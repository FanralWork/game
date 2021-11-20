using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Text speedText;
    public Transform player;
    public bool CanJump = true;

    public const float minforwardSpeed = 1000f;
    public const float maxforwardSpeed = 3000f;
    public const float minsidewaySpeed = 25f;
    public const float maxsidewaySpeed = 100f;

    public float forwardForce = 2000f;
    public float sidewayForce = 30f;
    public float upwayForce = 1f;

    public float MinforwardSpeed
    {
        get { return minforwardSpeed;}
    }

    public float MaxforwardSpeed
    {
        get { return maxforwardSpeed; }
    }
    public float MinsidewaySpeed
    {
        get { return minsidewaySpeed; }
    }
    public float MaxsidewaySpeed
    {
        get { return maxsidewaySpeed; }
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
 
        if (Input.GetKey("d") | Input.GetKey("right"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") | Input.GetKey("left"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.GetKey("space") && player.position.y <= 1)
        {
            rb.AddForce(0, upwayForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            System.Threading.Tasks.Task.Delay(1000);
            Debug.Log("Jumping");

        }


        speedText.text = forwardForce.ToString("0");
    }
}
