namespace MediaInfoDotNet.WFClient
{
	partial class UserControlStreamsViewer
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.propertyGridStreamElement = new System.Windows.Forms.PropertyGrid();
			this.labelStream = new System.Windows.Forms.Label();
			this.numericUpDownStreamIndex = new System.Windows.Forms.NumericUpDown();
			this.bsCollection = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStreamIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCollection)).BeginInit();
			this.SuspendLayout();
			// 
			// propertyGridStreamElement
			// 
			this.propertyGridStreamElement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGridStreamElement.Location = new System.Drawing.Point(3, 29);
			this.propertyGridStreamElement.Name = "propertyGridStreamElement";
			this.propertyGridStreamElement.Size = new System.Drawing.Size(338, 257);
			this.propertyGridStreamElement.TabIndex = 2;
			// 
			// labelStream
			// 
			this.labelStream.AutoSize = true;
			this.labelStream.Location = new System.Drawing.Point(3, 5);
			this.labelStream.Name = "labelStream";
			this.labelStream.Size = new System.Drawing.Size(73, 13);
			this.labelStream.TabIndex = 0;
			this.labelStream.Text = "labelListName";
			this.labelStream.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownStreamIndex
			// 
			this.numericUpDownStreamIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownStreamIndex.Location = new System.Drawing.Point(221, 3);
			this.numericUpDownStreamIndex.Name = "numericUpDownStreamIndex";
			this.numericUpDownStreamIndex.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownStreamIndex.TabIndex = 3;
			this.numericUpDownStreamIndex.ValueChanged += new System.EventHandler(this.numericUpDownStreamIndex_ValueChanged);
			// 
			// bsCollection
			// 
			this.bsCollection.AllowNew = false;
			// 
			// UserControlStreamsViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDownStreamIndex);
			this.Controls.Add(this.labelStream);
			this.Controls.Add(this.propertyGridStreamElement);
			this.Name = "UserControlStreamsViewer";
			this.Size = new System.Drawing.Size(344, 289);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStreamIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCollection)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PropertyGrid propertyGridStreamElement;
		private System.Windows.Forms.Label labelStream;
		private System.Windows.Forms.NumericUpDown numericUpDownStreamIndex;
		public System.Windows.Forms.BindingSource bsCollection;
	}
}
