using System;
using System.Collections;
using System.Windows.Forms;
//==using CrystalDecisions.CrystalReports.Engine;
using System.ComponentModel;

namespace CXLIB
{
    [DesignTimeVisible(false)]
    public class IReportFilterPanel : UserControl
    {
        /*{
        public virtual ReportDocument GetReportSource()
        {
            throw new NotImplementedException();
        }
        */
        public virtual ArrayList GetReportData()
        {
            throw new NotImplementedException();
        }

        protected ArrayList f_LoadedReportData;
        ///
        public ArrayList GetLoadedReportData()
        {
            return f_LoadedReportData;
        }
    }
}
