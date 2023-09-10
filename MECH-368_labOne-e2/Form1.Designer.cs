namespace MECH_368_labOne_e2
{
    partial class QueueTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEnqueue = new TextBox();
            textBox2 = new TextBox();
            textBoxQueuedItems = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBoxQueueContents = new TextBox();
            buttonEnqueue = new Button();
            buttonDequeue = new Button();
            label1 = new Label();
            buttonDequeueAverage = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxEnqueue
            // 
            textBoxEnqueue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEnqueue.Location = new Point(126, 12);
            textBoxEnqueue.Name = "textBoxEnqueue";
            textBoxEnqueue.Size = new Size(100, 23);
            textBoxEnqueue.TabIndex = 0;
            textBoxEnqueue.KeyPress += textBoxEnqueue_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(126, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBoxQueuedItems
            // 
            textBoxQueuedItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxQueuedItems.Location = new Point(126, 70);
            textBoxQueuedItems.Name = "textBoxQueuedItems";
            textBoxQueuedItems.Size = new Size(100, 23);
            textBoxQueuedItems.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(37, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(164, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 4;
            // 
            // textBoxQueueContents
            // 
            textBoxQueueContents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxQueueContents.Location = new Point(12, 182);
            textBoxQueueContents.Multiline = true;
            textBoxQueueContents.Name = "textBoxQueueContents";
            textBoxQueueContents.Size = new Size(215, 107);
            textBoxQueueContents.TabIndex = 5;
            // 
            // buttonEnqueue
            // 
            buttonEnqueue.Location = new Point(12, 12);
            buttonEnqueue.Name = "buttonEnqueue";
            buttonEnqueue.Size = new Size(87, 23);
            buttonEnqueue.TabIndex = 6;
            buttonEnqueue.Text = "Enqueue";
            buttonEnqueue.UseVisualStyleBackColor = true;
            buttonEnqueue.Click += buttonEnqueue_Click;
            // 
            // buttonDequeue
            // 
            buttonDequeue.Location = new Point(12, 41);
            buttonDequeue.Name = "buttonDequeue";
            buttonDequeue.Size = new Size(87, 23);
            buttonDequeue.TabIndex = 7;
            buttonDequeue.Text = "Dequeue";
            buttonDequeue.UseVisualStyleBackColor = true;
            buttonDequeue.Click += buttonDequeue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 8;
            label1.Text = "Items in Queue";
            // 
            // buttonDequeueAverage
            // 
            buttonDequeueAverage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDequeueAverage.Location = new Point(12, 99);
            buttonDequeueAverage.Name = "buttonDequeueAverage";
            buttonDequeueAverage.Size = new Size(214, 23);
            buttonDequeueAverage.TabIndex = 9;
            buttonDequeueAverage.Text = "Dequeue and Average First N Data Points";
            buttonDequeueAverage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 10;
            label2.Text = "N:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 131);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 11;
            label3.Text = "Average:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 12;
            label4.Text = "Queue Contents:";
            // 
            // QueueTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 301);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonDequeueAverage);
            Controls.Add(label1);
            Controls.Add(buttonDequeue);
            Controls.Add(buttonEnqueue);
            Controls.Add(textBoxQueueContents);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBoxQueuedItems);
            Controls.Add(textBox2);
            Controls.Add(textBoxEnqueue);
            MinimumSize = new Size(255, 340);
            Name = "QueueTest";
            Text = "QueueTest";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEnqueue;
        private TextBox textBox2;
        private TextBox textBoxQueuedItems;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBoxQueueContents;
        private Button buttonEnqueue;
        private Button buttonDequeue;
        private Label label1;
        private Button buttonDequeueAverage;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}