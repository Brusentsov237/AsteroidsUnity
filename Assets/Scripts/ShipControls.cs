using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ShipControls : MonoBehaviour
{
  public Rigidbody2D rb;
  public GameObject bulletObject;
  public float sreenX;
  public float sreenY;
  public Text scoreText;
  public Text livesText;

  private PlayerInput _input;
  private Vector2 direction;
  private float rotation;

  private int score;
  private int lives;

  private void Awake()
  {
    _input = new PlayerInput();
    _input.PlayerShip.Shoot.performed += context => Shoot();
  }
  private void Start()
  {
    rb.inertia = 0.15f;
    score = 0;
    scoreText.text = $"Score: {score}";
    lives = 3;
    livesText.text = $"Lives: {lives}";
  }

  private void Shoot()
  {
    var bullet = Instantiate(bulletObject, transform.position, transform.rotation);
    bullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 1000);
    Destroy(bullet, 3);
  }

  void Update()
  {
    direction = _input.PlayerShip.MoveForward.ReadValue<Vector2>();
    rotation = _input.PlayerShip.Torque.ReadValue<float>();
  }

  void FixedUpdate()
  {
    rb.AddRelativeForce(direction * 5);
    rb.AddTorque(rotation * 1.5f);

    if (Mathf.Abs(transform.position.y) > sreenY) transform.position = new Vector3(transform.position.x, transform.position.y * -1);
    if (Mathf.Abs(transform.position.x) > sreenX) transform.position = new Vector3(transform.position.x * -1, transform.position.y);
  }

  void ScorePoints(int points)
  {
    score += points;
    scoreText.text = $"Score: {score}";
  }

  void OnCollisionEnter2D(Collision2D col)
  {
    if (col.relativeVelocity.magnitude > 2)
    {
      lives--;
      livesText.text = $"Lives: {lives}";
      if(lives <= 0) { }
    }
  }


  private void OnEnable()
  {
    _input.Enable();
  }

  private void OnDisable()
  {
    _input.Disable();
  }
}
