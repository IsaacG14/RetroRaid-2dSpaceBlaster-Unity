using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class DashHandler : MonoBehaviour
{
    [Header("UI")]
    public Image dashCooldownImage;

    [Header("Dash Settings")]
    public float dashForce = 20f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1f;

    [Header("Input Action")]
    public InputAction dashAction;
    public InputAction movementAction;

    private Rigidbody2D rb;
    private bool isDashing = false;
    private float lastDashTime = -999f;

    private void OnEnable()
    {
        dashAction.Enable();
        movementAction.Enable();
    }

    private void OnDisable()
    {
        dashAction.Disable();
        movementAction.Disable();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (dashAction.triggered && !isDashing && Time.time >= lastDashTime + dashCooldown)
        {
            StartCoroutine(PerformDash());
        }

        if (dashCooldownImage != null)
        {
            float cooldownPercent = Mathf.Clamp01((Time.time - lastDashTime) / dashCooldown);
            dashCooldownImage.fillAmount = cooldownPercent;
        }

    }

    private IEnumerator PerformDash()
    {
        isDashing = true;
        lastDashTime = Time.time;

        Vector2 dashDir = movementAction.ReadValue<Vector2>().normalized;
        if (dashDir == Vector2.zero)
        {
            dashDir = transform.up;
        }

        float startTime = Time.time;
        while (Time.time < startTime + dashDuration)
        {
            rb.velocity = dashDir * dashForce;
            yield return null;
        }

        rb.velocity = Vector2.zero; //   Stop momentum here
        isDashing = false;
    }

}
