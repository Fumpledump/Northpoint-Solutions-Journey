using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IssueText : MonoBehaviour
{
    public SpriteRenderer backgroundSpriteRenderer;
    public TextMeshPro textMeshPro;

    private void Start()
    {
        Setup("Test Test Test aaaaaaaaa!");
    }
    private void Setup(string text)
    {
        textMeshPro.SetText(text);
        textMeshPro.ForceMeshUpdate();
        Vector2 textSize = textMeshPro.GetRenderedValues(false);

        Vector2 padding = new Vector2(1f, 0.5f);
        backgroundSpriteRenderer.size = textSize + padding;

    }
}
