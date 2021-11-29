using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 100f;
    [Header("Y Clamp")]
    [SerializeField] private float minYClamp = -90f;
    [SerializeField] private float maxYClamp = 90f;
    [Header("X Clamp")]
    [SerializeField] private float minXClamp = -90f;
    [SerializeField] private float maxXClamp = 90f;

    private float yRotation = 0f;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, minYClamp, maxYClamp);

        xRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, minXClamp, maxXClamp);
        
        transform.localRotation = Quaternion.Euler(yRotation, xRotation, 0f);
    }

}
