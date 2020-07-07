using ArabicSupport;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetArabicText2 : MonoBehaviour
{
    [TextArea]
    public string Message;
    public TextMeshProUGUI Text;
    public Text simpleText;

    private void Start()
    {
        var fixedMessage = ArabicFixer.Fix(Message);
        //fixedMessage = "أهلا";
        if (Text)
        {
            Text.text = fixedMessage;
        }
        if (simpleText)
        {
            simpleText.text = fixedMessage;
        }
    }
}
