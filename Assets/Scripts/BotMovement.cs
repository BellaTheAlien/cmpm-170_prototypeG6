using UnityEngine;

public class BotMovement : MonoBehaviour
{
    public float speed = 3f;
    public  Transform[] waypoints;
    private int currentIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //using waypoints to move the bot, goes from one to another in a loop 
    void Update()
    {
        if (waypoints.Length == 0) return;

        Transform target = waypoints[currentIndex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Rotate to face direction
        Vector2 dir = target.position - transform.position;
        if (dir != Vector2.zero)
            transform.up = dir;

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
            currentIndex = (currentIndex + 1) % waypoints.Length; 
    }
}
