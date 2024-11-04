using UnityEngine;
using UnityEngine.UI;

public class ButtonGetRandomColor : MonoBehaviour
{
    [SerializeField] Button _button;

    public void GetRandomColor()
    {
        _button.image.color = Random.ColorHSV();
    }
}
