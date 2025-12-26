using ArabicSupport;
using RTLTMPro;
using TMPro;
using UnityEngine;

namespace Watermelon
{
    public class JawiFix : MonoBehaviour
    {
        public string fixedText;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            string fixedText = GetComponent<RTLTextMeshPro>().text;
            GetComponent<RTLTextMeshPro>().text = ArabicFixer.Fix(fixedText, true, true);
            Debug.Log(GetComponent<RTLTextMeshPro>().text);
        }

        // Update is called once per frame
        void Update() { }
    }
}
