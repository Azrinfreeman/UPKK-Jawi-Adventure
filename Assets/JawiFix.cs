using ArabicSupport;
using TMPro;
using UnityEngine;

namespace Watermelon
{
    public class JawiFix : MonoBehaviour
    {
        public string originalText;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ApplyFix();
        }

        public void ApplyFix()
        {
            GetComponent<TextMeshProUGUI>().text = ArabicFixer.Fix(originalText, true, true);
        }

        // Update is called once per frame
        void Update() { }
    }
}
