namespace CA_W4_1__ANGEL_L
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_country = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_population = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_population = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_choose = new System.Windows.Forms.Label();
            this.comboBox_choose = new System.Windows.Forms.ComboBox();
            this.button_combobox = new System.Windows.Forms.Button();
            this.listBox_hasil = new System.Windows.Forms.ListBox();
            this.label_countrylist = new System.Windows.Forms.Label();
            this.listBox_countrylist = new System.Windows.Forms.ListBox();
            this.listBox_cityllist = new System.Windows.Forms.ListBox();
            this.label_citylist = new System.Windows.Forms.Label();
            this.button_delcountry = new System.Windows.Forms.Button();
            this.button_delcity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(25, 32);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(72, 20);
            this.label_country.TabIndex = 0;
            this.label_country.Text = "Country :";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(25, 73);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(43, 20);
            this.label_city.TabIndex = 1;
            this.label_city.Text = "City :";
            // 
            // label_population
            // 
            this.label_population.AutoSize = true;
            this.label_population.Location = new System.Drawing.Point(25, 122);
            this.label_population.Name = "label_population";
            this.label_population.Size = new System.Drawing.Size(92, 20);
            this.label_population.TabIndex = 2;
            this.label_population.Text = "Population :";
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(128, 26);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(163, 26);
            this.textBox_country.TabIndex = 3;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(128, 70);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(163, 26);
            this.textBox_city.TabIndex = 4;
            // 
            // textBox_population
            // 
            this.textBox_population.Location = new System.Drawing.Point(128, 115);
            this.textBox_population.Name = "textBox_population";
            this.textBox_population.Size = new System.Drawing.Size(163, 26);
            this.textBox_population.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(325, 115);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(122, 39);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_choose
            // 
            this.label_choose.AutoSize = true;
            this.label_choose.Location = new System.Drawing.Point(25, 183);
            this.label_choose.Name = "label_choose";
            this.label_choose.Size = new System.Drawing.Size(64, 20);
            this.label_choose.TabIndex = 7;
            this.label_choose.Text = "Choose";
            // 
            // comboBox_choose
            // 
            this.comboBox_choose.FormattingEnabled = true;
            this.comboBox_choose.Location = new System.Drawing.Point(128, 180);
            this.comboBox_choose.Name = "comboBox_choose";
            this.comboBox_choose.Size = new System.Drawing.Size(163, 28);
            this.comboBox_choose.TabIndex = 8;
            this.comboBox_choose.SelectedIndexChanged += new System.EventHandler(this.comboBox_choose_SelectedIndexChanged);
            // 
            // button_combobox
            // 
            this.button_combobox.Location = new System.Drawing.Point(325, 180);
            this.button_combobox.Name = "button_combobox";
            this.button_combobox.Size = new System.Drawing.Size(176, 34);
            this.button_combobox.TabIndex = 9;
            this.button_combobox.Text = "Clear ComboBox";
            this.button_combobox.UseVisualStyleBackColor = true;
            this.button_combobox.Click += new System.EventHandler(this.button_combobox_Click);
            // 
            // listBox_hasil
            // 
            this.listBox_hasil.FormattingEnabled = true;
            this.listBox_hasil.ItemHeight = 20;
            this.listBox_hasil.Location = new System.Drawing.Point(32, 242);
            this.listBox_hasil.Name = "listBox_hasil";
            this.listBox_hasil.Size = new System.Drawing.Size(358, 184);
            this.listBox_hasil.TabIndex = 10;
            // 
            // label_countrylist
            // 
            this.label_countrylist.AutoSize = true;
            this.label_countrylist.Location = new System.Drawing.Point(503, 32);
            this.label_countrylist.Name = "label_countrylist";
            this.label_countrylist.Size = new System.Drawing.Size(101, 20);
            this.label_countrylist.TabIndex = 11;
            this.label_countrylist.Text = "Country List :";
            // 
            // listBox_countrylist
            // 
            this.listBox_countrylist.FormattingEnabled = true;
            this.listBox_countrylist.ItemHeight = 20;
            this.listBox_countrylist.Location = new System.Drawing.Point(625, 38);
            this.listBox_countrylist.Name = "listBox_countrylist";
            this.listBox_countrylist.Size = new System.Drawing.Size(177, 104);
            this.listBox_countrylist.TabIndex = 12;
            // 
            // listBox_cityllist
            // 
            this.listBox_cityllist.FormattingEnabled = true;
            this.listBox_cityllist.ItemHeight = 20;
            this.listBox_cityllist.Location = new System.Drawing.Point(625, 195);
            this.listBox_cityllist.Name = "listBox_cityllist";
            this.listBox_cityllist.Size = new System.Drawing.Size(177, 104);
            this.listBox_cityllist.TabIndex = 13;
            // 
            // label_citylist
            // 
            this.label_citylist.AutoSize = true;
            this.label_citylist.Location = new System.Drawing.Point(517, 195);
            this.label_citylist.Name = "label_citylist";
            this.label_citylist.Size = new System.Drawing.Size(72, 20);
            this.label_citylist.TabIndex = 14;
            this.label_citylist.Text = "City List :";
            // 
            // button_delcountry
            // 
            this.button_delcountry.Location = new System.Drawing.Point(847, 65);
            this.button_delcountry.Name = "button_delcountry";
            this.button_delcountry.Size = new System.Drawing.Size(151, 39);
            this.button_delcountry.TabIndex = 15;
            this.button_delcountry.Text = "Delete Country";
            this.button_delcountry.UseVisualStyleBackColor = true;
            this.button_delcountry.Click += new System.EventHandler(this.button_delcountry_Click);
            // 
            // button_delcity
            // 
            this.button_delcity.Location = new System.Drawing.Point(847, 221);
            this.button_delcity.Name = "button_delcity";
            this.button_delcity.Size = new System.Drawing.Size(151, 34);
            this.button_delcity.TabIndex = 16;
            this.button_delcity.Text = "Delete City";
            this.button_delcity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.button_delcity);
            this.Controls.Add(this.button_delcountry);
            this.Controls.Add(this.label_citylist);
            this.Controls.Add(this.listBox_cityllist);
            this.Controls.Add(this.listBox_countrylist);
            this.Controls.Add(this.label_countrylist);
            this.Controls.Add(this.listBox_hasil);
            this.Controls.Add(this.button_combobox);
            this.Controls.Add(this.comboBox_choose);
            this.Controls.Add(this.label_choose);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_population);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.label_population);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_country);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_population;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.TextBox textBox_population;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_choose;
        private System.Windows.Forms.ComboBox comboBox_choose;
        private System.Windows.Forms.Button button_combobox;
        private System.Windows.Forms.ListBox listBox_hasil;
        private System.Windows.Forms.Label label_countrylist;
        private System.Windows.Forms.ListBox listBox_countrylist;
        private System.Windows.Forms.ListBox listBox_cityllist;
        private System.Windows.Forms.Label label_citylist;
        private System.Windows.Forms.Button button_delcountry;
        private System.Windows.Forms.Button button_delcity;
    }
}

