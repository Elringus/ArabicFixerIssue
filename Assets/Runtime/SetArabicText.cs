using ArabicSupport;
using TMPro;
using UnityEngine;

public class SetArabicText : MonoBehaviour
{
    [TextArea]
    public string Message;
    public TextMeshProUGUI Text;

    private void Start ()
    {
        var fixedMessage = ArabicFixer.Fix(Message, Text.isRightToLeftText);
        Text.text = fixedMessage;
    }
}
