using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Watermelon
{
    public class QuestionClasses : MonoBehaviour
    {
        public static QuestionClasses instance;

        void Awake()
        {
            instance = this;
        }

        [System.Serializable]
        public class Question
        {
            public string question;
            public List<string> answerButton;
            public int AnswerOnButton;

            public Question(string question, List<string> answerButton, int AnswerOnButton)
            {
                this.question = question;
                this.answerButton = answerButton;
                this.AnswerOnButton = AnswerOnButton;
            }
        }

        [System.Serializable]
        public class Levels
        {
            public List<Question> questions = new List<Question>();
        }

        public int level;
        public List<Levels> levels;

        public void SetLevel(int levelNum)
        {
            level = levelNum;
        }

        // Start is called before the first frame update
        void Start()
        {
            levels.AddRange(
                new List<Levels>
                {
                    //Akidah Tahap
                    //level 1 AKIDAH 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود روكون ايمان؟",
                                new List<string>
                                {
                                    "تياڠ اڬام",
                                    "ڤركارا يڠ واجب دڤرچاياٴي",
                                    "روكون صلاة",
                                },
                                1
                            ),
                            new Question(
                                "براڤ بيلڠن روكون ايمان؟",
                                new List<string> { "تيڬ", "ليم", "انم" },
                                2
                            ),
                            new Question(
                                "روكون ايمان ڤرتام ايله برايمان كڤد",
                                new List<string> { "ملائكة", "الله", "رسول" },
                                1
                            ),
                            new Question(
                                "برايمان كڤد الله برمقصود كيت ڤرچاي بهاوا الله ايت",
                                new List<string> { "اد دان مها بركواس", "مأنسي", "باڽق" },
                                0
                            ),
                            new Question(
                                "روكون ايمان كدوا ايله برايمان كڤد",
                                new List<string> { "كتاب", "ملائكة", "رسول" },
                                1
                            ),
                            new Question(
                                "برايمان كڤد ملائكة برمقصود ڤرچاي بهاوا ملائكة",
                                new List<string>
                                {
                                    "تيدق وجود",
                                    "مخلوق الله يڠ طاعة",
                                    "بوليه ماكن دان مينوم",
                                },
                                1
                            ),
                            new Question(
                                "روكون ايمان كتيڬ ايله برايمان كڤد",
                                new List<string> { "كتاب", "رسول", "هاري اخيرة" },
                                0
                            ),
                            new Question(
                                "برايمان كڤد كتاب برمقصود ڤرچاي كڤد",
                                new List<string>
                                {
                                    "بوكو سكوله",
                                    "كتاب يڠ دتورونكن الله",
                                    "توراة سهاج",
                                },
                                1
                            ),
                            new Question(
                                "روكون ايمان كأمڤت ايله برايمان كڤد",
                                new List<string> { "رسول", "شرڬ", "هاري اخيرة" },
                                0
                            ),
                            new Question(
                                "روكون ايمان كليم ايله برايمان كڤد",
                                new List<string> { "قضاء دان قدر", "هاري اخيرة", "شرڬ" },
                                1
                            ),
                            new Question(
                                "روكون ايمان كأنم ايله برايمان كڤد",
                                new List<string> { "قضاء دان قدر", "شيطان", "ايمان" },
                                0
                            ),
                            new Question(
                                "دليل برايمان كڤد الله ترداڤت دالم",
                                new List<string> { "حديث", "القرآن", "قصه نبي" },
                                1
                            ),
                            new Question(
                                "الله منچيڤتا... د دنيا اين.",
                                new List<string> { "مأنسي دان عالم", "حيوان سهاج", "بندا جاهت" },
                                0
                            ),
                            new Question(
                                "تندا اورڠ برايمان كڤد الله ايله دي",
                                new List<string> { "راجين برعبادة", "مالس صلاة", "سوك منيڤو" },
                                0
                            ),
                            new Question(
                                "كيت مستي يقين بهاوا الله ايله توهن يڠ",
                                new List<string> { "راماي", "ساتو", "دوا" },
                                1
                            ),
                            new Question(
                                "اورڠ يڠ برايمان كڤد الله تيدق اكن",
                                new List<string> { "منيڤو", "برذكر", "برشكور" },
                                0
                            ),
                            new Question(
                                "ايمان برمقصود ڤرچاي دڠن",
                                new List<string>
                                {
                                    "ليده دان هاتي",
                                    "مات دان تليڠا",
                                    "تاڠن دان كاكي",
                                },
                                0
                            ),
                            new Question(
                                "الله برصفت مها",
                                new List<string> { "لوڤ", "كواس", "لمه" },
                                1
                            ),
                            new Question(
                                "كلمه شهادة مڠاندوڠي دوا",
                                new List<string> { "كليمه", "بهاڬين", "دعاء" },
                                1
                            ),
                            new Question(
                                "بهاڬين ڤرتام شهادة ايله ڤڠاكوان كڤد",
                                new List<string> { "رسول", "الله", "ملائكة" },
                                1
                            ),
                            new Question(
                                "بهاڬين كدوا شهادة ايله ڤڠاكوان كڤد",
                                new List<string>
                                {
                                    "محمد سباڬاي رسول",
                                    "الله سباڬاي توهن",
                                    "ملائكة",
                                },
                                0
                            ),
                            new Question(
                                "شهادة مڠاجر كيت سوڤاي",
                                new List<string>
                                {
                                    "ڤرچاي كڤد الله دان رسول",
                                    "مالس صلاة",
                                    "تيدق برزكاة",
                                },
                                0
                            ),
                            new Question(
                                "اورڠ إسلام واجب ممباچ كلمه شهادة كتيك",
                                new List<string> { "برماءين", "ماسوق إسلام", "تيدور" },
                                1
                            ),
                            new Question(
                                "إسلام برمقصود",
                                new List<string> { "كأمانن دان ڤاتوه كڤد الله", "ككاياءن", "كواس" },
                                0
                            ),
                            new Question(
                                "ايمان برمقصود",
                                new List<string>
                                {
                                    "ڤرچاي دان يقين كڤد الله",
                                    "مڽره ديري كڤد شيطان",
                                    "مالس بلاجر",
                                },
                                0
                            ),
                            new Question(
                                "إسلام دان ايمان مستي اد برسام اونتوق منجادي",
                                new List<string> { "اومت يڠ سمڤورنا", "اورڠ كاي", "ڤماءين بولا" },
                                0
                            ),
                            new Question(
                                "هوبوڠن إسلام دان ايمان سڤرتي",
                                new List<string>
                                {
                                    "ڤوكوق دان بواه",
                                    "اءير دان اڤي",
                                    "لاڠيت دان لاءوت",
                                },
                                0
                            ),
                            new Question(
                                "أسماء الحسنى برمقصود نام٢",
                                new List<string> { "رسول", "باءيق الله", "ملائكة" },
                                1
                            ),
                            new Question(
                                "بيلڠن أسماء الحسنى ايله",
                                new List<string> { "33", "77", "99" },
                                2
                            ),
                            new Question(
                                "انتارا چونتوه أسماء الحسنى ايله",
                                new List<string> { "الرحمن", "ذوالقرنين", "فرعون" },
                                0
                            ),
                            new Question(
                                "الرحمن برمقصود",
                                new List<string> { "مها ڤموره", "مها كاي", "مها قوات" },
                                0
                            ),
                            new Question(
                                "أسماء الحسنى مڠاجر كيت سوڤاي",
                                new List<string> { "منيرو صفت باءيق الله", "برلاون", "منيڤو" },
                                0
                            ),
                            new Question(
                                "الله برصفت السميع برمقصود الله مها",
                                new List<string> { "مليهت", "مندڠر", "مڠتاهوءي" },
                                1
                            ),
                            new Question(
                                "الله برصفت البصير برمقصود الله مها",
                                new List<string> { "مليهت", "ڤموره", "بركواس" },
                                0
                            ),
                            new Question(
                                "توحيد برمقصود مڠيساكن",
                                new List<string> { "رسول", "الله", "ملائكة" },
                                1
                            ),
                            new Question(
                                "توحيد تربهاڬي كڤد... بهاڬين.",
                                new List<string> { "دوا", "تيڬ", "امڤت" },
                                1
                            ),
                            new Question(
                                "توحيد ربوبية برمقصود مڠيساكن الله سباڬاي",
                                new List<string> { "توهن يڠ منچيڤتا دان منتدبير", "رسول", "مأنسي" },
                                0
                            ),
                            new Question(
                                "توحيد ألوهية برمقصود هاڽ مڽمبه",
                                new List<string> { "رسول", "الله", "ملائكة" },
                                1
                            ),
                            new Question(
                                "توحيد أسماء وصفات برمقصود برايمان دڠن",
                                new List<string> { "نام دان صفت الله", "نام نبي", "كتاب الله" },
                                0
                            ),
                            new Question(
                                "دليل توحيد بوليه دداڤتي دالم",
                                new List<string> { "القرآن", "بوكو چريتا", "سورت خبر" },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ برتوحيد تيدق اكن... سلاين الله.",
                                new List<string> { "مڽمبه", "مڽبوت", "مڽايڠي" },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ تيدق برتوحيد اكن منجادي",
                                new List<string> { "برايمان", "مشرك", "عالم" },
                                1
                            ),
                            new Question(
                                "كيت مستي ممڤلاجري توحيد سوڤاي",
                                new List<string> { "كنل الله", "منجادي كاي", "دڤوجي اورڠ" },
                                0
                            ),
                            new Question(
                                "الله سهاج يڠ لايق دسمبه كرنا دي",
                                new List<string> { "مها قوات دان بركواس", "مأنسي", "ملائكة" },
                                0
                            ),
                            new Question(
                                "دليل ايمان كڤد الله ترداڤت دالم سورة",
                                new List<string> { "الإخلاص", "الفاتحة", "الكوثر" },
                                1
                            ),
                            new Question(
                                "إسلام دان ايمان ممباوا كيت كجالن",
                                new List<string> { "نراك", "كباءيقن", "كمالسن" },
                                1
                            ),
                            new Question(
                                "ايمان دالم هاتي اكن ممبوات سسأورڠ منجادي",
                                new List<string> { "ڤڽايڠ دان جوجور", "ڤماره", "ڤندندم" },
                                0
                            ),
                            new Question(
                                "أسماء الحسنى منونجوقكن صفت الله يڠ",
                                new List<string> { "بوروق", "موليا", "جاهت" },
                                1
                            ),
                            new Question(
                                "كيت هندقله بردعاء مڠڬوناكن",
                                new List<string> { "أسماء الحسنى", "نام سنديري", "نام اورڠ" },
                                0
                            ),
                            new Question(
                                "اورڠ إسلام مستي ڤرچاي كڤد سموا",
                                new List<string> { "روكون ايمان", "روكون نڬارا", "روكون هيدوڤ" },
                                0
                            ),
                            new Question(
                                "برايمان كڤد الله منجاديكن كيت",
                                new List<string> { "طاعة دان برشكور", "مالس دان سومبوڠ", "لالاي" },
                                0
                            ),
                        }, //tahap 4
                    },
                    //level 2 IBADAH 1 (Contains Sirah Content)
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "سيرة برمقصود چريتا تنتڠ كهيدوڤن...",
                                new List<string> { "نبي دان رسول", "ملائكة", "صحابت" },
                                0
                            ),
                            new Question(
                                "سيرة مڠاجر كيت تنتڠ نبي محمد...",
                                new List<string> { "كصيحاتن", "كهيدوڤن", "ڤكرجاءن" },
                                1
                            ),
                            new Question(
                                "سومبر اوتام سيرة ايله...",
                                new List<string> { "القرآن دان حديث", "بوكو چريتا", "سورت خبر" },
                                0
                            ),
                            new Question(
                                "كيت بلاجر سيرة سوڤاي داڤت... نبي محمد.",
                                new List<string> { "منيرو اخلاق", "برلاون دڠن", "ملوڤاكنڽ" },
                                0
                            ),
                            new Question(
                                "سيرة ممبنتو كيت منجادي...",
                                new List<string> { "مالس", "سومبوڠ", "باءيق" },
                                2
                            ),
                            new Question(
                                "اورڠ يڠ تيدق بلاجر سيرة اكن سوكر مڠنل...",
                                new List<string> { "حيوان", "نبي محمد", "تومبوهن" },
                                1
                            ),
                            new Question(
                                "سيرة ايله ساتو چارا اونتوق كيت مڠتاهوءي سجاره...",
                                new List<string> { "إسلام", "نڬارا", "دنيا" },
                                0
                            ),
                            new Question(
                                "سيرة منچريتاكن ڤرجواڠن...",
                                new List<string> { "صحابت نبي", "ملائكة", "موسوه" },
                                0
                            ),
                            new Question(
                                "كيت هندقله ممباچ سيرة دڠن راس...",
                                new List<string> { "ماره", "بوسن", "چينتا كڤد نبي" },
                                2
                            ),
                            new Question(
                                "ڤڠاجرن سيرة ممبنتو كيت منجادي اومت يڠ...",
                                new List<string> { "لمه", "قوات دان برايمان", "لوڤ ديري" },
                                1
                            ),
                            new Question(
                                "باڤ نبي محمد برنام...",
                                new List<string> { "أبو طالب", "عبد الله", "عبد المطلب" },
                                1
                            ),
                            new Question(
                                "ايبو نبي محمد برنام...",
                                new List<string> { "فاطمة", "آمنة", "خديجة" },
                                1
                            ),
                            new Question(
                                "داتوق نبي محمد برنام...",
                                new List<string> { "أبو طالب", "عبد المطلب", "حمزة" },
                                1
                            ),
                            new Question(
                                "نام ڤنوه نبي محمد ايله محمد بن...",
                                new List<string> { "أبو طالب", "عبد الله", "أبو بكر" },
                                1
                            ),
                            new Question(
                                "نبي محمد برأصل دريڤد بڠسا...",
                                new List<string> { "قريش", "روم", "فارسي" },
                                0
                            ),
                            new Question(
                                "نبي محمد كتورونن نبي...",
                                new List<string> { "عيسى", "إبراهيم", "موسى" },
                                1
                            ),
                            new Question(
                                "نبي محمد دڬلر الأمين كرنا...",
                                new List<string>
                                {
                                    "سوك برڬوراو",
                                    "برسيقڤ جوجور دان أمانه",
                                    "قوات ماكن",
                                },
                                1
                            ),
                            new Question(
                                "ايبو نبي محمد وفاة كتيك بڬيندا ماسيه...",
                                new List<string> { "بايي", "رماجا", "ديواسا" },
                                0
                            ),
                            new Question(
                                "سلڤس ايبو دان باڤ وفاة، نبي دجاڬ اوليه...",
                                new List<string> { "صحابت", "داتوق", "جيرن" },
                                1
                            ),
                            new Question(
                                "سلڤس داتوق وفاة، نبي دجاڬ اوليه...",
                                new List<string> { "أبو طالب", "عمر", "بلال" },
                                0
                            ),
                            new Question(
                                "نبي محمد ايله... تراخير.",
                                new List<string> { "رسول", "ملائكة", "صحابت" },
                                0
                            ),
                            new Question(
                                "نبي محمد دأوتوسكن كڤد...",
                                new List<string> { "قوم عرب سهاج", "سموا مأنسي", "اورڠ قريش سهاج" },
                                1
                            ),
                            new Question(
                                "تنترا برڬاجه داتڠ اونتوق... كعبة.",
                                new List<string> { "ممبينا", "ممسنهكن", "ممبرسيهكن" },
                                1
                            ),
                            new Question(
                                "ڤميمڤين تنترا برڬاجه ايله...",
                                new List<string> { "أبرهة", "أبو جهل", "حمزة" },
                                0
                            ),
                            new Question(
                                "الله مڠهنتر بوروڠ... اونتوق ملاون تنترا برڬاجه.",
                                new List<string> { "مرڤاتي", "أبابيل", "ڬاڬق" },
                                1
                            ),
                            new Question(
                                "بوروڠ-بوروڠ ايت ممباوا...",
                                new List<string> { "باتو", "ماكنن", "سورت" },
                                0
                            ),
                            new Question(
                                "ڤريستيوا تنترا برڬاجه برلاكو ڤد تاهون...",
                                new List<string> { "تاهون ڬاجه", "تاهون اونتا", "تاهون هاريماو" },
                                0
                            ),
                            new Question(
                                "باڤ نبي محمد منيڠڬل دنيا د...",
                                new List<string> { "مكة", "مدينة", "شام" },
                                2
                            ),
                            new Question(
                                "باڤ نبي وفاة سبلوم نبي...",
                                new List<string> { "لاهير", "بركهوين", "برهجرة" },
                                0
                            ),
                            new Question(
                                "ايبو نبي برنام آمنة بنت...",
                                new List<string> { "وهب", "عمر", "علي" },
                                0
                            ),
                            new Question(
                                "داتوق نبي ايله سأورڠ يڠ...",
                                new List<string> { "ڤماره", "ڤڽايڠ دان موليا", "سومبوڠ" },
                                1
                            ),
                            new Question(
                                "ڤريستيوا تنترا برڬاجه منونجوقكن الله ايت...",
                                new List<string> { "لمه", "مها كواس", "لوڤ" },
                                1
                            ),
                            new Question(
                                "الله مليندوڠي كعبة دريڤد...",
                                new List<string> { "مأنسي", "تنترا برڬاجه", "بوروڠ" },
                                1
                            ),
                            new Question(
                                "ڤريستيوا ايت برلاكو سبلوم نبي محمد...",
                                new List<string> { "لاهير", "بركهوين", "برهجرة" },
                                0
                            ),
                            new Question(
                                "نبي محمد لاهير د...",
                                new List<string> { "مكة", "مدينة", "طائف" },
                                0
                            ),
                            new Question(
                                "ماس كلاهيرن نبي ايله ڤد وقتو...",
                                new List<string> { "ڤاڬي", "سياڠ", "مالم" },
                                2
                            ),
                            new Question(
                                "نبي لاهير ڤد هاري...",
                                new List<string> { "إثنين", "جمعة", "سبت" },
                                0
                            ),
                            new Question(
                                "تاهون كلاهيرن نبي دكنلي سباڬاي...",
                                new List<string> { "تاهون اونتا", "تاهون ڬاجه", "تاهون هجرة" },
                                1
                            ),
                            new Question(
                                "كلاهيرن نبي ممباوا رحمة كڤد...",
                                new List<string>
                                {
                                    "اومت إسلام سهاج",
                                    "سلوروه عالم",
                                    "بڠسا عرب سهاج",
                                },
                                1
                            ),
                            new Question(
                                "نام نبي دبريكن اوليه...",
                                new List<string> { "ايبوڽ", "داتوقڽ", "صحابت" },
                                1
                            ),
                            new Question(
                                "نبي محمد د-سوسوكن اوليه...",
                                new List<string> { "حليمة السعدية", "آمنة", "فاطمة" },
                                0
                            ),
                            new Question(
                                "كلاهيرن نبي دسامبوت دڠن ڤنوه...",
                                new List<string> { "ڬمبيرا", "سديه", "ماره" },
                                0
                            ),
                            new Question(
                                "نبي محمد لاهير دالم كأداءن...",
                                new List<string> { "برسيه دان سوچي", "ساكيت", "مناڠيس قوات" },
                                0
                            ),
                            new Question(
                                "داتوق نبي ساڠت... اڤابيلا نبي لاهير.",
                                new List<string> { "سديه", "ڬمبيرا", "تاكوت" },
                                1
                            ),
                            new Question(
                                "كلاهيرن نبي محمد منونجوقكن كاسيه سايڠ... كڤد مأنسي.",
                                new List<string> { "ملائكة", "الله", "ايبو" },
                                1
                            ),
                            new Question(
                                "نبي لاهير اونتوق ممباوا... كڤد مأنسي.",
                                new List<string> { "كسستن", "كبنرن", "كسوسهن" },
                                1
                            ),
                            new Question(
                                "اومت إسلام ڤاتوت برشكور اتس... نبي محمد.",
                                new List<string> { "كماتين", "كلاهيرن", "هجرة" },
                                1
                            ),
                            new Question(
                                "نبي ايله چونتوه... باڬي سلوروه مأنسي.",
                                new List<string> { "بوروق", "ترباءيق", "بياسا" },
                                1
                            ),
                            new Question(
                                "كلاهيرن نبي برلاكو سلڤس ڤريستيوا...",
                                new List<string> { "إسراء معراج", "تنترا برڬاجه", "هجرة" },
                                1
                            ),
                            new Question(
                                "كيت مستي منچينتاءي نبي دڠن چارا...",
                                new List<string> { "منيرو اخلاقڽ", "ملوڤاكنڽ", "ممبنچيڽ" },
                                0
                            ),

                            ///tahapo 2
                        },
                    },
                    //level 3 Sirah Tahap 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "سيرة برمقصود چريتا تنتڠ كهيدوڤن",
                                new List<string> { "نبي دان رسول", "ملائكة", "صحابت" },
                                0
                            ),
                            new Question(
                                "سيرة مڠاجر كيت تنتڠ نبي محمد",
                                new List<string> { "كصيحاتن", "كهيدوڤن", "ڤكرجاءن" },
                                1
                            ),
                            new Question(
                                "سومبر اوتام سيرة ايله",
                                new List<string> { "القرآن دان حديث", "بوكو چريتا", "سورت خبر" },
                                0
                            ),
                            new Question(
                                "كيت بلاجر سيرة سوڤاي داڤت... نبي محمد",
                                new List<string> { "منيرو اخلاق", "برلاون دڠن", "ملوڤاكنڽ" },
                                0
                            ),
                            new Question(
                                "سيرة ممبنتو كيت منجادي",
                                new List<string> { "مالس", "سومبوڠ", "باءيق" },
                                2
                            ),
                            new Question(
                                "اورڠ يڠ تيدق بلاجر سيرة اكن سوكر مڠنل",
                                new List<string> { "حيوان", "نبي محمد", "تومبوهن" },
                                1
                            ),
                            new Question(
                                "سيرة ايله ساتو چارا اونتوق كيت مڠتاهوءي سجاره",
                                new List<string> { "إسلام", "نڬارا", "دنيا" },
                                0
                            ),
                            new Question(
                                "سيرة منچريتاكن ڤرجواڠن",
                                new List<string> { "صحابت نبي", "ملائكة", "موسوه" },
                                0
                            ),
                            new Question(
                                "كيت هندقله ممباچ سيرة دڠن راس",
                                new List<string> { "ماره", "بوسن", "چينتا كڤد نبي" },
                                2
                            ),
                            new Question(
                                "ڤڠاجرن سيرة ممبنتو كيت منجادي اومت يڠ",
                                new List<string> { "لمه", "قوات دان برايمان", "لوڤ ديري" },
                                1
                            ),
                            new Question(
                                "باڤ نبي محمد برنام",
                                new List<string> { "أبو طالب", "عبد الله", "عبد المطلب" },
                                1
                            ),
                            new Question(
                                "ايبو نبي محمد برنام",
                                new List<string> { "فاطمة", "آمنة", "خديجة" },
                                1
                            ),
                            new Question(
                                "داتوق نبي محمد برنام",
                                new List<string> { "أبو طالب", "عبد المطلب", "حمزة" },
                                1
                            ),
                            new Question(
                                "نام ڤنوه نبي محمد ايله محمد بن",
                                new List<string> { "أبو طالب", "عبد الله", "أبو بكر" },
                                1
                            ),
                            new Question(
                                "نبي محمد برأصل دريڤد بڠسا",
                                new List<string> { "قريش", "روم", "فارسي" },
                                0
                            ),
                            new Question(
                                "نبي محمد كتورونن نبي",
                                new List<string> { "عيسى", "إبراهيم", "موسى" },
                                1
                            ),
                            new Question(
                                "نبي محمد دڬلر الأمين كرنا",
                                new List<string>
                                {
                                    "سوك برڬوراو",
                                    "برسيقڤ جوجور دان أمانه",
                                    "قوات ماكن",
                                },
                                1
                            ),
                            new Question(
                                "ايبو نبي محمد وفاة كتيك بڬيندا ماسيه",
                                new List<string> { "بايي", "رماجا", "ديواسا" },
                                0
                            ),
                            new Question(
                                "سلڤس ايبو دان باڤ وفاة، نبي دجاڬ اوليه",
                                new List<string> { "صحابت", "داتوق", "جيرن" },
                                1
                            ),
                            new Question(
                                "سلڤس داتوق وفاة، نبي دجاڬ اوليه",
                                new List<string> { "أبو طالب", "عمر", "بلال" },
                                0
                            ),
                            new Question(
                                "نبي محمد ايله... تراخير.",
                                new List<string> { "رسول", "ملائكة", "صحابت" },
                                0
                            ),
                            new Question(
                                "نبي محمد دأوتوسكن كڤد",
                                new List<string> { "قوم عرب سهاج", "سموا مأنسي", "اورڠ قريش سهاج" },
                                1
                            ),
                            new Question(
                                "تنترا برڬاجه داتڠ اونتوق... كعبة.",
                                new List<string> { "ممبينا", "ممسنهكن", "ممبرسيهكن" },
                                1
                            ),
                            new Question(
                                "ڤميمڤين تنترا برڬاجه ايله",
                                new List<string> { "أبرهة", "أبو جهل", "حمزة" },
                                0
                            ),
                            new Question(
                                "الله مڠهنتر بوروس... اونتوق ملاون تنترا برڬاجه.",
                                new List<string> { "مرڤاتي", "أبابيل", "ڬاڬق" },
                                1
                            ),
                            new Question(
                                "بوروڠ-بوروڠ ايت ممباوا",
                                new List<string> { "باتو", "ماكنن", "سورت" },
                                0
                            ),
                            new Question(
                                "ڤريستيوا تنترا برڬاجه برلاكو ڤد تاهون",
                                new List<string> { "تاهون ڬاجه", "تاهون اونتا", "تاهون هاريماو" },
                                0
                            ),
                            new Question(
                                "باڤ نبي محمد منيڠڬل دنيا د",
                                new List<string> { "مكة", "مدينة", "شام" },
                                2
                            ),
                            new Question(
                                "باڤ نبي وفاة سبلوم نبي",
                                new List<string> { "لاهير", "بركهوين", "برهجرة" },
                                0
                            ),
                            new Question(
                                "ايبو نبي برنام آمنة بنت",
                                new List<string> { "وهب", "عمر", "علي" },
                                0
                            ),
                            new Question(
                                "داتوق نبي ايله سأورڠ يڠ",
                                new List<string> { "ڤماره", "ڤڽايڠ دان موليا", "سومبوڠ" },
                                1
                            ),
                            new Question(
                                "ڤريستيوا تنترا برڬاجه منونجوقكن الله ايت",
                                new List<string> { "لمه", "مها كواس", "لوڤ" },
                                1
                            ),
                            new Question(
                                "الله مليندوڠي كعبة دريڤد",
                                new List<string> { "مأنسي", "تنترا برڬاجه", "بوروڠ" },
                                1
                            ),
                            new Question(
                                "ڤريستيوا ايت برلاكو سبلوم نبي محمد",
                                new List<string> { "لاهير", "بركهوين", "برهجرة" },
                                0
                            ),
                            new Question(
                                "نبي محمد لاهير د",
                                new List<string> { "مكة", "مدينة", "طائف" },
                                0
                            ),
                            new Question(
                                "ماس كلاهيرن نبي ايله ڤد وقتو",
                                new List<string> { "ڤاڬي", "سياڠ", "مالم" },
                                2
                            ),
                            new Question(
                                "نبي لاهير ڤد هاري",
                                new List<string> { "إثنين", "جمعة", "سبت" },
                                0
                            ),
                            new Question(
                                "تاهون كلاهيرن نبي دكنلي سباڬاي",
                                new List<string> { "تاهون اونتا", "تاهون ڬاجه", "تاهون هجرة" },
                                1
                            ),
                            new Question(
                                "كلاهيرن نبي ممباوا رحمة كڤد",
                                new List<string>
                                {
                                    "اومت إسلام سهاج",
                                    "سلوروه عالم",
                                    "بڠسا عرب سهاج",
                                },
                                1
                            ),
                            new Question(
                                "نام نبي دبريكن اوليه",
                                new List<string> { "ايبوڽ", "داتوقڽ", "صحابت" },
                                1
                            ),
                            new Question(
                                "نبي محمد د-سوسوكن اوليه",
                                new List<string> { "حليمة السعدية", "آمنة", "فاطمة" },
                                0
                            ),
                            new Question(
                                "كلاهيرن نبي دسامبوت دڠن ڤنوه",
                                new List<string> { "ڬمبيرا", "سديه", "ماره" },
                                0
                            ),
                            new Question(
                                "نبي محمد لاهير دالم كأداءن",
                                new List<string> { "برسيه دان سوچي", "ساكيت", "مناڠيس قوات" },
                                0
                            ),
                            new Question(
                                "داتوق نبي ساڠت... اڤابيلا نبي لاهير.",
                                new List<string> { "سديه", "ڬمبيرا", "تاكوت" },
                                1
                            ),
                            new Question(
                                "كلاهيرن نبي محمد منونجوقكن كاسيه سايڠ... كڤد مأنسي.",
                                new List<string> { "ملائكة", "الله", "ايبو" },
                                1
                            ),
                            new Question(
                                "نبي لاهير اونتوق ممباوا... كڤد مأنسي.",
                                new List<string> { "كسستن", "كبنرن", "كسوسهن" },
                                1
                            ),
                            new Question(
                                "اومت إسلام ڤاتوت برشكور اتس... نبي محمد",
                                new List<string> { "كماتين", "كلاهيرن", "هجرة" },
                                1
                            ),
                            new Question(
                                "نبي ايله چونتوه... باڬي سلوروه مأنسي.",
                                new List<string> { "بوروق", "ترباءيق", "بياسا" },
                                1
                            ),
                            new Question(
                                "كلاهيرن نبي برلاكو سلڤس ڤريستيوا",
                                new List<string> { "إسراء معراج", "تنترا برڬاجه", "هجرة" },
                                1
                            ),
                            new Question(
                                "كيت مستي منچينتاءي نبي دڠن چارا",
                                new List<string> { "منيرو اخلاقڽ", "ملوڤاكنڽ", "ممبنچيڽ" },
                                0
                            ),

                            ///tahapo 2
                        },
                    },
                    //level adab tahap 1
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود ادب دڠن الله؟",
                                new List<string>
                                {
                                    "ڤربواتن يڠ سوڤن ترهادڤ الله",
                                    "بربوات جاهت كڤد الله",
                                    "ملوڤاكن الله",
                                },
                                0
                            ),
                            new Question(
                                "حكوم برادب دڠن الله ايله",
                                new List<string> { "واجب", "سنة", "مكروه" },
                                0
                            ),
                            new Question(
                                "كيت هندقله سنتياس... كڤد الله.",
                                new List<string> { "طاعة", "ملاون", "برمالس-مالسن" },
                                0
                            ),
                            new Question(
                                "چونتوه ادب دڠن الله ايله",
                                new List<string> { "منونايكن صلاة", "برڬادوه", "منيڤو" },
                                0
                            ),
                            new Question(
                                "اڤابيلا كيت بردعاء، كيت هندقله",
                                new List<string>
                                {
                                    "رنده ديري دان برسوڤن",
                                    "ماره-ماره",
                                    "برچاكڤ قوات",
                                },
                                0
                            ),
                            new Question(
                                "حكمة برادب دڠن الله ايله الله اكن",
                                new List<string> { "مڽايڠي كيت", "مماراهي كيت", "منجاءوهكن كيت" },
                                0
                            ),
                            new Question(
                                "كيت منونجوقكن ادب كڤد الله دڠن",
                                new List<string>
                                {
                                    "برشكور اتس نعمة-ڽ",
                                    "مڠابايكن ڤرينته-ڽ",
                                    "ملڠڬر حكوم",
                                },
                                0
                            ),
                            new Question(
                                "كيت هندقله... كڤد اجرن إسلام.",
                                new List<string> { "مڠيكوت", "منولق", "مننتڠ" },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن الله ايله",
                                new List<string>
                                {
                                    "دبنچي دان بردوسا",
                                    "دسايڠي سموا اورڠ",
                                    "داڤت ڤهالا",
                                },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ برادب دڠن الله اكن منداڤت",
                                new List<string> { "ڤهالا دان كبركتن", "كسديهن", "حكومن" },
                                0
                            ),
                            new Question(
                                "ادب دڠن ايبو باڤ برمقصود",
                                new List<string>
                                {
                                    "حرمتي دان طاعتي ايبو باڤ",
                                    "ملاون ايبو باڤ",
                                    "ابايكن مريك",
                                },
                                0
                            ),
                            new Question(
                                "حكوم برادب دڠن ايبو باڤ ايله",
                                new List<string> { "واجب", "هاروس", "سنة" },
                                0
                            ),
                            new Question(
                                "كيت هندقله مندڠر نصيحة",
                                new List<string> { "ايبو باڤ", "كاون", "اورڠ اسيڠ" },
                                0
                            ),
                            new Question(
                                "چونتوه ادب دڠن ايبو باڤ ايله",
                                new List<string>
                                {
                                    "ممبنتو دان مڠحرمتي مريك",
                                    "منيڠڬيكن سوارا",
                                    "منيڠڬلكن رومه",
                                },
                                0
                            ),
                            new Question(
                                "كيت تيدق بوليه... كڤد ايبو باڤ.",
                                new List<string> { "منيڠڬيكن سوارا", "مڽاڤو رومه", "ممبنتو مريك" },
                                0
                            ),
                            new Question(
                                "حكمة برادب دڠن ايبو باڤ ايله",
                                new List<string> { "دكاسيهي الله دان ايبو باڤ", "دحكوم", "دبنچي" },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن ايبو باڤ ايله",
                                new List<string>
                                {
                                    "بردوسا دان دبنچي",
                                    "دكاسيهي اورڠ",
                                    "داڤت ڤهالا",
                                },
                                0
                            ),
                            new Question(
                                "كيت هندقله برچاكڤ دڠن ايبو باڤ دڠن سوارا يڠ",
                                new List<string> { "لمبوت دان سوڤن", "قوات", "كاسر" },
                                0
                            ),
                            new Question(
                                "ايبو باڤ ڤرلو دحرمتي كرنا مريك",
                                new List<string> { "برجاس كڤد كيت", "اورڠ جاءوه", "ڬورو" },
                                0
                            ),
                            new Question(
                                "كيت بوليه بردعاء كڤد الله سوڤاي... ايبو باڤ كيت.",
                                new List<string> { "مڠاسيهي", "مڠحكوم", "منڬور" },
                                0
                            ),
                            new Question(
                                "كلوارڬ ايله",
                                new List<string>
                                {
                                    "اورڠ يڠ تيڠڬل برسام كيت",
                                    "اورڠ اسيڠ",
                                    "كاون سكوله",
                                },
                                0
                            ),
                            new Question(
                                "اهلي كلوارڬ ترديري دريڤد",
                                new List<string>
                                {
                                    "ايبو باڤ دان اديق-براديق",
                                    "اورڠ جاءوه",
                                    "ڬورو",
                                },
                                0
                            ),
                            new Question(
                                "كيت هندقله مڠحرمتي",
                                new List<string> { "اهلي كلوارڬ", "اورڠ تيدق دكنلي", "حيوان" },
                                0
                            ),
                            new Question(
                                "محرم ايله",
                                new List<string> { "اورڠ يڠ حرام دكهويني", "اورڠلوار", "كاون" },
                                0
                            ),
                            new Question(
                                "بوكن محرم ايله",
                                new List<string>
                                {
                                    "اورڠ يڠ بوليه دكهويني",
                                    "اورڠ سبليق",
                                    "اديق كاندوڠ",
                                },
                                0
                            ),
                            new Question(
                                "كيت هندقله برڬاءول دڠن كلوارڬ سچارا",
                                new List<string> { "سوڤن دان حرمت", "كاسر", "بيسيڠ" },
                                0
                            ),
                            new Question(
                                "كيت مستي منولوڠ اهلي كلوارڬ يڠ",
                                new List<string> { "ساكيت", "مالس", "جاهت" },
                                0
                            ),
                            new Question(
                                "كيت هندقله... اڤابيلا برچاكڤ دڠن كلوارڬ.",
                                new List<string>
                                {
                                    "مڠڬوناكن كات يڠ باءيق",
                                    "منيڠڬيكن سوارا",
                                    "كتاوا قوات",
                                },
                                0
                            ),
                            new Question(
                                "اهلي كلوارڬ مستي هيدوڤ دالم كأداءن",
                                new List<string> { "هرموني دان كاسيه سايڠ", "برڬادوه", "برجاءوهن" },
                                0
                            ),
                            new Question(
                                "كڤنتيڠن برادب دڠن كلوارڬ ايله داڤت هيدوڤ",
                                new List<string> { "بهاڬيا دان دسايڠي", "سديه", "بوسن" },
                                0
                            ),
                            new Question(
                                "كيت مستي مڠعملكن ادب سوڤاي",
                                new List<string> { "دكاسيهي الله", "دحكوم", "دبنچي ڬورو" },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن كلوارڬ ايله",
                                new List<string>
                                {
                                    "هيدوڤ تيدق بهاڬيا",
                                    "دكاسيهي سموا اورڠ",
                                    "داڤت ڬنجرن",
                                },
                                0
                            ),
                            new Question(
                                "كيت هندقله مڠحرمتي سموا اهلي كلوارڬ",
                                new List<string>
                                {
                                    "تنڤا مڠيرا عمور",
                                    "يڠ كاي سهاج",
                                    "يڠ مودا سهاج",
                                },
                                0
                            ),
                            new Question(
                                "كلوارڬ يڠ بهاڬيا هيدوڤ دڠن ڤنوه",
                                new List<string>
                                {
                                    "كاسيه سايڠ دان تولول-منولوڠ",
                                    "كماراهن",
                                    "ڤرموسوهن",
                                },
                                0
                            ),
                            new Question(
                                "چارا مروجودكن كلوارڬ بهاڬيا ايله دڠن",
                                new List<string>
                                {
                                    "برتولق انسور دان ساليڠ ممبنتو",
                                    "برڬادوه",
                                    "مڽالهكن",
                                },
                                0
                            ),
                            new Question(
                                "ادب برچاكڤ دڠن كلوارڬ ايله دڠن سوارا يڠ",
                                new List<string> { "لمبوت دان سوڤن", "قوات دان ماره", "كاسر" },
                                0
                            ),
                            new Question(
                                "كيت هندقله منزيارهي",
                                new List<string> { "ساودارا-مارا", "اورڠ جاهت", "اورڠ تيدق دكنلي" },
                                0
                            ),
                            new Question(
                                "كيت مستي برشكور كڤد الله اتس",
                                new List<string> { "نعمة كلوارڬ", "كسديهن", "كماراهن" },
                                0
                            ),
                            new Question(
                                "كيت هندقله سنتياس... ايبو باڤ دان كلوارڬ.",
                                new List<string> { "مندعاءكن مريك", "مماراهي مريك", "منڠكيڠ مريك" },
                                0
                            ),
                            new Question(
                                "كيت مستي طاعة كڤد ڤرينته",
                                new List<string> { "الله دان ايبو باڤ", "كاون", "ڬورو" },
                                0
                            ),
                            new Question(
                                "الله سوك كڤد انق يڠ... كڤد ايبو باڤ.",
                                new List<string> { "ڤاتوه دان طاعة", "درهاك", "ماره" },
                                0
                            ),
                            new Question(
                                "ادب بردعاء كڤد الله ايله دڠن",
                                new List<string> { "رنده ديري دان سوڤن", "كتاوا", "مناڠيس قوات" },
                                0
                            ),
                            new Question(
                                "كيت مستي برايمان دان... كڤد الله.",
                                new List<string> { "برشكور", "ملاون", "ماره" },
                                0
                            ),
                            new Question(
                                "چونتوه تيدق برادب دڠن الله ايله",
                                new List<string> { "منيڠڬلكن صلاة", "برذكر", "بردعاء" },
                                0
                            ),
                            new Question(
                                "كيت هندقله... كڤد اجرن إسلام.",
                                new List<string> { "طاعة", "منولق", "ملاون" },
                                0
                            ),
                            new Question(
                                "الله اكن سايڠ كڤد اورڠ يڠ",
                                new List<string> { "برادب دان ڤاتوه", "درهاك", "لالاي" },
                                0
                            ),
                            new Question(
                                "ادب ايله",
                                new List<string>
                                {
                                    "ڤراڠاي يڠ باءيق دان سوڤن",
                                    "سيقڤ جاهت",
                                    "كرس هاتي",
                                },
                                0
                            ),
                            new Question(
                                "انق يڠ باءيق اكن سنتياس... ايبو باڤ.",
                                new List<string> { "مڠحرمتي", "منڠكيڠ", "ملاون" },
                                0
                            ),
                            new Question(
                                "حكمة برادب دڠن كلوارڬ ايله",
                                new List<string> { "دسايڠي الله دان مأنسي", "دبنچي اورڠ", "دحكوم" },
                                0
                            ),
                            new Question(
                                "الله سوك اورڠ يڠ",
                                new List<string> { "برادب دان سوڤن", "ڤماره", "درهاك" },
                                0
                            ),

                            ///tahapo 2
                        },
                    },
                    //level AKIDAH TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "ملائكة اياله مخلوق الله يڠ دچيڤتا درڤد ...",
                                new List<string> { "اءير", "چهايا", "تانه" },
                                1
                            ),
                            new Question(
                                "ملائكة برصيفت ...",
                                new List<string> { "تيدق ڤرنه ايڠكر", "ڤماره", "تيدور وقتو مالم" },
                                0
                            ),
                            new Question(
                                "ملائكة تيدق ممڤوڽاءي ...",
                                new List<string> { "سايڤ", "جantina", "توڬس" }, // "Jantina" usually "جنتينا"
                                1
                            ),
                            new Question(
                                "توڬس ملائكة ميكائيل اياله ممبري ...",
                                new List<string> { "رزقي", "وحيو", "علمو" },
                                0
                            ),
                            new Question(
                                "ملائكة يڠ منجاڬ شرڬ اياله ...",
                                new List<string> { "مالك", "رضوان", "عتيد" },
                                1
                            ),
                            new Question(
                                "ملائكة منچاتت عملن ماءنسي سوڤايا ...",
                                new List<string>
                                {
                                    "ماءنسي بوليه منيرو",
                                    "دجاديكن ريكود عملن",
                                    "ملائكة بوسن",
                                },
                                1
                            ),
                            new Question(
                                "ملائكة تيدق ماكن دان مينوم كرانا ...",
                                new List<string>
                                {
                                    "مريك مالس",
                                    "مريك درڤد چهايا",
                                    "مريك لاڤر سنتياس",
                                },
                                1
                            ),
                            new Question(
                                "ملائكة عتيد منچاتت ...",
                                new List<string> { "ڤربواتن جاهت", "ڤربواتن باءيق", "رزقي" },
                                0
                            ),
                            new Question(
                                "ملائكة يڠ منيوڤ سڠكاكالا ڤد هاري قيامة اياله ...",
                                new List<string> { "عزرائيل", "إسرافيل", "ميكائيل" },
                                1
                            ),
                            new Question(
                                "مڠاڤ ماءنسي ڤرلو بربوات باءيق؟",
                                new List<string>
                                {
                                    "كرانا دتونتون ملائكة",
                                    "كرانا تاكوتكن ماءنسي",
                                    "كرانا ايڠين سومبوڠ",
                                },
                                0
                            ),
                            new Question(
                                "برايمان كڤد ملائكة منمبهكن ...",
                                new List<string>
                                {
                                    "ايمان دان كطاعتن",
                                    "مالس برعبادة",
                                    "صيفت ماره",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه كتوا سڬالا ملائكة؟",
                                new List<string> { "ميكائيل", "جبريل", "مالك" },
                                1
                            ),
                            new Question(
                                "رسول اياله ماءنسي يڠ ...",
                                new List<string>
                                {
                                    "لاهير د ااستان",
                                    "دأوتوس اوليه الله",
                                    "ساڠت كاي",
                                },
                                1
                            ),
                            new Question(
                                "رسول دڤيليه اوليه ...",
                                new List<string> { "ملائكة", "ماءنسي", "الله" },
                                2
                            ),
                            new Question(
                                "ساله ساتو صيفت واجب رسول اياله ...",
                                new List<string> { "بربوهوڠ", "امانة", "ڤمالس" },
                                1
                            ),
                            new Question(
                                "چونتوه نبي دان رسول يڠ واجب دكتاهوءي اياله ...",
                                new List<string> { "أبو لهب", "نبي نوح", "قارون" },
                                1
                            ),
                            new Question(
                                "رسول ممباوا اجرن ...",
                                new List<string> { "سيحير", "كباءيقن", "تڠكره" },
                                1
                            ),
                            new Question(
                                "مڠاڤ ماءنسي ڤرلو مڠيكوتي اجرن رسول؟",
                                new List<string>
                                {
                                    "سوڤايا هيدوڤ مڠيكوت ڤتونجوق الله",
                                    "اونتوق مرايه ڤوڤولاريتي",
                                    "اونتوق جادي كاي",
                                },
                                0
                            ),
                            new Question(
                                "اجرن رسول مڠاجر ماءنسي سوڤايا ...",
                                new List<string>
                                {
                                    "مڽمبه الله",
                                    "مڽمبه ماتاهاري",
                                    "مڠهينا اورڠ لاءين",
                                },
                                0
                            ),
                            new Question(
                                "رسول مڠاجق ماءنسي كأره ...",
                                new List<string> { "كجاهتن", "كباءيقن", "ڤربالهن" },
                                1
                            ),
                            new Question(
                                "صيفت واجب الله اياله صيفت يڠ ...",
                                new List<string> { "مستحيل", "ڤستي اد ڤد الله", "ميليق ملائكة" },
                                1
                            ),
                            new Question(
                                "صيفت قيامه بنفسه برمقصود ...",
                                new List<string>
                                {
                                    "الله برديري سنديري، تيدق برڬنتوڠ كڤد سسياڤا",
                                    "الله ڤرلوكن مخلوق",
                                    "الله لمه",
                                },
                                0
                            ),
                            new Question(
                                "الله مها مڠتاهوءي دسبوت ...",
                                new List<string> { "علم", "قدرة", "حياة" },
                                0
                            ),
                            new Question(
                                "الله مها بركواس دسبوت ...",
                                new List<string> { "إرادة", "قدرة", "بصر" },
                                1
                            ),
                            new Question(
                                "الله مها هيدوڤ دسبوت ...",
                                new List<string> { "حياة", "سمع", "بصر" },
                                0
                            ),
                            new Question(
                                "الله تيدق سام دڠن مخلوق دسبوت صيفت ...",
                                new List<string> { "بقاء", "مخالفته للحوادث", "قدم" },
                                1
                            ),
                            new Question(
                                "الله برچاكڤ تنڤا سوارا دسبوت ...",
                                new List<string> { "علم", "كلام", "بصر" },
                                1
                            ),
                            new Question(
                                "الله مندڠر سڬالا-ڬالاڽ اياله صيفت ...",
                                new List<string> { "سمع", "بصر", "قيام" },
                                0
                            ),
                            new Question(
                                "الله مليهت سموا ڤركارا اياله صيفت ...",
                                new List<string> { "قدرة", "علم", "بصر" },
                                2
                            ),
                            new Question(
                                "صيفت سلبية اياله صيفت يڠ ...",
                                new List<string> { "منولق ككورڠن", "منمبه ككورڠن", "ميليق مخلوق" },
                                0
                            ),
                            new Question(
                                "چونتوه ڤڠحياتن صيفت الله اياله ...",
                                new List<string> { "منجادي امانة", "منيڤو", "برمالس-مالسن" },
                                0
                            ),
                            new Question(
                                "الله مميليقي صيفت سمڤورنا كرانا ...",
                                new List<string>
                                {
                                    "الله مها بركواس",
                                    "الله سڤرتي مخلوق",
                                    "الله ڤرلوكن بنتوان",
                                },
                                0
                            ),
                            new Question(
                                "صيفت معنوية اياله ...",
                                new List<string>
                                {
                                    "صيفت يڠ ملڠكڤكن صيفت معاني",
                                    "صيفت بيبس توڬس",
                                    "صيفت مخلوق",
                                },
                                0
                            ),
                            new Question(
                                "وجود برمقصود الله ...",
                                new List<string>
                                {
                                    "تيدق وجود",
                                    "وجود تنڤا ڤنچيڤتا",
                                    "وجود سڤرتي ماءنسي",
                                },
                                1
                            ),
                            new Question(
                                "ماءنسي ڤرچاي كڤد وجود الله كرانا ...",
                                new List<string>
                                {
                                    "عالم اين اد ڤنچيڤتا",
                                    "عالم ترجادي سنديري",
                                    "عالم تيدق وجود",
                                },
                                0
                            ),
                            new Question(
                                "قدم برمقصود الله ...",
                                new List<string> { "اد ڤرمولاءن", "تيدق برمولا", "بارو دچيڤتاكن" },
                                1
                            ),
                            new Question(
                                "عالم يڠ تراتور ممبوقتيكن الله ...",
                                new List<string> { "لمه", "قدم دان بركواس", "تياد" },
                                1
                            ),
                            new Question(
                                "بقاء برمقصود الله ...",
                                new List<string> { "ككل", "اكن ماتي", "توا" },
                                0
                            ),
                            new Question(
                                "برايمان بهاوا الله ككل منجاديكن كيت ...",
                                new List<string> { "ڬليسه", "يقين دان تنڠ", "مالس برعبادة" },
                                1
                            ),
                            new Question(
                                "چونتوه ممهامي بقاء اياله ...",
                                new List<string>
                                {
                                    "يقين الله سنتياس اد",
                                    "يقين الله سماكين توا",
                                    "يقين الله ممرلوكن مخلوق",
                                },
                                0
                            ),
                            new Question(
                                "تومبوهن ڤنتيڠ كرانا ...",
                                new List<string>
                                {
                                    "مڠحاصيلكن ماكنن",
                                    "مڽببكن كبولورن",
                                    "منجادي راچون",
                                },
                                0
                            ),
                            new Question(
                                "داون برفوڠسي اونتوق ...",
                                new List<string>
                                {
                                    "منڠكڤ چهايا ماتاهاري",
                                    "مڠلواركن اڤي",
                                    "مڠحاصيلكن باتو",
                                },
                                0
                            ),
                            new Question(
                                "حكمه تومبوهن كڤد ماءنسي اياله ...",
                                new List<string>
                                {
                                    "منجادي تمڤت تيدور",
                                    "مڽدياكن اوكسيجن",
                                    "مڠهالڠ هوجن",
                                },
                                1
                            ),
                            new Question(
                                "الله منچيڤتا تومبوهن سوڤايا ماءنسي ...",
                                new List<string> { "ممبازير", "برشكور", "مڽومبوڠ" },
                                1
                            ),
                            new Question(
                                "بواه-بواهن مڠاندوڠي ...",
                                new List<string> { "ۏيتامين", "باتو", "بسي" },
                                0
                            ),
                            new Question(
                                "أولوا العزم اياله رسول يڠ ...",
                                new List<string> { "ڤوتوس اسا", "ساڠت تابه", "لمه" },
                                1
                            ),
                            new Question(
                                "بيلاڠن رسول أولوا العزم اياله ...",
                                new List<string> { "5", "7", "10" },
                                0
                            ),
                            new Question(
                                "نبي عيسى عليه السلام اياله ساله سأورڠ ...",
                                new List<string> { "أولوا العزم", "صحابة", "ملائكة" },
                                0
                            ),
                            new Question(
                                "نبي إبراهيم دڬلر أولوا العزم كرانا ...",
                                new List<string>
                                {
                                    "سوك ماره",
                                    "صبر دان كوات مڠهادڤي اوجين",
                                    "تيدق بردعوه",
                                },
                                1
                            ),
                            new Question(
                                "چونتوه منلادني أولوا العزم اياله ...",
                                new List<string>
                                {
                                    "موده ڤوتوس اسا",
                                    "صبر مڠهادڤي چابرن",
                                    "سوك برتڠكر",
                                },
                                1
                            ),
                        },
                    },
                    //level IBADAH TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود وضوء؟",
                                new List<string>
                                {
                                    "مڽوچيكن ديري دڠن دبو",
                                    "مڽوچيكن اڠڬوتا ترتنتو دڠن اءير",
                                    "مڠهيلڠكن نجيس",
                                },
                                1
                            ),
                            new Question(
                                "تيمم دلاكوكن اڤابيلا ...",
                                new List<string>
                                {
                                    "مالس بروضوء",
                                    "تياد اءير اتاو مضرت ڬونا اءير",
                                    "اءير جاءوه",
                                },
                                1
                            ),
                            new Question(
                                "اڠڬوتا وضوء بريكوت اداله بتول كچوالي ...",
                                new List<string> { "موک", "كڤالا", "ڤروت" },
                                2
                            ),
                            new Question(
                                "اڠڬوتا تيمم اياله ..",
                                new List<string>
                                {
                                    "موک دان تاڠن",
                                    "كڤالا دان كاكي",
                                    "تاڠن دان كاكي",
                                },
                                0
                            ),
                            new Question(
                                "ڤركارا يڠ ممبطلكن وضوء اياله ...",
                                new List<string>
                                {
                                    "برجالن",
                                    "كلوار سسواتو درڤد قبل/دوبور",
                                    "مينوم اءير",
                                },
                                1
                            ),
                            new Question(
                                "ڤركارا يڠ ممبطلكن تيمم اياله ...",
                                new List<string> { "دودوق", "مندافت اءير", "برنفس" },
                                1
                            ),
                            new Question(
                                "نجيس برت دسوچيكن دڠن ...",
                                new List<string>
                                {
                                    "اءير سهاج",
                                    "توجوه باسوهن ترماسوق تانه",
                                    "لڤ تيڬ كالي",
                                },
                                1
                            ),
                            new Question(
                                "نجيس ريڠن اياله ...",
                                new List<string>
                                {
                                    "داره",
                                    "ارق",
                                    "اءير كنچيڠ بايي للاكي بلوم ماكن ماكنن ڤجل",
                                },
                                2
                            ),
                            new Question(
                                "نجيس ڤرتڠهن دسوچيكن دڠن ...",
                                new List<string>
                                {
                                    "باسوه هيڠڬ هيلڠ باو دان ورنا",
                                    "لڤ تيڬ كالي",
                                    "باسوه توجوه كالي",
                                },
                                0
                            ),
                            new Question(
                                "استنجاء برمقصود ...",
                                new List<string>
                                {
                                    "ممبرسيه حدث بسر",
                                    "ممبرسيه قبل دان دوبور",
                                    "مندي واجب",
                                },
                                1
                            ),
                            new Question(
                                "حكم استنجاء اياله ..",
                                new List<string> { "سنة", "هاروس", "واجب" },
                                2
                            ),
                            new Question(
                                "الت كست بريكوت بوليه دڬوناكن اونتوق استنجاء كچوالي ...",
                                new List<string> { "باتو سوچي", "تيسو", "كاءين برنجيس" },
                                2
                            ),
                            new Question(
                                "مينيموم لڤ باڬي استنجاء الت كست اداله ...",
                                new List<string> { "1 كالي", "3 كالي", "7 كالي" },
                                1
                            ),
                            new Question(
                                "نجيس ريڠن دسوچيكن دڠن ...",
                                new List<string>
                                {
                                    "باسوه توجوه كالي",
                                    "ڤرچيقن اءير",
                                    "لڤ تيڬ كالي",
                                },
                                1
                            ),
                            new Question(
                                "حكمه بروضوء اياله.",
                                new List<string>
                                {
                                    "مڠهيلڠكن مڠنتوق",
                                    "مڽوچيكن جيوا",
                                    "ملامبتكن صلاة",
                                },
                                1
                            ),
                            new Question(
                                "أذان برمقصود ...",
                                new List<string> { "ڤڠڬيلن صلاة", "ڤريڠاتن ماكن", "سروان تيدور" },
                                0
                            ),
                            new Question(
                                "إقامة برمقصود",
                                new List<string>
                                {
                                    "سروان منديريكن صلاة",
                                    "ڤڠڬيلن ماكن",
                                    "سروان برذكر",
                                },
                                0
                            ),
                            new Question(
                                "حكمه أذان اياله ...",
                                new List<string>
                                {
                                    "مڽرو ماءنسي ماءين",
                                    "مڽمڤاءيكن شعار إسلام",
                                    "مڠهالڠ عبادة",
                                },
                                1
                            ),
                            new Question(
                                "وضوء تيدق صح جك ...",
                                new List<string> { "تيدق ترتيب", "باڽق برچاكڤ", "دودوق" },
                                0
                            ),
                            new Question(
                                "تيمم دلاكوكن مڠڬوناكن ...",
                                new List<string> { "اءير", "دبو سوچي", "رومڤوت" },
                                1
                            ),
                            new Question(
                                "روكون وضوء ڤرتام اياله",
                                new List<string> { "ممباسوه كاكي", "ممباسوه تاڠن", "نية" },
                                2
                            ),
                            new Question(
                                "روكون تيمم ڤرتام اياله",
                                new List<string> { "منڤوق دبو", "نية", "منچوچي موک" },
                                1
                            ),
                            new Question(
                                "نجيس برت چونتوهڽ ...",
                                new List<string> { "ايم", "ايكن", "انجيڠ" },
                                2
                            ),
                            new Question(
                                "چارا مڽوچيكن نجيس ڤرتڠهن اياله ...",
                                new List<string>
                                {
                                    "باسوه هيڠڬ هيلڠ صيفت نجيس",
                                    "لڤ تيڬ كالي",
                                    "تانه + اءير",
                                },
                                0
                            ),
                            new Question(
                                "اءير مستعمل اياله",
                                new List<string>
                                {
                                    "اءير مطلق",
                                    "اءير دڬوناكن ڤد اڠڬوتا وضوء",
                                    "اءير هوجن",
                                },
                                1
                            ),
                            new Question(
                                "اءير مطلق بوليه دڬوناكن اونتوق ...",
                                new List<string> { "مينوم سهاج", "برسوچي", "مماسق سهاج" },
                                1
                            ),
                            new Question(
                                "استنجاء تيدق صح جك مڠڬوناكن ...",
                                new List<string> { "تيسو", "باتو سوچي", "بندا تاجم" },
                                2
                            ),
                            new Question(
                                "حكمه استنجاء اياله ...",
                                new List<string>
                                {
                                    "ممبازير اءير",
                                    "مڠيلقكن باو تيدق انق",
                                    "ملامبتكن مندي",
                                },
                                1
                            ),
                            new Question(
                                "أذان دشريعتكن اونتوق ...",
                                new List<string>
                                {
                                    "مڠاجق ماكن",
                                    "ممبريتاهو ماسوق وقتو صلاة",
                                    "منندا ڤراياءن",
                                },
                                1
                            ),
                            new Question(
                                "لفظ أذان برمولا دڠن ...",
                                new List<string> { "الله أكبر", "الحمدلله", "سبحان الله" },
                                0
                            ),
                            new Question(
                                "بروضوء داڤت.",
                                new List<string>
                                {
                                    "مننڠكن هاتي",
                                    "مڠهيلڠكن ڤلوه",
                                    "مورناكن كوليت",
                                },
                                0
                            ),
                            new Question(
                                "تيمم تيدق صح تنڤا ..",
                                new List<string> { "نية", "دبو", "لاڤيق" },
                                0
                            ),
                            new Question(
                                "نجيس مخففة اياله ...",
                                new List<string>
                                {
                                    "اءير كنچيڠ بايي للاكي",
                                    "نجيس ماءنسي ديواسا",
                                    "اءير ليور انجيڠ",
                                },
                                0
                            ),
                            new Question(
                                "تانه دڬوناكن اونتوق مڽوچيكن ...",
                                new List<string> { "نجيس ريڠن", "نجيس برت", "نجيس ڤرتڠهن" },
                                1
                            ),
                            new Question(
                                "روكون وضوء يڠ واجب اداله.",
                                new List<string> { "تيتيق اءير", "ممباسوه موک", "مڠريڠكن اڠڬوتا" },
                                1
                            ),
                            new Question(
                                "روكون تيمم اياله ..",
                                new List<string> { "مندي", "مڽاڤو موک دان تاڠن", "مڽيرم اءير" },
                                1
                            ),
                            new Question(
                                "چونتوه نجيس ڤرتڠهن اياله ...",
                                new List<string> { "اءير كنچيڠ", "اءير مطلق", "دبو سوچي" },
                                0
                            ),
                            new Question(
                                "اءير متنجس اياله",
                                new List<string>
                                {
                                    "اءير دچمڤور صابون",
                                    "اءير تركنا نجيس",
                                    "اءير ماسق",
                                },
                                1
                            ),
                            new Question(
                                "استنجاء واجب اڤابيلا",
                                new List<string>
                                {
                                    "سلڤس ماكن",
                                    "كلوار نجيس كچيل اتاو بسر",
                                    "سلڤس صلاة",
                                },
                                1
                            ),
                            new Question(
                                "أذان دان إقامة منونجوقكن ...",
                                new List<string>
                                {
                                    "شعار إسلام",
                                    "ڤرماءينن تراديسي",
                                    "اوڤچارا عادة",
                                },
                                0
                            ),
                            new Question(
                                "حكمه تيمم اياله.",
                                new List<string>
                                {
                                    "منجيمتكن ماس",
                                    "ممودهكن عبادة دالم كسوكرن",
                                    "مڠيلقكن وضوء",
                                },
                                1
                            ),
                            new Question(
                                "اءير مطلق ترماسوق",
                                new List<string> { "اءير سوڠاي", "ميڽق", "تيه" },
                                0
                            ),
                            new Question(
                                "مڽاڤو كڤالا اداله ...",
                                new List<string> { "سنة وضوء", "روكون وضوء", "مكروه وضوء" },
                                1
                            ),
                            new Question(
                                "تيمم دلاكوكن ڤد",
                                new List<string> { "ڤاكاين", "موک دان تاڠن", "كاكي دان ڤروت" },
                                1
                            ),
                            new Question(
                                "نجيس مغلظة اياله",
                                new List<string> { "داره", "كنچيڠ بايي", "بابي" },
                                2
                            ),
                            new Question(
                                "اءير كنچيڠ بايي ڤرمڤوان دسوچيكن دڠن ...",
                                new List<string> { "باسوهن بياسا", "ڤرچيقن", "توجوه باسوهن" },
                                0
                            ),
                            new Question(
                                "إقامة دلفظكن ...",
                                new List<string> { "سكالي سهاري", "سبلوم صلاة فرض", "سلڤس تيدور" },
                                1
                            ),
                            new Question(
                                "أذان دكومندڠكن اوليه ...",
                                new List<string> { "امام", "بلال", "خطيب" },
                                1
                            ),
                            new Question(
                                "حكمه نجيس دسوچيكن اياله ...",
                                new List<string>
                                {
                                    "مڠيلقكن ڤڽاكيت",
                                    "مڠهيلڠكن ڤهالا",
                                    "منمبه ببن",
                                },
                                0
                            ),
                            new Question(
                                "تيمم برمولا دڠن ...",
                                new List<string> { "مڽاڤو تاڠن", "نية", "منڤوق دبو دوا كالي" },
                                1
                            ),
                        },
                    },
                    //level SIRAH TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "سياڤاكه ايبو سوسوان نبي محمد؟",
                                new List<string> { "حليمة السعدية", "آمنة", "فاطمة" },
                                0
                            ),
                            new Question(
                                "نبي محمد ددوسوكن د ڤركامڤوڠن؟",
                                new List<string> { "بني سعد", "بني تميم", "بني عباس" },
                                0
                            ),
                            new Question(
                                "سياڤاكه ايبو كاندوڠ نبي محمد؟",
                                new List<string> { "حليمة", "آمنة", "خديجة" },
                                1
                            ),
                            new Question(
                                "اڤاكه توجوان نبي محمد دباوا منزيارهي ڤوسارا ايهندا؟",
                                new List<string>
                                {
                                    "ملاوت كلوارڬ",
                                    "مڠوكوهكن صلة الرحيم",
                                    "مڠنڠ ايهنداڽ",
                                },
                                2
                            ),
                            new Question(
                                "د ماناكه ترلتقڽ ڤوسارا ايهندا نبي؟",
                                new List<string> { "مدينة", "مكة", "طائف" },
                                0
                            ),
                            new Question(
                                "سياڤاكه يڠ وفت كتيك نبي بروسيا 6 تاهون؟",
                                new List<string> { "آمنة", "عبد المطلب", "أبو طالب" },
                                0
                            ),
                            new Question(
                                "سلڤس كوفاتن ايبو، نبي دجاڬ اوليه؟",
                                new List<string> { "داتوقڽ", "ڤاقچيقڽ", "جيرنڽ" },
                                0
                            ),
                            new Question(
                                "نام داتوق نبي محمد اياله؟",
                                new List<string> { "عبدالله", "عبد المطلب", "أبو طالب" },
                                1
                            ),
                            new Question(
                                "أبو طالب اياله؟",
                                new List<string> { "باڤ ساودارا نبي", "ڬورو نبي", "صحابة نبي" },
                                0
                            ),
                            new Question(
                                "أبو طالب منجاڬ نبي دڠن ڤنوه؟",
                                new List<string> { "ماره", "كاسيه سايڠ", "ڤقساءن" },
                                1
                            ),
                            new Question(
                                "ڬلرن نبي محمد سبلوم منجادي رسول اياله؟",
                                new List<string> { "الأمين", "المختار", "الحكيم" },
                                0
                            ),
                            new Question(
                                "ڬلرن الأمين برمقصود؟",
                                new List<string> { "بيجقسان", "ترڤوجي", "دڤرچاياءي" },
                                2
                            ),
                            new Question(
                                "مڠاڤ نبي دڬلر الأمين؟",
                                new List<string>
                                {
                                    "سوك برڬوراو",
                                    "سنتياس برچاكڤ بنر",
                                    "سوك برماءين",
                                },
                                1
                            ),
                            new Question(
                                "ڤريستيوا مڠاڠكت حجر الأسود برلاكو كتيك عمور نبي؟",
                                new List<string> { "15 تاهون", "25 تاهون", "35 تاهون" },
                                2
                            ),
                            new Question(
                                "سياڤاكه يڠ منچادڠكن ڤڽلساين ڤرتيكاين حجر الأسود؟",
                                new List<string> { "نبي محمد", "أبو طالب", "عبد المطلب" },
                                0
                            ),
                            new Question(
                                "مڠاڠكت حجر الأسود منونجوقكن نبي سأورڠ يڠ؟",
                                new List<string> { "ڤناكوت", "عاديل", "لالاي" },
                                1
                            ),
                            new Question(
                                "ڤكرجاءن نبي سماس كچيل اياله؟",
                                new List<string> { "ڤتاني", "ڤڠمبالا كمبيڠ", "نلاين" },
                                1
                            ),
                            new Question(
                                "مڠمبالا كمبيڠ مڠاجر نبي صيفت؟",
                                new List<string> { "صبر", "ماره", "لالاي" },
                                0
                            ),
                            new Question(
                                "نبي برنياڬ ك شام برسام؟",
                                new List<string> { "أبو طالب", "عبد المطلب", "أبو بكر" },
                                0
                            ),
                            new Question(
                                "برنياڬ ك شام مڠاجر نبي اونتوق؟",
                                new List<string> { "برماءين", "منيڤو", "برديكاري" },
                                2
                            ),
                            new Question(
                                "صيفت واجب رسول يڠ برمقصود بنر اياله؟",
                                new List<string> { "أمانة", "فطانة", "صدق" },
                                2
                            ),
                            new Question(
                                "صيفت أمانة برمقصود؟",
                                new List<string> { "بوليه دڤرچاياءي", "چرديق", "مڽمڤاءيكن" },
                                0
                            ),
                            new Question(
                                "صيفت تبليغ برمقصود؟",
                                new List<string> { "مڽمڤاءيكن", "مڽمبوڽيكن", "مڠحكوم" },
                                0
                            ),
                            new Question(
                                "صيفت فطانة برمقصود؟",
                                new List<string> { "بيجقسان", "ڤماره", "لالاي" },
                                0
                            ),
                            new Question(
                                "سياڤاكه چونتوه ترباءيق صيفت صدق؟",
                                new List<string> { "نبي محمد", "أبو لهب", "أبو جهل" },
                                0
                            ),
                            new Question(
                                "مڠاڤ رسول واجب برصيفت بنر؟",
                                new List<string>
                                {
                                    "اونتوق كسرونوقن",
                                    "اونتوق دسانجوڠ ماءنسي",
                                    "سوڤايا اومت ڤرچاي اجرن بڬيندا",
                                },
                                2
                            ),
                            new Question(
                                "رسول الله سنتياس أمانة كرانا؟",
                                new List<string> { "ماهو ككاياءن", "طاعة كڤد الله", "ماهو ڤوجين" },
                                1
                            ),
                            new Question(
                                "تبليغ منونجوقكن رسول الله سنتياس؟",
                                new List<string> { "مڽمڤاءيكن وحيو", "ديام", "مڽمبوڽيكن اجرن" },
                                0
                            ),
                            new Question(
                                "فطانة دڤرلوكن سوڤايا رسول داڤت؟",
                                new List<string> { "برماءين", "مڽلسايكن مسئله", "منيڤو" },
                                1
                            ),
                            new Question(
                                "چونتوه صيفت أمانة نبي اياله؟",
                                new List<string>
                                {
                                    "منجاڬ بارڠ اورڠ مكة",
                                    "منيڤو دالم برنياڬ",
                                    "برمالس-مالسن",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه يڠ منجاڬ نبي سلڤس داتوقڽ وفت؟",
                                new List<string> { "أبو طالب", "أبو بكر", "عمر" },
                                0
                            ),
                            new Question(
                                "كيصه مڠاڠكت حجر الأسود برلاكو د؟",
                                new List<string> { "كعبة", "بوكيت صفا", "ڬوا حراء" },
                                0
                            ),
                            new Question(
                                "مڠاڤ سوكو-سوكو قريش برڬادوه كتيك ممبينا كعبة؟",
                                new List<string>
                                {
                                    "تيدق چوكوڤ باتو",
                                    "ماهو ملتقكن حجر الأسود",
                                    "تيدق سوك كعبة",
                                },
                                1
                            ),
                            new Question(
                                "ڤڽلساين نبي منونجوقكن صيفت؟",
                                new List<string> { "عاديل", "ماره", "لالاي" },
                                0
                            ),
                            new Question(
                                "مڠاڤ نبي دهانتر ك كامڤوڠ بني سعد؟",
                                new List<string>
                                {
                                    "اودارا سڬر دان باءيق اونتوق ممبسر",
                                    "باڽق ڤرماءينن",
                                    "راماي ڤداڬڠ",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه ابڠ سوسوان نبي؟",
                                new List<string> { "علي", "حمزة", "أبو طالب" },
                                1
                            ),
                            new Question(
                                "آمنة وفت د؟",
                                new List<string> { "أبواء", "مدينة", "مكة" },
                                0
                            ),
                            new Question(
                                "عبد المطلب اياله؟",
                                new List<string> { "داتوق نبي", "انق نبي", "مننتو نبي" },
                                0
                            ),
                            new Question(
                                "صيفت صدق داڤت دليهت اڤابيلا نبي سنتياس؟",
                                new List<string> { "بربوهوڠ", "برچاكڤ بنر", "مڽمبوڽيكن كبنرن" },
                                1
                            ),
                            new Question(
                                "أمانة داڤت دليهت كتيك نبي؟",
                                new List<string>
                                {
                                    "منجاڬ بارڠ اورڠ",
                                    "ممچهكن بارڠ",
                                    "مڠهيلڠكن بارڠ",
                                },
                                0
                            ),
                            new Question(
                                "تبليغ داڤت دليهت كتيك نبي؟",
                                new List<string> { "مڽمڤاءيكن وحيو", "برديام ديري", "تيدق مڠاجر" },
                                0
                            ),
                            new Question(
                                "فطانة داڤت دليهت كتيك نبي؟",
                                new List<string>
                                {
                                    "مڽلسايكن ڤرتيكاين",
                                    "برماءين سهاج",
                                    "مڠات اورڠ",
                                },
                                0
                            ),
                            new Question(
                                "برنياڬ د شام منونجوقكن نبي سأورڠ يڠ؟",
                                new List<string> { "ڤنيڤو", "راجين", "مالس" },
                                1
                            ),
                            new Question(
                                "ڤكرجاءن مڠمبالا كمبيڠ منجاديكن نبي لبيه؟",
                                new List<string> { "لالاي", "برتڠڬوڠجواب", "ڤماره" },
                                1
                            ),
                            new Question(
                                "ڬلرن الأمين دبري اوليه؟",
                                new List<string> { "ڤوترا روم", "اورڠ قريش", "اورڠ يهودي" },
                                1
                            ),
                            new Question(
                                "مڠاڤ صيفت واجب رسول ڤنتيڠ؟",
                                new List<string>
                                {
                                    "اونتوق مميكت ماءنسي",
                                    "اونتوق منجاديكن دعوه دتريما",
                                    "اونتوق هيبورن",
                                },
                                1
                            ),
                            new Question(
                                "صيفت صدق لاونڽ اياله؟",
                                new List<string> { "بوهوڠ", "أمانة", "راجين" },
                                0
                            ),
                            new Question(
                                "صيفت أمانة لاونڽ اياله؟",
                                new List<string> { "چورڠ", "بيجقسان", "براني" },
                                0
                            ),
                            new Question(
                                "صيفت تبليغ لاونڽ اياله؟",
                                new List<string> { "مڽمڤاءيكن", "مڽمبوڽيكن", "منجوال" },
                                1
                            ),
                            new Question(
                                "صيفت فطانة لاونڽ اياله؟",
                                new List<string> { "چرديق", "بودوه", "جوجور" },
                                1
                            ),
                        },
                    },
                    //level ADAB TAHAP 2
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "مقصود ادب دڠن رسول الله اياله ...",
                                new List<string>
                                {
                                    "مڠيكوت ڤرينته ڬورو",
                                    "مڠحرمتي دان ممولياكن بڬيندا",
                                    "مڠيكوتي راكن-راكن",
                                },
                                1
                            ),
                            new Question(
                                "حكم برادب دڠن رسول الله اياله ...",
                                new List<string> { "هاروس", "مكروه", "واجب" },
                                2
                            ),
                            new Question(
                                "انتارا بريكوت، يڠ ماناكه ترماسوق ادب دڠن رسول الله؟",
                                new List<string>
                                {
                                    "مڠهينا سنة",
                                    "مڠيكوتي اجرن بڬيندا",
                                    "ملوڤاكن سجاره نبي",
                                },
                                1
                            ),
                            new Question(
                                "اخلاق رسول الله كتيك برصحابت اياله ...",
                                new List<string>
                                {
                                    "سوك برموسوه",
                                    "مڽاكيتي صحابت",
                                    "بربوات باءيق كڤد صحابت",
                                },
                                2
                            ),
                            new Question(
                                "اخلاق رسول الله كتيك برچاكڤ اياله ...",
                                new List<string> { "منجريت", "بركات بنر دان لمه لمبوت", "بربوهوڠ" },
                                1
                            ),
                            new Question(
                                "انتارا بريكوت، يڠ ماناكه اخلاق نبي كتيك برسوكن؟",
                                new List<string>
                                {
                                    "مڽوسهكن اورڠ لاءين",
                                    "منيڤو اونتوق منڠ",
                                    "برسوكن دڠن عاديل",
                                },
                                2
                            ),
                            new Question(
                                "اخلاق رسول الله كتيك برڤاكاين اياله ...",
                                new List<string>
                                {
                                    "سومبوڠ",
                                    "مميله ڤاكاين يڠ برسيه",
                                    "منيرو ڤاكاين دلارڠ",
                                },
                                1
                            ),
                            new Question(
                                "مڠحرمتي رسول الله منداثڠكن ...",
                                new List<string> { "دوسا", "حكمه دان كبركتن", "كمارهن" },
                                1
                            ),
                            new Question(
                                "كيصه ثابت بن قيس ممبري ڤڠاجرن سوڤايا ...",
                                new List<string>
                                {
                                    "برسوارا كوات",
                                    "مرندهكن سوارا",
                                    "تيدق برچاكڤ دڠن نبي",
                                },
                                1
                            ),
                            new Question(
                                "مڠيكوت ادب رسول الله ممباوا كڤد ...",
                                new List<string>
                                {
                                    "هيدوڤ لبيه تراتور",
                                    "هيدوڤ برمسئله",
                                    "هيدوڤ كلم كابوت",
                                },
                                0
                            ),
                            // Fasal 2 - Adab Tidur
                            new Question(
                                "ادب سبلوم تيدور اياله ...",
                                new List<string>
                                {
                                    "برلاري",
                                    "ممباچ دعاء",
                                    "منونتون تي.ۏي. هيڠڬ ليوت مالم",
                                },
                                1
                            ),
                            new Question(
                                "ادب سلڤس باڠون تيدور اياله ...",
                                new List<string>
                                {
                                    "تروس ماكن",
                                    "ممباچ دعاء باڠون تيدور",
                                    "تيدور سمولا",
                                },
                                1
                            ),
                            new Question(
                                "مڠعملكن ادب تيدور داڤت ...",
                                new List<string>
                                {
                                    "ممباوا كبركتن",
                                    "مڽوسهكن",
                                    "منجاديكن تيدور تيدق لينا",
                                },
                                0
                            ),
                            new Question(
                                "تيدق مڠعملكن ادب تيدور بوليه مڽببكن ...",
                                new List<string> { "بادن سڬر", "موده لالاي", "لبيه برديسيڤلين" },
                                1
                            ),
                            new Question(
                                "سنة بروضوء سبلوم تيدور سوڤايا ...",
                                new List<string>
                                {
                                    "چڤت لاڤر",
                                    "دسكاءي كاون",
                                    "مندافت ڤرليندوڠن الله",
                                },
                                2
                            ),
                            new Question(
                                "مڽوسون تمڤت تيدور منونجوقكن سيكڤ ...",
                                new List<string> { "مالس", "راجين دان برديسيڤلين", "سومبوڠ" },
                                1
                            ),
                            new Question(
                                "دعاء سبلوم تيدور اياله ...",
                                new List<string>
                                {
                                    "بسم الله",
                                    "الحمدلله",
                                    "باسمك اللهم أموت وأحيا",
                                },
                                2
                            ),
                            // Fasal 3 - Adab Menunaikan Hajat
                            new Question(
                                "ادب ماسوق تاندس اياله ...",
                                new List<string>
                                {
                                    "ماسوق دڠن كاكي كانن",
                                    "ماسوق سمبيل بربوال",
                                    "ماسوق دڠن كاكي كيري",
                                },
                                2
                            ),
                            new Question(
                                "دعاء ماسوق تاندس دباچ سوڤايا ...",
                                new List<string>
                                {
                                    "مندافت كبرسيهن",
                                    "دجاءوهكن درڤد ڬڠڬوان شيطان",
                                    "مڠهيلڠكن مڠنتوق",
                                },
                                1
                            ),
                            new Question(
                                "ادب كلوار تاندس اياله ...",
                                new List<string>
                                {
                                    "ملڠكه دڠن كاكي كانن",
                                    "تيدق ممباچ دعاء",
                                    "مڠوتوركن تاندس",
                                },
                                0
                            ),
                            new Question(
                                "ادب مندي ترماسوق ...",
                                new List<string>
                                {
                                    "ممبازير اءير",
                                    "مڽيرم سلوروه بادن",
                                    "برماءين اءير",
                                },
                                1
                            ),
                            new Question(
                                "قضاء حاجت برمقصود ...",
                                new List<string> { "مندي", "بواڠ اءير كچيل/اءير بسر", "تيدور" },
                                1
                            ),
                            new Question(
                                "كتيك قضاء حاجت، كيت تيدق بوليه ...",
                                new List<string> { "مڠهادڤ قبلة", "ديام", "ممبرسيهكن ديري" },
                                0
                            ),
                            new Question(
                                "مڠعملكن ادب تاندس ممبري ...",
                                new List<string> { "كمضرتن", "كباءيقن دان كصيحتن", "مسئله" },
                                1
                            ),
                            new Question(
                                "تيدق منجاڬ ادب تاندس بوليه مڽببكن ...",
                                new List<string> { "تاندس برسيه", "ڤڽاكيت", "بادن صيحت" },
                                1
                            ),
                            // Fasal 4 - Adab Berpakaian
                            new Question(
                                "عورة برمقصود ...",
                                new List<string>
                                {
                                    "تمڤت برماءين",
                                    "اڠڬوتا يڠ واجب دتوتوڤ",
                                    "تمڤت بلاجر",
                                },
                                1
                            ),
                            new Question(
                                "عورة للاكي انتارا ...",
                                new List<string>
                                {
                                    "ڤوست هيڠڬ لوتوت",
                                    "كڤالا هيڠڬ كاكي",
                                    "تاڠن هيڠڬ دادا",
                                },
                                0
                            ),
                            new Question(
                                "ساله ساتو چيري ڤاكاين منوتوڤ عورة اياله ...",
                                new List<string> { "نيڤيس", "كتت", "تيدق منمڤقكن بنتوق توبوه" },
                                2
                            ),
                            new Question(
                                "ادب مماكاي ڤاكاين اياله ...",
                                new List<string>
                                {
                                    "مماكاي دري كيري",
                                    "مماكاي دري كانن",
                                    "مماكاي ڤاكاين كويق",
                                },
                                1
                            ),
                            new Question(
                                "مڠعملكن ادب برڤاكاين منونجوقكن كيت ...",
                                new List<string> { "سومبوڠ", "تيدق ڤدولي", "منجاڬ مروه ديري" },
                                2
                            ),
                            new Question(
                                "تيدق منجاڬ ادب برڤاكاين بوليه مڽببكن ...",
                                new List<string> { "دڤندڠ بوروق", "دڤوجي", "دسكاءي راماي" },
                                0
                            ),
                            // Fasal 5 - Adab Makan dan Minum
                            new Question(
                                "ادب سبلوم ماكن اياله ...",
                                new List<string> { "ممباسوه تاڠن", "برماءين", "تيدور" },
                                0
                            ),
                            new Question(
                                "ادب سماس ماكن اياله ...",
                                new List<string>
                                {
                                    "مڽليتكن تاڠن كيري",
                                    "ماكن دڠن تاڠن كانن",
                                    "مڠوڽه كوات",
                                },
                                1
                            ),
                            new Question(
                                "سلڤس ماكن كيت دڬالقكن ...",
                                new List<string> { "ممباسوه ڤيڠڬن", "منجريت", "ممبواڠ ماكنن" },
                                0
                            ),
                            new Question(
                                "ادب مينوم اياله ...",
                                new List<string>
                                {
                                    "مينوم سمبيل برديري",
                                    "مينوم دڠن تاڠن كانن",
                                    "مينوم سمبيل برچاكڤ",
                                },
                                1
                            ),
                            new Question(
                                "كلبيهن مڠعملكن ادب ماكن اياله ...",
                                new List<string>
                                {
                                    "ماكنن منجادي بوسوق",
                                    "مندافت ڤهالا",
                                    "تيدق كڽڠ",
                                },
                                1
                            ),
                            new Question(
                                "عاقبة تيدق برادب كتيك ماكن اياله ...",
                                new List<string> { "دسكاءي ڬورو", "ترچكيق", "لبيه سوڤن" },
                                1
                            ),
                            new Question(
                                "ممباچ دعاء سبلوم ماكن منونجوقكن صيفت ...",
                                new List<string> { "شكور", "سومبوڠ", "مالس" },
                                0
                            ),
                            // Fasal 6 - Adab Masuk dan Keluar Rumah
                            new Question(
                                "ادب ماسوق رومه اياله ...",
                                new List<string> { "منجريت", "ممبري سلام", "منندڠ ڤينتو" },
                                1
                            ),
                            new Question(
                                "ادب كلوار رومه اياله ...",
                                new List<string>
                                {
                                    "ممباچ دعاء كلوار رومه",
                                    "مڽاڽي",
                                    "ممبواڠ سمڤه",
                                },
                                0
                            ),
                            new Question(
                                "مڠعملكن ادب ماسوق رومه ممباوا ...",
                                new List<string> { "مسئله", "كسلامتن", "كمارهن" },
                                1
                            ),
                            new Question(
                                "تيدق مڠعملكن ادب كلوار رومه بوليه مڠعاقبتكن ...",
                                new List<string>
                                {
                                    "دلليندوڠي الله",
                                    "هيلڠ كسلامتن",
                                    "مندافت ڤهالا",
                                },
                                1
                            ),
                            new Question(
                                "ساله ساتو ادب دالم رومه اياله ...",
                                new List<string>
                                {
                                    "مڽوسهكن اهلي كلوارڬ",
                                    "مڠحرمتي ايبو باڤ",
                                    "مميجيق بارڠ",
                                },
                                1
                            ),
                            // Fasal 7 - Adab Menaiki Kenderaan
                            new Question(
                                "ادب مناءيقي كندراءن اياله ...",
                                new List<string> { "تولق-منولق", "براتور دڠن سوڤن", "منجريت" },
                                1
                            ),
                            new Question(
                                "دعاء مناءيقي كندراءن دباچ اونتوق ...",
                                new List<string>
                                {
                                    "مندافت هيبورن",
                                    "كسلامتن دالم ڤرجلانن",
                                    "ممبواڠ ماس",
                                },
                                1
                            ),
                            new Question(
                                "ادب مڠڬوناكن كندراءن عوام اياله ...",
                                new List<string> { "مڠڬڠڬو ڤنومڤڠ", "دودوق سوڤن", "مڽاڽي كوات" },
                                1
                            ),
                            new Question(
                                "كلبيهن مڠعملكن ادب كندراءن اياله ...",
                                new List<string> { "ڤرجلانن سلامت", "كندراءن روسق", "ڤنومڤڠ ماره" },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب د دالم كندراءن ...",
                                new List<string>
                                {
                                    "دسكاءي سموا اورڠ",
                                    "ممبهاياكن ديري دان اورڠ لاءين",
                                    "سلامت سنتياس",
                                },
                                1
                            ),
                            new Question(
                                "منجاڬ كبرسيهن كندراءن عوام اياله ...",
                                new List<string>
                                {
                                    "ادب يڠ باءيق",
                                    "تيدق ڤنتيڠ",
                                    "ملامبتكن ڤرجلانن",
                                },
                                0
                            ),
                            new Question(
                                "دودوق دڠن سوڤن كتيك مناءيقي كندراءن منونجوقكن ...",
                                new List<string> { "اخلاق موليا", "سيكڤ بوروق", "صيفت ماره" },
                                0
                            ),
                        },
                    },
                    //LEVEL AKIDAH TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه توجوان الله منورونكن كتاب٢-ڽ؟",
                                new List<string>
                                {
                                    "اونتوق ڤتونجوق ماءنسي",
                                    "اونتوق هياسن رومه",
                                    "اونتوق دجوال",
                                },
                                0
                            ),
                            new Question(
                                "كتاب زبور دتورونكن كڤد نبي؟",
                                new List<string> { "نبي يونس", "نبي داود", "نبي آدم" },
                                1
                            ),
                            new Question(
                                "كتاب إنجيل مروڤاكن كتاب باڬي اومت؟",
                                new List<string> { "نبي موسى", "نبي عيسى", "نبي هود" },
                                1
                            ),
                            new Question(
                                "اڤاكه كتاب ڤرتام سبلوم القرءان؟",
                                new List<string> { "زبور", "توراة", "إنجيل" },
                                1
                            ),
                            new Question(
                                "مڠاڤ القرءان دسبوت معجزة تربسر؟",
                                new List<string>
                                {
                                    "بهاساڽ اينده",
                                    "تيدق بروبه",
                                    "مڠاندوڠي كيصه مودن",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه عملن ترباءيق ترهادڤ القرءان؟",
                                new List<string>
                                {
                                    "تيدق مڽنتوهڽ",
                                    "ممباچاڽ سلالو",
                                    "مڽيمڤنڽ د الماري",
                                },
                                1
                            ),
                            new Question(
                                "سياڤاكه يڠ دتوڬسكن مڽمڤاءيكن القرءان كڤد ماءنسي؟",
                                new List<string> { "نبي محمد", "نبي عيسى", "نبي إبراهيم" },
                                0
                            ),
                            new Question(
                                "اڤاكه بوقتي سسأورڠ منچينتاءي القرءان؟",
                                new List<string> { "مڠعملكن اجرنڽ", "ملتقڽ تيڠڬي", "مورناكنڽ" },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود كتاب سماوي؟",
                                new List<string>
                                {
                                    "كتاب بواتن ماءنسي",
                                    "كتاب داري لاڠيت",
                                    "كتاب سكوله",
                                },
                                1
                            ),
                            new Question(
                                "مڠاڤ ماءنسي ڤرلو برايمان كڤد كتاب؟",
                                new List<string>
                                {
                                    "اونتوق ڤندوان هيدوڤ",
                                    "اونتوق كوليكسي",
                                    "اونتوق ڤرتنديڠن",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا هاري قيامة؟",
                                new List<string> { "هنچورڽ عالم", "هاري كلاهيرن", "ڤرڤيندهن رومه" },
                                0
                            ),
                            new Question(
                                "ساله ساتو تندا كچيل قيامة اياله؟",
                                new List<string>
                                {
                                    "باڠونن تيڠڬي",
                                    "كمونچولن دجال",
                                    "تورونڽ نبي عيسى",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه تندا بسر قيامة؟",
                                new List<string>
                                {
                                    "راماي منونتوت علمو",
                                    "ماتاهاري تربيت د بارت",
                                    "حيوان ماكين باڽق",
                                },
                                1
                            ),
                            new Question(
                                "مڠاڤ ماءنسي دباڠكيتكن؟",
                                new List<string>
                                {
                                    "اونتوق برماءين",
                                    "اونتوق دأديلي",
                                    "اونتوق برسيار-سيار",
                                },
                                1
                            ),
                            new Question(
                                "اورڠ برايمان ڤرچاي هاري قيامة كرانا؟",
                                new List<string>
                                {
                                    "ستياڤ مخلوق ڤستي ماتي",
                                    "عالم ككل سلاماڽ",
                                    "ماءنسي هيدوڤ دوا كالي",
                                },
                                0
                            ),
                            new Question(
                                "كسن برايمان كڤد قيامة؟",
                                new List<string>
                                {
                                    "سوك برمالس",
                                    "راجين بربوات باءيق",
                                    "تيدق كيصه دوسا",
                                },
                                1
                            ),
                            new Question(
                                "سياڤاكه يڠ مڠتاهوءي تاريخ قيامة؟",
                                new List<string> { "ملائكة", "نبي", "الله" },
                                2
                            ),
                            new Question(
                                "اڤ يڠ برلاكو ستله قيامة؟",
                                new List<string> { "آخرة", "ماءنسي غائب", "تياد كهيدوڤن" },
                                0
                            ),
                            new Question(
                                "اڤاكه چونتوه تندا كچيل قيامة؟",
                                new List<string>
                                {
                                    "راماي اورڠ بربوهوڠ",
                                    "بولن تربله",
                                    "دجال مونچول",
                                },
                                0
                            ),
                            new Question(
                                "مڠاڤ تندا قيامة دبريتاهو كڤد ماءنسي؟",
                                new List<string>
                                {
                                    "سوڤايا تاكوت",
                                    "سوڤايا سدر دان برتوبة",
                                    "سوڤايا ملاريكن ديري",
                                },
                                1
                            ),
                            new Question(
                                "مخالفته للحوادث برمقصود الله؟",
                                new List<string>
                                {
                                    "بربيذا درڤد مخلوق",
                                    "سام سڤرتي ماءنسي",
                                    "مڽروڤاءي ملائكة",
                                },
                                0
                            ),
                            new Question(
                                "دليل صيفت اين باڽق دسبوت دالم سورة؟",
                                new List<string> { "الإخلاص", "الفلق", "الناس" },
                                0
                            ),
                            new Question(
                                "الله تيدق سام دڠن مخلوق كرانا؟",
                                new List<string> { "الله سمڤورنا", "مخلوق كوات", "مخلوق بركواس" },
                                0
                            ),
                            new Question(
                                "مخلوق ممرلوكن اودارا تتاڤي الله؟",
                                new List<string>
                                {
                                    "ڤرلو اودارا",
                                    "تيدق برحاجت اڤ ڤون",
                                    "ڤرلو تناڬ",
                                },
                                1
                            ),
                            new Question(
                                "صيفت اين ممبوقتيكن الله؟",
                                new List<string>
                                {
                                    "تريكت رواڠ",
                                    "برڬنتوڠ ڤد مخلوق",
                                    "سمڤورنا تنڤا ككورڠن",
                                },
                                2
                            ),
                            new Question(
                                "كسن برايمان كڤد صيفت اين؟",
                                new List<string>
                                {
                                    "يقين كبسرن الله",
                                    "تاكوت ماءنسي",
                                    "منجادي سومبوڠ",
                                },
                                0
                            ),
                            new Question(
                                "مڠاڤ ماءنسي تيدق بوليه مڽروڤاكن الله دڠن مخلوق؟",
                                new List<string>
                                {
                                    "الله مها سوچي",
                                    "مخلوق سمڤورنا",
                                    "ماءنسي تاهو سڬالاڽ",
                                },
                                0
                            ),
                            new Question(
                                "ڤربيذاءن انتارا الله دان مخلوق اياله؟",
                                new List<string>
                                {
                                    "الله تيدق بروبه",
                                    "مخلوق تيدق ماتي",
                                    "مخلوق تيدق لمه",
                                },
                                0
                            ),
                            new Question(
                                "صيفت اين منڬسكن الله؟",
                                new List<string>
                                {
                                    "مڽروڤاءي مخلوق",
                                    "تيدق مڽروڤاءي مخلوق",
                                    "ممرلوكن تمڤت",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه بوقتي عقل تنتڠ صيفت اين؟",
                                new List<string>
                                {
                                    "مخلوق لمه",
                                    "ڤنچيڤتا مستي بربيذا دري چيڤتاءن",
                                    "مخلوق ككل",
                                },
                                1
                            ),
                            new Question(
                                "قيامه بنفسه برمقصود الله؟",
                                new List<string>
                                {
                                    "ممرلوكن بنتوان",
                                    "برڬنتوڠ كڤد مخلوق",
                                    "برديري سنديري",
                                },
                                2
                            ),
                            new Question(
                                "مخلوق ممرلوكن ماكنن تتاڤي الله؟",
                                new List<string>
                                {
                                    "ممرلوكن لبيه باڽق",
                                    "تيدق برحاجت اڤ ڤون",
                                    "ممرلوكن بنتوان",
                                },
                                1
                            ),
                            new Question(
                                "دليل صيفت اين تردڤت دالم سورة؟",
                                new List<string> { "الإخلاص", "الكافرون", "الفيل" },
                                0
                            ),
                            new Question(
                                "الله برصيفت قيامه بنفسه كرانا؟",
                                new List<string> { "مها كاي", "مها لاڤر", "مها ڤنت" },
                                0
                            ),
                            new Question(
                                "كسن ممهامي صيفت اين؟",
                                new List<string>
                                {
                                    "سوك بربوهوڠ",
                                    "تمبه يقين برعبادة",
                                    "منجادي مالس",
                                },
                                1
                            ),
                            new Question(
                                "الله تيدق برحاجت كڤد؟",
                                new List<string> { "مخلوق", "كواس", "ديري-ڽ" },
                                0
                            ),
                            new Question(
                                "صيفت اين منونجوقكن الله؟",
                                new List<string>
                                {
                                    "برڬنتوڠ كڤد لاڠيت",
                                    "برڬنتوڠ كڤد وقتو",
                                    "تيدق برڬنتوڠ كڤد سسياڤا",
                                },
                                2
                            ),
                            new Question(
                                "مخلوق برديري دڠن بنتوان الله، الله برديري؟",
                                new List<string>
                                {
                                    "دڠن بنتوان مخلوق",
                                    "دڠن سنديري",
                                    "دڠن ماتاهاري",
                                },
                                1
                            ),
                            new Question(
                                "دڠن ممهامي صيفت اين، ماءنسي اكن؟",
                                new List<string> { "برڤوتوس اسا", "سومبوڠ", "برشكور" },
                                2
                            ),
                            new Question(
                                "الله تيدق بروبه كرانا؟",
                                new List<string> { "مها سمڤورنا", "ممرلوكن ماكن", "ممرلوكن ريحت" },
                                0
                            ),
                            new Question(
                                "حيوان دچيڤتاكن الله اونتوق؟",
                                new List<string> { "بوقتيكن ككواساءن-ڽ", "ڤرماءينن", "هياسن" },
                                0
                            ),
                            new Question(
                                "سورة النمل منچريتاكن تنتڠ؟",
                                new List<string> { "سموت", "هريماو", "كودا" },
                                0
                            ),
                            new Question(
                                "حيوان ممبنتو ماءنسي دڠن؟",
                                new List<string>
                                {
                                    "ممبري ماكنن",
                                    "مڠاجر مناري",
                                    "ممبري ڤاكاين مودن",
                                },
                                0
                            ),
                            new Question(
                                "لبه دسبوت دالم القرءان كرانا؟",
                                new List<string> { "مڠحاصيلكن مادو", "مربهاي", "سوكر دتڠكڤ" },
                                0
                            ),
                            new Question(
                                "كهيدوڤن حيوان منونجوقكن؟",
                                new List<string>
                                {
                                    "كبتولن",
                                    "كأيندهن چيڤتاءن الله",
                                    "تياد توجوان",
                                },
                                1
                            ),
                            new Question(
                                "ماءنسي ڤرلو منجاڬ حيوان كرانا؟",
                                new List<string>
                                {
                                    "حيوان ميليق ماءنسي",
                                    "حيوان تيدق برنيلاي",
                                    "سبهاڬين امانة الله",
                                },
                                2
                            ),
                            new Question(
                                "چونتوه حيوان دالم القرءان؟",
                                new List<string> { "ڬاجه", "كوچيڠ", "ڤندا" },
                                0
                            ),
                            new Question(
                                "مڠاڤ حيوان دأڠڬڤ تندا كبسرن الله؟",
                                new List<string>
                                {
                                    "سوكر دبونوه",
                                    "تيدق بوليه برڬرق",
                                    "دچيڤتا دڠن كاونيكن",
                                },
                                2
                            ),
                            new Question(
                                "ڤرانن اونتا دالم القرءان؟",
                                new List<string>
                                {
                                    "سباڬاي هياسن",
                                    "سباڬاي ڤڠڠكوتن زمان نبي",
                                    "سباڬاي سنجات",
                                },
                                1
                            ),
                            new Question(
                                "برفيكير تنتڠ حيوان ممباوا ماءنسي كڤد؟",
                                new List<string> { "لالاي", "كنل كبسرن الله", "تيدق ڤرچاي الله" },
                                1
                            ),
                        },
                    },
                    //LEVEL IBADAH TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود حدث كچيل؟",
                                new List<string>
                                {
                                    "كأداءن يڠ ممبطلكن وضوء",
                                    "كأداءن واجب مندي",
                                    "كأداءن سوچي درڤد نجيس",
                                },
                                0
                            ),
                            new Question(
                                "حدث بسر برلاكو كرانا.",
                                new List<string>
                                {
                                    "ماكن دان مينوم",
                                    "برسنتوهن دڠن نجيس",
                                    "برجماع اتاو كلوار ماني",
                                },
                                2
                            ),
                            new Question(
                                "چونتوه ڤركارا يڠ ممبطلكن وضوء اياله ..",
                                new List<string> { "تيدور ڽڽق", "مندي واجب", "برنية صلاة" },
                                0
                            ),
                            new Question(
                                "ڤركارا يڠ مواجبكن مندي واجب اياله.",
                                new List<string> { "كلوار ماني", "كنتوت", "مينوم اءير" },
                                0
                            ),
                            new Question(
                                "اڤاكه روكون مندي واجب يڠ بتول؟",
                                new List<string>
                                {
                                    "ممباچ دعاء مندي",
                                    "برنية دان مراتاكن اءير كسلوروه توبوه",
                                    "ممباسوه كاكي تيڬ كالي",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه حكمة مندي واجب؟",
                                new List<string>
                                {
                                    "مڠهيلڠكن مڠنتوق",
                                    "مڽوچيكن ديري درڤد حدث بسر",
                                    "منجادي لبيه كوات",
                                },
                                1
                            ),
                            new Question(
                                "حدث بسر مڽببكن سسأورڠ",
                                new List<string>
                                {
                                    "تيدق بوليه صلاة",
                                    "تيدق بوليه برچاكڤ",
                                    "تيدق بوليه ماكن",
                                },
                                0
                            ),
                            new Question(
                                "چارا برسوچي درڤد حدث كچيل اياله ...",
                                new List<string> { "مندي واجب", "بروضوء", "ممباچ دعاء" },
                                1
                            ),
                            new Question(
                                "ساله ساتو سبب برحدث بسر اياله ...",
                                new List<string>
                                {
                                    "كلوار داره لوك",
                                    "حيض باڬي ڤرمڤوان",
                                    "تيدور سكجڤ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤركارا يڠ دلارڠ كتيك برحدث كچيل؟",
                                new List<string> { "صلاة", "ماكن", "تيدور" },
                                0
                            ),
                            new Question(
                                "ڤركارا يڠ دلارڠ كتيك برحدث بسر اياله ...",
                                new List<string>
                                {
                                    "برسوكن",
                                    "منونتون تي.ۏي.",
                                    "مڽنتوه دان ممباچ القرءان",
                                },
                                2
                            ),
                            new Question(
                                "ساله ساتو سنة مندي واجب اياله ...",
                                new List<string>
                                {
                                    "ممباسوه كاكي تيڬ كالي",
                                    "منداهولوكن اڠڬوتا كانن",
                                    "مڠهادڤ قبلة",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود حدث بسر؟",
                                new List<string>
                                {
                                    "كأداءن يڠ ممبطلكن ڤواسا",
                                    "كأداءن يڠ ممرلوكن مندي واجب",
                                    "كأداءن تيدق بوليه ماكن",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه توجوان وضوء؟",
                                new List<string>
                                {
                                    "مڽوچيكن ديري درڤد نجيس",
                                    "مڽوچيكن ديري درڤد حدث كچيل",
                                    "مڠهيلڠكن ڤنت",
                                },
                                1
                            ),
                            new Question(
                                "حيض مڽببكن سسأورڠ.",
                                new List<string> { "واجب مندي", "هاروس بروضوء", "تروس صلاة" },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤربيذاءن حدث كچيل دان بسر؟",
                                new List<string>
                                {
                                    "چارا برسوچي بربيذا",
                                    "تياد ڤربيذاءن",
                                    "كدوا-دواڽ تيدق ممرلوكن نية",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكمة برسوچي؟",
                                new List<string>
                                {
                                    "مندافت ڤهالا دان هيدوڤ برسيه",
                                    "منجادي لبيه تيڠڬي",
                                    "منجادي كاي",
                                },
                                0
                            ),
                            new Question(
                                "انتارا سبب حدث كچيل اياله.",
                                new List<string> { "مونته سديكيت", "بواڠ اڠين", "برلاري جاءوه" },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود بالغ؟",
                                new List<string>
                                {
                                    "چوكوڤ عمور 18 تاهون",
                                    "سمڤايڽ سسأورڠ ڤد تندا٢ ديواسا",
                                    "ماسوق سكوله منڠه",
                                },
                                1
                            ),
                            new Question(
                                "باتس عورة للاكي اياله",
                                new List<string>
                                {
                                    "ڤوست هيڠڬ لوتوت",
                                    "لوتوت هيڠڬ توميت",
                                    "بهاڬين كڤالا سهاج",
                                },
                                0
                            ),
                            new Question(
                                "باتس عورة ڤرمڤوان اياله ...",
                                new List<string>
                                {
                                    "سلوروه توبوه كچوالي موك دان تاڠن",
                                    "ڤوست هيڠڬ لوتوت",
                                    "كڤالا سهاج",
                                },
                                0
                            ),
                            new Question(
                                "انتارا تندا بالغ اياله ..",
                                new List<string>
                                {
                                    "ڤنداي ممباچ",
                                    "ميمڤي باسه",
                                    "بوليه مناءيقي بس",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه تونتوتن شرع كڤد اورڠ بالغ؟",
                                new List<string>
                                {
                                    "بلاجر موزيك",
                                    "منجاڬ صلاة دان عبادة",
                                    "منجادي كتوا كلس",
                                },
                                1
                            ),
                            new Question(
                                "حكمة منوتوڤ عورة اياله ...",
                                new List<string>
                                {
                                    "منجادي لبيه چنتيق",
                                    "منجاڬ مروه دان كحرمتن",
                                    "سوڤايا تيدق ڤانس",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود عورة؟",
                                new List<string>
                                {
                                    "بهاڬين توبوه يڠ واجب دتوتوڤ",
                                    "نام ڤاكاين",
                                    "بهاڬين رمبوت",
                                },
                                0
                            ),
                            new Question(
                                "ڤرمڤوان واجب منوتوڤ عورة اڤابيلا",
                                new List<string> { "ماسوق تاديكا", "سوده بالغ", "برعمور 3 تاهون" },
                                1
                            ),
                            new Question(
                                "انتارا كسن تيدق منوتوڤ عورة اياله ...",
                                new List<string> { "دڤندڠ باءيق", "منجاڬ مروه", "مندافت دوسا" },
                                2
                            ),
                            new Question(
                                "عورة للاكي كتيك صلاة اياله.",
                                new List<string> { "ڤوست هيڠڬ لوتوت", "بهاڬين دادا", "بهاڬين موك" },
                                0
                            ),
                            new Question(
                                "بالغ باڬي ڤرمڤوان بركاءيت دڠن ...",
                                new List<string> { "سوارا بروبه", "حيض ڤرتام", "كوكو ڤنجڠ" },
                                1
                            ),
                            new Question(
                                "منوتوڤ عورة اداله ...",
                                new List<string> { "شرط صح صلاة", "ڤركارا هاروس", "تونتوتن شرع" },
                                2
                            ),
                            new Question(
                                "اڤاكه مقصود صلاة؟",
                                new List<string>
                                {
                                    "دعاء دان باچاءن ترتنتو",
                                    "ڤرڬرقن بادن سهاج",
                                    "ڤركارا يڠ ممبطلكن ڤواسا",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن صلاة فرض سهاري سمالم اياله ...",
                                new List<string> { "3", "5", "7" },
                                1
                            ),
                            new Question(
                                "وقتو صلاة صبح اياله ...",
                                new List<string> { "سلڤس عصر", "سبلوم شروق", "سلڤس عشاء" },
                                1
                            ),
                            new Question(
                                "روكون صلاة اياله.",
                                new List<string> { "برديري تڬق", "ماكن سبلوم صلاة", "برچاكڤ" },
                                0
                            ),
                            new Question(
                                "انتارا ڤركارا يڠ ممبطلكن صلاة اياله ...",
                                new List<string> { "برصلوات", "كتاوا كوات", "ممباچ الفاتحة" },
                                1
                            ),
                            new Question(
                                "ساله ساتو شرط صح صلاة اياله",
                                new List<string> { "مڠهادڤ قبلة", "مينوم اءير دهولو", "تيدور" },
                                0
                            ),
                            new Question(
                                "انتارا سنة دالم صلاة اياله",
                                new List<string> { "تكبيرة الإحرام", "دعاء قنوت", "نية" },
                                1
                            ),
                            new Question(
                                "وضوء اداله.",
                                new List<string> { "شرط صح صلاة", "ڤركارا سنة", "روكون صلاة" },
                                0
                            ),
                            new Question(
                                "صلاة دلاكوكن ..",
                                new List<string>
                                {
                                    "اونتوق مڠحرمتي ڬورو",
                                    "سباڬاي عبادة كڤد الله",
                                    "اونتوق منجادي تيڠڬي",
                                },
                                1
                            ),
                            new Question(
                                "دالم صلاة، روكون قولي اياله",
                                new List<string> { "ڤرڬرقن", "باچاءن", "نية" },
                                1
                            ),
                            new Question(
                                "چونتوه روكون صلاة اياله",
                                new List<string>
                                {
                                    "مماكاي تليكوڠ چنتيق",
                                    "ممباچ الفاتحة",
                                    "مڠيكت رمبوت",
                                },
                                1
                            ),
                            new Question(
                                "شرط واجب صلاة اياله",
                                new List<string>
                                {
                                    "چوكوڤ عمور بالغ",
                                    "بوليه ممباچ دعاء",
                                    "تاهو ممباچ بوكو",
                                },
                                0
                            ),
                            new Question(
                                "حكمة صلاة اياله",
                                new List<string>
                                {
                                    "مڠواتكن بادن",
                                    "مندكتكن ديري كڤد الله",
                                    "منجادي كاي",
                                },
                                1
                            ),
                            new Question(
                                "دالم صلاة، كيت ممباچ الفاتحة كتيك ...",
                                new List<string> { "ركوع", "برديري", "سجود" },
                                1
                            ),
                            new Question(
                                "صلاة مغرب ممڤوڽاءي ...",
                                new List<string> { "امڤت ركعة", "تيڬ ركعة", "دوا ركعة" },
                                1
                            ),
                            new Question(
                                "صلاة عصر دلاكوكن ڤد ...",
                                new List<string> { "وقتو تڠه مالم", "وقتو ڤتڠ", "وقتو ڤاڬي" },
                                1
                            ),
                            new Question(
                                "انتارا ڤركارا ممبطلكن صلاة اياله ...",
                                new List<string> { "برذكر دالم هاتي", "برحدث", "فوكوس" },
                                1
                            ),
                            new Question(
                                "نية صلاة دلاكوكن ...",
                                new List<string> { "دالم هاتي", "دلفظ دڠن كوات", "تيدق ڤرلو" },
                                0
                            ),
                            new Question(
                                "صلاة عشاء ممڤوڽاءي ...",
                                new List<string> { "امڤت ركعة", "تيڬ ركعة", "دوا ركعة" },
                                0
                            ),
                            new Question(
                                "ترتيب اياله ...",
                                new List<string>
                                {
                                    "منداهولوكن روكون دڠن توروتن يڠ بتول",
                                    "ملومڤت كتيك صلاة",
                                    "ممباچ دعاء وقتو صلاة",
                                },
                                0
                            ),
                        },
                    },
                    // LEVEL SIRAH TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "نبي محمد ﷺ بركتورونن:",
                                new List<string> { "عرب قريش", "ڤارسي", "روم" },
                                0
                            ),
                            new Question(
                                "داتوق نبي يڠ منجاڬ بڬيندا سلڤس ايبو وفت اياله:",
                                new List<string> { "عبد المطلب", "أبو طالب", "حمزة" },
                                0
                            ),
                            new Question(
                                "نبي محمد ﷺ لاهير د:",
                                new List<string> { "مكة", "مدينة", "طائف" },
                                0
                            ),
                            new Question(
                                "ايبو سوسو نبي محمد ﷺ اياله:",
                                new List<string> { "حليمة السعدية", "آمنة", "زينب" },
                                0
                            ),
                            new Question(
                                "بيلاڠن انق للاكي نبي اياله:",
                                new List<string> { "2 اورڠ", "4 اورڠ", "6 اورڠ" },
                                0
                            ),
                            new Question(
                                "بيلاڠن انق ڤرمڤوان نبي اياله:",
                                new List<string> { "4 اورڠ", "2 اورڠ", "3 اورڠ" },
                                0
                            ),
                            new Question(
                                "سوامي كڤد فاطمة اياله:",
                                new List<string> { "علي بن أبي طالب", "عثمان", "أبو بكر" },
                                0
                            ),
                            new Question(
                                "انق نبي يڠ منيڠڬل ڤد اوسيا كچيل اياله:",
                                new List<string> { "قاسم", "زينب", "رقية" },
                                0
                            ),
                            new Question(
                                "نام ايبو كڤد خديجة اياله:",
                                new List<string>
                                {
                                    "فاطمة بنت زائدة",
                                    "آمنة بنت وهب",
                                    "زينب بنت جحش",
                                },
                                0
                            ),
                            new Question(
                                "رومه تڠڬ يڠ بهاڬيا داڤت ممبنتوق:",
                                new List<string> { "اخلاق موليا", "مسئله سوسيال", "ڤرتليڠكهن" },
                                0
                            ),
                            new Question(
                                "انق خديجة دڠن نبي اياله:",
                                new List<string> { "فاطمة", "عائشة", "حفصة" },
                                0
                            ),
                            new Question(
                                "سيدنا علي اياله:",
                                new List<string> { "مننتو نبي", "باڤ ساودارا نبي", "ڬورو نبي" },
                                0
                            ),
                            new Question(
                                "سوسور ڬالور كلوارڬ ڤنتيڠ اونتوق:",
                                new List<string>
                                {
                                    "مڠنلي اصل-اصول",
                                    "منيمبولكن كبنچين",
                                    "مرندهكن قوم لاءين",
                                },
                                0
                            ),
                            new Question(
                                "انق ڤرمڤوان نبي يڠ برهجرة ك حبشة اياله:",
                                new List<string> { "رقية", "زينب", "أم كلثوم" },
                                0
                            ),
                            new Question(
                                "اينستيتوسي كلوارڬ برڤرانن ممبنتوق:",
                                new List<string>
                                {
                                    "ڬينراسي بركواليتي",
                                    "ڬينراسي ليار",
                                    "ڬينراسي مالس",
                                },
                                0
                            ),
                            new Question(
                                "نبي دجاڬ اوليه أبو طالب سلڤس:",
                                new List<string>
                                {
                                    "داتوق بڬيندا وفت",
                                    "بڬيندا بركهوين",
                                    "بڬيندا برهجرة",
                                },
                                0
                            ),
                            new Question(
                                "وحيو ڤرتام دسمڤاءيكن اوليه ملائكة:",
                                new List<string> { "جبريل", "ميكائيل", "إسرافيل" },
                                0
                            ),
                            new Question(
                                "ڤريستيوا كرسولن برلاكو د:",
                                new List<string> { "ڬوا حراء", "بوكيت أحد", "ڤادڠ عرفة" },
                                0
                            ),
                            new Question(
                                "نبي منريما وحيو ڤد وقتو:",
                                new List<string> { "مالم", "سياڠ", "صبح" },
                                0
                            ),
                            new Question(
                                "ڤرينته ڤرتام دالم إسلام اياله:",
                                new List<string> { "إقرأ", "سجود", "برذكر" },
                                0
                            ),
                            new Question(
                                "سلڤس منريما وحيو، نبي ڤولڠ كڤد:",
                                new List<string> { "خديجة", "أبو بكر", "علي" },
                                0
                            ),
                            new Question(
                                "خديجة مننڠكن نبي دڠن:",
                                new List<string>
                                {
                                    "ممبري سوكوڠن",
                                    "مڠيجيك بڬيندا",
                                    "برلاري ك رومه جيرن",
                                },
                                0
                            ),
                            new Question(
                                "نبي بردعوه سچارا سڽڤ سلاما:",
                                new List<string> { "3 تاهون", "1 تاهون", "10 تاهون" },
                                0
                            ),
                            new Question(
                                "اورڠ ڤرتام مملوق إسلام دري ڬولوڠن وانيتا اياله:",
                                new List<string> { "خديجة", "عائشة", "فاطمة" },
                                0
                            ),
                            new Question(
                                "اورڠ ڤرتام مملوق إسلام دري كانق٢ اياله:",
                                new List<string> { "علي بن أبي طالب", "زيد بن حارثة", "حسن" },
                                0
                            ),
                            new Question(
                                "سورة العلق مڠاجر كيت سوڤايا:",
                                new List<string>
                                {
                                    "ممباچ دان منونتوت علمو",
                                    "تيدور اول",
                                    "برداڬڠ",
                                },
                                0
                            ),
                            new Question(
                                "وحيو تورون ملالوءي:",
                                new List<string> { "ملائكة", "ميمڤي بياسا", "اورڠ صالح" },
                                0
                            ),
                            new Question(
                                "نبي ساڠت سوك برخلوة كرانا:",
                                new List<string>
                                {
                                    "برفيكير تنتڠ چيڤتاءن الله",
                                    "مڠاسيڠ ديري دري مشاركت",
                                    "مڠومڤول هرتا",
                                },
                                0
                            ),
                            new Question(
                                "كتيك منريما وحيو، نبي براس:",
                                new List<string> { "ڬمنتر", "ڬمبيرا", "ماره" },
                                0
                            ),
                            new Question(
                                "دعوه اول ترتومڤو كڤد:",
                                new List<string> { "اهلي كلوارڬ", "كتوا قريش", "قوم يهودي" },
                                0
                            ),
                            new Question(
                                "كباءيقن ممباچ اياله:",
                                new List<string> { "منمبه ڤڠتاهوان", "ممبازير ماس", "مڽوسهكن" },
                                0
                            ),
                            new Question(
                                "زيد بن حارثة اياله:",
                                new List<string> { "ڤمبنتو نبي", "موسوه نبي", "كتوا قريش" },
                                0
                            ),
                            new Question(
                                "خديجة ممبري سوكوڠن كڤد نبي دالم بنتوق:",
                                new List<string> { "هرتا دان سماڠت", "سنجات", "تنترا" },
                                0
                            ),
                            new Question(
                                "ڬلرن خديجة اياله:",
                                new List<string>
                                {
                                    "ايبو اورڠ برايمان",
                                    "ڤوتري قريش",
                                    "وانيتا بدر",
                                },
                                0
                            ),
                            new Question(
                                "صيفت خديجة يڠ اوتام اياله:",
                                new List<string> { "ڤموره", "بخيل", "ڬارڠ" },
                                0
                            ),
                            new Question(
                                "ڤرانن خديجة سباڬاي ايستري اياله:",
                                new List<string> { "مننڠكن نبي", "مڠاول دعوه", "مڠهالڠ شعار" },
                                0
                            ),
                            new Question(
                                "خديجة سنتياس منجادي:",
                                new List<string>
                                {
                                    "ڤڽوكوڠ اوتام نبي",
                                    "ڤڠكريتيك نبي",
                                    "ڤننتڠ دعوه",
                                },
                                0
                            ),
                            new Question(
                                "خديجة ممبنتو نبي كتيك بڬيندا:",
                                new List<string> { "منريما وحيو", "برڤرڠ", "برهجرة" },
                                0
                            ),
                            new Question(
                                "خديجة منونجوقكن كاسيه سايڠ دڠن:",
                                new List<string> { "مڠوربنكن هرتا", "منولق نبي", "ماره كڤد نبي" },
                                0
                            ),
                            new Question(
                                "خديجة منجادي ڤمبنتو نبي دڠن:",
                                new List<string>
                                {
                                    "مڠوروس كڤرلوان رومه",
                                    "مڽوروه نبي بكرجا لبيه",
                                    "منيڠڬلكن رومه",
                                },
                                0
                            ),
                            new Question(
                                "تاهون وفت خديجة دكنلي سباڬاي:",
                                new List<string> { "تاهون كسديهن", "تاهون ڬاجه", "تاهون هجرة" },
                                0
                            ),
                            new Question(
                                "نبي مڠهرڬاءي خديجة كرانا:",
                                new List<string> { "جاساڽ بسر", "رومهڽ بسر", "هرتا باڽق" },
                                0
                            ),
                        },
                    },
                    // LEVEL ADAB TAHAP 3
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اورڠ ديواسا برمقصود ..",
                                new List<string>
                                {
                                    "كانق-كانق كچيل",
                                    "اينديۏيدو يڠ سوده ماتڠ",
                                    "بايي",
                                },
                                1
                            ),
                            new Question(
                                "اورڠ توا مروجوع كڤد ...",
                                new List<string> { "ورڬ امس", "رماجا", "ڤلاجر سكوله" },
                                0
                            ),
                            new Question(
                                "ساله ساتو دليل بربوات باءيق كڤد ايبو باڤ اياله ...",
                                new List<string> { "سوروهن جيرن", "القرءان", "بوكو چريتا" },
                                1
                            ),
                            new Question(
                                "انتارا ادب دڠن اورڠ توا اياله ...",
                                new List<string>
                                {
                                    "منجريت كڤد مريك",
                                    "مڠحرمتي ڤرچاكڤن مريك",
                                    "مڠابايكن ارهن",
                                },
                                1
                            ),
                            new Question(
                                "فاءيده برادب دڠن اورڠ توا اياله ...",
                                new List<string>
                                {
                                    "دسايڠي الله",
                                    "دبنچي سموا اورڠ",
                                    "هيدوڤ كسوڽين",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن اورڠ ديواسا اياله ...",
                                new List<string> { "راماي كاون", "مندافت دوسا", "دڤوجي ڬورو" },
                                1
                            ),
                            new Question(
                                "تڠڬوڠجواب انق كڤد ايبو باڤ اياله ...",
                                new List<string>
                                {
                                    "منجواب دڠن كاسر",
                                    "منولوڠ مريك",
                                    "مڽوروه مريك بكرجا",
                                },
                                1
                            ),
                            new Question(
                                "چونتوه اورڠ ديواسا اياله ...",
                                new List<string>
                                {
                                    "موريد تاهون 1",
                                    "ڤنجاڬ سكوله",
                                    "بايي بارو لاهير",
                                },
                                1
                            ),
                            new Question(
                                "اڤابيلا ايبو باڤ برچاكڤ، انق ڤرلو ...",
                                new List<string> { "مڠابايكن", "مندڠر دڠن باءيق", "برلاري كلوار" },
                                1
                            ),
                            new Question(
                                "مڠحرمتي اورڠ توا ممباوا كڤد",
                                new List<string>
                                {
                                    "هوبوڠن كلوارڬ يڠ باءيق",
                                    "ڤرسليسيهن فهم",
                                    "كسديهن",
                                },
                                0
                            ),
                            new Question(
                                "جيرن برمقصود ..",
                                new List<string>
                                {
                                    "اورڠ يڠ تيڠڬل جاءوه",
                                    "اورڠ يڠ تيڠڬل بردكتن",
                                    "اورڠ دالم سكوله",
                                },
                                1
                            ),
                            new Question(
                                "دليل ادب برجيرن مڠاجر كيت سوڤايا ...",
                                new List<string> { "برموسوهن", "ساليڠ ممبنتو", "مڽاكيتي جيرن" },
                                1
                            ),
                            new Question(
                                "ادب دڠن جيرن إسلام دان بوكن إسلام ترماسوق ...",
                                new List<string> { "مڠوتوق", "مڠڬڠڬو وقتو ريحت", "برتڬور ساڤ" },
                                2
                            ),
                            new Question(
                                "فاءيده برادب دڠن جيرن اياله ...",
                                new List<string>
                                {
                                    "دحرمتي مشاركت",
                                    "رومه منجادي كوتور",
                                    "تيدق دكنلي سسياڤا",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن جيرن اياله ...",
                                new List<string>
                                {
                                    "هيدوڤ امن",
                                    "برلاكو ڤرڬادوهن",
                                    "جيرن سماكين راڤت",
                                },
                                1
                            ),
                            new Question(
                                "ساله ساتو حق جيرن اياله",
                                new List<string> { "دچرچا", "تيدق دلاين", "دبنتو كتيك سوسه" },
                                2
                            ),
                            new Question(
                                "جيرن بوكن إسلام ڤرلو ...",
                                new List<string> { "دڤندڠ رنده", "دحرمتي", "دهينا" },
                                1
                            ),
                            new Question(
                                "ڤربواتن مڠهيدوڤكن موزيك كوات هيڠڬ مڠڬڠڬو جيرن اياله ...",
                                new List<string> { "باءيق", "بوروق", "سنة" },
                                1
                            ),
                            new Question(
                                "ممبري سلام كڤد جيرن اداله عملن ...",
                                new List<string> { "تيدق دڬالقكن", "هاروس دأيلقكن", "برادب" },
                                2
                            ),
                            new Question(
                                "جك جيرن دتيمڤا مصيبة، كيت ڤرلو ...",
                                new List<string> { "ملاريكن ديري", "منونجوقكن سيمڤاتي", "مڠيجيك" },
                                1
                            ),
                            new Question(
                                "تتامو اياله ...",
                                new List<string>
                                {
                                    "اورڠ يڠ داتڠ بركونجوڠ",
                                    "بيناتڠ ڤليهاراءن",
                                    "بارڠ رومه",
                                },
                                0
                            ),
                            new Question(
                                "دليل ادب ملاين تتامو مڠاجر سوڤايا ...",
                                new List<string> { "كدكوت", "مڠهينا تتامو", "مولياكن تتامو" },
                                2
                            ),
                            new Question(
                                "ادب ملاين تتامو ترماسوق",
                                new List<string>
                                {
                                    "مڽمبوت دڠن سڽومن",
                                    "منوتوڤ ڤينتو موك تتامو",
                                    "ممبياركن تتامو برديري لاما",
                                },
                                0
                            ),
                            new Question(
                                "فاءيده ملاين تتامو اياله ..",
                                new List<string> { "دڤندڠ باءيق", "دڤندڠ سومبوڠ", "دڤولاوكن" },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن تتامو اياله ...",
                                new List<string>
                                {
                                    "تتامو براس ڬمبيرا",
                                    "رومه دسكاءي سموا",
                                    "هوبوڠن رڠڬڠ",
                                },
                                2
                            ),
                            new Question(
                                "ادب سباڬاي تتامو اياله.",
                                new List<string>
                                {
                                    "مڠوتوركن رومه توان",
                                    "مڠحرمتي ماس توان رومه",
                                    "مماراهي توان رومه",
                                },
                                1
                            ),
                            new Question(
                                "باتس ڤرڬاءولن دڠن تتامو ڤرلو دجاڬ سوڤايا ...",
                                new List<string>
                                {
                                    "تيدق منيمبولكن فتنة",
                                    "ملاكوكن ڤركارا حرام",
                                    "مڠڬڠڬو جيرن",
                                },
                                0
                            ),
                            new Question(
                                "تتامو يڠ باءيق تيدق ...",
                                new List<string>
                                {
                                    "مڠامبيل بارڠ تنڤا ايذين",
                                    "مڠوچڤ تريما كاسيه",
                                    "مڠحرمتي رواڠ توان رومه",
                                },
                                0
                            ),
                            new Question(
                                "توان رومه ڤرلو ...",
                                new List<string>
                                {
                                    "ممبياركن تتامو منوڠڬو",
                                    "مڽمبوت تتامو",
                                    "برڤورا-ڤورا تياد د رومه",
                                },
                                1
                            ),
                            new Question(
                                "ملاين تتامو دڠن باءيق اداله ...",
                                new List<string> { "ادب يڠ دتونتوت", "تيدق ڤنتيڠ", "دلارڠ" },
                                0
                            ),
                            new Question(
                                "OKU برمقصود ..",
                                new List<string>
                                {
                                    "اورڠ يڠ كوات",
                                    "اورڠ يڠ سمڤورنا",
                                    "اورڠ يڠ ممڤوڽاءي ككورڠن ترتنتو",
                                },
                                2
                            ),
                            new Question(
                                "كاتڬوري OKU ترماسوق ...",
                                new List<string> { "ڤندڠرن", "كصيحتن نورمل", "كچرڬسن ڤنوه" },
                                0
                            ),
                            new Question(
                                "ادب دڠن OKU اياله ...",
                                new List<string>
                                {
                                    "مڠعاءيبكن مريك",
                                    "مڠهولوركن بنتوان",
                                    "منترتاواكن ككورڠن",
                                },
                                1
                            ),
                            new Question(
                                "فاءيده برادب دڠن OKU اياله ...",
                                new List<string> { "مندافت ڤهالا", "مندافت موسوه", "دبنچي الله" },
                                0
                            ),
                            new Question(
                                "تيدق مڠحرمتي OKU مڽببكن ..",
                                new List<string> { "هوبوڠن باءيق", "ڤربالهن", "كاسيه سايڠ برتمبه" },
                                1
                            ),
                            new Question(
                                "القرءان اياله.",
                                new List<string> { "كلمة الله", "بوكو چريتا", "نوتا سكوله" },
                                0
                            ),
                            new Question(
                                "ادب دڠن القرءان ترماسوق ...",
                                new List<string>
                                {
                                    "لتق د لنتاي",
                                    "منجاڬ كبرسيهن ديري",
                                    "ممبوك هلامن سچارا كاسر",
                                },
                                1
                            ),
                            new Question(
                                "فاءيده برادب دڠن القرءان اياله ...",
                                new List<string>
                                {
                                    "دجاءوهي رحمة",
                                    "مندافت هداية",
                                    "هاتي منجادي ڬلڤ",
                                },
                                1
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن القرءان اياله ...",
                                new List<string>
                                {
                                    "مندافت ڤهالا",
                                    "منجادي لبيه باءيق",
                                    "مندافت دوسا",
                                },
                                2
                            ),
                            new Question(
                                "مڠحرمتي كتاب دان بوكو برمقصود ...",
                                new List<string>
                                {
                                    "مروسقكن بوكو",
                                    "منجاڬ دڠن راڤي",
                                    "ممبواڠ سسوك هاتي",
                                },
                                1
                            ),
                            new Question(
                                "ڬورو برمقصود ...",
                                new List<string>
                                {
                                    "اورڠ يڠ مڠاجر",
                                    "كاون سبايا",
                                    "جيرن سبله رومه",
                                },
                                0
                            ),
                            new Question(
                                "ادب دڠن ڬورو ترماسوق ...",
                                new List<string>
                                {
                                    "مڠوچڤ سلام",
                                    "منجريت كتيك ڬورو مڠاجر",
                                    "تيدق مڽياڤكن كرجا",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن ڬورو اياله ...",
                                new List<string>
                                {
                                    "مندافت كبركتن",
                                    "سوكر مندافت علمو",
                                    "منجادي موريد چمرلڠ",
                                },
                                1
                            ),
                            new Question(
                                "مندڠر ارهن ڬورو اداله ...",
                                new List<string> { "تيدق ڤنتيڠ", "ساتو ادب", "دلارڠ" },
                                1
                            ),
                            new Question(
                                "ڬورو يڠ دحرمتي اكن ...",
                                new List<string>
                                {
                                    "تيدق سوك مڠاجر",
                                    "لبيه موده ممبري علمو",
                                    "ممبنچي موريد",
                                },
                                1
                            ),
                            new Question(
                                "ادب كتيك بلاجر اياله ...",
                                new List<string> { "سوك بيسيڠ", "ممولاكن دڠن دعاء", "مڠڬڠڬو كاون" },
                                1
                            ),
                            new Question(
                                "ڤركارا يڠ ڤرلو دهيندري كتيك بلاجر اياله ...",
                                new List<string>
                                {
                                    "منومڤوكن ڤرهاتين",
                                    "ماكن سمبيل بلاجر",
                                    "مڠولڠ كاجي",
                                },
                                1
                            ),
                            new Question(
                                "فاءيده برادب كتيك بلاجر اياله ...",
                                new List<string>
                                {
                                    "موده ممهامي ڤلاجرن",
                                    "سماكين مالس",
                                    "تيدق برجاي",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب كتيك بلاجر اياله ...",
                                new List<string>
                                {
                                    "لمه دالم ڤلاجرن",
                                    "منجادي چمرلڠ",
                                    "مندافت باڽق ڤهالا",
                                },
                                0
                            ),
                            new Question(
                                "كڤنتيڠن منجاڬ كبرسيهن سكوله اياله ...",
                                new List<string>
                                {
                                    "موجودكن ڤرسكيترن صيحت",
                                    "مڽببكن ڤڽاكيت",
                                    "منيمبولكن باو بوسوق",
                                },
                                0
                            ),
                        },
                    },
                    // level Akidah Tahap 4
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود قضاء دان قدر؟",
                                new List<string>
                                {
                                    "ڤرينته ماءنسي",
                                    "كتنتوان الله سجق ازلي",
                                    "ڤيليهن همبا",
                                    "كڤوتوسن امام",
                                },
                                1
                            ),
                            new Question(
                                "برايمان دڠن قضاء دان قدر حكومڽ؟",
                                new List<string> { "سنة", "هاروس", "واجب", "مكروه" },
                                2
                            ),
                            new Question(
                                "ساله ساتو چيري اورڠ يڠ برايمان دڠن قضاء دان قدر اياله؟",
                                new List<string> { "چڤت ماره", "رضا دان صبر", "ڤوتوس اسا", "تكبر" },
                                1
                            ),
                            new Question(
                                "اورڠ يڠ تيدق ڤرچاي كڤد قضاء دان قدر ترماسوق دالم ڬولوڠن؟",
                                new List<string> { "مؤمن", "كافير", "صالح", "مسافير" },
                                1
                            ),
                            new Question(
                                "ڤرچاي كڤد قضاء دان قدر ترماسوق دالم روكون؟",
                                new List<string> { "إسلام", "ايمان", "إحسان", "شريعة" },
                                1
                            ),
                            new Question(
                                "قضاء اياله؟",
                                new List<string>
                                {
                                    "كتنتوان الله سجق ازلي",
                                    "كتنتوان ستله برلاكو",
                                    "اوسها ماءنسي",
                                    "كڤوتوسن حاكيم",
                                },
                                0
                            ),
                            new Question(
                                "قدر اياله؟",
                                new List<string>
                                {
                                    "تقدير يڠ برلاكو كڤد مخلوق",
                                    "ڤيليهن ماءنسي",
                                    "كڤوتوسن امام",
                                    "صيفت ماءنسي",
                                },
                                0
                            ),
                            new Question(
                                "اورڠ برايمان دڠن قضاء دان قدر اكن سنتياس؟",
                                new List<string> { "صبر دان رضا", "ڬليسه", "ماره", "ڤوتوس اسا" },
                                0
                            ),
                            new Question(
                                "اڤابيلا منداڤت نعمة، اورڠ برايمان دڠن قضاء دان قدر اكن؟",
                                new List<string> { "كفور", "برشكور", "ماره", "ڤوتوس اسا" },
                                1
                            ),
                            new Question(
                                "اڤابيلا دتيمڤا مصيبة، اورڠ برايمان دڠن قضاء دان قدر اكن؟",
                                new List<string> { "صبر", "مناڠيس", "ڤوتوس اسا", "مڠلوه" },
                                0
                            ),
                            new Question(
                                "قضاء دان قدر منونجوقكن الله مها؟",
                                new List<string> { "مڠتاهوءي", "لمه", "لوڤا", "ساكيت" },
                                0
                            ),
                            new Question(
                                "ڤرچاي قضاء دان قدر منجاديكن هاتي؟",
                                new List<string> { "تنڠ", "ڬليسه", "تاكوت", "مالس" },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود صيفت وحدانية؟",
                                new List<string>
                                {
                                    "الله مها اسا",
                                    "الله مها ڤموره",
                                    "الله مها كواس",
                                    "الله مها بيجقسان",
                                },
                                0
                            ),
                            new Question(
                                "دليل نقلي صيفت وحدانية تردڤت دالم سورة؟",
                                new List<string> { "الإخلاص", "الفاتحة", "البقرة", "الناس" },
                                0
                            ),
                            new Question(
                                "دليل عقلي صيفت وحدانية اياله؟",
                                new List<string>
                                {
                                    "عالم اين منونجوقكن اداڽ توهن يڠ ساتو",
                                    "سموا اورڠ بركات بڬيتو",
                                    "ماءنسي منوليس بوكو",
                                    "سموا بندا سام",
                                },
                                0
                            ),
                            new Question(
                                "صيفت يڠ برلاونن دڠن وحدانية اياله؟",
                                new List<string> { "بربيلڠ-بيلڠ", "اسا", "مها كواس", "مها ڤموره" },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ تيدق ڤرچاي كڤد صيفت وحدانية اياله؟",
                                new List<string> { "كافير", "مؤمن", "صالح", "صبر" },
                                0
                            ),
                            new Question(
                                "اڤابيلا برايمان دڠن صيفت وحدانية، كيت اكن؟",
                                new List<string>
                                {
                                    "مڽمبه الله سهاج",
                                    "مڽمبه باڽق توهن",
                                    "تيدق مڽمبه الله",
                                    "منجادي سومبوڠ",
                                },
                                0
                            ),
                            new Question(
                                "الله مها اسا برمقصود الله تياد؟",
                                new List<string> { "سكوتو", "كواس", "علمو", "ككاياءن" },
                                0
                            ),
                            new Question(
                                "ماءنسي يڠ ڤرچاي كڤد باڽق توهن دڤڠڬيل؟",
                                new List<string> { "مشرك", "مؤمن", "صالح", "صبر" },
                                0
                            ),
                            new Question(
                                "صيفت وحدانية منونجوقكن الله ايت؟",
                                new List<string> { "اسا دان توڠڬل", "باڽق", "دوا", "تيڬ" },
                                0
                            ),
                            new Question(
                                "دليل نقلي وحدانية برمقصود؟",
                                new List<string>
                                {
                                    "دليل درڤد القرءان دان حديث",
                                    "دليل درڤد عقل",
                                    "دليل درڤد ماءنسي",
                                    "دليل درڤد سجاره",
                                },
                                0
                            ),
                            new Question(
                                "دليل عقلي وحدانية برمقصود؟",
                                new List<string>
                                {
                                    "دليل درڤد عقل فيكيرن",
                                    "دليل درڤد القرءان",
                                    "دليل درڤد حديث",
                                    "دليل درڤد كتاب إنجيل",
                                },
                                0
                            ),
                            new Question(
                                "حكمة برايمان دڠن صيفت وحدانية اياله؟",
                                new List<string>
                                {
                                    "منجادي لبيه طاعة كڤد الله",
                                    "منجادي سومبوڠ",
                                    "منجادي لالاي",
                                    "منجادي مالس",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود صيفت قدرة؟",
                                new List<string>
                                {
                                    "الله مها بركواس",
                                    "الله مها كاي",
                                    "الله مها بيجقسان",
                                    "الله مها ڤڠاسيه",
                                },
                                0
                            ),
                            new Question(
                                "دليل نقلي صيفت قدرة تردڤت دالم ايات؟",
                                new List<string>
                                {
                                    "الله بركواس اتس تياڤ-تياڤ سسواتو",
                                    "الله مها اسا",
                                    "الله مها ڤڽايڠ",
                                    "الله مها مڠتاهوءي",
                                },
                                0
                            ),
                            new Question(
                                "دليل عقلي صيفت قدرة اياله؟",
                                new List<string>
                                {
                                    "عالم يڠ سمڤورنا منونجوقكن اداڽ كواس الله",
                                    "سموا اورڠ كات بڬيتو",
                                    "سموا بندا سام",
                                    "تياد بوقتي",
                                },
                                0
                            ),
                            new Question(
                                "صيفت يڠ برلاونن دڠن قدرة اياله؟",
                                new List<string> { "لمه", "بركواس", "كوات", "صبر" },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ برايمان دڠن صيفت قدرة ڤرچاي بهاوا الله؟",
                                new List<string> { "مها بركواس", "لمه", "تيدق تاهو", "تيدق ممڤو" },
                                0
                            ),
                            new Question(
                                "برايمان دڠن صيفت قدرة منجاديكن كيت؟",
                                new List<string>
                                {
                                    "يقين كڤد الله",
                                    "ڤوتوس اسا",
                                    "لمه ايمان",
                                    "تكبر",
                                },
                                0
                            ),
                            new Question(
                                "چونتوه صيفت قدرة الله اياله؟",
                                new List<string>
                                {
                                    "منچيڤتا عالم",
                                    "ماكن دان مينوم",
                                    "تيدور",
                                    "برجالن",
                                },
                                0
                            ),
                            new Question(
                                "الله تيدق موڠكين برصيفت؟",
                                new List<string> { "لمه", "بركواس", "مها مڠتاهوءي", "مها بيجقسان" },
                                0
                            ),
                            new Question(
                                "دليل نقلي صيفت قدرة اياله ايات القرءان يڠ مڽبوت؟",
                                new List<string>
                                {
                                    "الله بركواس اتس تياڤ-تياڤ سسواتو",
                                    "الله مها ڤموره",
                                    "الله مها اسا",
                                    "الله مها ڤڽابر",
                                },
                                0
                            ),
                            new Question(
                                "دليل عقلي صيفت قدرة اياله عقل يڠ مليهت؟",
                                new List<string>
                                {
                                    "عالم چيڤتاءن الله",
                                    "بوكو ماءنسي",
                                    "ڬمبر",
                                    "رومه",
                                },
                                0
                            ),
                            new Question(
                                "حكمة برايمان دڠن صيفت قدرة اياله؟",
                                new List<string>
                                {
                                    "منجادي لبيه يقين دان طاعة كڤد الله",
                                    "منجادي مالس",
                                    "منجادي لالاي",
                                    "منجادي سومبوڠ",
                                },
                                0
                            ),
                            new Question(
                                "الله بركواس منچيڤتا؟",
                                new List<string> { "عالم سمستا", "تيليفون", "كريتا", "كومڤوتر" },
                                0
                            ),
                            new Question(
                                "ماءنسي دچيڤتاكن اوليه؟",
                                new List<string> { "ملائكة", "جين", "الله", "نبي" },
                                2
                            ),
                            new Question(
                                "ڤروسيس كجادين ماءنسي برمولا دڠن؟",
                                new List<string> { "اءير ماني", "تانه", "تولڠ", "داره" },
                                0
                            ),
                            new Question(
                                "القرءان مڽبوت كجادين ماءنسي برمولا درڤد؟",
                                new List<string> { "تانه", "كايو", "باتو", "بسي" },
                                0
                            ),
                            new Question(
                                "جانين براد دالم رحيم ايبو سلاما؟",
                                new List<string> { "9 بولن", "5 بولن", "3 بولن", "7 بولن" },
                                0
                            ),
                            new Question(
                                "ڤروسيس كجادين ماءنسي دالم القرءان دسبوت دالم سورة؟",
                                new List<string> { "المؤمنون", "الفاتحة", "الإخلاص", "الناس" },
                                0
                            ),
                            new Question(
                                "ڤروسيس كجادين ماءنسي برمولا دڠن نطفة، كمودين؟",
                                new List<string> { "علقة", "مضغة", "تولڠ", "داڬيڠ" },
                                0
                            ),
                            new Question(
                                "سلڤس علقة، كجادين ماءنسي منجادي؟",
                                new List<string> { "مضغة", "نطفة", "تانه", "اءير" },
                                0
                            ),
                            new Question(
                                "سلڤس مضغة، الله منجاديكن؟",
                                new List<string> { "تولڠ", "داره", "اءير", "رمبوت" },
                                0
                            ),
                            new Question(
                                "سلڤس تولڠ، الله منوتوڤيڽ دڠن؟",
                                new List<string> { "داڬيڠ", "كوليت", "اءير", "رمبوت" },
                                0
                            ),
                            new Question(
                                "ڤروسيس كجادين ماءنسي ممبوقتيكن بهاوا الله؟",
                                new List<string> { "مها ڤنچيڤتا", "لمه", "ساكيت", "لالاي" },
                                0
                            ),
                            new Question(
                                "ماءنسي ملالوءي براڤ ف fasa كهيدوڤن؟",
                                new List<string> { "ليم", "دوا", "تيڬ", "امڤت" },
                                0
                            ),
                            new Question(
                                "ف fasa ڤرتام كهيدوڤن ماءنسي اياله؟",
                                new List<string> { "دالم كاندوڠن", "كانق-كانق", "ديواسا", "توا" },
                                0
                            ),
                            new Question(
                                "ف fasa تراخير كهيدوڤن ماءنسي اياله؟",
                                new List<string> { "ماتي", "كانق-كانق", "رماجا", "توا" },
                                0
                            ),
                            new Question(
                                "ڤنچيڤتاءن ماءنسي ممبوقتيكن كوجودن؟",
                                new List<string> { "الله", "ملائكة", "شيطان", "نبي" },
                                0
                            ),
                        },
                    },
                    // level Ibadah Tahap 4
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود صلاة برجماعة؟",
                                new List<string>
                                {
                                    "صلاة سأورڠ ديري",
                                    "صلاة يڠ دلاكوكن برسام امام دان مأموم",
                                    "صلاة كتيك ساكيت",
                                    "صلاة كتيك مسافير",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه كلبيهن صلاة برجماعة بربانديڠ صلاة سأورڠ؟",
                                new List<string> { "سام سهاج", "10 درجت", "27 درجت", "100 درجت" },
                                2
                            ),
                            new Question(
                                "سياڤاكه يڠ مميمڤين صلاة برجماعة؟",
                                new List<string> { "مؤذن", "امام", "مأموم", "بلال" },
                                1
                            ),
                            new Question(
                                "مأموم هندقله مڠيكوت امام دڠن؟",
                                new List<string>
                                {
                                    "منداهولوءي امام",
                                    "مڠيكوت ڤرڬرقن امام",
                                    "لمبت دري امام",
                                    "تيدق ايكوت لڠسوڠ",
                                },
                                1
                            ),
                            new Question(
                                "صف صلاة برجماعة مستيله؟",
                                new List<string>
                                {
                                    "لوروس دان راڤت",
                                    "بيڠكوق",
                                    "جاءوه-جاءوه",
                                    "برسليرق",
                                },
                                0
                            ),
                            new Question(
                                "صلاة جمعة دلاكوكن ڤد هاري؟",
                                new List<string> { "اثنين", "جمعة", "سبتو", "أحد" },
                                1
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة جمعة اياله؟",
                                new List<string>
                                {
                                    "دوا ركعة",
                                    "تيڬ ركعة",
                                    "امڤت ركعة",
                                    "ليم ركعة",
                                },
                                0
                            ),
                            new Question(
                                "صلاة جمعة مڠڬنتيكن صلاة؟",
                                new List<string> { "صبح", "ظهر", "عصر", "مغرب" },
                                1
                            ),
                            new Question(
                                "خطبة جمعة دلاكوكن سباڽق؟",
                                new List<string> { "سكالي", "دوا كالي", "تيڬ كالي", "امڤت كالي" },
                                1
                            ),
                            new Question(
                                "سياڤاكه يڠ واجب منونايكن صلاة جمعة؟",
                                new List<string>
                                {
                                    "سموا اورڠ إسلام",
                                    "للاكي إسلام يڠ چوكوڤ شرط",
                                    "ڤرمڤوان",
                                    "كانق-كانق",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود صلاة جمع؟",
                                new List<string>
                                {
                                    "مڠهيمڤونكن دوا صلاة فرض دالم ساتو وقتو",
                                    "مريڠنكن صلاة",
                                    "مڠڬنتي صلاة",
                                    "منمبه صلاة",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود صلاة قصر؟",
                                new List<string>
                                {
                                    "مڠهيمڤونكن دوا صلاة",
                                    "ممنديككن صلاة فرض امڤت ركعة كڤد دوا ركعة",
                                    "مڠڬنتي صلاة",
                                    "منمبه ركعة صلاة",
                                },
                                1
                            ),
                            new Question(
                                "صلاة جمع تربهاڬي كڤد براڤ جنيس؟",
                                new List<string> { "ساتو", "دوا", "تيڬ", "امڤت" },
                                1
                            ),
                            new Question(
                                "صلاة ظهر دان عصر بوليه دجمع ڤد وقتو؟",
                                new List<string> { "ڤاڬي", "مالم", "ظهر اتاو عصر", "صبح" },
                                2
                            ),
                            new Question(
                                "شرط اوتام صلاة جمع دان قصر اياله؟",
                                new List<string> { "برمسافير", "ساكيت", "مالس", "سيبوق" },
                                0
                            ),
                            new Question(
                                "اورڠ ساكيت يڠ تيدق ممڤو برديري بوليه صلاة دڠن؟",
                                new List<string> { "دودوق", "برباريڠ", "اشارت مات", "سموا د اتس" },
                                3
                            ),
                            new Question(
                                "اورڠ ساكيت يڠ تيدق ممڤو بروضوء بوليه؟",
                                new List<string> { "تيدق صلاة", "برتيمم", "مندي", "تيدور" },
                                1
                            ),
                            new Question(
                                "اڤابيلا تيدق ممڤو ركوع دان سجود، اورڠ ساكيت بوليه؟",
                                new List<string>
                                {
                                    "ڬنتي صلاة",
                                    "اشارت دڠن كڤالا",
                                    "تيدق صلاة",
                                    "تيدور",
                                },
                                1
                            ),
                            new Question(
                                "اڤابيلا تيدق ممڤو برڬرق لڠسوڠ، اورڠ ساكيت بوليه؟",
                                new List<string>
                                {
                                    "تيڠڬلكن صلاة",
                                    "صلاة دڠن هاتي",
                                    "صلاة دڠن تاڠن",
                                    "تيدور",
                                },
                                1
                            ),
                            new Question(
                                "إسلام مڠاجر كيت سوڤايا؟",
                                new List<string>
                                {
                                    "تيدق صلاة كتيك ساكيت",
                                    "تتڤ صلاة مڠيكوت كممڤوان",
                                    "منيڠڬلكن صلاة",
                                    "مليڠه-ليڠهكن صلاة",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود صلاة دالم كندراءن؟",
                                new List<string>
                                {
                                    "صلاة كتيك براد د مسجد",
                                    "صلاة كتيك مناءيقي كندراءن",
                                    "صلاة سمبيل برجالن",
                                    "صلاة سمبيل برلاري",
                                },
                                1
                            ),
                            new Question(
                                "صلاة دالم كندراءن بياساڽ دلاكوكن كتيك؟",
                                new List<string>
                                {
                                    "برمسافير جاءوه",
                                    "برجالن كاكي",
                                    "تيدور",
                                    "برماءين",
                                },
                                0
                            ),
                            new Question(
                                "اره قبلة باڬي صلاة دالم كندراءن اياله؟",
                                new List<string>
                                {
                                    "تيدق ڤنتيڠ",
                                    "مڠيكوت كممڤوان",
                                    "ك مان-مان",
                                    "مڠهادڤ اوتارا",
                                },
                                1
                            ),
                            new Question(
                                "صلاة سنة بوليه دلاكوكن دالم كندراءن دڠن؟",
                                new List<string>
                                {
                                    "اشارت كڤالا",
                                    "برديري تڬق",
                                    "دودوق اتس تانه",
                                    "سجود بتول-بتول",
                                },
                                0
                            ),
                            new Question(
                                "صلاة فرض دالم كندراءن هاڽ بوليه دلاكوكن جك؟",
                                new List<string>
                                {
                                    "ساڠت ضرورة",
                                    "مالس تورون",
                                    "تيدق ماهو برهنتي",
                                    "هندق چڤت سمڤاي",
                                },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ منداڤت ڤهالا 27 درجت دالم صلاة اياله؟",
                                new List<string>
                                {
                                    "اورڠ صلاة برجماعة",
                                    "اورڠ صلاة سأورڠ",
                                    "اورڠ تيدور",
                                    "اورڠ ماكن",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكوم صلاة برجماعة باڬي للاكي؟",
                                new List<string> { "سنة مؤكد", "واجب", "هاروس", "مكروه" },
                                0
                            ),
                            new Question(
                                "اورڠ ڤرمڤوان حكومڽ صلاة جمعة؟",
                                new List<string> { "واجب", "تيدق واجب", "سنة", "مكروه" },
                                1
                            ),
                            new Question(
                                "صلاة جمع تقديم برمقصود؟",
                                new List<string>
                                {
                                    "مڠهيمڤونكن صلاة د وقتو يڠ ڤرتام",
                                    "مڠهيمڤونكن صلاة د وقتو كدوا",
                                    "ممنديككن صلاة",
                                    "منمبه صلاة",
                                },
                                0
                            ),
                            new Question(
                                "صلاة جمع تأخير برمقصود؟",
                                new List<string>
                                {
                                    "مڠهيمڤونكن صلاة د وقتو يڠ كدوا",
                                    "مڠهيمڤونكن صلاة د وقتو ڤرتام",
                                    "ممنديككن صلاة",
                                    "منمبه صلاة",
                                },
                                0
                            ),
                            new Question(
                                "صلاة قصر دلاكوكن ڤد صلاة؟",
                                new List<string>
                                {
                                    "امڤت ركعة",
                                    "تيڬ ركعة",
                                    "دوا ركعة",
                                    "سموا صلاة",
                                },
                                0
                            ),
                            new Question(
                                "اورڠ ساكيت يڠ تيدق بوليه برتيمم بوليه؟",
                                new List<string>
                                {
                                    "صلاة دڠن اشارت",
                                    "تيدق صلاة",
                                    "توندا صلاة",
                                    "تيدق ڤرلو صلاة",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه شرط صح صلاة جمعة؟",
                                new List<string>
                                {
                                    "دديريكن د تمڤت برمقين",
                                    "دديريكن د ڤادڠ ڤاسير",
                                    "دلاكوكن سأورڠ ديري",
                                    "دلاكوكن د رومه",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن مينيموم جماعه اونتوق صلاة جمعة اياله؟",
                                new List<string> { "40 اورڠ", "10 اورڠ", "2 اورڠ", "100 اورڠ" },
                                0
                            ),
                            new Question(
                                "اڤابيلا برمسافير، صلاة عصر بوليه دقصر كڤد؟",
                                new List<string>
                                {
                                    "دوا ركعة",
                                    "امڤت ركعة",
                                    "تيڬ ركعة",
                                    "ساتو ركعة",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا برمسافير، صلاة ظهر بوليه دجمع دڠن؟",
                                new List<string> { "عصر", "مغرب", "صبح", "عشاء" },
                                0
                            ),
                            new Question(
                                "اورڠ ساكيت يڠ تيدق ممڤو مڠاڠكت تاڠن اونتوق تكبير بوليه؟",
                                new List<string>
                                {
                                    "اشارت دڠن جاري",
                                    "تيدق صلاة",
                                    "منوندا صلاة",
                                    "مڠهادڤ ك لاءين",
                                },
                                0
                            ),
                            new Question(
                                "صلاة دالم كاڤل تربڠ دلاكوكن دڠن چارا؟",
                                new List<string>
                                {
                                    "دودوق دان اشارت كڤالا",
                                    "تيدور",
                                    "تيدق صلاة",
                                    "برديري ڤنوه",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكمة صلاة برجماعة؟",
                                new List<string>
                                {
                                    "مڠواتكن اخوة",
                                    "ممبازير ماس",
                                    "ملمهكن ايمان",
                                    "منجادي مالس",
                                },
                                0
                            ),
                            new Question(
                                "صلاة جمعة دواجبكن كڤد للاكي يڠ؟",
                                new List<string> { "برمقيم", "مسافير", "كانق-كانق", "اورڠ ساكيت" },
                                0
                            ),
                            new Question(
                                "صلاة جمع بياساڽ دلاكوكن كتيك؟",
                                new List<string> { "برمسافير", "برماءين", "بكرجا", "تيدور" },
                                0
                            ),
                            new Question(
                                "صلاة قصر تيدق بوليه دلاكوكن باڬي صلاة؟",
                                new List<string> { "صبح دان مغرب", "ظهر", "عصر", "عشاء" },
                                0
                            ),
                            new Question(
                                "صلاة اورڠ ساكيت منونجوقكن بهاوا إسلام ايت؟",
                                new List<string> { "موده", "سوسه", "برت", "تيدق عاديل" },
                                0
                            ),
                            new Question(
                                "صلاة دالم كندراءن لبيه اوتام دلاكوكن جك؟",
                                new List<string>
                                {
                                    "صلاة سنة",
                                    "صلاة جمعة",
                                    "صلاة فرض",
                                    "صلاة برجماعة",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا تيدق ممڤو ركوع، اورڠ ساكيت بوليه ڬنتي دڠن؟",
                                new List<string>
                                {
                                    "منوندوقكن كڤالا سديكيت",
                                    "برديري تڬق",
                                    "دودوق سهاج",
                                    "تيدور",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكوم صلاة جمعة باڬي للاكي يڠ مسافير؟",
                                new List<string> { "ڬوڬور كواجيڤن", "واجب", "سنة", "مكروه" },
                                0
                            ),
                            new Question(
                                "اڤاكه صلاة يڠ بوليه دجمع دڠن صلاة عشاء؟",
                                new List<string> { "مغرب", "ظهر", "عصر", "صبح" },
                                0
                            ),
                            new Question(
                                "صلاة قصر دلاكوكن اڤابيلا ڤرجلانن ملبيهي؟",
                                new List<string>
                                {
                                    "دوا مرحلة",
                                    "ساتو مرحلة",
                                    "تيڬ مرحلة",
                                    "امڤت مرحلة",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا ساكيت، جك تيدق ممڤو برديري مك صلاة دڠن؟",
                                new List<string> { "دودوق", "باريڠ", "تيدور", "تيدق ڤرلو صلاة" },
                                0
                            ),
                            new Question(
                                "اڤابيلا ساكيت دان تيدق ممڤو دودوق، مك صلاة دڠن؟",
                                new List<string>
                                {
                                    "برباريڠ مڠيريڠ",
                                    "تيدور",
                                    "تيدق صلاة",
                                    "مڠهادڤ ك لاءين",
                                },
                                0
                            ),
                        },
                    },
                    // level Sirah Tahap 4
                    new Levels
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "سياڤاكه ملائكة يڠ مڽمڤاءيكن وحيو ڤرتام كڤد نبي محمد ﷺ؟",
                                new List<string> { "ميكائيل", "إسرافيل", "جبريل", "عزرائيل" },
                                2
                            ),
                            new Question(
                                "وحيو ڤرتام دتورونكن د؟",
                                new List<string> { "ڬوا حراء", "ڬوا ثور", "مسجد الحرام", "كعبة" },
                                0
                            ),
                            new Question(
                                "سورة ڤرتام يڠ دتورونكن اياله؟",
                                new List<string>
                                {
                                    "الفاتحة",
                                    "الإخلاص",
                                    "العلق ايات 1-5",
                                    "البقرة",
                                },
                                2
                            ),
                            new Question(
                                "نبي محمد ﷺ مولا بردعوه سچارا رهسيا سلاما؟",
                                new List<string> { "3 تاهون", "5 تاهون", "10 تاهون", "13 تاهون" },
                                0
                            ),
                            new Question(
                                "سياڤاكه صحابت ڤرتام يڠ مملوق إسلام؟",
                                new List<string>
                                {
                                    "أبو بكر",
                                    "علي بن أبي طالب",
                                    "خديجة",
                                    "زيد بن حارثة",
                                },
                                2
                            ),
                            new Question(
                                "مڠاڤاكه رسول الله ﷺ ممولاكن دعوه سچارا رهسيا؟",
                                new List<string>
                                {
                                    "كرانا تاكوت",
                                    "كرانا بلوم چوكوڤ علمو",
                                    "سوڤايا إسلام لبيه كوات دهولو",
                                    "كرانا دڤرينته باڤ ساودارا",
                                },
                                2
                            ),
                            new Question(
                                "اورڠ قريش مننتڠ دعوه رسول الله ﷺ كرانا؟",
                                new List<string>
                                {
                                    "إسلام مڠاجر مڽمبه الله يڠ اسا",
                                    "إسلام مڽوروه مينوم ارق",
                                    "إسلام مڠاجر برهالا دسمبه",
                                    "إسلام ممبنركن جودي",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه انتارا بريكوت يڠ مڽوكوڠ رسول الله ﷺ دالم دعوه؟",
                                new List<string>
                                {
                                    "أبو جهل",
                                    "أبو لهب",
                                    "أبو طالب",
                                    "عتبة بن ربيعة",
                                },
                                2
                            ),
                            new Question(
                                "اڤاكه ستراتيڬي رسول الله ﷺ مڠهادڤي تنتڠن قريش؟",
                                new List<string>
                                {
                                    "برصبر دان بردعاء",
                                    "مماراهي مريك",
                                    "مڽمبه برهالا",
                                    "برڤاليڠ دري دعوه",
                                },
                                0
                            ),
                            new Question(
                                "اخلاق رسول الله ﷺ كتيك بردعوه اياله؟",
                                new List<string>
                                {
                                    "صبر دان لمه لمبوت",
                                    "ماره-ماره",
                                    "منجريت",
                                    "ممقسا",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه يڠ دڬلر الصديق كرانا ممبنركن دعوه رسول الله ﷺ؟",
                                new List<string> { "عمر", "عثمان", "أبو بكر", "علي" },
                                2
                            ),
                            new Question(
                                "سياڤاكه ڤمودا ڤرتام يڠ مملوق إسلام؟",
                                new List<string>
                                {
                                    "علي بن أبي طالب",
                                    "عمر بن الخطاب",
                                    "زبير بن العوام",
                                    "طلحة",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه همبا ڤرتام يڠ مملوق إسلام؟",
                                new List<string>
                                {
                                    "بلال بن رباح",
                                    "زيد بن حارثة",
                                    "سلمان الفارسي",
                                    "عمار بن ياسر",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه فاءيده دعوه سچارا رهسيا؟",
                                new List<string>
                                {
                                    "إسلام داڤت برتاڤق دڠن سلامت",
                                    "إسلام هيلڠ",
                                    "إسلام دتولق",
                                    "إسلام تيدق بركمبڠ",
                                },
                                0
                            ),
                            new Question(
                                "ڬولوڠن قريش مننتڠ إسلام كرانا؟",
                                new List<string>
                                {
                                    "تاكوت كهيلڠن ڤڠاروه",
                                    "إسلام ممبنركن برهالا",
                                    "إسلام ممبنركن ارق",
                                    "إسلام مڽوروه برجودي",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود دعوه سچارا تربوك؟",
                                new List<string>
                                {
                                    "مڽمڤاءيكن إسلام كڤد عموم",
                                    "مڽمبوڽيكن إسلام",
                                    "مڠاجر هاڽ كلوارڬ",
                                    "تيدق بردعوه",
                                },
                                0
                            ),
                            new Question(
                                "انتارا يڠ مننتڠ رسول الله ﷺ اياله؟",
                                new List<string> { "أبو لهب", "بلال", "علي", "أبو بكر" },
                                0
                            ),
                            new Question(
                                "اڤاكه صيفت رسول الله ﷺ كتيك مڽمڤاءيكن دعوه؟",
                                new List<string> { "لمه لمبوت", "سومبوڠ", "ڬارڠ", "ماره" },
                                0
                            ),
                            new Question(
                                "سياڤاكه ايستري ڤرتام رسول الله ﷺ يڠ سنتياس مڽوكوڠ بڬيندا؟",
                                new List<string> { "عائشة", "حفصة", "خديجة", "أم سلمة" },
                                2
                            ),
                            new Question(
                                "اڤاكه ڤڠاجرن دري دعوه سچارا رهسيا؟",
                                new List<string>
                                {
                                    "كيت ڤرلو برحكمة دالم بردعوه",
                                    "كيت تيدق ڤرلو بردعوه",
                                    "كيت بوليه مڠهينا اورڠ لاءين",
                                    "كيت بوليه تيڠڬلكن إسلام",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه صحابت يڠ تركنل دڠن صيفت درماون دان بردعوه؟",
                                new List<string> { "أبو بكر", "عمر", "عثمان", "علي" },
                                0
                            ),
                            new Question(
                                "سياڤاكه صحابت يڠ تركنل براني دان تڬس دالم إسلام؟",
                                new List<string> { "أبو بكر", "عمر", "عثمان", "طلحة" },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا يڠ برلاكو د طائف؟",
                                new List<string>
                                {
                                    "رسول الله ﷺ دأوسير دان دچدراكن",
                                    "رسول الله ﷺ دسمبوت باءيق",
                                    "رسول الله ﷺ دلانتيق ڤميمڤين",
                                    "رسول الله ﷺ بركهوين",
                                },
                                0
                            ),
                            new Question(
                                "رسول الله ﷺ بردعاء د طائف والاوڤون؟",
                                new List<string> { "دساكيتي", "دحرمتي", "دسانجوڠ", "دسمبوت باءيق" },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠاجرن دري ڤريستيوا طائف؟",
                                new List<string>
                                {
                                    "برصبر دالم مڠهادڤي چابرن",
                                    "ڤوتوس اسا",
                                    "تيدق ڤرلو بردعوه",
                                    "برهنتي بردعوه",
                                },
                                0
                            ),
                            new Question(
                                "رسول الله ﷺ مڽمڤاءيكن دعوه كڤد قبيله كتيك؟",
                                new List<string>
                                {
                                    "موسيم حج",
                                    "بولن رمضان",
                                    "هاري راي",
                                    "بولن شعبان",
                                },
                                0
                            ),
                            new Question(
                                "قبيله ماناكه يڠ اخيرڽ منريما إسلام؟",
                                new List<string> { "أوس دان خزرج", "قريش", "طائف", "بني أمية" },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤرجنجين عقبة؟",
                                new List<string>
                                {
                                    "ڤرجنجين طاعة ستيا كڤد رسول الله ﷺ",
                                    "ڤرجنجين دڠن قريش",
                                    "ڤرجنجين دڠن طائف",
                                    "ڤرجنجين داماي",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ستراتيڬي أبو بكر دالم مڽيبركن إسلام؟",
                                new List<string>
                                {
                                    "مڠاجق صحابت-صحابت تردكت",
                                    "مڠڬوناكن ككرسن",
                                    "ممبوات ڤرجنجين دڠن قريش",
                                    "مڽمبوڽيكن إسلام",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه صحابت يڠ ممراليكن بلال؟",
                                new List<string> { "أبو بكر", "عمر", "عثمان", "علي" },
                                0
                            ),
                            new Question(
                                "اڤاكه يڠ دلاكوكن قريش كڤد رسول الله ﷺ دان صحابت؟",
                                new List<string>
                                {
                                    "ممولاوكن مريك",
                                    "ممبري هديه",
                                    "مڠحرمتي",
                                    "ممبنتو",
                                },
                                0
                            ),
                            new Question(
                                "ڤمولاءون رسول الله ﷺ برلاكو سلاما؟",
                                new List<string> { "3 تاهون", "5 تاهون", "7 تاهون", "10 تاهون" },
                                0
                            ),
                            new Question(
                                "د ماناكه رسول الله ﷺ دان صحابت دڤولاوكن؟",
                                new List<string> { "شعب أبي طالب", "ڬوا حراء", "كعبة", "مدينة" },
                                0
                            ),
                            new Question(
                                "اڤاكه عاقبة درڤد ڤمولاءون قريش؟",
                                new List<string>
                                {
                                    "اومت إسلام هيدوڤ سوسه دان لاڤر",
                                    "إسلام سماكين كوات",
                                    "إسلام دسمبوت باءيق",
                                    "قريش ماسوق إسلام",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠاجرن درڤد ڤمولاءون رسول الله ﷺ؟",
                                new List<string>
                                {
                                    "برصبر دالم مڠهادڤي چابرن",
                                    "برهنتي بردعوه",
                                    "مڽمبه برهالا",
                                    "منيڠڬلكن إسلام",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود معجزة؟",
                                new List<string>
                                {
                                    "ڤركارا لوار بياسا يڠ الله كورنياكن كڤد نبي",
                                    "ڤركارا ڤليق",
                                    "سحير",
                                    "ڤرماءينن",
                                },
                                0
                            ),
                            new Question(
                                "معجزة تربسر نبي محمد ﷺ اياله؟",
                                new List<string>
                                {
                                    "القرءان",
                                    "ممبله لاءوت",
                                    "توڠكت برتوكر اولر",
                                    "مڽمبوهكن بوتا",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه توجوان معجزة؟",
                                new List<string>
                                {
                                    "ممبوقتيكن كرسولن نبي",
                                    "اونتوق برماءين",
                                    "اونتوق منونجوق-نونجوق",
                                    "اونتوق سحير",
                                },
                                0
                            ),
                            new Question(
                                "القرءان ممبوقتيكن كبنرن نبي محمد ﷺ كرانا؟",
                                new List<string>
                                {
                                    "تياد سياڤا داڤت منيروڽ",
                                    "دتوليس اوليه ماءنسي",
                                    "سام سڤرتي كتاب لاءين",
                                    "بوليه دڤيندا",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه معجزة يڠ برلاكو كتيك اورڠ قريش ممينتا تندا؟",
                                new List<string>
                                {
                                    "بولن تربله",
                                    "لاءوت تربله",
                                    "توڠكت منجادي اولر",
                                    "اڤي منجادي سجوق",
                                },
                                0
                            ),
                            new Question(
                                "اءير كلوار دري چله جاري رسول الله ﷺ كتيك؟",
                                new List<string>
                                {
                                    "ڤارا صحابت كهاءوسن",
                                    "صحابت لاڤر",
                                    "صحابت تاكوت",
                                    "صحابت ساكيت",
                                },
                                0
                            ),
                            new Question(
                                "ماكنن برتمبه دڠن ايذين الله كتيك؟",
                                new List<string> { "ڤرڠ", "جموان كچيل", "كندوري", "موسيم ڤانس" },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا بسر يڠ برلاكو سبلوم صلاة ليم وقتو دفرضوك؟",
                                new List<string> { "إسراء معراج", "هجرة", "ڤرڠ بدر", "حج الوداع" },
                                0
                            ),
                            new Question(
                                "صلاة ليم وقتو دفرضوكن سماس ڤريستيوا؟",
                                new List<string>
                                {
                                    "إسراء معراج",
                                    "هجرة",
                                    "ڤرڠ أحد",
                                    "ڤمبيناءن كعبة",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكمة معجزة رسول الله ﷺ؟",
                                new List<string>
                                {
                                    "مڠواتكن ايمان اومت إسلام",
                                    "اونتوق برماءين",
                                    "اونتوق منونجوق-نونجوق",
                                    "اونتوق مناكوتكن",
                                },
                                0
                            ),
                            new Question(
                                "معجزة برلاكو دڠن ايذين؟",
                                new List<string> { "الله", "ماءنسي", "ملائكة", "نبي" },
                                0
                            ),
                            new Question(
                                "اڤاكه يڠ ممبيذاكن معجزة دان سحير؟",
                                new List<string>
                                {
                                    "معجزة دري الله، سحير دري جين",
                                    "معجزة دري ماءنسي",
                                    "معجزة سام سڤرتي سحير",
                                    "كدوا-دواڽ سام",
                                },
                                0
                            ),
                            new Question(
                                "القرءان منجادي معجزة كرانا؟",
                                new List<string>
                                {
                                    "بهاس دان ايسيڽ اينده دان بنر",
                                    "سام سڤرتي بوكو بياسا",
                                    "دتوليس صحابت",
                                    "بوليه دڤيندا",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠاجرن درڤد معجزة نبي محمد ﷺ؟",
                                new List<string>
                                {
                                    "ميقيني كرسولن بڬيندا",
                                    "تيدق برايمان",
                                    "منجادي سومبوڠ",
                                    "لالاي",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه معجزة يڠ ماسيه ككل هيڠڬ هاري اين؟",
                                new List<string>
                                {
                                    "القرءان",
                                    "بولن تربله",
                                    "اءير كلوار دري جاري",
                                    "ماكنن برتمبه",
                                },
                                0
                            ),
                        },
                    },
                    new Levels //Level Adab Tahap 4
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود زياره؟",
                                new List<string>
                                {
                                    "ڤرڬي ملنچوڠ",
                                    "مڠونجوڠي سسأورڠ دڠن توجوان باءيق",
                                    "ممبلي بارڠ",
                                    "ڤرڬي برسوكن",
                                },
                                1
                            ),
                            new Question(
                                "انتارا ادب منزيارهي راكن سبايا اياله؟",
                                new List<string>
                                {
                                    "ممبري سلام",
                                    "ممبوات بيسيڠ",
                                    "مڠامبيل بارڠ تنڤا ايذين",
                                    "برڬادوه",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا هندق ڤولڠ دري رومه راكن، كيت ڤرلو؟",
                                new List<string>
                                {
                                    "ديام سهاج",
                                    "ممبنتيڠ ڤينتو",
                                    "مڠوچڤكن تريما كاسيه",
                                    "ممباوا بارڠڽ",
                                },
                                2
                            ),
                            new Question(
                                "ڤربواتن يڠ دلارڠ كتيك منزيارهي راكن سبايا اياله؟",
                                new List<string>
                                {
                                    "ممبري سلام",
                                    "ممينتا ايذين ماسوق",
                                    "مروسقكن بارڠ راكن",
                                    "بربوال سوڤن",
                                },
                                2
                            ),
                            new Question(
                                "كلبيهن منزيارهي راكن دڠن ادب يڠ باءيق اياله؟",
                                new List<string>
                                {
                                    "مندافت كاسيه سايڠ",
                                    "دبنچي اورڠ",
                                    "دماراهي جيرن",
                                    "هيلڠ كاون",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب كتيك منزيارهي راكن اياله؟",
                                new List<string> { "دڤوجي", "دحرمتي", "دڤندڠ سيروڠ", "دسايڠي" },
                                2
                            ),
                            new Question(
                                "اڤابيلا راكن ممبري ماكنن، كيت ڤرلو؟",
                                new List<string>
                                {
                                    "تولق دڠن كاسر",
                                    "امبيل دڠن سوڤن",
                                    "هينا ماكنن",
                                    "بواڠ ماكنن",
                                },
                                1
                            ),
                            new Question(
                                "مڠحرمتي راكن سبايا كتيك زياره اكن؟",
                                new List<string>
                                {
                                    "مڠواتكن ڤرصحابتن",
                                    "ملمهكن هوبوڠن",
                                    "منيمبولكن ڤرڬادوهن",
                                    "ممبوات كبنچين",
                                },
                                0
                            ),
                            new Question(
                                "جك راكن تياد د رومه، كيت ڤرلو؟",
                                new List<string>
                                {
                                    "ڤچهكن ڤينتو",
                                    "ڤولڠ دڠن سوڤن",
                                    "جريت ڤڠڬيل",
                                    "ڤنجت ڤاڬر",
                                },
                                1
                            ),
                            new Question(
                                "عاقبة سوك ممبوات بيسيڠ كتيك منزيارهي راكن اياله؟",
                                new List<string>
                                {
                                    "راكن سوك",
                                    "راكن ڬمبيرا",
                                    "راكن ماره",
                                    "راكن حرمت",
                                },
                                2
                            ),
                            new Question(
                                "اڤابيلا منزيارهي اورڠ ديواسا، كيت ڤرلو ممڠڬيل مريك دڠن؟",
                                new List<string>
                                {
                                    "نام سهاج",
                                    "ڤڠڬيلن حرمت",
                                    "سينديرن",
                                    "ڬلرن كاسر",
                                },
                                1
                            ),
                            new Question(
                                "لارڠن كتيك منزيارهي اورڠ ديواسا اياله؟",
                                new List<string>
                                {
                                    "دودوق سوڤن",
                                    "مموتوڠ ڤرچاكڤن",
                                    "مندڠر نصيحت",
                                    "ممبري سلام",
                                },
                                1
                            ),
                            new Question(
                                "كلبيهن برادب دڠن اورڠ ديواسا اياله؟",
                                new List<string>
                                {
                                    "دبنچي",
                                    "دكاسيهي دان دحرمتي",
                                    "دماراهي",
                                    "دڤولاو",
                                },
                                1
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن اورڠ ديواسا اياله؟",
                                new List<string> { "دسايڠي", "دحرمتي", "دڤندڠ رنده", "دكاسيهي" },
                                2
                            ),
                            new Question(
                                "اڤابيلا بربيچارا دڠن اورڠ ديواسا كيت هندقله؟",
                                new List<string>
                                {
                                    "منڠكيڠ",
                                    "سوڤن دان لمه لمبوت",
                                    "مڠهينا",
                                    "مموتوڠ چاكڤ",
                                },
                                1
                            ),
                            new Question(
                                "مڠحرمتي اورڠ ديواسا ترماسوق اخلاق؟",
                                new List<string> { "بوروق", "موليا", "جاهت", "تيدق ڤنتيڠ" },
                                1
                            ),
                            new Question(
                                "بردعاء اونتوق كباءيقن اورڠ ديواسا اداله تندا؟",
                                new List<string> { "بنچي", "حرمت دان كاسيه سايڠ", "دندم", "لالاي" },
                                1
                            ),
                            new Question(
                                "مڠاڠكت سوارا د هادڤن اورڠ ديواسا اداله؟",
                                new List<string>
                                {
                                    "ادب بوروق",
                                    "ادب موليا",
                                    "عملن باءيق",
                                    "عملن سنة",
                                },
                                0
                            ),
                            new Question(
                                "چونتوه ساودارا مارا اياله؟",
                                new List<string> { "صحابت سكوله", "سڤوڤو", "جيرن سبله", "ڬورو" },
                                1
                            ),
                            new Question(
                                "لارڠن كتيك منزيارهي ساودارا مارا اياله؟",
                                new List<string>
                                {
                                    "ممبنتو مريك",
                                    "ممبوات بيسيڠ",
                                    "مندعاكن مريك",
                                    "ممبري سلام",
                                },
                                1
                            ),
                            new Question(
                                "كلبيهن منزيارهي ساودارا مارا دڠن ادب باءيق اياله؟",
                                new List<string>
                                {
                                    "مندافت كاسيه سايڠ",
                                    "دڤولاو",
                                    "دبنچي",
                                    "دجاءوهي",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دڠن ساودارا مارا اياله؟",
                                new List<string>
                                {
                                    "صلة الرحيم ترڤوتوس",
                                    "صلة الرحيم برتمبه ارت",
                                    "هوبوڠن برتمبه كاسيه",
                                    "هوبوڠن دحرمتي",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا بربوال دڠن ساودارا مارا كيت هندقله؟",
                                new List<string> { "كاسر", "مڠهينا", "سوڤن", "ممبنتق" },
                                2
                            ),
                            new Question(
                                "مڠونجوڠي ساودارا مارا ڤد هاري راي اداله؟",
                                new List<string>
                                {
                                    "عملن باءيق",
                                    "عملن بوروق",
                                    "تيدق ڤنتيڠ",
                                    "سيا-سيا",
                                },
                                0
                            ),
                            new Question(
                                "مڠحرمتي ساودارا مارا يڠ لبيه توا اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤرلو",
                                    "تيدق ڤنتيڠ",
                                },
                                0
                            ),
                            new Question(
                                "دعاء كڤد اورڠ ساكيت اياله؟",
                                new List<string>
                                {
                                    "سموڬ چڤت ماتي",
                                    "سموڬ الله مڽمبوهكنمو",
                                    "سموڬ سماكين ساكيت",
                                    "سموڬ سوسه",
                                },
                                1
                            ),
                            new Question(
                                "لارڠن كتيك منزيارهي اورڠ ساكيت اياله؟",
                                new List<string>
                                {
                                    "ممبري كات سماڠت",
                                    "ممبوات بيسيڠ",
                                    "ممباچ دعاء",
                                    "سڽوم",
                                },
                                1
                            ),
                            new Question(
                                "ادب منزيارهي اورڠ ساكيت د هوسڤيتل اياله؟",
                                new List<string>
                                {
                                    "دودوق سوڤن",
                                    "ملومڤت-لومڤت",
                                    "كتاوا كوات",
                                    "ممبوات بيسيڠ",
                                },
                                0
                            ),
                            new Question(
                                "لارڠن كتيك منزيارهي اورڠ ساكيت د هوسڤيتل اياله؟",
                                new List<string>
                                {
                                    "منجاڬ كبرسيهن",
                                    "ممباوا ماكنن تيدق سسواي",
                                    "منجاڬ ادب",
                                    "بردعاء",
                                },
                                1
                            ),
                            new Question(
                                "چونتوه بواه تاڠن يڠ تيدق سسواي اونتوق اورڠ ساكيت اياله؟",
                                new List<string>
                                {
                                    "بواه-بواهن سڬر",
                                    "اءير برڬس",
                                    "جوس بواه",
                                    "بوكو دعاء",
                                },
                                1
                            ),
                            new Question(
                                "كلبيهن برادب كتيك منزيارهي اورڠ ساكيت اياله؟",
                                new List<string>
                                {
                                    "ممبينا كاسيه سايڠ",
                                    "ممبوات اورڠ ساكيت بنچي",
                                    "منمبه ڤرموسوهن",
                                    "ممبوات ماره",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب كتيك منزيارهي اورڠ ساكيت اياله؟",
                                new List<string>
                                {
                                    "ممبوات اورڠ ساكيت ترڬڠڬو",
                                    "اورڠ ساكيت ڬمبيرا",
                                    "اورڠ ساكيت تنڠ",
                                    "اورڠ ساكيت ڤوليه",
                                },
                                0
                            ),
                            new Question(
                                "ممبنتو اورڠ ساكيت اداله اخلاق؟",
                                new List<string> { "بوروق", "موليا", "جاهت", "تيدق ڤنتيڠ" },
                                1
                            ),
                            new Question(
                                "مندعاكن كسمبوهن اورڠ ساكيت اداله تندا؟",
                                new List<string> { "كاسيه سايڠ", "بنچي", "دندم", "سومبوڠ" },
                                0
                            ),
                            new Question(
                                "مڠوچڤكن سلام كڤد اورڠ ساكيت اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤنتيڠ",
                                    "سيا-سيا",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا منزيارهي كماتين كيت هندقله؟",
                                new List<string>
                                {
                                    "ديام دان تنڠ",
                                    "كتاوا",
                                    "ممبوات بيسيڠ",
                                    "برماءين",
                                },
                                0
                            ),
                            new Question(
                                "مڠوچڤكن تعزية كڤد كلوارڬ سي ماتي اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤرلو",
                                    "تيدق ڤنتيڠ",
                                },
                                0
                            ),
                            new Question(
                                "دعاء كڤد سي ماتي اياله؟",
                                new List<string>
                                {
                                    "يا الله، امڤونيله دي",
                                    "يا الله، سيقساله دي",
                                    "يا الله، هيناكن دي",
                                    "يا الله، جاءوهيله دي",
                                },
                                0
                            ),
                            new Question(
                                "مناڠيسي كماتين دڠن برلبيهن حكومڽ؟",
                                new List<string> { "حرام", "واجب", "سنة", "هاروس" },
                                0
                            ),
                            new Question(
                                "مڠيريڠي جنازه هيڠڬ ك قبور اداله؟",
                                new List<string>
                                {
                                    "عملن موليا",
                                    "عملن بوروق",
                                    "تيدق ڤنتيڠ",
                                    "سيا-سيا",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا منزيارهي قبور كيت هندقله؟",
                                new List<string> { "ممباچ دعاء", "منجريت", "برماءين", "كتاوا" },
                                0
                            ),
                            new Question(
                                "مڠوچڤكن سلام كڤد اهلي قبور اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤرلو",
                                    "تيدق ڤنتيڠ",
                                },
                                0
                            ),
                            new Question(
                                "دعاء كتيك منزيارهي قبور اياله؟",
                                new List<string>
                                {
                                    "يا الله، امڤونكن ڤڠهوني قبور اين",
                                    "يا الله، سيقساله ڤڠهوني قبور اين",
                                    "يا الله، هيناكن ڤڠهوني قبور اين",
                                    "يا الله، جاءوهيله ڤڠهوني قبور اين",
                                },
                                0
                            ),
                            new Question(
                                "مڠحرمتي كاوسن قبور اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤنتيڠ",
                                    "تيدق ڤرلو",
                                },
                                0
                            ),
                            new Question(
                                "برماءين-ماءين د كاوسن قبور اداله؟",
                                new List<string>
                                {
                                    "ادب بوروق",
                                    "ادب موليا",
                                    "تيدق ڤنتيڠ",
                                    "عملن باءيق",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا مڠحاضيري مجليس كراماين كيت هندقله؟",
                                new List<string>
                                {
                                    "ممبري سلام",
                                    "ممبوات بيسيڠ",
                                    "مڽوسهكن توان رومه",
                                    "مڠهينا",
                                },
                                0
                            ),
                            new Question(
                                "برڤاكاين سوڤن كتيك مجليس اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤنتيڠ",
                                    "تيدق ڤرلو",
                                },
                                0
                            ),
                            new Question(
                                "ممبنتو توان رومه دالم مجليس اداله؟",
                                new List<string>
                                {
                                    "اخلاق موليا",
                                    "اخلاق بوروق",
                                    "تيدق ڤنتيڠ",
                                    "تيدق ڤرلو",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا ماكن د مجليس كيت هندقله؟",
                                new List<string>
                                {
                                    "تيدق ممبازير",
                                    "ممبازير",
                                    "ممبوات بيسيڠ",
                                    "مڠهينا",
                                },
                                0
                            ),
                            new Question(
                                "مڠحرمتي تتامو لاءين دالم مجليس اداله؟",
                                new List<string>
                                {
                                    "ادب موليا",
                                    "ادب بوروق",
                                    "تيدق ڤنتيڠ",
                                    "تيدق ڤرلو",
                                },
                                0
                            ),
                        },
                    },
                    new Levels // Level Akidah Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه ڤڠرتين صيفت إرادة الله؟",
                                new List<string>
                                {
                                    "الله مها مندڠر",
                                    "الله مها بركواس",
                                    "الله مننتوكن سڬالا كهندق-ڽ",
                                    "الله مها مليهت",
                                },
                                2
                            ),
                            new Question(
                                "دليل عقلي الله برصيفت إرادة اياله ...",
                                new List<string>
                                {
                                    "مستحيل الله تيدق بركهندق",
                                    "الله مها مندڠر",
                                    "الله مها مليهت",
                                    "مستحيل الله بركواس",
                                },
                                0
                            ),
                            new Question(
                                "صيفت برلاونن دڠن إرادة اياله ...",
                                new List<string> { "كهندق", "ترڤقسا", "علمو", "هيدوڤ" },
                                1
                            ),
                            new Question(
                                "كسن برايمان دڠن صيفت إرادة اياله ...",
                                new List<string>
                                {
                                    "تنڠ منريما تقدير الله",
                                    "ڤوتوس اسا دڠن هيدوڤ",
                                    "تيدق ڤرچاي ڤد تقدير",
                                    "تيدق ماهو بروسها",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برايمان دڠن صيفت إرادة اياله ...",
                                new List<string>
                                {
                                    "هيدوڤ بهاڬيا",
                                    "لمه ايمان",
                                    "سماكين يقين ڤد تقدير",
                                    "منيڠكتكن عمل",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صيفت علم الله؟",
                                new List<string>
                                {
                                    "الله مها مڠتاهوءي سڬالا ڤركارا",
                                    "الله مها مندڠر",
                                    "الله مها مليهت",
                                    "الله مها بركواس",
                                },
                                0
                            ),
                            new Question(
                                "دليل نقلي الله مها مڠتاهوءي اياله ...",
                                new List<string>
                                {
                                    "سورة البقرة ايات 255",
                                    "سورة الفاتحة ايات 1",
                                    "سورة الإخلاص ايات 1",
                                    "سورة الكافرون ايات 6",
                                },
                                0
                            ),
                            new Question(
                                "دليل عقلي الله برصيفت علم اياله ...",
                                new List<string>
                                {
                                    "مستحيل الله جاهيل",
                                    "مستحيل الله بركواس",
                                    "مستحيل الله مندڠر",
                                    "مستحيل الله هيدوڤ",
                                },
                                0
                            ),
                            new Question(
                                "ڤربيذاءن علمو الله دڠن علمو ماءنسي اياله ...",
                                new List<string>
                                {
                                    "علمو ماءنسي ترباتس، علمو الله تيدق ترباتس",
                                    "علمو ماءنسي سمڤورنا",
                                    "علمو الله ترباتس",
                                    "علمو الله سام دڠن ماءنسي",
                                },
                                0
                            ),
                            new Question(
                                "صيفت برلاونن دڠن علم اياله ...",
                                new List<string> { "تاهو", "جاهيل", "هيدوڤ", "بركواس" },
                                1
                            ),
                            new Question(
                                "كسن برايمان دڠن صيفت علم اياله ...",
                                new List<string>
                                {
                                    "يقين الله مڠتاهوءي سڬالا عمل",
                                    "تيدق تاكوت ملاكوكن دوسا",
                                    "بربوات سسوك هاتي",
                                    "تيدق بروسها",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برايمان دڠن صيفت علم اياله ...",
                                new List<string>
                                {
                                    "منجادي لبيه برتقوى",
                                    "هيلڠ راس تاكوت كڤد الله",
                                    "منمبه عمل صالح",
                                    "سماكين راجين برعبادة",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صيفت سمع؟",
                                new List<string>
                                {
                                    "الله مها مليهت",
                                    "الله مها مندڠر",
                                    "الله مها بركواس",
                                    "الله مها مڠتاهوءي",
                                },
                                1
                            ),
                            new Question(
                                "دليل نقلي الله مها مندڠر اياله ...",
                                new List<string>
                                {
                                    "سورة البقرة ايات 127",
                                    "سورة الفاتحة ايات 1",
                                    "سورة الإخلاص ايات 2",
                                    "سورة الناس ايات 6",
                                },
                                0
                            ),
                            new Question(
                                "دليل عقلي الله برصيفت سمع اياله ...",
                                new List<string>
                                {
                                    "مستحيل الله تولي",
                                    "مستحيل الله بيسو",
                                    "مستحيل الله جاهيل",
                                    "مستحيل الله ماتي",
                                },
                                0
                            ),
                            new Question(
                                "ڤربيذاءن ڤندڠرن الله دڠن ماءنسي اياله ...",
                                new List<string>
                                {
                                    "الله مندڠر دڠن تليڠا",
                                    "الله مندڠر تنڤا الت، ماءنسي ڤرلوكن تليڠا",
                                    "الله مندڠر سديكيت سهاج",
                                    "الله مندڠر سام سڤرتي ماءنسي",
                                },
                                1
                            ),
                            new Question(
                                "صيفت برلاونن دڠن سمع اياله ...",
                                new List<string> { "مندڠر", "تولي", "مليهت", "جاهيل" },
                                1
                            ),
                            new Question(
                                "كسن برايمان دڠن صيفت سمع اياله ...",
                                new List<string>
                                {
                                    "تاكوت بركات بوروق",
                                    "تيدق ڤدولي بركات اڤ-اڤ",
                                    "تيدق منجاڬ ليده",
                                    "سوك برڬادوه",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برايمان دڠن صيفت سمع اياله ...",
                                new List<string>
                                {
                                    "سنتياس برذكر",
                                    "تيدق منجاڬ ڤرچاكڤن",
                                    "منجادي لبيه برهاتي-هاتي",
                                    "سنتياس تاكوت كڤد الله",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صيفت بصر؟",
                                new List<string>
                                {
                                    "الله مها مليهت",
                                    "الله مها مندڠر",
                                    "الله مها بركواس",
                                    "الله مها هيدوڤ",
                                },
                                0
                            ),
                            new Question(
                                "دليل نقلي الله مها مليهت اياله ...",
                                new List<string>
                                {
                                    "سورة البقرة ايات 233",
                                    "سورة الملك ايات 19",
                                    "سورة الفاتحة ايات 5",
                                    "سورة الإخلاص ايات 1",
                                },
                                1
                            ),
                            new Question(
                                "دليل عقلي الله برصيفت بصر اياله ...",
                                new List<string>
                                {
                                    "مستحيل الله بوتا",
                                    "مستحيل الله بيسو",
                                    "مستحيل الله جاهيل",
                                    "مستحيل الله تولي",
                                },
                                0
                            ),
                            new Question(
                                "صيفت برلاونن دڠن بصر اياله ...",
                                new List<string> { "مليهت", "بوتا", "تولي", "جاهيل" },
                                1
                            ),
                            new Question(
                                "كسن برايمان دڠن صيفت بصر اياله ...",
                                new List<string>
                                {
                                    "يقين الله مليهت ڤربواتن كيت",
                                    "براني بوات معصية",
                                    "تيدق منجاڬ ڤربواتن",
                                    "تيدق ڤدولي اورڠ لاءين",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برايمان دڠن صيفت بصر اياله ...",
                                new List<string>
                                {
                                    "هيدوڤ بهاڬيا",
                                    "سوك بوات معصية",
                                    "راجين برعبادة",
                                    "سوك منولوڠ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صيفت حياة؟",
                                new List<string>
                                {
                                    "الله مها هيدوڤ",
                                    "الله مها مندڠر",
                                    "الله مها مڠتاهوءي",
                                    "الله مها مليهت",
                                },
                                0
                            ),
                            new Question(
                                "دليل نقلي الله مها هيدوڤ اياله ...",
                                new List<string>
                                {
                                    "سورة البقرة ايات 255",
                                    "سورة الفاتحة ايات 6",
                                    "سورة الإخلاص ايات 3",
                                    "سورة الناس ايات 5",
                                },
                                0
                            ),
                            new Question(
                                "دليل عقلي الله برصيفت حياة اياله ...",
                                new List<string>
                                {
                                    "مستحيل الله ماتي",
                                    "مستحيل الله تولي",
                                    "مستحيل الله بوتا",
                                    "مستحيل الله لمه",
                                },
                                0
                            ),
                            new Question(
                                "صيفت برلاونن دڠن حياة اياله ...",
                                new List<string> { "هيدوڤ", "ماتي", "تيدور", "لوڤا" },
                                1
                            ),
                            new Question(
                                "ڤربيذاءن حياة الله دڠن ماءنسي اياله ...",
                                new List<string>
                                {
                                    "حياة ماءنسي ككل",
                                    "حياة الله ككل، ماءنسي سمنتارا",
                                    "حياة الله سمنتارا",
                                    "حياة الله سام دڠن ماءنسي",
                                },
                                1
                            ),
                            new Question(
                                "كسن برايمان دڠن صيفت حياة الله اياله ...",
                                new List<string>
                                {
                                    "يقين الله مها هيدوڤ سلاما-لاماڽ",
                                    "تاكوت ماتي",
                                    "تيدق برعبادة",
                                    "تيدق ماهو بلاجر",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برايمان دڠن صيفت حياة اياله ...",
                                new List<string>
                                {
                                    "تيدق يقين كڤد الله",
                                    "سماكين برتقوى",
                                    "سماكين راجين برعبادة",
                                    "سماكين توكل",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين رسول؟",
                                new List<string>
                                {
                                    "للاكي ڤيليهن الله يڠ منريما وحيو",
                                    "ملائكة يڠ ڤاتوه",
                                    "والي الله",
                                    "صحابة نبي",
                                },
                                0
                            ),
                            new Question(
                                "صيفت واجب باڬي رسول اياله ...",
                                new List<string>
                                {
                                    "صدق، أمانة، تبليغ، فطانة",
                                    "جاهيل، خيانت، منيڤو، لالاي",
                                    "كاي، ميسكين، كوات، لمه",
                                    "تيڠڬي، رنده، چڤت، لمبت",
                                },
                                0
                            ),
                            new Question(
                                "صيفت مستحيل باڬي رسول اياله ...",
                                new List<string> { "صدق", "خيانت", "أمانة", "تبليغ" },
                                1
                            ),
                            new Question(
                                "صيفت هاروس باڬي رسول اياله ...",
                                new List<string>
                                {
                                    "بركهوين اتاو تيدق",
                                    "كاي",
                                    "ميسكين",
                                    "تيدق ماتي",
                                },
                                0
                            ),
                            new Question(
                                "حكوم برايمان دڠن صيفت رسول اياله ...",
                                new List<string> { "هاروس", "سنة", "واجب", "مكروه" },
                                2
                            ),
                            new Question(
                                "كسن برايمان دڠن صيفت رسول اياله ...",
                                new List<string>
                                {
                                    "منجاديكن رسول چونتوه تلادن",
                                    "تيدق مڠيكوت رسول",
                                    "ممبنچي رسول",
                                    "لالاي درڤد سنة",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه مقصود ڤركارا سمعيات؟",
                                new List<string>
                                {
                                    "ڤركارا يڠ هاڽ دكتاهوءي ملالوءي وحيو",
                                    "ڤركارا يڠ داڤت دبوقتيكن عقل",
                                    "ڤركارا يڠ بوليه دليهت",
                                    "ڤركارا يڠ بوليه دراس",
                                },
                                0
                            ),
                            new Question(
                                "حكوم برايمان دڠن ڤركارا سمعيات اياله ...",
                                new List<string> { "واجب", "سنة", "هاروس", "مكروه" },
                                0
                            ),
                            new Question(
                                "انتارا چونتوه ڤركارا سمعيات اياله ...",
                                new List<string>
                                {
                                    "عالم برزخ",
                                    "ممباچ دعاء",
                                    "مڠاجي القرءان",
                                    "منونايكن حج",
                                },
                                0
                            ),
                            new Question(
                                "نام ملائكة يڠ واجب دكتاهوءي اياله ...",
                                new List<string>
                                {
                                    "جبريل، ميكائيل، إسرافيل، عزرائيل",
                                    "جبريل، مالك، رقيب، عتيد",
                                    "ميكائيل، إسرافيل، نكير، منكر",
                                    "هاڽ جبريل",
                                },
                                0
                            ),
                            new Question(
                                "سؤالن قبور دتاڽ اوليه ..",
                                new List<string>
                                {
                                    "ملائكة رقيب دان عتيد",
                                    "ملائكة منكر دان نكير",
                                    "ملائكة ميكائيل دان إسرافيل",
                                    "ملائكة جبريل دان عزرائيل",
                                },
                                1
                            ),
                            new Question(
                                "چونتوه نعمة قبور اياله ...",
                                new List<string>
                                {
                                    "باو هاروم دري شرڬ",
                                    "عذاب دڠن اڤي",
                                    "دهيمڤيت قبور",
                                    "دڤوكول ملائكة",
                                },
                                0
                            ),
                            new Question(
                                "چونتوه عذاب قبور اياله ...",
                                new List<string>
                                {
                                    "چهاي ترڠ دري شرڬ",
                                    "قبور دلواسكن",
                                    "هيمڤيتن قبور",
                                    "باو هاروم",
                                },
                                2
                            ),
                            new Question(
                                "ڤادڠ محشر اياله.",
                                new List<string>
                                {
                                    "تمڤت بركومڤول ماءنسي سلڤس دباڠكيتكن",
                                    "تمڤت ماءنسي بلاجر",
                                    "تمڤت اورڠ ماتي دسماديكن",
                                    "تمڤت ملائكة تيڠڬل",
                                },
                                0
                            ),
                            new Question(
                                "حساب برمقصود ...",
                                new List<string>
                                {
                                    "تيمبڠن عملن",
                                    "سؤال جواب عملن ماءنسي",
                                    "تمڤت ماءنسي بركومڤول",
                                    "جمبتن منوجو شرڬ",
                                },
                                1
                            ),
                            new Question(
                                "ميزان اياله ...",
                                new List<string>
                                {
                                    "تيمبڠن عملن باءيق دان بوروق",
                                    "سؤالن قبور",
                                    "نعمة قبور",
                                    "هاري قيامة",
                                },
                                0
                            ),
                            new Question(
                                "تيتين صراط اياله ...",
                                new List<string>
                                {
                                    "جمبتن د اتس نراك منوجو شرڬ",
                                    "جالن منوجو ڤادڠ محشر",
                                    "ڤينتو ماسوق شرڬ",
                                    "ڤينتو ماسوق نراك",
                                },
                                0
                            ),
                            new Question(
                                "ڬولوڠن اهلي شرڬ اياله ...",
                                new List<string>
                                {
                                    "اورڠ برايمان دان برعمل صالح",
                                    "اورڠ كافير",
                                    "اورڠ منافق",
                                    "اورڠ ايڠكر",
                                },
                                0
                            ),
                        },
                    },
                    new Levels // Level Ibadah Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه ڤڠرتين صلاة سنة رواتب؟",
                                new List<string>
                                {
                                    "صلاة يڠ دلاكوكن ڤد وقتو مالم سهاج",
                                    "صلاة يڠ مڠيريڠي صلاة فرض",
                                    "صلاة يڠ دلاكوكن هاڽ ڤد بولن رمضان",
                                    "صلاة يڠ دلاكوكن كتيك اد حاجت ترتنتو",
                                },
                                1
                            ),
                            new Question(
                                "صلاة سنة رواتب دلاكوكن ...",
                                new List<string>
                                {
                                    "سبلوم دان سلڤس صلاة فرض",
                                    "سلڤس صلاة جنازه",
                                    "سلڤس صلاة استخارة",
                                    "ڤد مالم جمعة سهاج",
                                },
                                0
                            ),
                            new Question(
                                "حكوم صلاة سنة رواتب اياله ...",
                                new List<string> { "واجب", "سنة مؤكد", "سنة بياسا", "هاروس" },
                                1
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة سنة رواتب مؤكد يڠ ڤاليڠ اوتام اياله ...",
                                new List<string> { "6 ركعة", "8 ركعة", "10 ركعة", "12 ركعة" },
                                3
                            ),
                            new Question(
                                "انتارا فضيلة صلاة رواتب اياله ...",
                                new List<string>
                                {
                                    "مندافت ڤهالا شهيد",
                                    "دبينا رومه د شرڬ",
                                    "مندافت رزقي مليمڤه",
                                    "عمور دڤنجڠكن",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صلاة تراويح؟",
                                new List<string>
                                {
                                    "صلاة سنة د بولن رمضان ڤد مالم هاري",
                                    "صلاة سنة سلڤس صبح",
                                    "صلاة سنة اونتوق مموهون حاجت",
                                    "صلاة سنة ڤد ڤاڬي هاري راي",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة وتر يڠ ڤاليڠ سديكيت اياله ...",
                                new List<string> { "1 ركعة", "2 ركعة", "3 ركعة", "4 ركعة" },
                                0
                            ),
                            new Question(
                                "فضيلة صلاة تراويح انتاراڽ اياله ...",
                                new List<string>
                                {
                                    "مڠهاڤوسكن دوسا-دوسا كچيل",
                                    "ممبري كصيحتن توبوه بادن",
                                    "ممنجڠكن عمور",
                                    "مڽمبوهكن ڤڽاكيت",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صلاة حاجت؟",
                                new List<string>
                                {
                                    "صلاة سنة كرانا ڬرهانا",
                                    "صلاة سنة اونتوق مموهون سسواتو حاجت",
                                    "صلاة سنة سلڤس صلاة فرض",
                                    "صلاة سنة د بولن شوال",
                                },
                                1
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة حاجت اياله ...",
                                new List<string> { "1 ركعة", "2 ركعة", "3 ركعة", "4 ركعة" },
                                1
                            ),
                            new Question(
                                "انتارا فضيلة صلاة حاجت اياله ...",
                                new List<string>
                                {
                                    "حاجت دڤرمودهكن الله",
                                    "عمور دڤنجڠكن",
                                    "مندافت رومه د شرڬ",
                                    "دعاء دتولق",
                                },
                                0
                            ),
                            new Question(
                                "بيلاكه وقتو صلاة ضحى برمولا؟",
                                new List<string>
                                {
                                    "سلڤس ماتاهاري ناءيق هيڠڬ ترڬلينچير",
                                    "سلڤس صلاة مغرب",
                                    "سلڤس عشاء",
                                    "سلڤس صبح",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة ضحى ڤاليڠ سديكيت اياله ...",
                                new List<string> { "2 ركعة", "4 ركعة", "6 ركعة", "8 ركعة" },
                                0
                            ),
                            new Question(
                                "دعاء سلڤس صلاة ضحى مموهون ...",
                                new List<string>
                                {
                                    "كقواتن ايمان",
                                    "رزقي يڠ بركت",
                                    "كسمبوهن دري ساكيت",
                                    "عمور ڤنجڠ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صلاة تهجد؟",
                                new List<string>
                                {
                                    "صلاة سنة سلڤس صبح",
                                    "صلاة سنة مالم سلڤس تيدور",
                                    "صلاة سنة كرانا ڬرهانا",
                                    "صلاة سنة برجماعة د بولن رمضان",
                                },
                                1
                            ),
                            new Question(
                                "شرط اونتوق صلاة تهجد اياله ...",
                                new List<string>
                                {
                                    "ڤرلو دلاكوكن برجماعة",
                                    "ڤرلو تيدور دهولو سبلوم باڠون",
                                    "ڤرلو دلاكوكن سلڤس عصر",
                                    "ڤرلو دلاكوكن سلڤس صبح",
                                },
                                1
                            ),
                            new Question(
                                "انتارا فضيلة صلاة تهجد اياله ...",
                                new List<string>
                                {
                                    "مڽيحتكن بادن",
                                    "مندكتكن ديري كڤد الله",
                                    "ڤنجڠ عمور",
                                    "مندافت هرتا باڽق",
                                },
                                1
                            ),
                            new Question(
                                "صلاة استخارة دلاكوكن اڤابيلا ...",
                                new List<string>
                                {
                                    "هندق ممبوات ڤيليهن",
                                    "هندق منزيارهي قبور",
                                    "هندق مڽمبوت هاري راي",
                                    "هندق منونايكن حج",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة استخارة اياله ...",
                                new List<string> { "1 ركعة", "2 ركعة", "3 ركعة", "4 ركعة" },
                                1
                            ),
                            new Question(
                                "اڤاكه فضيلة صلاة استخارة؟",
                                new List<string>
                                {
                                    "مندافت ككاياءن",
                                    "مندافت ڤتونجوق الله",
                                    "مندافت عمور ڤنجڠ",
                                    "مندافت كصيحتن",
                                },
                                1
                            ),
                            new Question(
                                "صلاة ڬرهانا دلاكوكن كتيك ...",
                                new List<string>
                                {
                                    "برلاكو ڬرهانا ماتاهاري اتاو بولن",
                                    "برلاكو ريبوت",
                                    "برلاكو بنجير",
                                    "برلاكو ڬمڤا بومي",
                                },
                                0
                            ),
                            new Question(
                                "لفظ سروان اونتوق صلاة ڬرهانا اياله ...",
                                new List<string>
                                {
                                    "الله اكبر",
                                    "الصلاة جامعة",
                                    "لا إله إلا الله",
                                    "سبحان الله",
                                },
                                1
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة ڬرهانا ماتاهاري اياله ...",
                                new List<string> { "1 ركعة", "2 ركعة", "3 ركعة", "4 ركعة" },
                                1
                            ),
                            new Question(
                                "اڤاكه فضيلة صلاة ڬرهانا؟",
                                new List<string>
                                {
                                    "مندافت ڤتونجوق",
                                    "مڠيڠتكن كبسرن الله",
                                    "مڽيحتكن بادن",
                                    "منمبهكن رزقي",
                                },
                                1
                            ),
                            new Question(
                                "بيلاكه صلاة هاري راي عيد الفطري دلقساناكن؟",
                                new List<string>
                                {
                                    "سلڤس صبح",
                                    "سلڤس ماتاهاري ناءيق",
                                    "سلڤس مغرب",
                                    "سلڤس عشاء",
                                },
                                1
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة هاري راي اياله ...",
                                new List<string> { "1 ركعة", "2 ركعة", "3 ركعة", "4 ركعة" },
                                1
                            ),
                            new Question(
                                "اڤاكه لفظ تكبير هاري راي؟",
                                new List<string>
                                {
                                    "الله اكبر 3 كالي دان الحمدلله",
                                    "الله اكبر، الله اكبر، الله اكبر ولله الحمد",
                                    "سبحان الله والحمدلله",
                                    "لا إله إلا الله",
                                },
                                1
                            ),
                            new Question(
                                "انتارا فضيلة صلاة هاري راي اياله ...",
                                new List<string>
                                {
                                    "مڠهاڤوسكن دوسا بسر",
                                    "مندافت ڬنجرن ڤهالا",
                                    "مندافت عمور ڤنجڠ",
                                    "منجادي كاي",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين صلاة توبة؟",
                                new List<string>
                                {
                                    "صلاة سنة مموهون كأمڤونن دوسا",
                                    "صلاة سنة مالم سلڤس تيدور",
                                    "صلاة سنة كرانا حاجت",
                                    "صلاة سنة ڬرهانا",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن ركعة صلاة توبة اياله ...",
                                new List<string> { "1 ركعة", "2 ركعة", "3 ركعة", "4 ركعة" },
                                1
                            ),
                            new Question(
                                "وقتو يڠ سسواي اونتوق صلاة توبة اياله.",
                                new List<string>
                                {
                                    "بيلا-بيلا ماس كچوالي وقتو يڠ دلارڠ",
                                    "سلڤس صبح",
                                    "سلڤس عصر",
                                    "سلڤس مغرب",
                                },
                                0
                            ),
                            new Question(
                                "انتارا فضيلة صلاة توبة اياله.",
                                new List<string>
                                {
                                    "دوسا دهاڤوسكن الله",
                                    "مندافت رومه د شرڬ",
                                    "مندافت عمور ڤنجڠ",
                                    "مندافت كصيحتن",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠرتين ڤواسا؟",
                                new List<string>
                                {
                                    "مناهم ديري درڤد ماكن، مينوم دان ڤركارا ممبطلكن ڤواسا",
                                    "مناهم ديري دري برچاكڤ",
                                    "مناهم ديري دري تيدور",
                                    "مناهم ديري دري ماره",
                                },
                                0
                            ),
                            new Question(
                                "حكوم برڤواسا د بولن رمضان اياله ...",
                                new List<string> { "هاروس", "سنة", "واجب", "مكروه" },
                                2
                            ),
                            new Question(
                                "انتارا ڤركارا يڠ ممبطلكن ڤواسا اياله ...",
                                new List<string>
                                {
                                    "مندي واجب",
                                    "ماكن دان مينوم دڠن سڠاج",
                                    "تيدور ڤد سياڠ هاري",
                                    "برجالن جاءوه",
                                },
                                1
                            ),
                            new Question(
                                "انتارا فضيلة ڤواسا رمضان اياله ...",
                                new List<string>
                                {
                                    "مندافت كصيحتن",
                                    "مڠهاڤوسكن دوسا",
                                    "مندافت عمور ڤنجڠ",
                                    "منجادي كاي",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه كڤنتيڠن ڤواسا باڬي سأورڠ مسلم؟",
                                new List<string>
                                {
                                    "ملاتيه ديري برصبر",
                                    "منجادي كوات",
                                    "منجادي كاي",
                                    "منجادي ڤنداي",
                                },
                                0
                            ),
                            new Question(
                                "انتارا جنيس ڤواسا واجب سلاين رمضان اياله ...",
                                new List<string>
                                {
                                    "ڤواسا اثنين خميس",
                                    "ڤواسا عرفة",
                                    "ڤواسا نذر",
                                    "ڤواسا شوال",
                                },
                                2
                            ),
                            new Question(
                                "انتارا چونتوه ڤواسا سنة اياله ...",
                                new List<string>
                                {
                                    "ڤواسا رمضان",
                                    "ڤواسا كفارة",
                                    "ڤواسا اثنين دان خميس",
                                    "ڤواسا نذر",
                                },
                                2
                            ),
                            new Question(
                                "انتارا حكمة ڤواسا ترهادڤ كصيحتن اياله ...",
                                new List<string>
                                {
                                    "مڠورڠكن برت بادن",
                                    "مڽيحتكن توبوه بادن",
                                    "منجادي كوات",
                                    "ڤنجڠ عمور",
                                },
                                1
                            ),
                            new Question(
                                "انتارا حكمة ڤواسا دري سڬي روحاني اياله ...",
                                new List<string>
                                {
                                    "ممبرسيهكن هاتي",
                                    "مندافت عمور ڤنجڠ",
                                    "منجادي كاي",
                                    "مندافت ڤڠكت",
                                },
                                0
                            ),
                            new Question(
                                "انتارا لارڠن كتيك برڤواسا اياله ...",
                                new List<string>
                                {
                                    "ماكن دان مينوم ڤد سياڠ هاري",
                                    "تيدور ڤد سياڠ هاري",
                                    "بلاجر ڤد سياڠ هاري",
                                    "بكرجا ڤد سياڠ هاري",
                                },
                                0
                            ),
                            new Question(
                                "انتارا حكمة ڤواسا ترهادڤ هوبوڠن سوسيال اياله ...",
                                new List<string>
                                {
                                    "منجاءوهكن ديري دري مشاركت",
                                    "منيمبولكن راس سيمڤاتي",
                                    "منجادي كاي",
                                    "مندافت ڤڠكت",
                                },
                                1
                            ),
                            new Question(
                                "ڤواسا انم هاري د بولن شوال ديناماكن ڤواسا ...",
                                new List<string>
                                {
                                    "ڤواسا نذر",
                                    "ڤواسا سنة شوال",
                                    "ڤواسا عرفة",
                                    "ڤواسا اثنين خميس",
                                },
                                1
                            ),
                        },
                    },
                    new Levels // Level Sirah Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه ڤريستيوا ڤنتيڠ يڠ برلاكو دالم ڤرڠ بدر؟",
                                new List<string>
                                {
                                    "رسول الله ﷺ برهجرة ك مدينة",
                                    "ڤرتمڤورن ڤرتام انتارا إسلام دان قريش",
                                    "ڤرجنجين حديبية دتنداتاڠني",
                                    "ڤمبوكاءن كوتا مكة",
                                },
                                1
                            ),
                            new Question(
                                "سبب اوتام برلاكوڽ ڤرڠ بدر اياله؟",
                                new List<string>
                                {
                                    "اورڠ قريش مرمڤس هرتا اورڠ إسلام",
                                    "اورڠ قريش مڽرڠ مدينة",
                                    "اورڠ قريش ممبنتو يهودي",
                                    "اورڠ قريش مڠهالڠ رسول الله ﷺ بردعوه",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن تنترا إسلام دالم ڤرڠ بدر اياله لبيه كورڠ؟",
                                new List<string>
                                {
                                    "313 اورڠ",
                                    "500 اورڠ",
                                    "700 اورڠ",
                                    "1000 اورڠ",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن تنترا قريش دالم ڤرڠ بدر اياله لبيه كورڠ؟",
                                new List<string>
                                {
                                    "200 اورڠ",
                                    "500 اورڠ",
                                    "1000 اورڠ",
                                    "1500 اورڠ",
                                },
                                2
                            ),
                            new Question(
                                "ڤرتولوڠن الله كڤد تنترا إسلام دالم ڤرڠ بدر اياله دڠن؟",
                                new List<string>
                                {
                                    "تورونڽ هوجن",
                                    "تورونڽ ملائكة",
                                    "تورونڽ ريبوت ڤاسير",
                                    "تورونڽ ڬوروه دان كيلت",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه حاصيل درڤد ڤرڠ بدر؟",
                                new List<string>
                                {
                                    "إسلام كاله",
                                    "إسلام منڠ دڠن ڤرتولوڠن الله",
                                    "قريش مڽره ديري",
                                    "تنترا إسلام لاري دري ميدن ڤرڠ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه حكمة درڤد ڤرڠ بدر؟",
                                new List<string>
                                {
                                    "منونجوقكن كلمهن تنترا إسلام",
                                    "مڠواتكن ايمان دان سماڠت اومت إسلام",
                                    "مڠورڠكن دعوه رسول الله ﷺ",
                                    "مڠهالڠ إسلام بركمبڠ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا ڤنتيڠ يڠ برلاكو دالم ڤرڠ أحد؟",
                                new List<string>
                                {
                                    "رسول الله ﷺ دبويكوت",
                                    "رسول الله ﷺ چدرا",
                                    "رسول الله ﷺ برهجرة",
                                    "رسول الله ﷺ وفت",
                                },
                                1
                            ),
                            new Question(
                                "سبب اوتام ڤرڠ أحد برلاكو اياله؟",
                                new List<string>
                                {
                                    "اورڠ قريش ايڠين ممبالس ككالهن د بدر",
                                    "اورڠ قريش ايڠين مڠهالڠ هجرة",
                                    "اورڠ قريش ايڠين مناون مدينة",
                                    "اورڠ قريش ايڠين برداماي",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه صحابت يڠ منجاڬ رسول الله ﷺ دالم ڤرڠ أحد؟",
                                new List<string>
                                {
                                    "أبو بكر",
                                    "علي بن أبي طالب",
                                    "طلحة بن عبيد الله",
                                    "عمر الخطاب",
                                },
                                2
                            ),
                            new Question(
                                "اڤاكه ستراتيڬي تنترا إسلام دالم ڤرڠ أحد؟",
                                new List<string>
                                {
                                    "مماسڠ ڤاريت",
                                    "منمڤتكن ڤمانه د بوكيت أحد",
                                    "مڽرڠ ڤد وقتو مالم",
                                    "برليندوڠ دالم مسجد",
                                },
                                1
                            ),
                            new Question(
                                "مڠاڤ تنترا إسلام كاله دالم ڤرڠ أحد؟",
                                new List<string>
                                {
                                    "مريك لاڤر",
                                    "ڤمانه تيدق مماتوهي ارهن نبي",
                                    "مريك ترلالو سديكيت",
                                    "مريك تياد سنجات",
                                },
                                1
                            ),
                            new Question(
                                "سياڤاكه يڠ تربونوه دالم ڤرڠ أحد سباڬاي شهيد تركنل؟",
                                new List<string>
                                {
                                    "حمزة بن عبد المطلب",
                                    "بلال بن رباح",
                                    "أبو عبيدة الجراح",
                                    "عبدالله بن مسعود",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكمة درڤد ڤرڠ أحد؟",
                                new List<string>
                                {
                                    "تنترا إسلام تيدق ڤرلو طاعة ڤرينته",
                                    "اومت إسلام بلاجر ڤنتيڠڽ طاعة ڤميمڤين",
                                    "تنترا قريش سماكين تاكوت",
                                    "إسلام سماكين لمه",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا ڤنتيڠ يڠ برلاكو دالم ڤرڠ خندق؟",
                                new List<string>
                                {
                                    "تنترا إسلام مڠڬالي ڤاريت",
                                    "تنترا إسلام مناون مكة",
                                    "تنترا إسلام برداماي دڠن قريش",
                                    "تنترا إسلام لاري دري ڤرڠ",
                                },
                                0
                            ),
                            new Question(
                                "سبب اوتام ڤرڠ خندق برلاكو اياله؟",
                                new List<string>
                                {
                                    "قريش ايڠين ممبالس دندم أحد",
                                    "قريش ماهو برداماي",
                                    "قريش ماهو ممبنتو يهودي",
                                    "قريش ماهو مناون مدينة",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه يڠ منچادڠكن ستراتيڬي مڠڬالي ڤاريت؟",
                                new List<string> { "أبو هريرة", "سلمان الفارسي", "أبو بكر", "عمر" },
                                1
                            ),
                            new Question(
                                "ڤرتولوڠن الله كڤد تنترا إسلام دالم ڤرڠ خندق اياله؟",
                                new List<string>
                                {
                                    "هوجن ريبوت يڠ كوات",
                                    "تنترا قريش كلاڤرن",
                                    "تنترا قريش دسرڠ بيناتڠ",
                                    "تنترا قريش ساكيت",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن تنترا قريش دان سكوتوڽ دالم ڤرڠ خندق لبيه كورڠ؟",
                                new List<string>
                                {
                                    "3000 اورڠ",
                                    "5000 اورڠ",
                                    "10,000 اورڠ",
                                    "15,000 اورڠ",
                                },
                                2
                            ),
                            new Question(
                                "اڤاكه ڬلرن لاءين باڬي ڤرڠ خندق؟",
                                new List<string> { "ڤرڠ احزاب", "ڤرڠ تبوك", "ڤرڠ حنين", "ڤرڠ بدر" },
                                0
                            ),
                            new Question(
                                "اڤاكه حكمة درڤد ڤرڠ خندق؟",
                                new List<string>
                                {
                                    "منونجوقكن كلمهن اومت إسلام",
                                    "منونجوقكن ڤنتيڠڽ ستراتيڬي دان كصبرن",
                                    "منونجوقكن كهيبتن تنترا قريش",
                                    "ملمهكن اومت إسلام",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا ڤنتيڠ يڠ برلاكو د حديبية؟",
                                new List<string>
                                {
                                    "تنترا إسلام برڤرڠ",
                                    "رسول الله ﷺ مڠاداكن ڤرجنجين داماي",
                                    "رسول الله ﷺ برهجرة",
                                    "رسول الله ﷺ وفت",
                                },
                                1
                            ),
                            new Question(
                                "سبب اوتام ڤرجنجين حديبية دأداكن اياله؟",
                                new List<string>
                                {
                                    "اورڠ إسلام ماهو ماسوق مكة اونتوق عمرة",
                                    "اورڠ إسلام ماهو برداڬڠ",
                                    "اورڠ إسلام ماهو برهجرة",
                                    "اورڠ إسلام ماهو برڤرڠ",
                                },
                                0
                            ),
                            new Question(
                                "سياڤاكه اوتوسن رسول الله ﷺ يڠ دهانتر ك مكة؟",
                                new List<string>
                                {
                                    "أبو سفيان",
                                    "عثمان بن عفان",
                                    "علي بن أبي طالب",
                                    "أبو بكر",
                                },
                                1
                            ),
                            new Question(
                                "انتارا ايسي كاندوڠن ڤرجنجين حديبية اياله؟",
                                new List<string>
                                {
                                    "ڬنچاتن سنجات سلاما 10 تاهون",
                                    "قريش مستي ماسوق إسلام",
                                    "تنترا إسلام مستي كاله",
                                    "اومت إسلام تيدق بوليه برهجرة",
                                },
                                0
                            ),
                            new Question(
                                "كسن ڤرجنجين حديبية كڤد اومت إسلام اياله؟",
                                new List<string>
                                {
                                    "إسلام سماكين لمه",
                                    "إسلام سماكين بركمبڠ",
                                    "إسلام كاله دالم ڤڤرڠن",
                                    "إسلام برهجرة ك حبشة",
                                },
                                1
                            ),
                            new Question(
                                "مڠاڤ ڤرجنجين حديبية دأڠڬڤ كمنڠن بسر إسلام؟",
                                new List<string>
                                {
                                    "كرانا إسلام بوليه برداڬڠ",
                                    "كرانا إسلام بوليه مڽيبركن دعوه دڠن امن",
                                    "كرانا إسلام منڠ ڤرڠ",
                                    "كرانا إسلام داڤت هرتا رمڤسن",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه حكمة درڤد ڤرجنجين حديبية؟",
                                new List<string>
                                {
                                    "ڤنتيڠڽ منڤتي جنجي دان كصبرن",
                                    "ڤنتيڠڽ ملڠڬر جنجي",
                                    "ڤنتيڠڽ ڤڤرڠن",
                                    "ڤنتيڠڽ منيڤو موسوه",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا ڤنتيڠ دالم ڤمبوكاءن كوتا مكة؟",
                                new List<string>
                                {
                                    "رسول الله ﷺ وفت",
                                    "رسول الله ﷺ دان تنترا إسلام مماسوقي مكة تنڤا ڤرتومڤهن داره",
                                    "تنترا قريش مڽرڠ مدينة",
                                    "ڤرجنجين حديبية دتنداتاڠني",
                                },
                                1
                            ),
                            new Question(
                                "سبب اوتام ڤمبوكاءن كوتا مكة اياله؟",
                                new List<string>
                                {
                                    "قريش ملڠڬر ڤرجنجين حديبية",
                                    "قريش مڽرڠ مدينة",
                                    "قريش مڠهينا رسول الله ﷺ",
                                    "قريش مناون صحابت",
                                },
                                0
                            ),
                            new Question(
                                "بيلاڠن تنترا إسلام يڠ منوجو ك مكة اياله لبيه كورڠ؟",
                                new List<string>
                                {
                                    "2000 اورڠ",
                                    "5000 اورڠ",
                                    "10,000 اورڠ",
                                    "20,000 اورڠ",
                                },
                                2
                            ),
                            new Question(
                                "سيكڤ رسول الله ﷺ ترهادڤ قريش ستله منڠ اياله؟",
                                new List<string>
                                {
                                    "ممبالس دندم",
                                    "ممبونوه سموا موسوه",
                                    "ممبري ڤڠامڤونن",
                                    "مڠهالاو مريك",
                                },
                                2
                            ),
                            new Question(
                                "اڤاكه كسن ڤمبوكاءن كوتا مكة؟",
                                new List<string>
                                {
                                    "إسلام منجادي اڬام يڠ كوات دان ترسيبر لواس",
                                    "قريش سماكين بركواس",
                                    "إسلام سماكين لمه",
                                    "إسلام برهجرة لاڬي",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤڠاجرن درڤد ڤمبوكاءن كوتا مكة؟",
                                new List<string>
                                {
                                    "كمنڠن إسلام دڠن ڤرتولوڠن الله",
                                    "ڤنتيڠڽ برڤرڠ سلالو",
                                    "ممبالس دندم ايت موليا",
                                    "إسلام مستي بروندور",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه حكمة درڤد ڤمبوكاءن كوتا مكة؟",
                                new List<string>
                                {
                                    "إسلام منجادي اڬام يڠ كوات دان ترسيبر لواس",
                                    "إسلام منجادي لمه",
                                    "إسلام برهنتي بركمبڠ",
                                    "إسلام هاڽ اونتوق مكة",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه ڤريستيوا سبلوم كوفاتن رسول الله ﷺ؟",
                                new List<string>
                                {
                                    "رسول الله ﷺ ساكيت",
                                    "رسول الله ﷺ برهجرة",
                                    "رسول الله ﷺ برڤرڠ",
                                    "رسول الله ﷺ وفت",
                                },
                                0
                            ),
                            new Question(
                                "سبب اوتام كوفاتن رسول الله ﷺ اياله؟",
                                new List<string>
                                {
                                    "بڬيندا چدرا د بدر",
                                    "بڬيندا چدرا د أحد",
                                    "بڬيندا ساكيت تنيت",
                                    "بڬيندا برهجرة",
                                },
                                2
                            ),
                            new Question(
                                "سياڤاكه يڠ منجادي ڤڠڬنتي رسول الله ﷺ سلڤس كوفاتن بڬيندا؟",
                                new List<string>
                                {
                                    "عمر الخطاب",
                                    "أبو بكر الصديق",
                                    "علي بن أبي طالب",
                                    "عثمان بن عفان",
                                },
                                1
                            ),
                            new Question(
                                "باڬايماناكه سيكڤ صحابت كتيك مڠهادڤي كوفاتن رسول الله ﷺ؟",
                                new List<string>
                                {
                                    "مناڠيس، سديه تتاڤي رضا",
                                    "برڬمبيرا",
                                    "برڤرڠ",
                                    "ملاريكن ديري",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه اعتبار درڤد كوفاتن رسول الله ﷺ؟",
                                new List<string>
                                {
                                    "ستياڤ يڠ هيدوڤ ڤستي اكن ماتي",
                                    "رسول الله ﷺ ككل هيدوڤ",
                                    "إسلام براخير",
                                    "اومت إسلام هيلڠ اڬام",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه كتوكوهن رسول الله ﷺ دالم كلوارڬ؟",
                                new List<string>
                                {
                                    "ڤميمڤين يڠ ظاليم",
                                    "سوامي دان ايه يڠ ڤڽايڠ",
                                    "ابڠ يڠ كاسر",
                                    "باڤ ساودارا يڠ ڬارڠ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه چونتوه اخلاق رسول الله ﷺ ترهادڤ ايستري بڬيندا؟",
                                new List<string>
                                {
                                    "سوك مماراهي",
                                    "ممبنتو دالم اوروسن رومه",
                                    "مڠابايكن تڠڬوڠجواب",
                                    "تيدق برچاكڤ",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه چونتوه رسول الله ﷺ دالم منديديق انق؟",
                                new List<string>
                                {
                                    "مڠابايكن ڤنديديقن انق",
                                    "ممبري كاسيه سايڠ دان تونجوق اجر",
                                    "ممبياركن تنڤا بيمبيڠن",
                                    "برسيكڤ كاسر",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه كتوكوهن رسول الله ﷺ دالم برسوسيال؟",
                                new List<string>
                                {
                                    "منجاءوهي جيرن",
                                    "مڠاسيهي جيرن دان مشاركت",
                                    "ممبنچي اورڠ ميسكين",
                                    "تيدق ڤدولي دڠن مشاركت",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه سيكڤ رسول الله ﷺ دالم ڤرهوبوڠن دڠن صحابت؟",
                                new List<string>
                                {
                                    "سومبوڠ",
                                    "ممنتيڠكن ديري",
                                    "مسرا دان مڠحرمتي مريك",
                                    "تيدق برچاكڤ دڠن مريك",
                                },
                                2
                            ),
                            new Question(
                                "اڤاكه صيفت رسول الله ﷺ كتيك برمشوارت دڠن صحابت؟",
                                new List<string>
                                {
                                    "تيدق مندڠر ڤندڠن",
                                    "برمشوارت دان مندڠر ڤنداڤت صحابت",
                                    "ممبوات كڤوتوسن سنديري سهاج",
                                    "منولق ڤندڠن سموا",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه صيفت اوتام رسول الله ﷺ يڠ منجادي چونتوه؟",
                                new List<string>
                                {
                                    "جوجور، أمانة، مڽمڤاءيكن، بيجقسان",
                                    "منيڤو دان خيانت",
                                    "ظاليم دان سومبوڠ",
                                    "ڤماره دان كاسر",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه اعتبار درڤد كتوكوهن رسول الله ﷺ دالم كلوارڬ؟",
                                new List<string>
                                {
                                    "كيت مستي بركاسر دڠن كلوارڬ",
                                    "كيت مستي منونايكن تڠڬوڠجواب دڠن كاسيه سايڠ",
                                    "كيت تيدق ڤرلو ڤدولي كلوارڬ",
                                    "كيت هاڽ ڤنتيڠكن ديري",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه اعتبار درڤد كتوكوهن رسول الله ﷺ دالم برسوسيال؟",
                                new List<string>
                                {
                                    "مڠاسيهي جيرن دان مشاركت",
                                    "ممبنچي جيرن",
                                    "مڠابايكن مشاركت",
                                    "مموتوسكن صلة الرحيم",
                                },
                                0
                            ),
                            new Question(
                                "اڤاكه اعتبار درڤد كتوكوهن رسول الله ﷺ دالم ڤرهوبوڠن دڠن صحابت؟",
                                new List<string>
                                {
                                    "حرمت-مڠحرمتي دان ستيا كاون",
                                    "برموسوهن دڠن كاون",
                                    "تيدق ڤدولي صحابت",
                                    "ممنتيڠكن ديري",
                                },
                                0
                            ),
                        },
                    },
                    new Levels // Level Adab Tahap 5
                    {
                        questions = new List<Question>
                        {
                            new Question(
                                "اڤاكه مقصود برينترقسي؟",
                                new List<string>
                                {
                                    "برچاكڤ سأورڠ ديري",
                                    "برهوبوڠ دڠن اورڠ لاءين",
                                    "منوليس سهاج",
                                    "دودوق ديام",
                                },
                                1
                            ),
                            new Question(
                                "انتارا ادب برينترقسي اياله؟",
                                new List<string>
                                {
                                    "مڠڬوناكن كات-كات كاسر",
                                    "سڽوم دان ممبري سلام",
                                    "مموتوڠ ڤرچاكڤن",
                                    "منجريت",
                                },
                                1
                            ),
                            new Question(
                                "اڤابيلا بربوال دڠن اورڠ لاءين، كيت هندقله؟",
                                new List<string> { "مڠهينا", "مندڠر دڠن سوڤن", "مڽمڤوق", "منڠكيڠ" },
                                1
                            ),
                            new Question(
                                "مڠحرمتي اورڠ كتيك برينترقسي منونجوقكن؟",
                                new List<string>
                                {
                                    "اخلاق موليا",
                                    "اخلاق بوروق",
                                    "تيدق ڤنتيڠ",
                                    "سيا-سيا",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب كتيك برينترقسي اياله؟",
                                new List<string> { "دسايڠي", "دبنچي", "دحرمتي", "دكاسيهي" },
                                1
                            ),
                            new Question(
                                "ميديا سوسيال اياله؟",
                                new List<string>
                                {
                                    "تمڤت برجومڤا",
                                    "اڤليكاسي دالم تالين اونتوق برهوبوڠ",
                                    "كداي ممبلي-بله",
                                    "مجليس رسمي",
                                },
                                1
                            ),
                            new Question(
                                "ادب مڠڬوناكن ميديا سوسيال اياله؟",
                                new List<string>
                                {
                                    "مڽيبركن فتنة",
                                    "مڠحرمتي ڤريۏاسي اورڠ لاءين",
                                    "مڠهينا كاون",
                                    "بركات بوهوڠ",
                                },
                                1
                            ),
                            new Question(
                                "ڤركارا يڠ دلارڠ دالم ميديا سوسيال اياله؟",
                                new List<string>
                                {
                                    "بركوڠسي علمو برمنفعة",
                                    "مڽيبركن بريتا ڤلسو",
                                    "ممبري سلام",
                                    "منوليس دعاء",
                                },
                                1
                            ),
                            new Question(
                                "مڠڬوناكن بهاس سوڤن دالم ميديا سوسيال منونجوقكن؟",
                                new List<string>
                                {
                                    "اخلاق موليا",
                                    "اخلاق بوروق",
                                    "تيدق ڤنتيڠ",
                                    "سيا-سيا",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة مڽالهڬوناكن ميديا سوسيال اياله؟",
                                new List<string>
                                {
                                    "مندافت كاون بارو",
                                    "هيلڠ كڤرچاياءن اورڠ لاءين",
                                    "مندافت علمو برمنفعة",
                                    "دكاسيهي",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود معاملة؟",
                                new List<string>
                                {
                                    "هوبوڠن سسام ماءنسي",
                                    "هوبوڠن دڠن حيوان",
                                    "هوبوڠن دڠن تومبوهن",
                                    "هوبوڠن دڠن عالم سكيتر",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا برهوتڠ كيت مستي؟",
                                new List<string>
                                {
                                    "ملوڤاكن هوتڠ",
                                    "ممباير سمولا ڤد ماس دتتڤكن",
                                    "تيدق ممباير",
                                    "منيڤو ڤمبري هوتڠ",
                                },
                                1
                            ),
                            new Question(
                                "اورڠ يڠ تيدق ممباير هوتڠ حكومڽ؟",
                                new List<string> { "واجب", "سنة", "حرام", "هاروس" },
                                2
                            ),
                            new Question(
                                "انتارا ادب برجوال بلي اياله؟",
                                new List<string>
                                {
                                    "منيڤو تيمبڠن",
                                    "جوجور دان أمانة",
                                    "مڽوروق بارڠ",
                                    "مڠامبيل اونتوڠ برلبيهن",
                                },
                                1
                            ),
                            new Question(
                                "اورڠ يڠ منيڤو دالم جوال بلي اكن؟",
                                new List<string>
                                {
                                    "دكاسيهي الله",
                                    "دلعنة الله",
                                    "دڤوجي اورڠ",
                                    "دحرمتي",
                                },
                                1
                            ),
                            new Question(
                                "بركوڠسي رزقي برسام اورڠ لاءين اكن؟",
                                new List<string>
                                {
                                    "منمبه ڤرموسوهن",
                                    "مندافت كبركتن",
                                    "منمبه كبنچين",
                                    "منيمبولكن دندم",
                                },
                                1
                            ),
                            new Question(
                                "برصدقه كڤد اورڠ ميسكين ترماسوق؟",
                                new List<string>
                                {
                                    "عملن سيا-سيا",
                                    "عملن موليا",
                                    "عملن ترچلا",
                                    "عملن دلارڠ",
                                },
                                1
                            ),
                            new Question(
                                "عاقبة منيڤو دالم هوتڠ دان جوال بلي اياله؟",
                                new List<string>
                                {
                                    "مندافت كبركتن",
                                    "كهيلڠن كبركتن",
                                    "دسايڠي الله",
                                    "دڤوجي",
                                },
                                1
                            ),
                            new Question(
                                "چونتوه هرتا بندا عوام اياله؟",
                                new List<string>
                                {
                                    "بس سكوله",
                                    "تامن ڤرماءينن",
                                    "جالن راي",
                                    "سموا د اتس",
                                },
                                3
                            ),
                            new Question(
                                "ادب منجاڬ هرتا عوام اياله؟",
                                new List<string>
                                {
                                    "مروسقكن كروسي تامن",
                                    "منچونتيڠ دينديڠ سكوله",
                                    "مڠڬوناكنڽ دڠن باءيق",
                                    "ممبواڠ سمڤه مراتا-رات",
                                },
                                2
                            ),
                            new Question(
                                "مروسقكن هرتا عوام حكومڽ؟",
                                new List<string> { "هاروس", "حرام", "سنة", "مكروه" },
                                1
                            ),
                            new Question(
                                "كلبيهن منجاڬ هرتا عوام اياله؟",
                                new List<string>
                                {
                                    "مندافت ڤهالا",
                                    "دبنچي اورڠ",
                                    "دهينا",
                                    "مروڬيكن",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة مروسقكن هرتا عوام اياله؟",
                                new List<string>
                                {
                                    "دسايڠي مشاركت",
                                    "دتيمڤا كروڬين",
                                    "دڤوجي اورڠ",
                                    "مندافت ڤهالا",
                                },
                                1
                            ),
                            new Question(
                                "انتارا چونتوه منجاڬ عالم سكيتر اياله؟",
                                new List<string>
                                {
                                    "ممباكر سمڤه سمبارڠن",
                                    "ممبواڠ سمڤه د تمڤتڽ",
                                    "منبڠ ڤوكوق سسوك هاتي",
                                    "مڠوتوركن سوڠاي",
                                },
                                1
                            ),
                            new Question(
                                "إسلام مڠاجر اومتڽ سوڤايا؟",
                                new List<string>
                                {
                                    "مروسقكن بومي",
                                    "ممليهارا عالم سكيتر",
                                    "مڠابايكن كبرسيهن",
                                    "ممبازير سومبر",
                                },
                                1
                            ),
                            new Question(
                                "ممبواڠ سمڤه مراتا-رات اكن مڽببكن؟",
                                new List<string>
                                {
                                    "عالم سكيتر برسيه",
                                    "ڤڽاكيت دان ڤنچمارن",
                                    "مشاركت صيحت",
                                    "مندافت ڤهالا",
                                },
                                1
                            ),
                            new Question(
                                "منانم ڤوكوق اداله عملن؟",
                                new List<string>
                                {
                                    "باءيق دان مندافت ڤهالا",
                                    "تيدق برڬونا",
                                    "بوروق",
                                    "حرام",
                                },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق منجاڬ عالم سكيتر اياله؟",
                                new List<string>
                                {
                                    "مندافت كبركتن",
                                    "هيدوڤ صيحت",
                                    "بنچان عالم",
                                    "كتنڠن",
                                },
                                2
                            ),
                            new Question(
                                "دعاء كتيك ماسوق مسجد اياله؟",
                                new List<string>
                                {
                                    "اللهم افتح لي ابواب رحمتك",
                                    "اللهم اني اسألك علما نافعا",
                                    "سبحان الله",
                                    "بسم الله الرحمن الرحيم",
                                },
                                0
                            ),
                            new Question(
                                "دعاء كتيك كلوار مسجد اياله؟",
                                new List<string>
                                {
                                    "اللهم افتح لي ابواب رحمتك",
                                    "اللهم اني اسألك فضلك",
                                    "الحمدلله",
                                    "استغفر الله",
                                },
                                1
                            ),
                            new Question(
                                "اڤابيلا ماسوق مسجد كيت ڤرلو؟",
                                new List<string>
                                {
                                    "برلاري-لاري",
                                    "منداهولوكن كاكي كانن",
                                    "ممبوات بيسيڠ",
                                    "ممباوا ماكنن",
                                },
                                1
                            ),
                            new Question(
                                "اڤابيلا كلوار مسجد كيت ڤرلو؟",
                                new List<string>
                                {
                                    "منداهولوكن كاكي كيري",
                                    "منداهولوكن كاكي كانن",
                                    "ملومڤت",
                                    "ممبنتيڠ ڤينتو",
                                },
                                0
                            ),
                            new Question(
                                "انتارا لارڠن د مسجد اياله؟",
                                new List<string>
                                {
                                    "ممباچ القرءان",
                                    "تيدور برلبيهن",
                                    "برذكر",
                                    "صلاة سنة",
                                },
                                1
                            ),
                            new Question(
                                "اڤاكه مقصود اعتكاف؟",
                                new List<string>
                                {
                                    "دودوق د مسجد دڠن نية ترتنتو",
                                    "تيدور د رومه",
                                    "برجالن-جالن د تامن",
                                    "برجوالن د ڤاسر",
                                },
                                0
                            ),
                            new Question(
                                "حكوم اعتكاف اياله؟",
                                new List<string> { "واجب", "سنة", "حرام", "مكروه" },
                                1
                            ),
                            new Question(
                                "انتارا عملن كتيك اعتكاف اياله؟",
                                new List<string>
                                {
                                    "ممباچ القرءان",
                                    "برماءين بولا",
                                    "ممبوات بيسيڠ",
                                    "تيدور برلبيهن",
                                },
                                0
                            ),
                            new Question(
                                "اورڠ يڠ برعتكاف هندقله؟",
                                new List<string>
                                {
                                    "منجاڬ ادب د مسجد",
                                    "مروسقكن مسجد",
                                    "برجوال بلي",
                                    "برڬوراو سندا",
                                },
                                0
                            ),
                            new Question(
                                "كلبيهن اعتكاف اياله؟",
                                new List<string>
                                {
                                    "مندافت ڤهالا",
                                    "دبنچي الله",
                                    "دماراهي اورڠ",
                                    "دروڬيكن",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا ڬورو سدڠ مڠاجر كيت هندقله؟",
                                new List<string>
                                {
                                    "بيسيڠ",
                                    "مندڠر دڠن خشوع",
                                    "برماءين",
                                    "برجالن-جالن",
                                },
                                1
                            ),
                            new Question(
                                "انتارا ادب د مجليس علمو اياله؟",
                                new List<string>
                                {
                                    "دودوق سوڤن",
                                    "مڽمڤوق ڬورو",
                                    "كتاوا كوات",
                                    "بربوال كوسوڠ",
                                },
                                0
                            ),
                            new Question(
                                "منچاتت علمو كتيك بلاجر منونجوقكن؟",
                                new List<string> { "راجين", "مالس", "لالاي", "تيدق ڤنتيڠ" },
                                0
                            ),
                            new Question(
                                "مڠحرمتي ڬورو دالم مجليس علمو حكومڽ؟",
                                new List<string> { "واجب", "هاروس", "مكروه", "حرام" },
                                0
                            ),
                            new Question(
                                "عاقبة تيدق برادب دالم مجليس علمو اياله؟",
                                new List<string>
                                {
                                    "مندافت كبركتن",
                                    "هيلڠ كبركتن علمو",
                                    "مندافت ڤهالا",
                                    "دحرمتي",
                                },
                                1
                            ),
                            new Question(
                                "حكوم صلاة جمعة اياله؟",
                                new List<string>
                                {
                                    "واجب باڬي للاكي",
                                    "سنة باڬي للاكي",
                                    "هاروس باڬي وانيتا",
                                    "مكروه",
                                },
                                0
                            ),
                            new Question(
                                "اڤابيلا مندڠر خطبة جمعة كيت مستي؟",
                                new List<string>
                                {
                                    "بربوال",
                                    "ديام دان مندڠر",
                                    "تيدور",
                                    "كلوار مسجد",
                                },
                                1
                            ),
                            new Question(
                                "انتارا ادب صلاة هاري راي اياله؟",
                                new List<string>
                                {
                                    "ممباچ تكبير راي",
                                    "برماءين مرچون د مسجد",
                                    "بيسيڠ دالم صف",
                                    "مڠڬڠڬو اورڠ صلاة",
                                },
                                0
                            ),
                            new Question(
                                "سنة ڤرڬي ك صلاة هاري راي دڠن؟",
                                new List<string>
                                {
                                    "جالن يڠ سام ڤرڬي دان باليق",
                                    "جالن يڠ بربيذا",
                                    "تيدق ڤرڬي",
                                    "تيدور",
                                },
                                1
                            ),
                            new Question(
                                "حكوم صلاة جنازه اياله؟",
                                new List<string> { "فرض كفاية", "فرض عين", "سنة", "هاروس" },
                                0
                            ),
                            new Question(
                                "بيلاڠن تكبير دالم صلاة جنازه اياله؟",
                                new List<string> { "تيڬ", "امڤت", "ليم", "انم" },
                                1
                            ),
                            new Question(
                                "دعاء دالم صلاة جنازه دباچ اونتوق؟",
                                new List<string>
                                {
                                    "ميت سهاج",
                                    "سموا اورڠ هيدوڤ",
                                    "ميت دان اورڠ إسلام",
                                    "اورڠ بوكن إسلام",
                                },
                                2
                            ),
                            new Question(
                                "مڠيريڠي جنازه هيڠڬ ك قبور اداله؟",
                                new List<string>
                                {
                                    "عملن موليا",
                                    "عملن بوروق",
                                    "تيدق ڤنتيڠ",
                                    "دلارڠ",
                                },
                                0
                            ),
                            new Question(
                                "كمودهن مسجد سڤرتي؟",
                                new List<string>
                                {
                                    "اءير، كيڤس، كرڤيت",
                                    "ڤاسر مالم",
                                    "كداي ماكن",
                                    "جالن راي",
                                },
                                0
                            ),
                            new Question(
                                "مڠوروسكن كمودهن مسجد ترماسوق؟",
                                new List<string>
                                {
                                    "تڠڬوڠجواب برسام",
                                    "تيدق ڤنتيڠ",
                                    "كرجا سيا-سيا",
                                    "دلارڠ",
                                },
                                0
                            ),
                            new Question(
                                "مروسقكن كمودهن مسجد حكومڽ؟",
                                new List<string> { "هاروس", "حرام", "سنة", "مكروه" },
                                1
                            ),
                            new Question(
                                "منجاڬ كبرسيهن مسجد اداله؟",
                                new List<string>
                                {
                                    "عملن موليا",
                                    "عملن بوروق",
                                    "تيدق ڤنتيڠ",
                                    "عملن دلارڠ",
                                },
                                0
                            ),
                        },
                    },
                }
            );
        }

        // Update is called once per frame
        void Update() { }
    }
}
