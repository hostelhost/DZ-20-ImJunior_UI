using System.Collections;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private float _delayTime = 2f;

    private WaitForSeconds _waitForSeconds;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_delayTime);
        StartCoroutine(ColorReplacementAfterPeriodTime());
    }

    private IEnumerator ColorReplacementAfterPeriodTime()
    {
        while (true)
        {
            _meshRenderer.material.color = Random.ColorHSV();
            yield return _waitForSeconds;
        }
    }
}
