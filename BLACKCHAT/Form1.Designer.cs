
namespace BLACKCHAT
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonEnviar = new System.Windows.Forms.Button();
			this.txtFrase = new System.Windows.Forms.TextBox();
			this.listBoxRespostas = new System.Windows.Forms.ListBox();
			this.PCtxt = new System.Windows.Forms.TextBox();
			this.Restxt = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonEnviar
			// 
			this.buttonEnviar.BackColor = System.Drawing.Color.Red;
			this.buttonEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEnviar.Location = new System.Drawing.Point(926, 339);
			this.buttonEnviar.Name = "buttonEnviar";
			this.buttonEnviar.Size = new System.Drawing.Size(119, 26);
			this.buttonEnviar.TabIndex = 0;
			this.buttonEnviar.Text = "ENVIAR";
			this.buttonEnviar.UseVisualStyleBackColor = false;
			this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
			// 
			// txtFrase
			// 
			this.txtFrase.BackColor = System.Drawing.Color.Red;
			this.txtFrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFrase.Location = new System.Drawing.Point(64, 339);
			this.txtFrase.Multiline = true;
			this.txtFrase.Name = "txtFrase";
			this.txtFrase.Size = new System.Drawing.Size(826, 26);
			this.txtFrase.TabIndex = 1;
			this.txtFrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrase_KeyPress);
			// 
			// listBoxRespostas
			// 
			this.listBoxRespostas.BackColor = System.Drawing.Color.Red;
			this.listBoxRespostas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBoxRespostas.Font = new System.Drawing.Font("Noto Kufi Arabic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxRespostas.ForeColor = System.Drawing.Color.Black;
			this.listBoxRespostas.FormattingEnabled = true;
			this.listBoxRespostas.ItemHeight = 15;
			this.listBoxRespostas.Location = new System.Drawing.Point(64, 84);
			this.listBoxRespostas.Name = "listBoxRespostas";
			this.listBoxRespostas.Size = new System.Drawing.Size(826, 197);
			this.listBoxRespostas.TabIndex = 2;
			// 
			// PCtxt
			// 
			this.PCtxt.BackColor = System.Drawing.Color.Red;
			this.PCtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PCtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PCtxt.Location = new System.Drawing.Point(926, 84);
			this.PCtxt.Multiline = true;
			this.PCtxt.Name = "PCtxt";
			this.PCtxt.Size = new System.Drawing.Size(196, 27);
			this.PCtxt.TabIndex = 1;
			this.PCtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrase_KeyPress);
			// 
			// Restxt
			// 
			this.Restxt.AcceptsTab = true;
			this.Restxt.BackColor = System.Drawing.Color.Red;
			this.Restxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Restxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Restxt.Location = new System.Drawing.Point(926, 155);
			this.Restxt.Multiline = true;
			this.Restxt.Name = "Restxt";
			this.Restxt.Size = new System.Drawing.Size(196, 28);
			this.Restxt.TabIndex = 1;
			this.Restxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrase_KeyPress);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Red;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(926, 220);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(196, 61);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "ADICIONAR";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1160, 62);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Niagara Solid", 30.5F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(437, 9);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
			this.label1.Size = new System.Drawing.Size(227, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "BLACKBOT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1160, 429);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listBoxRespostas);
			this.Controls.Add(this.Restxt);
			this.Controls.Add(this.PCtxt);
			this.Controls.Add(this.txtFrase);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.buttonEnviar);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "BLACKBOT";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonEnviar;
		private System.Windows.Forms.TextBox txtFrase;
		private System.Windows.Forms.ListBox listBoxRespostas;
		private System.Windows.Forms.TextBox PCtxt;
		private System.Windows.Forms.TextBox Restxt;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}

