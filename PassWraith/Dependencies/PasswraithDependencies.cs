using Guna.UI2.WinForms;
using PassWraith.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWraith.Dependencies
{
    public class PasswraithDependencies
    {
        public Timer MainTimer { get; set; }
        public Guna2Panel DispUsernamePanel { get; set; }
        public Guna2Panel DispPasswordPanel { get; set; }
        public Guna2Panel DispWebsitePanel { get; set; }
        public Guna2Button DispBtnUsernameCopy { get; set; }
        public Guna2Button DispBtnPasswordView { get; set; }
        public Guna2Button DispBtnPasswordCopy { get; set; }
        public Guna2Button DispBtnWebsiteCopy { get; set; }
        public Guna2TextBox DispTxtPassword { get; set; }
        public Guna2HtmlLabel DispLblUsername { get; set; }
        public Guna2HtmlLabel DispLblWebsiteName { get; set; }
        public FlowLayoutPanel FlpMain { get; set; }
        public Guna2HtmlLabel LblDisplayUserName { get; set; }
        public Guna2HtmlLabel LblDisplayWebsiteName { get; set; }
        public Guna2PictureBox DisplayPicBox { get; set; }
        public Guna2Button AddBtn { get; set; }
        public Guna2Button EditBtn { get; set; }
        public Guna2Button DeleteBtn { get; set; }
        public Guna2Button RestoreBtn { get; set; }
        public Guna2Button AllItemsBtn { get; set; }
        public Guna2Button BtnFavourites { get; set; }
        public Guna2Button BtnCards { get; set; }
        public Guna2Button BtnTrash { get; set; }
        public Guna2HtmlLabel DispLblUsernameTitle { get; set; }
        public Guna2HtmlLabel DispLblPasswordTitle { get; set; }
        public Guna2HtmlLabel DispLblWebsiteTitle { get; set; }
        public Guna2TextBox TxtNotes { get; set; }
        public Guna2HtmlToolTip GunaToolTip { get; set; }
        public Guna2PictureBox StarPicBox { get; set; }
        public Guna2Panel LeftPanel { get; set; }
        public Guna2Panel MidPanel { get; set; }
        public Guna2Panel RightPanel { get; set; }
        public Guna2BorderlessForm MainFormBorderLess { get; set; }
        public Guna2DragControl LeftDrag { get; set; }
        public Guna2DragControl MidDrag { get; set; }
        public Guna2DragControl RightDrag { get; set; }
        public Guna2DragControl FlpMainDrag { get; set; }
        public Guna2TextBox SearchBox { get; set; }
        public Guna2Panel DisplayPanel { get; set; }
        public Guna2Separator Separator1 { get; set; }
        public Guna2Panel Guna2Panel1 { get; set; }
        public Guna2HtmlLabel LblNotes { get; set; }
        public Guna2Separator Separator2 { get; set; }
        public Guna2Button BtnImport { get; set; }
        public Guna2Button BtnExport { get; set; }
    }
}
