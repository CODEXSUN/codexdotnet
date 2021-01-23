// Version : 3 dt : 31-07-2017
// Auto Generated
// 31-07-2017 08:39:30 PM
// last update : 31-07-2017

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;

//  
namespace AXCODE
{
    public partial class FMtables : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private MasterTables obj;
        private List<MasterTablesItems> itemstbl;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "CLOSE";
                    obj = CMtables_exten.PKId(pPkValue);
                    itemstbl = CMtablesitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "SAVE";
                    obj = CMtables.GetNew;
                    itemstbl = CMtablesitems.GetNew;
                    editgrid.RowCount = 0;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "UPDATE";
                    obj = CMtables_exten.PKId(pPkValue);
                    itemstbl = CMtablesitems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\nDELETE";
                    obj = CMtables_exten.PKId(pPkValue);
                    itemstbl = CMtablesitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "PRINT";
                    obj = CMtables_exten.PKId(pPkValue);
                    itemstbl = CMtablesitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
            }

            this.LoadData(obj);
            this.Loaditems(itemstbl);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(MasterTables obj)
        {
            vId = obj.Mastertables_id;
            txt_databases_id.Text = obj.Databases_id;
            txt_tables_name.Text = obj.Mastertables_name;
            txt_tables_alias.Text = obj.Alias;
            txt_namespaces_id.Text = obj.Namespaces_id;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        private void Loaditems(List<MasterTablesItems> list)
        {
            if (list != null)
            {
                editgrid.RowCount = 0;
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[MASTERTABLESITEMS.MASTERTABLESITEMS_ID].Value = list[r].Mtablesitems_id;
                    row.Cells[MASTERTABLESITEMS.FIELDSNAME].Value = list[r].Fieldsname;
                    row.Cells[MASTERTABLESITEMS.MASTERTABLES_ID].Value = list[r].Mtables_id;
                    row.Cells[MASTERTABLESITEMS.DISPLAYNAME].Value = list[r].Displayname;
                    row.Cells[MASTERTABLESITEMS.DATATYPE].Value = list[r].Datatype;
                    //row.Cells[MTABLESITEMS.LENGTHS].Value = list[r].Lengths;
                    //row.Cells[MTABLESITEMS.PKEYS].Value = list[r].Pkeys;
                    //row.Cells[MTABLESITEMS.IFNULL].Value = list[r].Ifnull;
                    //row.Cells[MTABLESITEMS.REFEREDTBL].Value = list[r].Refered_tbl;
                    row.Cells[MASTERTABLESITEMS.INPUTTYPE].Value = list[r].Inputtype;
                    row.Cells[MASTERTABLESITEMS.WIDTH].Value = list[r].Width;
                    row.Cells[MASTERTABLESITEMS.HEIGHT].Value = list[r].Height;
                    row.Cells[MASTERTABLESITEMS.CPOSITION].Value = list[r].Cposition;
                    row.Cells[MASTERTABLESITEMS.RPOSITION].Value = list[r].Rposition;
                    row.Cells[MASTERTABLESITEMS.ALIGNTO].Value = list[r].Alignto;
                    row.Cells[MASTERTABLESITEMS.VALIDATE].Value = list[r].Validate;
                    row.Cells[MASTERTABLESITEMS.ISDEFAULT].Value = list[r].Isdefault;
                    row.Cells[MASTERTABLESITEMS.PLACEMENT].Value = list[r].Placement;
                }
            }
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_databases_id.Enabled = !pReadOnly;
            txt_tables_name.Enabled = !pReadOnly;
            txt_tables_alias.Enabled = !pReadOnly;
            //txt_createdon.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;
            editgrid.Enabled = !pReadOnly;
            btn_active.Enabled = !pReadOnly;

        }

        #endregion[Enable  Disable Controls]

        #region[Save Event]

        private SQLITE_DAL dalsession;
        private void Save_Event()
        {
            if (Validation() != false)
            {
                switch (fAction)
                {
                    case BtnEvent.Open:
                        this.Hide();
                        Form_NeedToRefresh();
                        break;

                    case BtnEvent.New:
                        try
                        {

                            var vData = CollectData();
                            dalsession = new SQLITE_DAL();
                            dalsession.BeginTransaction();
                            CMtables.Insert(vData, dalsession);
                            vId = SQLITE_DAL.GetIdentity(dalsession);
                            var vItems = CollectItems(vId);
                            CMtablesitems.Insert(vItems, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Saved Successfully.", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            SetAction(BtnEvent.New, null);
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Save...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Edit:
                        try
                        {

                            var vData = CollectData();
                            dalsession = new SQLITE_DAL();
                            dalsession.BeginTransaction();

                            CMtablesitems.Delete(vId, dalsession);

                            CMtables.Update(vData, dalsession);
                            var vItems = CollectItems(vId);
                            CMtablesitems.Insert(vItems, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Updated Successfully.", "Update...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Update...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Delete:
                        try
                        {
                            dalsession = new SQLITE_DAL();
                            dalsession.BeginTransaction();
                            CMtables.Delete(vId, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Deleted Successfully.", "Delete...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Update...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Print:
                        this.Hide();
                        Form_NeedToRefresh();
                        break;
                }
            }
        }

        #endregion[Save Event]

        #region[Validation]

        private bool Validation()
        {
            if (txt_databases_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Databases should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_databases_id.Focus();
                return false;
            }

            if (txt_namespaces_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Namespace should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_databases_id.Focus();
                return false;
            }

            if (Core.Stative == Core.Idle)
            {
                MessageBox.Show(this.FindForm(), "Select Active or not !", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_active.Focus();
                return false;
            }

            return true;
        }

        #endregion[Validation]

        #region[Collect Data]

        private MasterTables CollectData()
        {
            MasterTables fobj = new MasterTables()
            {
                Mastertables_id = vId,
                Databases_id = CDatabases_exten.GetId_Name(txt_databases_id.Text.Trim()),
                Mastertables_name = txt_tables_name.Text.ToUpper().Trim(),
                Alias = txt_tables_alias.Text.ToUpper().Trim(),
                Namespaces_id = CNamespaces_exten.GetId_Name(txt_namespaces_id.Text.Trim()),
                Active_id = Core.Stative,
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect Item]
        List<MasterTablesItems> CollectItems(string tableId)
        {
            List<MasterTablesItems> _table_item_list = new List<MasterTablesItems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {
                MasterTablesItems items = new MasterTablesItems();
                // 
                if (
                (editgrid[MASTERTABLESITEMS.DATATYPE, r].Value + "") == "" &&
                (editgrid[MASTERTABLESITEMS.INPUTTYPE, r].Value + "") == "" &&
                (editgrid[MASTERTABLESITEMS.WIDTH, r].Value + "") == "" &&
                (editgrid[MASTERTABLESITEMS.HEIGHT, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row). 
                }
                else
                {
                    items.Mtablesitems_id = "";
                    items.Mtables_id = tableId;
                    items.Fieldsname = editgrid[MASTERTABLESITEMS.FIELDSNAME, r].Value + "".ToUpper().Trim();
                    items.Displayname = (editgrid[MASTERTABLESITEMS.DISPLAYNAME, r].Value + "").ToUpper().Trim();
                    items.Datatype = (editgrid[MASTERTABLESITEMS.DATATYPE, r].Value + "").Trim();
                    items.Inputtype = (editgrid[MASTERTABLESITEMS.INPUTTYPE, r].Value + "");
                    items.Width = (editgrid[MASTERTABLESITEMS.WIDTH, r].Value + "");
                    items.Height = (editgrid[MASTERTABLESITEMS.HEIGHT, r].Value + "");
                    items.Cposition = (editgrid[MASTERTABLESITEMS.CPOSITION, r].Value + "");
                    items.Rposition = (editgrid[MASTERTABLESITEMS.RPOSITION, r].Value + "");
                    items.Validate = (editgrid[MASTERTABLESITEMS.VALIDATE, r].Value + "");
                    items.Isdefault = (editgrid[MASTERTABLESITEMS.ISDEFAULT, r].Value + "");
                    items.Placement = (editgrid[MASTERTABLESITEMS.PLACEMENT, r].Value + "");
                    items.Alignto = (editgrid[MASTERTABLESITEMS.ALIGNTO, r].Value + "");

                    _table_item_list.Add(items);
                }
            }
            if (_table_item_list.Count != 0)
            {
                return _table_item_list;
            }
            return null;
        }

        #endregion[Collect Item]

    }//cls 
}//ns 
