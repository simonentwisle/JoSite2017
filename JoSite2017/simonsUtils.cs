using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;

namespace JoSite2017
{
    internal class simonsUtils
    {
        #region Methods

        private string getConnString()
        {
            return ConfigurationManager.ConnectionStrings["MSForumConn"].ToString();
        }

        public void FillDD(DropDownList o_DDList, string s_TableName, string s_IDColumn, string s_SortColumn, string productID, string s_SelectedValue)
        {
            string s_SQL = "";

            s_SQL = "SELECT * FROM " + s_TableName + " ORDER BY " + s_SortColumn + " ASC";
            SqlConnection o_conn = new SqlConnection(getConnString());
            SqlDataAdapter o_DataAdaptor = new SqlDataAdapter(s_SQL, o_conn);
            DataSet o_Dataset = new DataSet();

            o_DataAdaptor.Fill(o_Dataset, s_TableName);
            o_DDList.DataSource = o_Dataset.Tables[s_TableName].DefaultView;
            o_DDList.DataTextField = s_SortColumn;
            o_DDList.DataValueField = s_IDColumn;
            o_DDList.DataBind();
            o_DDList.Items.Insert(0, "Unselected");
            o_DDList.Items[0].Value = "0";
            if (s_SelectedValue == "")
            {
                o_DDList.SelectedIndex = 0;
            }
            else
            {
                o_DDList.SelectedValue = s_SelectedValue;
            }
            o_Dataset = null;
            o_DataAdaptor = null;
            o_conn = null;

        }

        public Boolean checkDateDD(DropDownList o_DDList)
        {
            Boolean dateIsCool = true;
            if (o_DDList.SelectedItem.Text.IndexOf("Unselected", 0).ToString() != "-1")
            {
                dateIsCool = false;
                this.highlightControl(o_DDList);
            }
            return dateIsCool;
        }

        public int convertBoolToBit(bool boolValue)
        {
            int returnValue = 0;
            if (boolValue != false)
            {
                returnValue = 1;
            }
            return returnValue;
        }

        public bool convertBitToBool(int bitValue)
        {
            bool returnValue = false;
            if (bitValue == 1)
            {
                returnValue = true;
            }
            return returnValue;
        }

        public void resetControlsBackColours(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                switch (c.GetType().ToString())
                {
                    case "System.Web.UI.WebControls.DropDownList":
                        ((DropDownList)c).BackColor = System.Drawing.Color.FromName("#ffffff");
                        break;
                    case "System.Web.UI.WebControls.TextBox":
                        ((TextBox)c).BackColor = System.Drawing.Color.FromName("#ffffff");
                        break;
                    default://do nothing
                        break;
                }
                if (c.Controls.Count > 0)
                {
                    resetControlsBackColours(c);
                }
            }
        }

        public Control highlightControl(Control c)
        {
            switch (c.GetType().ToString())
            {
                case "System.Web.UI.WebControls.DropDownList":
                    ((DropDownList)c).BackColor = System.Drawing.Color.FromName("#939d3d");
                    break;
                case "System.Web.UI.WebControls.TextBox":
                    ((TextBox)c).BorderColor = System.Drawing.Color.Red;
                    //((TextBox)c).BackColor = System.Drawing.Color.FromName("#ffffff");
                    break;
                default://do nothing
                    break;
            }
            return c;
        }

        public string getErrorMessage()
        {
            string errorMessage = "<p class=\"erroralert\">ATTENTION!</p><p class=\"errormessage\">There is a problem with the highlighted field\\s below.<br />Please read the instructions, check and try again.</p>";
            return errorMessage;
        }

        private void IterateThroughChildren(Control parent)
        {
            Label lblControlList = new Label();
            foreach (Control c in parent.Controls)
            {
                lblControlList.Text += "<li>" + c.GetType().ToString() + "</li>";
                //lblControlList.Text += "<li>" + c.ToString() + "</li>";
                if (c.Controls.Count > 0)
                {
                    lblControlList.Text += "<ul>";
                    IterateThroughChildren(c);
                    lblControlList.Text += "</ul>";
                }
            }
        }

        private Control _co;
        public Control find_control(Control _c, string _name)
        {
            if (_co != null) return _co;
            IEnumerator _ir = _c.Controls.GetEnumerator();
            _ir.Reset();
            while (_ir.MoveNext())
            {
                if (_co != null) break;
                if (((Control)_ir.Current).ID == _name)
                {
                    _co = ((Control)_ir.Current);
                    break;
                }
                find_control(((Control)_ir.Current), _name);
            }
            return _co;
        }

        public bool isEmail(string inputEmail)
        {
            if (inputEmail == null)
                return (false);

            int supported = 0;

            string tempStr = "a";
            System.Configuration.RegexStringValidatorAttribute tempReg = new System.Configuration.RegexStringValidatorAttribute(tempStr);
            if (tempReg.Match(tempStr)) supported = 1;

            if (supported != 1)
                return (inputEmail.IndexOf(".") > 2) && (inputEmail.IndexOf("@") > 0);
            System.Configuration.RegexStringValidatorAttribute r1 = new System.Configuration.RegexStringValidatorAttribute("(@.*@)|(\\.\\.)|(@\\.)|(^\\.)");
            System.Configuration.RegexStringValidatorAttribute r2 = new System.Configuration.RegexStringValidatorAttribute("^.+\\@(\\[?)[a-zA-Z0-9\\-\\.]+\\.([a-zA-Z]{2,3}|[0-9]{1,3})(\\]?)$");
            return (!r1.Match(inputEmail) && r2.Match(inputEmail));
        }

        public string getFileTypeFromSuffix(string fileSuffix)
        {
            string strDocType = "";
            switch (fileSuffix)
            {
                case ".doc":
                    strDocType = "application/msword";
                    break;
                case ".ppt":
                    strDocType = "application/ms-powerpoint";
                    break;
                case ".htm":
                    strDocType = "text/html";
                    break;
                case ".html":
                    strDocType = "text/html";
                    break;
                case ".jpg":
                    strDocType = "image/jpeg";
                    break;
                case ".gif":
                    strDocType = "image/gif";
                    break;
                case ".pdf":
                    strDocType = "application/pdf";
                    break;
                default:
                    strDocType = "text/plain";
                    break;
            }

            return strDocType;
        }

        #endregion
    }
}