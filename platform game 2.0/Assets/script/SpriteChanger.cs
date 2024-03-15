using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite[] sprites; // List of sprites to cycle through
    public float timeBetweenSprites = 1.0f; // Time between sprite changes
    public string playerTag = "Player"; // Tag of the player GameObject
    private SpriteRenderer spriteRenderer;
    private int currentSpriteIndex = 0;
    private bool playerInside = false;
    private float timer = 0.0f;
    public CollisionDetection collisionDetection; // Reference to the ObjectDetector script

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (sprites.Length > 0 && spriteRenderer != null)
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        if (collisionDetection == null)
        {
            Debug.LogError("ObjectDetector reference is not set!");
            return;
        }
    }

    void Update()
    {
        if (playerInside)
        {
            timer += Time.deltaTime;
            if (timer >= timeBetweenSprites)
            {
                timer = 0.0f;
                ChangeSprite();
            }
        }
        if (collisionDetection.playerInside)
        {
            playerInside = true;
        }
        else
        {
            playerInside = false;
            currentSpriteIndex = 0; // Reset sprite index when player exits trigger
            if (sprites.Length > 0 && spriteRenderer != null)
                spriteRenderer.sprite = sprites[currentSpriteIndex];
        }
    }

    void ChangeSprite()
    {
        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
        if (sprites.Length > 0 && spriteRenderer != null)
            spriteRenderer.sprite = sprites[currentSpriteIndex];
    }

    public int GetCurrentSpriteIndex()
    {
        return currentSpriteIndex;
    }
}