#if UNITY_EDITOR
using UnityEngine;
internal class Test : MonoBehaviour
{
    [LableText("A12")]
    public int B;

    [LableText("A13")]
    [field: SerializeField]
    public int A { get; set; }

    private void Update()
    {
        Debug.Log(A);
    }
}
#endif
