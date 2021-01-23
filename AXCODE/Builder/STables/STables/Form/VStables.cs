using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;

//  
namespace AXCODE
{
    public partial class FStables : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Stables obj;
        private List<SFields> itemstbl;
        private List<SFieldsItems> itemssub;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "CLOSE";
                    obj = CStables_exten.PKId(pPkValue, new SQLITE_DAL());
                    itemstbl = CSFields_exten.FKId(pPkValue, new SQLITE_DAL());
                    itemssub = CSFieldsitems_exten.FKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "SAVE";
                    obj = CStables.GetNew;
                    itemstbl = CSFields.GetNew;
                    itemssub = CSFieldsitem.GetNew;
                    editgrid.RowCount = 0;
                    editgrid_2.RowCount = 0;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "UPDATE";
                    obj = CStables_exten.PKId(pPkValue, new SQLITE_DAL());
                    itemstbl = CSFields_exten.FKId(pPkValue, new SQLITE_DAL());
                    itemssub = CSFieldsitems_exten.FKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\nDELETE";
                    obj = CStables_exten.PKId(pPkValue, new SQLITE_DAL());
                    itemstbl = CSFields_exten.FKId(pPkValue, new SQLITE_DAL());
                    itemssub = CSFieldsitems_exten.FKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "PRINT";
                    obj = CStables_exten.PKId(pPkValue, new SQLITE_DAL());
                    itemstbl = CSFields_exten.FKId(pPkValue, new SQLITE_DAL());
                    itemssub = CSFieldsitems_exten.FKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(false);
                    break;
            }

            this.LoadData(obj);
            this.Loaditems(itemstbl);
            this.Loaditems_2(itemssub);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Stables obj)
        {
            vId = obj.Stables_id;
            txt_databases_id.Text = obj.Databases_id;
            txt_tables_name.Text = obj.Stables_name;
            txt_tables_alias.Text = obj.Alias;
            txt_namespaces_id.Text = obj.Namespaces_id;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        private void Loaditems(List<SFields> list)
        {
            if (list != null)
            {
                editgrid.RowCount = 0;
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[SFIELDS.SFIELDS_ID].Value = list[r].Sfields_id;
                    row.Cells[SFIELDS.FIELDSNAME].Value = list[r].Fieldsname;
                    row.Cells[SFIELDS.STABLES_ID].Value = list[r].Stables_id;
                    row.Cells[SFIELDS.DISPLAY_NAME].Value = list[r].Displayname;
                    row.Cells[SFIELDS.DATATYPE].Value = list[r].Datatype;
                    //row.Cells[SFIELDS.LENGTHS].Value = list[r].Lengths;
                    //row.Cells[SFIELDS.PKEYS].Value = list[r].Pkeys;
                    //row.Cells[SFIELDS.IFNULL].Value = list[r].Ifnull;
                    //row.Cells[SFIELDS.REFEREDTBL].Value = list[r].Refered_tbl;
                    row.Cells[SFIELDS.INPUTTYPE].Value = list[r].Inputtype;
                    row.Cells[SFIELDS.WIDTH].Value = list[r].Width;
                    row.Cells[SFIELDS.HEIGHT].Value = list[r].Height;
                    row.Cells[SFIELDS.CPOSITION].Value = list[r].Cposition;
                    row.Cells[SFIELDS.RPOSITION].Value = list[r].Rposition;
                    row.Cells[SFIELDS.ALIGNTO].Value = list[r].Alignto;
                    row.Cells[SFIELDS.VALIDATE].Value = list[r].Validate;
                    row.Cells[SFIELDS.ISDEFAULT].Value = list[r].Isdefault;
                    row.Cells[SFIELDS.PLACEMENT].Value = list[r].Placement;
                    row.Cells[SFIELDS.READONLY].Value = list[r].Readonly;
                }
            }
        }

        private void Loaditems_2(List<SFieldsItems> list)
        {
            if (list != null)
            {
                editgrid_2.RowCount = 0;
                editgrid_2.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid_2.Rows[r];

                    row.Cells[SFIELDSITEMS.SFIELDSITEMS_ID].Value = list[r].Sfieldsitems_id;
                    row.Cells[SFIELDSITEMS.FIELDSNAME].Value = list[r].Fieldsname;
                    row.Cells[SFIELDSITEMS.STABLES_ID].Value = list[r].Stables_id;
                    row.Cells[SFIELDSITEMS.DISPLAY_NAME].Value = list[r].Displayname;
                    row.Cells[SFIELDSITEMS.DATATYPE].Value = list[r].Datatype;
                    //row.Cells[SFIELDSITEMS.LENGTHS].Value = list[r].Lengths;
                    //row.Cells[SFIELDSITEMS.PKEYS].Value = list[r].Pkeys;
                    //row.Cells[SFIELDSITEMS.IFNULL].Value = list[r].Ifnull;
                    //row.Cells[SFIELDSITEMS.REFEREDTBL].Value = list[r].Refered_tbl;
                    row.Cells[SFIELDSITEMS.INPUTTYPE].Value = list[r].Inputtype;
                    row.Cells[SFIELDSITEMS.WIDTH].Value = list[r].Width;
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
            //txt_notes.Enabled = !pReadOnly;

            editgrid.Enabled = !pReadOnly;
            editgrid_2.Enabled = !pReadOnly;

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

                            CStables.Insert(vData, dalsession);
                            vId = SQLITE_DAL.GetIdentity(dalsession);

                            var vItems = CollectItems(vId);
                            CSFields.Insert(vItems, dalsession);

                            var vItems_2 = CollectItems_2(vId);
                            CSFieldsitem.Insert(vItems_2, dalsession);

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

                            CSFields.Delete(vId, dalsession);
                            CSFieldsitem.Delete(vId, dalsession);

                            CStables.Update(vData, dalsession);

                            var vItems = CollectItems(vId);
                            CSFields.Insert(vItems, dalsession);

                            var vItems_2 = CollectItems_2(vId);
                            CSFieldsitem.Insert(vItems_2, dalsession);

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
                            CStables.Delete(vId, dalsession);
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
                MessageBox.Show(this.FindForm(), "Databases Name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_databases_id.Focus();
                return false;
            }

            if (Core.Stative == Core.Idle)
            {
                MessageBox.Show(this.FindForm(), "Select Active or not !", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_active.Focus();
                return false;
            }

            if (txt_namespaces_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Namespace should not Empty !", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_active.Focus();
                return false;
            }

            return true;
        }

        #endregion[Validation]

        #region[Collect Data]

        private Stables CollectData()
        {
            Stables fobj = new Stables()
            {
                Stables_id = vId,
                Databases_id = CDatabases_exten.GetId_Name(txt_databases_id.Text.Trim()),
                Stables_name = txt_tables_name.Text.ToUpper().Trim(),
                Alias = txt_tables_alias.Text.ToUpper().Trim(),
                Namespaces_id = CNamespaces_exten.GetId_Name(txt_namespaces_id.Text.Trim()),
                Active_id = Core.Stative,
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect Item]
        private List<SFields> CollectItems(string tableId)
        {
            List<SFields> _table_item_list = new List<SFields>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {
                SFields items = new SFields();
                // 
                if (
                (editgrid[SFIELDS.DATATYPE, r].Value + "") == "" &&
                //(editgrid[SFIELDS.LENGTHS, r].Value + "") == "" &&
                //(editgrid[SFIELDS.PKEYS, r].Value + "") == "" &&
                //(editgrid[SFIELDS.IFNULL, r].Value + "") == "" &&
                (editgrid[SFIELDS.INPUTTYPE, r].Value + "") == "" &&
                (editgrid[SFIELDS.WIDTH, r].Value + "") == "" &&
                (editgrid[SFIELDS.HEIGHT, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row). 
                }
                else
                {
                    items.Sfields_id = "";
                    items.Stables_id = tableId;
                    items.Fieldsname = editgrid[SFIELDS.FIELDSNAME, r].Value + "".ToUpper().Trim();
                    items.Displayname = (editgrid[SFIELDS.DISPLAY_NAME, r].Value + "").ToUpper().Trim();
                    items.Datatype = (editgrid[SFIELDS.DATATYPE, r].Value + "").Trim();
                    items.Inputtype = (editgrid[SFIELDS.INPUTTYPE, r].Value + "");
                    items.Width = (editgrid[SFIELDS.WIDTH, r].Value + "");
                    items.Height = (editgrid[SFIELDS.HEIGHT, r].Value + "");
                    items.Cposition = (editgrid[SFIELDS.CPOSITION, r].Value + "");
                    items.Rposition = (editgrid[SFIELDS.RPOSITION, r].Value + "");
                    items.Alignto = (editgrid[SFIELDS.ALIGNTO, r].Value + "");
                    items.Validate = (editgrid[SFIELDS.VALIDATE, r].Value + "");
                    items.Isdefault = (editgrid[SFIELDS.ISDEFAULT, r].Value + "");
                    items.Placement = (editgrid[SFIELDS.PLACEMENT, r].Value + "");
                    items.Readonly = (editgrid[SFIELDS.READONLY, r].Value + "");

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

        #region[Collect Item 2]
        private List<SFieldsItems> CollectItems_2(string tableId)
        {
            List<SFieldsItems> _table_item_list = new List<SFieldsItems>();

            for (int r = 0; r < editgrid_2.RowCount; r++)
            {
                SFieldsItems items = new SFieldsItems();
                // 
                if (
                (editgrid_2[SFIELDSITEMS.DATATYPE, r].Value + "") == "" &&
                //(editgrid_2[SFIELDSITEMS.LENGTHS, r].Value + "") == "" &&
                //(editgrid_2[SFIELDSITEMS.PKEYS, r].Value + "") == "" &&
                //(editgrid_2[SFIELDSITEMS.IFNULL, r].Value + "") == "" &&
                (editgrid_2[SFIELDSITEMS.INPUTTYPE, r].Value + "") == "" &&
                (editgrid_2[SFIELDSITEMS.WIDTH, r].Value + "") == "" 
                )
                {
                    //==LEAVE IT(the empty row). 
                }
                else
                {
                    items.Sfieldsitems_id = "";
                    items.Stables_id = tableId;
                    items.Fieldsname = editgrid_2[SFIELDSITEMS.FIELDSNAME, r].Value + "".ToUpper().Trim();
                    items.Displayname = (editgrid_2[SFIELDSITEMS.DISPLAY_NAME, r].Value + "").ToUpper().Trim();
                    items.Datatype = (editgrid_2[SFIELDSITEMS.DATATYPE, r].Value + "").Trim();
                    //items.Lengths = (editgrid_2[SFIELDSITEMS.LENGTHS, r].Value + "").Trim();
                    //items.Pkeys = (editgrid_2[SFIELDSITEMS.PKEYS, r].Value + "").Trim();
                    //items.Ifnull = (editgrid_2[SFIELDSITEMS.IFNULL, r].Value + "").Trim();
                    //items.Refered_tbl = (editgrid_2[SFIELDSITEMS.REFEREDTBL, r].Value + "");
                    items.Inputtype = (editgrid_2[SFIELDSITEMS.INPUTTYPE, r].Value + "");
                    items.Width = (editgrid_2[SFIELDSITEMS.WIDTH, r].Value + "");
                    //if (editgrid_2[SFIELDSITEMS.ALIGNTO, r].Value + "" != "")
                    //{
                    //    items.Alignto = (editgrid_2[SFIELDSITEMS.ALIGNTO, r].Value + "");
                    //}
                    //else
                    //{
                    //    items.Alignto = AutoCode.Center;
                    //}
                    _table_item_list.Add(items);
                }
            }
            if (_table_item_list.Count != 0)
            {
                return _table_item_list;
            }
            return null;
        }

        #endregion[Collect Item 2]
    }//cls 
}//ns 
