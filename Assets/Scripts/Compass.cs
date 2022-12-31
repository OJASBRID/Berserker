using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public GameObject iconPrefab;
    public RawImage compassimage;
    public Transform player;
    List<QuestMarker> markers = new List<QuestMarker>();
    // Start is called before the first frame update
    float compassunit;

    public QuestMarker one;

    private void Start()
    {
        compassunit = compassimage.rectTransform.rect.width / 360f;
        Addquestmarker(one);
    }

    // Update is called once per frame
    void Update()
    {
        compassimage.uvRect = new Rect(player.localEulerAngles.y / 360f, 0f, 1f, 1f);

        foreach(QuestMarker marker in markers)
        {

            marker.image.rectTransform.anchoredPosition = GetPosOnCompass(marker);
        }
    }

    public void Addquestmarker(QuestMarker marker)
    {
        GameObject newMarker = Instantiate(iconPrefab, compassimage.transform);
        marker.image = newMarker.GetComponent<Image>();
        marker.image.sprite = marker.Icon;

        markers.Add(marker);
    }

    Vector2 GetPosOnCompass(QuestMarker marker)
    {

        Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.z);
        Vector2 playerFWD = new Vector2(player.transform.forward.x, player.transform.forward.z);

        float angle = Vector2.SignedAngle(marker.position - playerPos, playerFWD);
        return new Vector2(compassunit*angle, 0f);
    }
}
