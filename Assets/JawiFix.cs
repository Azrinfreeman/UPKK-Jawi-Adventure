using ArabicSupport;
using TMPro;
using UnityEngine;

namespace Watermelon
{
    public class JawiFix : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            string fixedText = GetComponent<TextMeshProUGUI>().text;
            GetComponent<TextMeshProUGUI>().text = ArabicFixer.Fix(fixedText, true, true);
        }

        // Update is called once per frame
        void Update() { }
    }
}
