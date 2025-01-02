using UnityEngine;
using UnityEngine.InputSystem;

namespace NyanKyaw
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float playerSpeed = 50f;

        private Vector3 playerDirection;

        private Rigidbody rb;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void FixedUpdate()
        {
            MovePlayer();
        }

        public void MovePlayer()
        {
            rb.AddForce(playerDirection * playerSpeed);
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                other.gameObject.SetActive(false);
            }
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
        }

        #region Input System
        public void OnMove(InputValue movementValue)
        {
            Vector2 inputVector = movementValue.Get<Vector2>();
            playerDirection = new Vector3(inputVector.x, 0, inputVector.y);
        }

        #endregion
    }
}
