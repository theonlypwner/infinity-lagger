namespace InfinityLagger
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.radIncrement = new System.Windows.Forms.RadioButton();
			this.radDecrement = new System.Windows.Forms.RadioButton();
			this.radLeft = new System.Windows.Forms.RadioButton();
			this.radRight = new System.Windows.Forms.RadioButton();
			this.grpOp = new System.Windows.Forms.GroupBox();
			this.tglRunning = new System.Windows.Forms.CheckBox();
			this.progress = new System.Windows.Forms.ProgressBar();
			this.lblOpsDesc = new System.Windows.Forms.Label();
			this.lblCountDesc = new System.Windows.Forms.Label();
			this.lblOps = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.btnLatency = new System.Windows.Forms.Button();
			this.grpOp.SuspendLayout();
			this.SuspendLayout();
			// 
			// radIncrement
			// 
			this.radIncrement.AutoSize = true;
			this.radIncrement.Location = new System.Drawing.Point(6, 19);
			this.radIncrement.Name = "radIncrement";
			this.radIncrement.Size = new System.Drawing.Size(72, 17);
			this.radIncrement.TabIndex = 0;
			this.radIncrement.TabStop = true;
			this.radIncrement.Text = "Increment";
			this.radIncrement.UseVisualStyleBackColor = true;
			// 
			// radDecrement
			// 
			this.radDecrement.AutoSize = true;
			this.radDecrement.Location = new System.Drawing.Point(6, 42);
			this.radDecrement.Name = "radDecrement";
			this.radDecrement.Size = new System.Drawing.Size(77, 17);
			this.radDecrement.TabIndex = 1;
			this.radDecrement.TabStop = true;
			this.radDecrement.Text = "Decrement";
			this.radDecrement.UseVisualStyleBackColor = true;
			// 
			// radLeft
			// 
			this.radLeft.AutoSize = true;
			this.radLeft.Location = new System.Drawing.Point(6, 65);
			this.radLeft.Name = "radLeft";
			this.radLeft.Size = new System.Drawing.Size(67, 17);
			this.radLeft.TabIndex = 2;
			this.radLeft.TabStop = true;
			this.radLeft.Text = "Left Shift";
			this.radLeft.UseVisualStyleBackColor = true;
			// 
			// radRight
			// 
			this.radRight.AutoSize = true;
			this.radRight.Location = new System.Drawing.Point(6, 88);
			this.radRight.Name = "radRight";
			this.radRight.Size = new System.Drawing.Size(74, 17);
			this.radRight.TabIndex = 3;
			this.radRight.TabStop = true;
			this.radRight.Text = "Right Shift";
			this.radRight.UseVisualStyleBackColor = true;
			// 
			// grpOp
			// 
			this.grpOp.Controls.Add(this.radIncrement);
			this.grpOp.Controls.Add(this.radRight);
			this.grpOp.Controls.Add(this.radDecrement);
			this.grpOp.Controls.Add(this.radLeft);
			this.grpOp.Location = new System.Drawing.Point(12, 48);
			this.grpOp.Name = "grpOp";
			this.grpOp.Size = new System.Drawing.Size(138, 121);
			this.grpOp.TabIndex = 4;
			this.grpOp.TabStop = false;
			this.grpOp.Text = "Operation";
			// 
			// tglRunning
			// 
			this.tglRunning.Appearance = System.Windows.Forms.Appearance.Button;
			this.tglRunning.AutoSize = true;
			this.tglRunning.Location = new System.Drawing.Point(170, 48);
			this.tglRunning.Name = "tglRunning";
			this.tglRunning.Size = new System.Drawing.Size(78, 23);
			this.tglRunning.TabIndex = 5;
			this.tglRunning.Text = "Toggle State";
			this.tglRunning.UseVisualStyleBackColor = true;
			this.tglRunning.CheckedChanged += new System.EventHandler(this.tglRunning_CheckedChanged);
			// 
			// progress
			// 
			this.progress.Location = new System.Drawing.Point(12, 12);
			this.progress.MarqueeAnimationSpeed = 10;
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(335, 30);
			this.progress.TabIndex = 6;
			// 
			// lblOpsDesc
			// 
			this.lblOpsDesc.AutoSize = true;
			this.lblOpsDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOpsDesc.Location = new System.Drawing.Point(156, 74);
			this.lblOpsDesc.Name = "lblOpsDesc";
			this.lblOpsDesc.Size = new System.Drawing.Size(174, 20);
			this.lblOpsDesc.TabIndex = 7;
			this.lblOpsDesc.Text = "Operations per second:";
			// 
			// lblCountDesc
			// 
			this.lblCountDesc.AutoSize = true;
			this.lblCountDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCountDesc.Location = new System.Drawing.Point(156, 118);
			this.lblCountDesc.Name = "lblCountDesc";
			this.lblCountDesc.Size = new System.Drawing.Size(56, 20);
			this.lblCountDesc.TabIndex = 7;
			this.lblCountDesc.Text = "Count:";
			// 
			// lblOps
			// 
			this.lblOps.AutoSize = true;
			this.lblOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOps.Location = new System.Drawing.Point(166, 94);
			this.lblOps.Name = "lblOps";
			this.lblOps.Size = new System.Drawing.Size(97, 24);
			this.lblOps.TabIndex = 7;
			this.lblOps.Text = "Unknown";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.Location = new System.Drawing.Point(166, 138);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(21, 24);
			this.lblCount.TabIndex = 7;
			this.lblCount.Text = "0";
			// 
			// btnLatency
			// 
			this.btnLatency.Enabled = false;
			this.btnLatency.Location = new System.Drawing.Point(271, 48);
			this.btnLatency.Name = "btnLatency";
			this.btnLatency.Size = new System.Drawing.Size(75, 23);
			this.btnLatency.TabIndex = 8;
			this.btnLatency.Text = "Get Latency";
			this.btnLatency.UseVisualStyleBackColor = true;
			this.btnLatency.Click += new System.EventHandler(this.updateLatency);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 180);
			this.Controls.Add(this.btnLatency);
			this.Controls.Add(this.lblOps);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblCountDesc);
			this.Controls.Add(this.lblOpsDesc);
			this.Controls.Add(this.progress);
			this.Controls.Add(this.tglRunning);
			this.Controls.Add(this.grpOp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Infinity Lagger";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Close);
			this.grpOp.ResumeLayout(false);
			this.grpOp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radIncrement;
		private System.Windows.Forms.RadioButton radDecrement;
		private System.Windows.Forms.RadioButton radLeft;
		private System.Windows.Forms.RadioButton radRight;
		private System.Windows.Forms.GroupBox grpOp;
		private System.Windows.Forms.CheckBox tglRunning;
		private System.Windows.Forms.ProgressBar progress;
		private System.Windows.Forms.Label lblOpsDesc;
		private System.Windows.Forms.Label lblCountDesc;
		private System.Windows.Forms.Label lblOps;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Button btnLatency;
	}
}

