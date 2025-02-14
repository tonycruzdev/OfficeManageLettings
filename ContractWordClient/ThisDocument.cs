﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace ContractWordClient
{
    public partial class ThisDocument
    {
        private APCHomeList _action = new APCHomeList(); 
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            ActionsPane.Controls.Add(_action);
            _action.Dock = DockStyle.Fill;
        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
            ActionsPane.Controls.Remove(_action);
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);

        }

        #endregion
    }
}

