using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IssueText : MonoBehaviour
{
    public SpriteRenderer backgroundSpriteRenderer;
    public TextMeshPro textMeshPro;
    public InputField inputIssue;

    public Transform target;
    public Vector3 offset;
    public float smoothFactor;

    private void Start()
    {
        Setup(PlayerPrefs.GetString("Issue"));
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = targetPosition;
    }

    private void Setup(string text)
    {
        if (PlayerPrefs.GetString("Issue") == "" && inputIssue == null)
        {
            Destroy(gameObject);

        }
        else
        {
            textMeshPro.SetText(text);
            textMeshPro.ForceMeshUpdate();
            Vector2 textSize = textMeshPro.GetRenderedValues(false);

            Vector2 padding = new Vector2(1f, 0.5f);
            backgroundSpriteRenderer.size = textSize + padding;
        }
    }

    public void SetIssue()
    {
        PlayerPrefs.SetString("Issue", inputIssue.text);
        PlayerPrefs.Save();
    }
}
