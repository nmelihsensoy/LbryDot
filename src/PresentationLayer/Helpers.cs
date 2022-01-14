using PresentationLayer.Pages;
using PresentationLayer.Resources;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    //Definitions of function or variables that can only used in PresentationLayer to help another function or variable.
    //Creating with no relation any of classes is required.
    public static class Helpers
    {
        //Get currently active language value. "" : EN, "tr" : TR
        public static string GetCurrentLanguage()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            return currentCulture.ToString();
        }

        public static void ChangeLanguage(string CultureAbbr = "")
        {
            //Thread.CurrentThread.CurrentUICulture.ClearCachedData();

            if (GetCurrentLanguage() != CultureAbbr)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureAbbr);
            }
        }

        public static string GetValueFromCulture(string StringName, string CultureName)
        {
            return Strings.ResourceManager.GetString(StringName, CultureInfo.GetCultureInfo(CultureName));
        }

        public static void ChangePage(Form Current, Form Next)
        {
            if(Current != null && Next != null)
            {
                Current.Hide();
                Next.Show();
            }    
        }

        public static void OpenSubPages(Panel Panel, Form SubForm, ref string ActiveSubPage)
        {
                ActiveSubPage = SubForm.Text;
                SubForm.TopLevel = false;
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.Dock = DockStyle.Fill;
                Panel.Controls.Add(SubForm);
                Panel.Tag = SubForm;
                SubForm.BringToFront();
                SubForm.Show();
        }

        public static bool CompareForms(Form F1, Form F2)
        {
            if (F2 == null) return false;
            
            if (F1 == null || F1.Text != F2.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void OpenSubPages(ref Form _ActiveForm, Panel Panel, Form SubForm)
        {
            if(_ActiveForm != null)
            {
                _ActiveForm.Close();
            }
            _ActiveForm = SubForm;
            SubForm.TopLevel = false;
            SubForm.FormBorderStyle = FormBorderStyle.None;
            SubForm.Dock = DockStyle.Fill;
            Panel.Controls.Add(SubForm);
            Panel.Tag = SubForm;
            //SubForm.BringToFront();
            SubForm.Show();
        }

        public static void CloseForm(Form F)
        {
            F.Hide();
        }

        public static void CloseApplication()
        {
            Application.Exit();
        }

        public static void MinimizeWindow(Form F)
        {
            F.WindowState = FormWindowState.Minimized;
        }

        public static void MaximizeWindow(Form F)
        {
            F.WindowState = FormWindowState.Maximized;
        }

        public static void NormalizeWindow(Form F)
        {
            F.WindowState = FormWindowState.Normal;
        }

        public static void MaximizeWindowToggle(Form F)
        {
            if (F.WindowState == FormWindowState.Normal)
            {
                F.WindowState = FormWindowState.Maximized;
            }
            else
            {
                F.WindowState = FormWindowState.Normal;
            }
        }

        public static void MakePictureBoxCircle(PictureBox P)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, P.Width, P.Height);
            P.Region = new Region(path);
        }

        public static Image ConvertByteToImage(byte [] ImgInByte, Image DefaultImg=null)
        {
            if(ImgInByte != null && ImgInByte.Length > 0)
            {
                MemoryStream ms2 = new MemoryStream(ImgInByte, 0, ImgInByte.Length);
                ms2.Write(ImgInByte, 0, ImgInByte.Length);
                return Image.FromStream(ms2, true);
            }
            return DefaultImg;
        }

        public static void SendEvent(EventHandler EventHandler, object Sender, EventArgs E)
        {
            if (EventHandler != null)
            {
                EventHandler(Sender, E);
            }
        }

        public static void AddControlToEmptyContainer<T,C>(C Container, T Control) where T : System.Windows.Forms.Control where C : System.Windows.Forms.Control
        {
            if (Container.Controls.Count < 1)
            {
                if (!Container.Controls.Contains(Control))
                {
                    Control.Visible = true;
                    Container.Controls.Add(Control);
                }
            }
        }

        public static Color GetReadableColorByBackground(Color BgColor)
        {
            if (BgColor.GetBrightness() > 0.50)
            {
                return Color.Black;
            }
            else
            {
                return Color.White;
            }
        }

        public static void SetFormStartPoint(ref Form Frm, Point Pt, int Px=20, int Py=20)
        {
            Frm.StartPosition = FormStartPosition.Manual;
            Pt.X += Px;
            Pt.Y += Py;
            Frm.Location = Pt;
        }

        public static void InitGenericTableStyle(ref DataGridView Table)
        {
            Table.RowHeadersVisible = false;
            Table.BorderStyle = BorderStyle.None;
            Table.DefaultCellStyle.SelectionBackColor = Table.DefaultCellStyle.BackColor;
            Table.DefaultCellStyle.SelectionForeColor = Table.DefaultCellStyle.ForeColor;
            Table.EnableHeadersVisualStyles = false;
            Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Table.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.GenericTableBackColor;
            Table.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.GenericFormBackColor;
            Table.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Table.RowTemplate.Height = 30;
            Table.AllowUserToResizeRows = false;
            Table.AllowUserToResizeColumns = false;
            Table.ReadOnly = true;
            Table.ClearSelection();
        }

        public static string SpaceSqueeze(string Str)
        {
            return Regex.Replace(Str, @"\s\s+", " ");
        }

    }
}