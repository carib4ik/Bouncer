using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ShowCenterOfMass : MonoBehaviour
{
    public Color gizmoColor = Color.red; // Цвет Gizmo
    public float gizmoRadius = 0.1f; // Радиус Gizmo

    private Rigidbody rb;

    void Start()
    {
        // Получаем компонент Rigidbody
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody not found on the object.");
        }
    }

    void OnDrawGizmos()
    {
        // Проверяем, есть ли компонент Rigidbody
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        if (rb != null)
        {
            // Устанавливаем цвет Gizmo
            Gizmos.color = gizmoColor;

            // Рисуем сферу в точке центра массы
            Gizmos.DrawSphere(rb.worldCenterOfMass, gizmoRadius);
        }
    }
}