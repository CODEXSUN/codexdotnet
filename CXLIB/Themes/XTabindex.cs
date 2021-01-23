namespace CXLIB
{
    public class XTab
    {
        public static int Lbl_TabIndex { get; internal set; } = 100;

        public static int Splitcontainer { get; internal set; } = 100;
        public static int Btn_list { get; internal set; } = 21;

        public static int BtnList { get; internal set; }
        public static int BtnIndex { get; internal set; }
        public static int Txt_TabIndex { get; internal set; } = 1;

        public static int Index(int tabIndex)
        {
            if (tabIndex == 0)
            {
                return 1;
            }
            else
            {
                return tabIndex + 1;
            }
            
        }
    }
   
}
