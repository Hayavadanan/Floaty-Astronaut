//The scorlling BG is managed by this file.
//Continuous scrolling effect is created by slowly shifting the MainTextureOffset of the bg
//material of the mesh renderer in the Update method.
using UnityEngine;

public class Parallex : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float animationSpeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime , 0);
    }
}
