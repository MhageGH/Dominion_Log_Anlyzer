﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_analyze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ownCard0 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_name1 = new System.Windows.Forms.Label();
            this.label_name0 = new System.Windows.Forms.Label();
            this.label_ownCard1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_deck0 = new System.Windows.Forms.Label();
            this.label_name0_deck = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_log.Location = new System.Drawing.Point(12, 30);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(387, 478);
            this.textBox_log.TabIndex = 0;
            // 
            // button_analyze
            // 
            this.button_analyze.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_analyze.Location = new System.Drawing.Point(94, 514);
            this.button_analyze.Name = "button_analyze";
            this.button_analyze.Size = new System.Drawing.Size(103, 23);
            this.button_analyze.TabIndex = 1;
            this.button_analyze.Text = "ログの解析";
            this.button_analyze.UseVisualStyleBackColor = true;
            this.button_analyze.Click += new System.EventHandler(this.button_analyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ログを貼り付けて下さい";
            // 
            // label_ownCard0
            // 
            this.label_ownCard0.AutoSize = true;
            this.label_ownCard0.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_ownCard0.Location = new System.Drawing.Point(6, 39);
            this.label_ownCard0.Name = "label_ownCard0";
            this.label_ownCard0.Size = new System.Drawing.Size(13, 18);
            this.label_ownCard0.TabIndex = 3;
            this.label_ownCard0.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_name1);
            this.groupBox1.Controls.Add(this.label_name0);
            this.groupBox1.Controls.Add(this.label_ownCard1);
            this.groupBox1.Controls.Add(this.label_ownCard0);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(405, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 496);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所持カード";
            // 
            // label_name1
            // 
            this.label_name1.AutoSize = true;
            this.label_name1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_name1.Location = new System.Drawing.Point(127, 21);
            this.label_name1.Name = "label_name1";
            this.label_name1.Size = new System.Drawing.Size(13, 18);
            this.label_name1.TabIndex = 7;
            this.label_name1.Text = "-";
            // 
            // label_name0
            // 
            this.label_name0.AutoSize = true;
            this.label_name0.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_name0.Location = new System.Drawing.Point(6, 21);
            this.label_name0.Name = "label_name0";
            this.label_name0.Size = new System.Drawing.Size(13, 18);
            this.label_name0.TabIndex = 6;
            this.label_name0.Text = "-";
            // 
            // label_ownCard1
            // 
            this.label_ownCard1.AutoSize = true;
            this.label_ownCard1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_ownCard1.Location = new System.Drawing.Point(127, 39);
            this.label_ownCard1.Name = "label_ownCard1";
            this.label_ownCard1.Size = new System.Drawing.Size(13, 18);
            this.label_ownCard1.TabIndex = 5;
            this.label_ownCard1.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_deck0);
            this.groupBox2.Controls.Add(this.label_name0_deck);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(677, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 496);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "山札";
            // 
            // label_deck0
            // 
            this.label_deck0.AutoSize = true;
            this.label_deck0.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_deck0.Location = new System.Drawing.Point(6, 39);
            this.label_deck0.Name = "label_deck0";
            this.label_deck0.Size = new System.Drawing.Size(13, 18);
            this.label_deck0.TabIndex = 6;
            this.label_deck0.Text = "-";
            // 
            // label_name0_deck
            // 
            this.label_name0_deck.AutoSize = true;
            this.label_name0_deck.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_name0_deck.Location = new System.Drawing.Point(6, 21);
            this.label_name0_deck.Name = "label_name0_deck";
            this.label_name0_deck.Size = new System.Drawing.Size(13, 18);
            this.label_name0_deck.TabIndex = 3;
            this.label_name0_deck.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_analyze);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form1";
            this.Text = "Dominion Log Analyzer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_analyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ownCard0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ownCard1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_name0_deck;
        private System.Windows.Forms.Label label_name1;
        private System.Windows.Forms.Label label_name0;
        private System.Windows.Forms.Label label_deck0;
    }
}

