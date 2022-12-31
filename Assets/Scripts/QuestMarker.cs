using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestMarker : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite Icon;
    public Image image;

    public Vector2 position { get { return new Vector2(transform.position.x, transform.position.z);} }
}
