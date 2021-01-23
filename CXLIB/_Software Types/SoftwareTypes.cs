namespace CXLIB
{
    public static class Softwares
    {
        public const string GARMENT = "GARMENT";
        public const string OFFSET_1 = "OFFSET_1";
        public const string UPVC = "UPVC";
        public const string TEX = "TEX";

        public static string Getcode(string v)
        {
            switch (v)
            {
                case GARMENT:
                    return SoftwareTypes.GARMENT;
                case OFFSET_1:
                    return SoftwareTypes.OFFSET;
                case UPVC:
                    return SoftwareTypes.UPVC;
                case TEX:
                    return SoftwareTypes.TEX;

                default:
                    break;
            }

            return null;
        }
    }

    public static class SoftwareTypes
    {
        public const string GARMENT = "1";
        public const string OFFSET = "2";
        public const string UPVC = "3";
        public const string TEX = "4";
    }
}
