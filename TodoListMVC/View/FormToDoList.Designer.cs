namespace TodoListMVC.View
{
    partial class FormToDoList
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.listBoxTarefas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(338, 271);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "button1";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(322, 166);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(100, 20);
            this.txtTarefa.TabIndex = 1;
            // 
            // listBoxTarefas
            // 
            this.listBoxTarefas.FormattingEnabled = true;
            this.listBoxTarefas.Location = new System.Drawing.Point(559, 145);
            this.listBoxTarefas.Name = "listBoxTarefas";
            this.listBoxTarefas.Size = new System.Drawing.Size(120, 95);
            this.listBoxTarefas.TabIndex = 2;
            this.listBoxTarefas.SelectedIndexChanged += new System.EventHandler(this.listBoxTarefas_SelectedIndexChanged);
            // 
            // FormToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTarefas);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FormToDoList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.ListBox listBoxTarefas;
    }
}