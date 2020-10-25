namespace yoSSTool
{
    partial class SSTool
    {
        private System.ComponentModel.IContainer components = null;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSTool));
            this.ph2 = new System.Windows.Forms.Button();
            this.luyten = new System.Windows.Forms.Button();
            this.everything = new System.Windows.Forms.Button();
            this.uav = new System.Windows.Forms.Button();
            this.lav = new System.Windows.Forms.Button();
            this.jdgui = new System.Windows.Forms.Button();
            this.procexpl = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.logdate = new System.Windows.Forms.Button();
            this.openPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ph2
            // 
            this.ph2.Location = new System.Drawing.Point(12, 12);
            this.ph2.Name = "ph2";
            this.ph2.Size = new System.Drawing.Size(198, 44);
            this.ph2.TabIndex = 0;
            this.ph2.Text = "Process Hacker 2";
            this.ph2.UseVisualStyleBackColor = true;
            this.ph2.Click += new System.EventHandler(this.ph2_Click);
            // 
            // luyten
            // 
            this.luyten.Location = new System.Drawing.Point(216, 12);
            this.luyten.Name = "luyten";
            this.luyten.Size = new System.Drawing.Size(177, 44);
            this.luyten.TabIndex = 1;
            this.luyten.Text = "Luyten";
            this.luyten.UseVisualStyleBackColor = true;
            this.luyten.Click += new System.EventHandler(this.luyten_Click);
            // 
            // everything
            // 
            this.everything.Location = new System.Drawing.Point(399, 12);
            this.everything.Name = "everything";
            this.everything.Size = new System.Drawing.Size(189, 44);
            this.everything.TabIndex = 2;
            this.everything.Text = "Search Everything";
            this.everything.UseVisualStyleBackColor = true;
            this.everything.Click += new System.EventHandler(this.everything_Click);
            // 
            // uav
            // 
            this.uav.Location = new System.Drawing.Point(12, 60);
            this.uav.Name = "uav";
            this.uav.Size = new System.Drawing.Size(198, 46);
            this.uav.TabIndex = 3;
            this.uav.Text = "User Assist View";
            this.uav.UseVisualStyleBackColor = true;
            this.uav.Click += new System.EventHandler(this.uav_Click);
            // 
            // lav
            // 
            this.lav.Location = new System.Drawing.Point(217, 60);
            this.lav.Name = "lav";
            this.lav.Size = new System.Drawing.Size(176, 46);
            this.lav.TabIndex = 4;
            this.lav.Text = "Last Activity Viewer";
            this.lav.UseVisualStyleBackColor = true;
            this.lav.Click += new System.EventHandler(this.lav_Click);
            // 
            // jdgui
            // 
            this.jdgui.Location = new System.Drawing.Point(399, 60);
            this.jdgui.Name = "jdgui";
            this.jdgui.Size = new System.Drawing.Size(188, 45);
            this.jdgui.TabIndex = 5;
            this.jdgui.Text = "JD-Gui";
            this.jdgui.UseVisualStyleBackColor = true;
            this.jdgui.Click += new System.EventHandler(this.jdguiClick);
            // 
            // procexpl
            // 
            this.procexpl.Location = new System.Drawing.Point(217, 112);
            this.procexpl.Name = "procexpl";
            this.procexpl.Size = new System.Drawing.Size(176, 48);
            this.procexpl.TabIndex = 6;
            this.procexpl.Text = "Process Explorer";
            this.procexpl.UseVisualStyleBackColor = true;
            this.procexpl.Click += new System.EventHandler(this.procExpClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // logdate
            // 
            this.logdate.Location = new System.Drawing.Point(17, 195);
            this.logdate.Name = "logdate";
            this.logdate.Size = new System.Drawing.Size(192, 42);
            this.logdate.TabIndex = 8;
            this.logdate.Text = "Log SS";
            this.logdate.UseVisualStyleBackColor = true;
            this.logdate.Click += new System.EventHandler(this.logDate);
            // 
            // Open Prev
            // 
            this.openPrev.Location = new System.Drawing.Point(399, 195);
            this.openPrev.Name = "openprev";
            this.openPrev.Size = new System.Drawing.Size(187, 41);
            this.openPrev.TabIndex = 9;
            this.openPrev.Text = "Open Previous SS Log";
            this.openPrev.UseVisualStyleBackColor = true;
            this.openPrev.Click += new System.EventHandler(this.openPrevLogClick);
            // 
            // SSTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.openPrev);
            this.Controls.Add(this.logdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.procexpl);
            this.Controls.Add(this.jdgui);
            this.Controls.Add(this.lav);
            this.Controls.Add(this.uav);
            this.Controls.Add(this.everything);
            this.Controls.Add(this.luyten);
            this.Controls.Add(this.ph2);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SSTool";
            this.Text = "Screenshare Tool";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button openPrev;

        private System.Windows.Forms.Button logdate;
        
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Button procexpl;

        private System.Windows.Forms.Button jdgui;

        private System.Windows.Forms.Button lav;

        private System.Windows.Forms.Button uav;

        private System.Windows.Forms.Button everything;

        private System.Windows.Forms.Button luyten;
        
        private System.Windows.Forms.Button ph2;

        #endregion
    }
}