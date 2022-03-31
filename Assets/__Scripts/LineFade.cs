using System.Collections;

using UnityEngine;

public class LineFade : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private float speed = 10f;
    LineRenderer lr;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        color.a = Mathf.Lerp(color.a, 0, Time.deltaTime * speed);
        lr.startColor = color;
        lr.endColor = color;

    }
}
