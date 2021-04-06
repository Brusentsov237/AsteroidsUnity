using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
  [SerializeField] Rigidbody2D rb;
  [SerializeField] AudioClip Explosion;
  [SerializeField] GameObject mediumAsteroid;
  [SerializeField] GameObject smallAsteroid;
  [SerializeField] int asteroidSize;
  [SerializeField] float maxAbsDirection;
  [SerializeField] float maxAbsRotation;
  [SerializeField] float sreenX;
  [SerializeField] float sreenY;

  private Vector2 direction;
  private float rotation;

  private GameObject player;

  void Start()
  {
    direction = new Vector2(Random.Range(-maxAbsDirection, maxAbsDirection),Random.Range(-maxAbsDirection, maxAbsDirection));
    rotation = Random.Range(-maxAbsRotation,maxAbsRotation);

    rb.AddRelativeForce(direction);
    rb.AddTorque(rotation);

    player = GameObject.FindWithTag("Player");
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (Mathf.Abs(transform.position.y) > sreenY) transform.position = new Vector3(transform.position.x, transform.position.y * -1);
    if (Mathf.Abs(transform.position.x) > sreenX) transform.position = new Vector3(transform.position.x * -1, transform.position.y);
  }

  void OnTriggerEnter2D(Collider2D collider)
  {
    if (collider.CompareTag("Bullet"))
    {
      AudioSource.PlayClipAtPoint(Explosion, -transform.position, 12f);
      Destroy(collider.gameObject);
      Destroy(gameObject);

      if (asteroidSize == 3)
      {
        player.SendMessage("ScorePoints", 100);
        Instantiate(mediumAsteroid, transform.position, transform.rotation);
        Instantiate(mediumAsteroid, transform.position, transform.rotation);
      }
      else if (asteroidSize == 2)
      {
        player.SendMessage("ScorePoints", 50);
        Instantiate(smallAsteroid, transform.position, transform.rotation);
        Instantiate(smallAsteroid, transform.position, transform.rotation);
      }
      else
      {
        player.SendMessage("ScorePoints", 25);
      }
    }
  }
}
