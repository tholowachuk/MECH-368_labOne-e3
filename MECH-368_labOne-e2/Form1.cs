namespace MECH_368_labOne_e2
{
    public partial class QueueTest : Form
    {
        //I do not know what this does. Microsoft docs continue to suck for new users.
        //presumably it's calling a new function (queue), allocating a 32-bit space for storage, and then naming a new instance of that storage 'dataQueue'. 
        public Queue<Int32> dataQueue = new Queue<Int32>();
        
        //maybe I can make a secondary queue that increments with every press of the 'Enqueue' button, and I can decrement it when I have collected the new value for display
        public Queue<Int32> countQueue = new Queue<Int32>();

        //create a function to display items within a queue
        public string UpdateQueue(string a, string b)
        {
            //function UpdateQueue accepts arguments of the name of the queue you would like analyzed & either "c" or "n" as options; if "c", return is a string of contents of the queue, if "n", return is the number of elements in the queue
            //2023-09-09 - future iterations should be more flexible in the queues that can be input for analysis; hardcoding is the act of a coward (but this is the wrong way to use a queue anyways)
            if (a == "dataQueue" && b == "n")
            {
                return Convert.ToString(dataQueue.Count);
            }

            if (a == "dataQueue" && b == "c" && countQueue.Count >= 1)
            {
                countQueue.Dequeue();
                foreach (int number in dataQueue)
                {

                }
                return "1";
            }
            else
            {
                return "";
            }
        }

        public QueueTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start timer, set tick to conduct an event
            System.Windows.Forms.Timer queueTimer = new System.Windows.Forms.Timer();
            queueTimer.Interval = 100;
            queueTimer.Tick += new EventHandler(queueTimer_Tick);
            queueTimer.Start();
        }
        private void queueTimer_Tick(object sender, EventArgs e)
        {
            textBoxQueuedItems.Text = UpdateQueue("dataQueue", "n");
            textBoxQueueContents.AppendText(Convert.ToString(UpdateQueue("dataQueue", "c")));
        }

        private void textBoxEnqueue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //control types of input in textboxEnqueue, allowing only integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            //check whether the text box has anything to add to the queue, add if yes
            if (textBoxEnqueue.Text == "")
            {
                MessageBox.Show("There is nothing to submit to the queue!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataQueue.Enqueue(Convert.ToInt32(textBoxEnqueue.Text));
                textBoxEnqueue.Clear();
                countQueue.Enqueue(1);
            }
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            //check whether the queue has numbers to remove from the queue, remove if yes
            if (dataQueue.Count() > 0)
            {
                dataQueue.Dequeue();
            }
            else
            {
                MessageBox.Show("The queue is empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}