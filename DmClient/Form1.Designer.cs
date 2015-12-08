namespace DmClient
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
            this.butConnect = new System.Windows.Forms.Button();
            this.butVisual = new System.Windows.Forms.Button();
            this.butDhGetting = new System.Windows.Forms.Button();
            this.labConnectStatus = new System.Windows.Forms.Label();
            this.labDhGettingStatus = new System.Windows.Forms.Label();
            this.labVisualStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butConnect
            // 
            this.butConnect.Location = new System.Drawing.Point(41, 12);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(89, 42);
            this.butConnect.TabIndex = 0;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // butVisual
            // 
            this.butVisual.Location = new System.Drawing.Point(41, 131);
            this.butVisual.Name = "butVisual";
            this.butVisual.Size = new System.Drawing.Size(89, 42);
            this.butVisual.TabIndex = 1;
            this.butVisual.Text = "Визуализация";
            this.butVisual.UseVisualStyleBackColor = true;
            this.butVisual.Click += new System.EventHandler(this.butVisual_Click);
            // 
            // butDhGetting
            // 
            this.butDhGetting.Location = new System.Drawing.Point(41, 72);
            this.butDhGetting.Name = "butDhGetting";
            this.butDhGetting.Size = new System.Drawing.Size(89, 42);
            this.butDhGetting.TabIndex = 2;
            this.butDhGetting.Text = "Получить скважины";
            this.butDhGetting.UseVisualStyleBackColor = true;
            this.butDhGetting.Click += new System.EventHandler(this.butDhGetting_Click);
            // 
            // labConnectStatus
            // 
            this.labConnectStatus.Location = new System.Drawing.Point(162, 27);
            this.labConnectStatus.Name = "labConnectStatus";
            this.labConnectStatus.Size = new System.Drawing.Size(190, 23);
            this.labConnectStatus.TabIndex = 3;
            // 
            // labDhGettingStatus
            // 
            this.labDhGettingStatus.Location = new System.Drawing.Point(162, 87);
            this.labDhGettingStatus.Name = "labDhGettingStatus";
            this.labDhGettingStatus.Size = new System.Drawing.Size(190, 23);
            this.labDhGettingStatus.TabIndex = 4;
            // 
            // labVisualStatus
            // 
            this.labVisualStatus.Location = new System.Drawing.Point(162, 146);
            this.labVisualStatus.Name = "labVisualStatus";
            this.labVisualStatus.Size = new System.Drawing.Size(190, 23);
            this.labVisualStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 233);
            this.Controls.Add(this.labVisualStatus);
            this.Controls.Add(this.labDhGettingStatus);
            this.Controls.Add(this.labConnectStatus);
            this.Controls.Add(this.butDhGetting);
            this.Controls.Add(this.butVisual);
            this.Controls.Add(this.butConnect);
            this.Name = "Form1";
            this.Text = "Визуализация скважин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butVisual;
        private System.Windows.Forms.Button butDhGetting;
        private System.Windows.Forms.Label labConnectStatus;
        private System.Windows.Forms.Label labDhGettingStatus;
        private System.Windows.Forms.Label labVisualStatus;
    }
}

