using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEIT
{
    public class UpdateClass
    {

        public static string SalesInvoice()
        {
            string q = "ALTER TABLE `amaltex_db`.`invoiceitems_tbl`";
            q += "DROP COLUMN `PO_ID`, ";
            q += "DROP COLUMN `POITEMS_ID`, ";
            q += "DROP COLUMN `DC_ID`,  ";
            q += "DROP COLUMN `DCITEMS_ID`,  ";
            q += "DROP INDEX `FK_INVOICEITEMS_PO_ID`, ";
            q += "DROP INDEX `FK_INVOICEITEMS_DC_ID`; ";





            return q;
        }
    }
}
