﻿namespace Proyecto_IMPERIO
{
    partial class frmVestido
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVestido));
			this.label1 = new System.Windows.Forms.Label();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTalla = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPrecio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pbFoto = new System.Windows.Forms.PictureBox();
			this.btnFoto = new System.Windows.Forms.Button();
			this.btnAccion = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(175, 192);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo";
			// 
			// tbCodigo
			// 
			this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCodigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCodigo.Location = new System.Drawing.Point(244, 181);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(148, 28);
			this.tbCodigo.TabIndex = 1;
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDescripcion.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcion.Location = new System.Drawing.Point(129, 226);
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(264, 28);
			this.tbDescripcion.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descripcion";
			// 
			// tbTalla
			// 
			this.tbTalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbTalla.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTalla.Location = new System.Drawing.Point(129, 266);
			this.tbTalla.Name = "tbTalla";
			this.tbTalla.Size = new System.Drawing.Size(100, 28);
			this.tbTalla.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(80, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Talla";
			// 
			// tbPrecio
			// 
			this.tbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPrecio.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPrecio.Location = new System.Drawing.Point(292, 266);
			this.tbPrecio.Name = "tbPrecio";
			this.tbPrecio.Size = new System.Drawing.Size(100, 28);
			this.tbPrecio.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(242, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Precio";
			// 
			// pbFoto
			// 
			this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbFoto.Location = new System.Drawing.Point(40, 72);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(120, 137);
			this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbFoto.TabIndex = 8;
			this.pbFoto.TabStop = false;
			// 
			// btnFoto
			// 
			this.btnFoto.BackColor = System.Drawing.Color.Black;
			this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFoto.ForeColor = System.Drawing.Color.White;
			this.btnFoto.Location = new System.Drawing.Point(178, 116);
			this.btnFoto.Name = "btnFoto";
			this.btnFoto.Size = new System.Drawing.Size(94, 38);
			this.btnFoto.TabIndex = 9;
			this.btnFoto.Text = "CARGAR FOTO";
			this.btnFoto.UseVisualStyleBackColor = false;
			this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
			// 
			// btnAccion
			// 
			this.btnAccion.BackColor = System.Drawing.Color.Black;
			this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccion.ForeColor = System.Drawing.Color.White;
			this.btnAccion.Location = new System.Drawing.Point(258, 332);
			this.btnAccion.Name = "btnAccion";
			this.btnAccion.Size = new System.Drawing.Size(129, 44);
			this.btnAccion.TabIndex = 10;
			this.btnAccion.Text = "AGREGAR VESTIDO";
			this.btnAccion.UseVisualStyleBackColor = false;
			this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(402, 46);
			this.panel1.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(351, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(51, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frmVestido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(401, 386);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAccion);
			this.Controls.Add(this.btnFoto);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.tbPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbTalla);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbDescripcion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbCodigo);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "frmVestido";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vestido";
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTalla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}