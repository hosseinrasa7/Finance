using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinanceProject.MasterControls
{
    public class RsaTextBox : TextBox
    {
        #region Member Variables
        Color waterMarkColor = Color.Gray;
        Color forecolor;
        Font font;
        Font waterMarkFont;
        string waterMarkText = "Your Text Here";
        #endregion
        #region Constructor
        public RsaTextBox()
        {
            base.Text = this.waterMarkText;
            forecolor = this.waterMarkColor;
           
        }
        #endregion
        #region Event Handler Methods
        void RsaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                this.forecolor = this.forecolor;
                this.font = this.font;
            }
            else
            {
                this.TextChanged -= new TextChangedEventHandler(RsaTextBox_TextChanged);
                base.Text = this.waterMarkText;
                this.TextChanged += new TextChangedEventHandler(RsaTextBox_TextChanged);
                this.forecolor = this.waterMarkColor;
                this.font = this.waterMarkFont;
            }
        }
       void RsaTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            string str = base.Text.Replace(this.waterMarkText, "");
            this.TextChanged -= new TextChangedEventHandler(RsaTextBox_TextChanged);
            this.Text = str;
            this.TextChanged += new TextChangedEventHandler(RsaTextBox_TextChanged);
        }
        #endregion

        #region User Defined Properties
        /// <summary>
        /// Property to set/get Watermark color at design/runtime
        /// </summary>
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Watermark color")]
        [DisplayName("WaterMark Color")]
        public Color WaterMarkColor
        {
            get
            {
                return this.waterMarkColor;
            }
            set
            {
                this.waterMarkColor = value;
                base.OnTextChanged(null);
            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets TextBox text")]
        [DisplayName("Text")]
        /// <summary>
        /// Property to get Text at runtime(hides base Text property)
        /// </summary>
        public new string Text
        {
            get
            {
                //required for validation for Text property
                return base.Text.Replace(this.waterMarkText, string.Empty);
            }
            set
            {
                base.Text = value;
            }
        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets WaterMark font")]
        [DisplayName("WaterMark Font")]
        /// <summary>
        /// Property to get Text at runtime(hides base Text property) 
        /// </summary>
        public Font WaterMarkFont
        {
            get
            {
                //required for validation for Text property
                return this.waterMarkFont;
            }
            set
            {
                this.waterMarkFont = value;
                this.OnTextChanged(null);
            }
        }
        /// <summary>
        ///  Property to set/get Watermark text at design/runtime
        /// </summary>
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets Watermark Text")]
        [DisplayName("WaterMark Text")]
        public string WaterMarkText
        {
            get
            {
                return this.waterMarkText;
            }
            set
            {
                this.waterMarkText = value;
                base.OnTextChanged(null);
            }
        }
        #endregion

    }
}
