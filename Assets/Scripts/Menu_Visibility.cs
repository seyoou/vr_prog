using UnityEngine;
using UnityEngine.InputSystem;


public class MenuToggle : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private InputActionReference toggleButton;
    [SerializeField] private Transform head;
    [SerializeField] private Transform controller;
    [SerializeField] private float spawnDistance = 2f;

    private void OnEnable()
    {
        toggleButton.action.Enable();
        toggleButton.action.performed += OnTogglePressed;
    }

    private void OnDisable()
    {
        toggleButton.action.performed -= OnTogglePressed; 
    }

    private void OnTogglePressed(InputAction.CallbackContext context)
    {
        bool willBeActive = !menu.activeSelf;
        menu.SetActive(willBeActive);

        if (willBeActive)
        {
            Vector3 spawnPos = controller.position + controller.forward * spawnDistance;
            spawnPos.y = head.position.y - 0.1f;

            menu.transform.position = spawnPos;

            Vector3 driection = menu.transform.position - head.position;
            driection.y = 0f;

            menu.transform.rotation = Quaternion.LookRotation(driection);
        }
    }
}