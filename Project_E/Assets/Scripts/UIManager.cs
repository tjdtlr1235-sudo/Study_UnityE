using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;
    public Transform canvasTransform;
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform); // 생선한 팝업 변수
        Popup popupScript = newPopup.GetComponent<Popup>(); // 팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText); // 팝업 내용 설정(인스턴스화된 개체에서 설정)
    }
}