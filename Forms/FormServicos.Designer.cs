
namespace ProjetoRH_GerenciadorDeServiços.Forms {
    partial class FormServicos {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaServicos = new System.Windows.Forms.ListView();
            this.btnListarServicos = new FontAwesome.Sharp.IconButton();
            this.btnPararServico = new FontAwesome.Sharp.IconButton();
            this.btnReiniciarServico = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCaminho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listaServicos);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços do Windows";
            // 
            // textBoxCaminho
            // 
            this.textBoxCaminho.Location = new System.Drawing.Point(54, 311);
            this.textBoxCaminho.Name = "textBoxCaminho";
            this.textBoxCaminho.Size = new System.Drawing.Size(370, 20);
            this.textBoxCaminho.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho:";
            // 
            // listaServicos
            // 
            this.listaServicos.HideSelection = false;
            this.listaServicos.Location = new System.Drawing.Point(6, 20);
            this.listaServicos.Name = "listaServicos";
            this.listaServicos.Size = new System.Drawing.Size(418, 284);
            this.listaServicos.TabIndex = 0;
            this.listaServicos.UseCompatibleStateImageBehavior = false;
            this.listaServicos.View = System.Windows.Forms.View.Details;
            this.listaServicos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listaServicos_ItemSelectionChanged);
            // 
            // btnListarServicos
            // 
            this.btnListarServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(99)))));
            this.btnListarServicos.FlatAppearance.BorderSize = 0;
            this.btnListarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.btnListarServicos.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnListarServicos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.btnListarServicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarServicos.IconSize = 17;
            this.btnListarServicos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarServicos.Location = new System.Drawing.Point(439, 20);
            this.btnListarServicos.Name = "btnListarServicos";
            this.btnListarServicos.Size = new System.Drawing.Size(103, 37);
            this.btnListarServicos.TabIndex = 8;
            this.btnListarServicos.Text = "Listar Serviços";
            this.btnListarServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarServicos.UseVisualStyleBackColor = false;
            this.btnListarServicos.Click += new System.EventHandler(this.btnListarServicos_Click);
            // 
            // btnPararServico
            // 
            this.btnPararServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.btnPararServico.FlatAppearance.BorderSize = 0;
            this.btnPararServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.btnPararServico.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnPararServico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.btnPararServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPararServico.IconSize = 17;
            this.btnPararServico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPararServico.Location = new System.Drawing.Point(439, 319);
            this.btnPararServico.Name = "btnPararServico";
            this.btnPararServico.Size = new System.Drawing.Size(103, 37);
            this.btnPararServico.TabIndex = 9;
            this.btnPararServico.Text = "Parar Serviço";
            this.btnPararServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPararServico.UseVisualStyleBackColor = false;
            this.btnPararServico.Click += new System.EventHandler(this.btnPararServico_Click);
            // 
            // btnReiniciarServico
            // 
            this.btnReiniciarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(196)))), ((int)(((byte)(165)))));
            this.btnReiniciarServico.FlatAppearance.BorderSize = 0;
            this.btnReiniciarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.btnReiniciarServico.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnReiniciarServico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.btnReiniciarServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReiniciarServico.IconSize = 17;
            this.btnReiniciarServico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReiniciarServico.Location = new System.Drawing.Point(439, 276);
            this.btnReiniciarServico.Name = "btnReiniciarServico";
            this.btnReiniciarServico.Size = new System.Drawing.Size(103, 37);
            this.btnReiniciarServico.TabIndex = 10;
            this.btnReiniciarServico.Text = "Reiniciar Serviço";
            this.btnReiniciarServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReiniciarServico.UseVisualStyleBackColor = false;
            this.btnReiniciarServico.Click += new System.EventHandler(this.btnReiniciarServico_Click);
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(568, 368);
            this.Controls.Add(this.btnReiniciarServico);
            this.Controls.Add(this.btnPararServico);
            this.Controls.Add(this.btnListarServicos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormServicos";
            this.Text = "FormServicos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCaminho;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnListarServicos;
        private FontAwesome.Sharp.IconButton btnPararServico;
        private FontAwesome.Sharp.IconButton btnReiniciarServico;
        private System.Windows.Forms.ListView listaServicos;
    }
}